// contrôles.cs
// contrôles pour le jeu de la vie
// Programmé par Antony Garand
// Le 12 mars 2014
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace JeuVie
{
    public partial class contrôles : Form
    {
        int scrX;
        int scrY;
        int maxX = 1024;
        int maxY = 768;
        int currentX;
        int currentY;
        int _width;
        int _height;
        PictureBox pictureBoxJeu;
        public contrôles(PictureBox jeu, int width, int height)
        {
            InitializeComponent();
            pictureBoxJeu = jeu;
            _height = height;
            _width = width;
            maxX = width;
            maxY = height;
            scrX = width;
            scrY = height;

            numericUpDownMaxY.Maximum = maxX;
            numericUpDownMaxX.Maximum = maxX;

            numericUpDownMaxY.Value = maxY;
            numericUpDownMaxX.Value = maxX;
        }

        private AutomateJeuVie[,] actuel;
        private AutomateJeuVie[,] prochain;
        private AutomateJeuVie[,] premier;
        private int turn = 0;
        private int nbAlive = 0;
        private bool start = false;
        private bool modeDemo = false; //2 couleurs (vivantes et mortes) ou 4 couleurs (Va vivre / Va mourrir)

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
            currentX = maxX;
            currentY = maxY;
            premier = new AutomateJeuVie[currentX, currentY];
            actuel = new AutomateJeuVie[currentX, currentY];
            //i = X, J = Y - Génère un tableau de cellules
            Random random = new Random();
            int rnd;
            for (int i = 0; i < currentX; i++)
            {
                for (int j = 0; j < currentY; j++)
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

            prochain = new AutomateJeuVie[currentX, currentY];
            //i = X, J = Y - Génère un tableau de cellules mortes qui sera mis à jour
            for (int i = 0; i < currentX; i++)
            {
                for (int j = 0; j < currentY; j++)
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
            for (int i = 0; i < currentX; i++)
            {
                //Parcours le tableau en X,Y
                for (int j = 0; j < currentY; j++)
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
                        if (coordX == 0 || coordX == currentX-1 || coordY == 0 || coordY == currentY-1)
                        {

                            //Remplace le X & Y en fonction de sa situation 
                            if (X == -1)
                                X = currentX-1;
                            if (X == currentX)
                                X = 0;
                            if (Y == -1)
                                Y = currentY-1;
                            if (Y == currentY)
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
            //Copie l'image de jeu de la vie
            Image img = this.pictureBoxJeu.Image;
            
            ////La retransforme en entier en gris
            //using (Graphics a = Graphics.FromImage(img))
            //{
            //    a.FillRectangle(new SolidBrush(Color.Gray), 0, 0, pictureBoxJeu.Width, pictureBoxJeu.Height);
            //}

            //Insère l'image dans le bitmap
            Bitmap bmp = new Bitmap(img);

            //Trouve le nombre de byte (2 bytes pour la "signature" truc machin pax "X")
            //int nbBytes = (currentX + 2) * currentY * 3;

            //byte[] pixels = new byte[nbBytes];
            

            Graphics dessin = Graphics.FromImage(img);
            SolidBrush brush = new SolidBrush(Color.Black);
            //LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            for (int i = 0; i < currentX; i++)
            {
                for (int j = 0; j < currentY; j++)
                {
                    //byte r = 0;
                    //byte g = 0;
                    //byte b = 0;
                    if (!modeDemo)
                    {
                        //Vivante
                        if (actuel[i, j].Vivante && suivant[i, j].Vivante)
                        {
                            //g = 255;
                            brush.Color = Color.LimeGreen;
                        }
                        //Mourrante
                        else if (actuel[i, j].Vivante && !suivant[i, j].Vivante)
                        {
                            //r = 255;
                            brush.Color = Color.Red;
                        }
                        //Naissante
                        else if (!actuel[i, j].Vivante && suivant[i, j].Vivante)
                        {
                            //b = 255;
                            
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
                        {
                            //r = 255;
                            //g = 255;
                            //b = 255;
                            brush.Color = Color.White;
                        }
                        else
                        {
                            brush.Color = Color.Black;
                        }
                    }
                    
                    //pixels[(i * 3) + (j * currentX+2) ] = (byte)r;
                    //pixels[(i * 3) + (j * currentX + 2)] = (byte)g;
                    //pixels[(i * 3) + (j * currentX + 2)] = (byte)b;

                    //Dessine en fonction de la grandeur de l'écran les carrés
                    dessin.FillRectangle(brush, (scrX / currentX + 1) * i, (scrY / currentY + 1) * j, (scrX / currentX) + 1, (scrY / currentY) + 1);
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
            for (int i = 0; i < currentX; i++)
            {
                for (int j = 0; j < currentY; j++)
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
        private void buttonFastForward_Click(object sender, EventArgs e)
        {
            if (numericUpDownSpeed.Value < 60)
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
                for (int i = 0; i < currentX; i++)
                {
                    for (int j = 0; j < currentY; j++)
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
            premier = new AutomateJeuVie[currentX, currentY];
            actuel = new AutomateJeuVie[currentX, currentY];
            prochain = new AutomateJeuVie[currentX, currentY];
            //i = X, J = Y - Génère un tableau de cellules mortes qui sera mis à jour
            for (int i = 0; i < currentX; i++)
            {
                for (int j = 0; j < currentY; j++)
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
            premier = new AutomateJeuVie[currentX, currentY];
            actuel = new AutomateJeuVie[currentX, currentY];
            prochain = new AutomateJeuVie[currentX, currentY];
            //i = X, J = Y - Génère un tableau de cellules mortes qui sera mis à jour
            for (int i = 0; i < currentX; i++)
            {
                for (int j = 0; j < currentY; j++)
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

            for (int i = 0; i < currentX; i++)
            {
                for (int j = 0; j < currentY; j++)
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
            premier = new AutomateJeuVie[currentX, currentY];
            actuel = new AutomateJeuVie[currentX, currentY];
            prochain = new AutomateJeuVie[currentX, currentY];
            //i = X, J = Y - Génère un tableau de cellules mortes qui sera mis à jour
            for (int i = 0; i < currentX; i++)
            {
                for (int j = 0; j < currentY; j++)
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

        private void radioButtonModeBW_CheckedChanged(object sender, EventArgs e)
        {
            modeDemo = true;
            Dessiner(actuel, prochain);
        }

        private void radioButtonModeColor_CheckedChanged(object sender, EventArgs e)
        {
            modeDemo = false;
            Dessiner(actuel, prochain);
        }

        private void timerLoop_Tick_1(object sender, EventArgs e)
        {
            NextTurn();
        }

        private void numericUpDownMaxX_ValueChanged(object sender, EventArgs e)
        {
            maxX = (int)numericUpDownMaxX.Value;
        }

        private void numericUpDownMaxY_ValueChanged(object sender, EventArgs e)
        {
            maxY = (int)numericUpDownMaxY.Value;
        }

    }
}
