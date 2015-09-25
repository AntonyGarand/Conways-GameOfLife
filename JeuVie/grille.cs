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
    public partial class grille : Form
    {
        public grille()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Transforme la grille en plein égran et oubre le form des contrôles pardessus. 
        /// </summary>
        private void grille_Shown(object sender, EventArgs e)
        {
            grille.ActiveForm.MaximizeBox = false;
            grille.ActiveForm.MinimizeBox = false;
            grille.ActiveForm.TopMost = false;
            grille.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            grille.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Form controles = new contrôles(this.pictureBoxJeu, grille.ActiveForm.Width, grille.ActiveForm.Height);
            controles.ShowDialog();
        }


    
    }
}
