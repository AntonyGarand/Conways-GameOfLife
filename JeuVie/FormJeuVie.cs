// FormJeuVie.cs
// Interprétation du jeu de la vie
// Programmé par Antony Garand
// Le 12 mars 2014

//Todo: VaVivre - Corriger le if
//      Placer les commandes dans une classe (Play, Pause, Plus vite, Moins vite, Initialiser, ...)
//      Charger un modèle prédéfinit
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuVie
{
    public partial class FormJeuVie : Form
    {
        private AutomateJeuVie[,] actuel;
        private AutomateJeuVie[,] prochain;
        private AutomateJeuVie[,] premier;
        private int turn = 0;
        private int nbAlive = 0;
        private bool start = false;
        private bool modeDemo = false; //2 couleurs (vivantes et mortes) ou 4 couleurs (Va vivre / Va mourrir)

        public FormJeuVie()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Instancie les variables de bases
        /// </summary>
        private void FormJeuVie_Load(object sender, EventArgs e)
        {
            textBoxTurn.Text = "0";
            textBoxNbAlive.Text = "0";
        }
        /// <summary>
        /// Initialise les paramètres de bases du jeu et génère aléatoirement une grille
        /// </summary>
        private void buttonInitialise_Click(object sender, EventArgs e)
        {
            buttonPlayPause.Image = JeuVie.Properties.Resources.play;
            start = false;
            timerLoop.Stop();
            turn = 0;
            nbAlive = 0;
            premier = new AutomateJeuVie[20, 20];
            actuel = new AutomateJeuVie[20, 20];
            //i = X, J = Y - Génère un tableau de cellules
            Random random = new Random();
            int rnd;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                   
                    rnd = random.Next(0, 100);
            
                    if (i == 0 && j == 0)
                    {
                        actuel[0, 0] = new AutomateJeuVie((int)numericUpDownPourcentage.Value);
                        if (actuel[0, 0].Vivante)
                            nbAlive++;

                        premier[0, 0] = new AutomateJeuVie((int)numericUpDownPourcentage.Value);
                    }
                    else
                    {
                        actuel[i, j] = new AutomateJeuVie(rnd, 0);
                        if (actuel[i, j].Vivante)
                            nbAlive++;
                        premier[i, j] = new AutomateJeuVie(rnd, 0);
                    }
                }

            }

            prochain = new AutomateJeuVie[20, 20];
            //i = X, J = Y - Génère un tableau de cellules mortes qui sera mis à jour
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    prochain[i,j] = new AutomateJeuVie(false);
                }
            }
            //Rempli le tableau "prochain" 
            prochain = UpdateNext(actuel, prochain);

            buttonInitialise.Text = "Réinitialiser";
            buttonFastForward.Enabled = true;
            buttonNext.Enabled = true;
            buttonPlayPause.Enabled = true;
            buttonPrevious.Enabled = true;
            buttonSlow.Enabled = true;
            Dessiner(actuel, prochain);

            textBoxNbAlive.Text = nbAlive.ToString();
            textBoxTurn.Text = turn.ToString();
        }

        /// <summary>
        /// Met à jour le tableau suivant en fonction du tableau actuel
        /// </summary>
        /// <param name="tableau">Tableau de cellules à mettre à jour</param>
        private AutomateJeuVie[,] UpdateNext(AutomateJeuVie[,] actuel, AutomateJeuVie[,] suivant)
        { 
            //Parcours le tableau en X,Y
            for (int i = 0; i < 20; i++)
            {
                //Parcours le tableau en X,Y
                for (int j = 0; j < 20; j++)
                {
                    //Définit si la cellule va vivre ou mourir (Bool)
                    suivant[i,j].Vivante = VaVivre(actuel, i, j);
                }
            }//Fin For
            return suivant;
        }//Fin UpdateNext

        //Todo dans le VaVivre
        /// <summary>
        /// Calcul si une cellule va vivre ou mourir
        /// </summary>
        /// <param name="tableau">Tableau avec les résultats actuels</param>
        /// <param name="coordX">Coordonées X de la cellule</param>
        /// <param name="coordY">Coordonées Y de la cellule</param>
        /// <returns></returns>
        private bool VaVivre(AutomateJeuVie[,] tableau, int coordX, int coordY)
        {
            //Détermine le nombre de voisins
            int nbVoisin = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    //Compte le nombre de voisin, excluant le "centre"

                    if (i == 0 && j == 0)
                    {     }
//Todo: Pourquoi if(i!= 0 && j!=0) ne marche pas!!
                    else{   
                        int X = coordX + i;
                        int Y = coordY + j;
                        #region exceptions
                        //Vérifie si la cellule est sur un extrémité du tableau
                        if (coordX == 0 || coordX == 19 || coordY == 0 || coordY == 19)
                        {

                            //Remplace le X & Y en fonction de sa situation 
                            if (X == -1)
                                X = 19;
                            if (X == 20)
                                X = 0;
                            if (Y == -1)
                                Y = 19;
                            if (Y == 20)
                                Y = 0;


                        }
                        #endregion
                        //Fin exceptions

                        if (tableau[X,Y].Vivante)
                            nbVoisin++;
                    }//Fin Centre
                }
            }//Fin du compte

            //Vérifie l'état dans laquelle se trouve la cellule
            bool etat = tableau[coordX, coordY].Vivante;
            bool retour;
            //Calcul l'état final de la cellule si la cellule est vivante
            if (etat)
            {
                if (nbVoisin == 2 || nbVoisin == 3)
                    retour = true;
                else
                    retour = false;
            }

            //Calcul l'état final de la cellule si elle est morte
            else 
            {
                if (nbVoisin == 3)
                    retour = true;
                else
                    retour = false;
            }

            return retour;
        }//Fin VaVivre

        /// <summary>
        /// Dessine le tableau
        /// </summary>
        /// <param name="actuel">Tableau actuel afin de trouver les cellules vivantes</param>
        /// <param name="suivant">Tableau suivant afin de trouver quelles cellules vont vivre ou mourrir</param>
        private void Dessiner(AutomateJeuVie[,] actuel, AutomateJeuVie[,] suivant)
        {
            Image img = this.pictureBoxJeu.Image;
            using (Graphics g = Graphics.FromImage(img))
            {
                g.FillRectangle(new SolidBrush(Color.Gray), 0, 0, pictureBoxJeu.Width, pictureBoxJeu.Height);
            }

            Graphics dessin = Graphics.FromImage(img);
            SolidBrush brush = new SolidBrush(Color.Black);

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (!modeDemo)
                    {
                        //Vivante
                        if (actuel[i, j].Vivante && suivant[i, j].Vivante)
                        {
                            brush.Color = Color.LimeGreen;
                        }
                        //Mourrante
                        else if (actuel[i, j].Vivante && !suivant[i, j].Vivante)
                        {
                            brush.Color = Color.Red;
                        }
                        //Naissante
                        else if (!actuel[i, j].Vivante && suivant[i, j].Vivante)
                        {
                            brush.Color = Color.Blue;
                        }
                        //Morte
                        else if (!actuel[i, j].Vivante && !suivant[i, j].Vivante)
                        {
                            brush.Color = Color.Black;
                        }
                    }
                    else
                    {
                        if (actuel[i, j].Vivante)
                            brush.Color = Color.White;
                        else
                            brush.Color = Color.Black;
                    }
                        dessin.FillEllipse(brush, 20*i, 20*j, 20, 20);
                    
                }
            }
            this.pictureBoxJeu.Image = img;
        }

        /// <summary>
        /// Passe au tour suivant
        /// </summary>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            NextTurn();
        }
        /// <summary>
        /// Passe au tour suivant et le dessine
        /// </summary>
        private void NextTurn()
        {
            nbAlive = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    actuel[i, j].Vivante = prochain[i, j].Vivante;
                    if (actuel[i,j].Vivante)
                        nbAlive++;
                }
            }
            prochain = UpdateNext(actuel, prochain);
            Dessiner(actuel, prochain);

            turn++;

            textBoxTurn.Text = turn.ToString();
            textBoxNbAlive.Text = nbAlive.ToString();
        }

        /// <summary>
        /// Démarre ou arrête l'avancement automatique
        /// </summary>
        private void buttonPlayPause_Click(object sender, EventArgs e)
        {
            if (start)
            {
                timerLoop.Stop();
                buttonPlayPause.Image = JeuVie.Properties.Resources.play;
                start = false;
            }
            else
            {
                timerLoop.Start();
                buttonPlayPause.Image = JeuVie.Properties.Resources.Pause;
                start = true;
            }
        }

        /// <summary>
        /// Passe au tour suivant de façon automatique (Timer)
        /// </summary>
        private void timerLoop_Tick(object sender, EventArgs e)
        {
            NextTurn();
        }

        /// <summary>
        /// Change la vitesse de l'avancement automatique
        /// </summary>
        private void numericUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            timerLoop.Interval = 1000 / (int)numericUpDownSpeed.Value;
        }

        /// <summary>
        /// Change la vitesse du déroulement automatique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFastForward_Click(object sender, EventArgs e)
        {
            if (numericUpDownSpeed.Value < 100)
            numericUpDownSpeed.Value++;
        }

        /// <summary>
        /// Ralenti la vitesse du déroulement automatique
        /// </summary>
        private void buttonSlow_Click(object sender, EventArgs e)
        {
            if (numericUpDownSpeed.Value > 1)
                numericUpDownSpeed.Value--;
        }

        /// <summary>
        /// Revient au tour d'avant
        /// </summary>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            int turnBackup = turn;
            if (turn > 0) {
                //Remet les cellules égales au tour 0
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        actuel[i, j].Vivante = premier[i, j].Vivante;
                        prochain[i, j].Vivante = false;
                    }
                }
                //Rempli le tableau "prochain" des données du tour 0
                prochain = UpdateNext(actuel, prochain);

                //Exécute Chaque tour jusqu'à celui d'avant
                for (int a = 0; a < turnBackup - 1; a++)
                {
                    NextTurn();
                }

                turn = turnBackup - 1;
                Dessiner(actuel, prochain);
                textBoxTurn.Text = turn.ToString();

            }
        }

        /// <summary>
        /// Charge le modèle 1
        /// </summary>
        private void modèle1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButtonModeBW.Checked = true;
            radioButtonModeColor.Checked = false;
            modeDemo = true;
            buttonPlayPause.Image = JeuVie.Properties.Resources.play;
            start = false;
            timerLoop.Stop();
            turn = 0;
            nbAlive = 0;
            premier = new AutomateJeuVie[20, 20];
            actuel = new AutomateJeuVie[20, 20];
            prochain = new AutomateJeuVie[20, 20];
            //i = X, J = Y - Génère un tableau de cellules mortes qui sera mis à jour
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    prochain[i,j] = new AutomateJeuVie(false);
                    premier[i, j] = new AutomateJeuVie(false);
                    actuel[i,j] = new AutomateJeuVie(false);
                }
            }
            //Rempli le tableau "Actuel" du modèle 1

            //Début carrés
            actuel[0, 5].Vivante = true;
            actuel[0, 6].Vivante = true;
            actuel[1, 5].Vivante = true;
            actuel[1, 6].Vivante = true;

            actuel[0, 11].Vivante = true;
            actuel[0, 10].Vivante = true;
            actuel[1, 11].Vivante = true;
            actuel[1, 10].Vivante = true;

            actuel[18, 5].Vivante = true;
            actuel[18, 6].Vivante = true;
            actuel[19, 5].Vivante = true;
            actuel[19, 6].Vivante = true;

            actuel[18, 11].Vivante = true;
            actuel[18, 10].Vivante = true;
            actuel[19, 11].Vivante = true;
            actuel[19, 10].Vivante = true;

            actuel[5, 0].Vivante = true;
            actuel[6, 0].Vivante = true;
            actuel[5, 1].Vivante = true;
            actuel[6, 1].Vivante = true;

            actuel[14, 0].Vivante = true;
            actuel[13, 0].Vivante = true;
            actuel[14, 1].Vivante = true;
            actuel[13, 1].Vivante = true;

            actuel[5, 16].Vivante = true;
            actuel[6, 16].Vivante = true;
            actuel[5, 15].Vivante = true;
            actuel[6, 15].Vivante = true;

            actuel[14, 16].Vivante = true;
            actuel[13, 16].Vivante = true;
            actuel[14, 15].Vivante = true;
            actuel[13, 15].Vivante = true;
            //Fin carrés

            //Début "Beignes"
            for (int i = 0; i < 3; i++)
            {
                actuel[5, 4 + i].Vivante = true;
                actuel[7, 4 + i].Vivante = true;
                actuel[12, 4 + i].Vivante = true;
                actuel[14, 4 + i].Vivante = true;

                actuel[5, 10 + i].Vivante = true;
                actuel[7, 10 + i].Vivante = true;
                actuel[12, 10 + i].Vivante = true;
                actuel[14, 10 + i].Vivante = true;
            }
            actuel[6, 4].Vivante = true;
            actuel[6, 6].Vivante = true;

            actuel[13, 4].Vivante = true;
            actuel[13, 6].Vivante = true;

            actuel[6, 10].Vivante = true;
            actuel[6, 12].Vivante = true;

            actuel[13, 10].Vivante = true;
            actuel[13, 12].Vivante = true;


            //Fin Beignes"




            //Rempli le tableau "prochain" 
            prochain = UpdateNext(actuel, prochain);

            buttonInitialise.Text = "Réinitialiser";
            buttonFastForward.Enabled = true;
            buttonNext.Enabled = true;
            buttonPlayPause.Enabled = true;
            buttonPrevious.Enabled = true;
            buttonSlow.Enabled = true;
            Dessiner(actuel, prochain);

            textBoxNbAlive.Text = nbAlive.ToString();
            textBoxTurn.Text = turn.ToString();
        }
        /// <summary>
        /// Charge le modèle 2
        /// </summary>
        private void modèle2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButtonModeBW.Checked = true;
            radioButtonModeColor.Checked = false;
            modeDemo = true;
            buttonPlayPause.Image = JeuVie.Properties.Resources.play;
            start = false;
            timerLoop.Stop();
            turn = 0;
            nbAlive = 0;
            premier = new AutomateJeuVie[20, 20];
            actuel = new AutomateJeuVie[20, 20];
            prochain = new AutomateJeuVie[20, 20];
            //i = X, J = Y - Génère un tableau de cellules mortes qui sera mis à jour
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    prochain[i, j] = new AutomateJeuVie(false);
                    premier[i, j] = new AutomateJeuVie(false);
                    actuel[i, j] = new AutomateJeuVie(false);
                }
            }
            //Rempli le tableau "Actuel" du modèle 2


            actuel[10, 10].Vivante = true;
            actuel[11, 10].Vivante = true;
            actuel[9, 10].Vivante = true;
            actuel[10, 11].Vivante = true;
            actuel[10, 9].Vivante = true;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (actuel[i, j].Vivante)
                        premier[i, j].Vivante = true;
                }
            }


            //Rempli le tableau "prochain" 
            prochain = UpdateNext(actuel, prochain);

            buttonInitialise.Text = "Réinitialiser";
            buttonFastForward.Enabled = true;
            buttonNext.Enabled = true;
            buttonPlayPause.Enabled = true;
            buttonPrevious.Enabled = true;
            buttonSlow.Enabled = true;
            Dessiner(actuel, prochain);

            textBoxNbAlive.Text = nbAlive.ToString();
            textBoxTurn.Text = turn.ToString();
        }
        /// <summary>
        /// Charge le modèle 3
        /// </summary>
        private void modèle3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButtonModeBW.Checked = true;
            radioButtonModeColor.Checked = false;
            modeDemo = true;
            buttonPlayPause.Image = JeuVie.Properties.Resources.play;
            start = false;
            timerLoop.Stop();
            turn = 0;
            nbAlive = 0;
            premier = new AutomateJeuVie[20, 20];
            actuel = new AutomateJeuVie[20, 20];
            prochain = new AutomateJeuVie[20, 20];
            //i = X, J = Y - Génère un tableau de cellules mortes qui sera mis à jour
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    prochain[i, j] = new AutomateJeuVie(false);
                    premier[i, j] = new AutomateJeuVie(false);
                    actuel[i, j] = new AutomateJeuVie(false);
                }
            }
            //Rempli le tableau "Actuel" du modèle 3

            for (int i = 6; i <= 13; i++)
            {
                actuel[i, 6].Vivante = true;
                premier[i, 6].Vivante = true;
            }
            


            //Rempli le tableau "prochain" 
            prochain = UpdateNext(actuel, prochain);

            buttonInitialise.Text = "Réinitialiser";
            buttonFastForward.Enabled = true;
            buttonNext.Enabled = true;
            buttonPlayPause.Enabled = true;
            buttonPrevious.Enabled = true;
            buttonSlow.Enabled = true;
            Dessiner(actuel, prochain);

            textBoxNbAlive.Text = nbAlive.ToString();
            textBoxTurn.Text = turn.ToString();
        }
        /// <summary>
        /// Change le mode pour "Noir et blanc"
        /// </summary>
        private void radioButtonModeBW_CheckedChanged(object sender, EventArgs e)
        {
            modeDemo = true;
            Dessiner(actuel, prochain);
        }
        /// <summary>
        /// Change le mode pour Couleur
        /// </summary>
        private void radioButtonModeColor_CheckedChanged(object sender, EventArgs e)
        {
            modeDemo = false;
            Dessiner(actuel, prochain);
        }
        /// <summary>
        /// Ouvre le jeu de la vie en plein écran (1600*900)
        /// </summary>
        private void buttonFS_Click(object sender, EventArgs e)
        {
            Form grille = new grille();
            grille.ShowDialog();
           
        }



    }
}
