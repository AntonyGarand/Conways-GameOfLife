//Définit une classe ayant les caractéristiques du jeu de la vie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuVie
{
    /// <summary>
    /// Automate représentant le jeu de la vie tel qu'imaginé par J. Conway.
    /// </summary>
    class AutomateJeuVie
    {
        private static int pourcentageGeneration;
        private static int nbVivantes;

        private bool vivante;
        private Random random = new Random();
        /// <summary>
        /// Génère les cellules.
        /// </summary>
        public AutomateJeuVie()
        {
            int rnd = random.Next(0, 100);
            if (rnd < pourcentageGeneration)
            {
                nbVivantes++;
                this.vivante = true;
            }
        }

        /// <summary>
        /// Définit si une cellule est vivante ou pas
        /// </summary>
        /// <param name="rnd">Chiffre aléatoire entre 0 et 100</param>
        /// <param name="useless">Inutile, chiffre peu importe quel qu'il soit</param> 
        public AutomateJeuVie(int rnd, int useless)
        {
            if (rnd < pourcentageGeneration)
            {
                nbVivantes++;
                this.vivante = true;
            }
        }

        /// <summary>
        /// Génère la première cellule et définit le pourcentage de cellules vivantes
        /// </summary>
        /// <param name="pourcentageGen">Pourcentage de cellules vivantes</param>
        public AutomateJeuVie(int pourcentageGen)
        {
            pourcentageGeneration = pourcentageGen;

            int rnd = random.Next(0, 100);
            if (rnd < pourcentageGeneration)
            {
                this.vivante = true;
                nbVivantes++;
            }
        }
        /// <summary>
        /// Génère une cellule morte ou vivante
        /// </summary>
        /// <param name="vie">Définit si la cellule est morte ou vivante</param>
        public AutomateJeuVie(bool vie)
        {
            if (vie)
                nbVivantes++;
            this.vivante = vie;
        }

        /// <summary>
        /// Permet de savoir si une cellule est vivante, et d'accéder à sa valeur actuelle.
        /// </summary>
        public bool Vivante
        {
            get { return this.vivante; }
            set { this.vivante = value; }
        }
        public static int NbVivantes
        {
            get { return nbVivantes; }
            set { nbVivantes = value; }
        }

    }
}
