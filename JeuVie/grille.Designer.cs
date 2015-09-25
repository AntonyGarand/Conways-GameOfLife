namespace JeuVie
{
    partial class grille
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxJeu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJeu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxJeu
            // 
            this.pictureBoxJeu.BackgroundImage = global::JeuVie.Properties.Resources.blank;
            this.pictureBoxJeu.Image = global::JeuVie.Properties.Resources.blank;
            this.pictureBoxJeu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxJeu.Name = "pictureBoxJeu";
            this.pictureBoxJeu.Size = new System.Drawing.Size(1600, 900);
            this.pictureBoxJeu.TabIndex = 0;
            this.pictureBoxJeu.TabStop = false;
            // 
            // grille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBoxJeu);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "grille";
            this.Text = "grille";
            this.Shown += new System.EventHandler(this.grille_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJeu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxJeu;
    }
}