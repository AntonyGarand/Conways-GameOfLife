namespace JeuVie
{
    partial class FormJeuVie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJeuVie));
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonSlow = new System.Windows.Forms.Button();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.buttonFastForward = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonInitialise = new System.Windows.Forms.Button();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.timerLoop = new System.Windows.Forms.Timer(this.components);
            this.labelNbVivantes = new System.Windows.Forms.Label();
            this.labelFrame = new System.Windows.Forms.Label();
            this.textBoxNbAlive = new System.Windows.Forms.TextBox();
            this.textBoxTurn = new System.Windows.Forms.TextBox();
            this.labelPourcentage = new System.Windows.Forms.Label();
            this.numericUpDownPourcentage = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxJeu = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chargerUnModèleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modèle1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modèle2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modèle3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonModeBW = new System.Windows.Forms.RadioButton();
            this.radioButtonModeColor = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.buttonFS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPourcentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJeu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Enabled = false;
            this.buttonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrevious.Image")));
            this.buttonPrevious.Location = new System.Drawing.Point(12, 472);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(61, 55);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonSlow
            // 
            this.buttonSlow.Enabled = false;
            this.buttonSlow.Image = ((System.Drawing.Image)(resources.GetObject("buttonSlow.Image")));
            this.buttonSlow.Location = new System.Drawing.Point(98, 472);
            this.buttonSlow.Name = "buttonSlow";
            this.buttonSlow.Size = new System.Drawing.Size(61, 55);
            this.buttonSlow.TabIndex = 2;
            this.buttonSlow.UseVisualStyleBackColor = true;
            this.buttonSlow.Click += new System.EventHandler(this.buttonSlow_Click);
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.Enabled = false;
            this.buttonPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlayPause.Image")));
            this.buttonPlayPause.Location = new System.Drawing.Point(183, 472);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(61, 55);
            this.buttonPlayPause.TabIndex = 3;
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
            // 
            // buttonFastForward
            // 
            this.buttonFastForward.Enabled = false;
            this.buttonFastForward.Image = ((System.Drawing.Image)(resources.GetObject("buttonFastForward.Image")));
            this.buttonFastForward.Location = new System.Drawing.Point(269, 472);
            this.buttonFastForward.Name = "buttonFastForward";
            this.buttonFastForward.Size = new System.Drawing.Size(61, 55);
            this.buttonFastForward.TabIndex = 4;
            this.buttonFastForward.UseVisualStyleBackColor = true;
            this.buttonFastForward.Click += new System.EventHandler(this.buttonFastForward_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonNext.Image")));
            this.buttonNext.Location = new System.Drawing.Point(351, 472);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(61, 55);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonInitialise
            // 
            this.buttonInitialise.Location = new System.Drawing.Point(244, 443);
            this.buttonInitialise.Name = "buttonInitialise";
            this.buttonInitialise.Size = new System.Drawing.Size(120, 23);
            this.buttonInitialise.TabIndex = 6;
            this.buttonInitialise.Text = "Initialiser";
            this.buttonInitialise.UseVisualStyleBackColor = true;
            this.buttonInitialise.Click += new System.EventHandler(this.buttonInitialise_Click);
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(346, 581);
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownSpeed.TabIndex = 7;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numericUpDownSpeed_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(267, 583);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(67, 13);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "Vitesse (fps):";
            // 
            // timerLoop
            // 
            this.timerLoop.Interval = 1000;
            this.timerLoop.Tick += new System.EventHandler(this.timerLoop_Tick);
            // 
            // labelNbVivantes
            // 
            this.labelNbVivantes.AutoSize = true;
            this.labelNbVivantes.Location = new System.Drawing.Point(188, 537);
            this.labelNbVivantes.Name = "labelNbVivantes";
            this.labelNbVivantes.Size = new System.Drawing.Size(146, 13);
            this.labelNbVivantes.TabIndex = 9;
            this.labelNbVivantes.Text = "Nombre de cellules vivantes: ";
            // 
            // labelFrame
            // 
            this.labelFrame.AutoSize = true;
            this.labelFrame.Location = new System.Drawing.Point(261, 560);
            this.labelFrame.Name = "labelFrame";
            this.labelFrame.Size = new System.Drawing.Size(73, 13);
            this.labelFrame.TabIndex = 10;
            this.labelFrame.Text = "Tour numéro: ";
            // 
            // textBoxNbAlive
            // 
            this.textBoxNbAlive.Enabled = false;
            this.textBoxNbAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNbAlive.Location = new System.Drawing.Point(346, 534);
            this.textBoxNbAlive.Name = "textBoxNbAlive";
            this.textBoxNbAlive.Size = new System.Drawing.Size(58, 20);
            this.textBoxNbAlive.TabIndex = 11;
            // 
            // textBoxTurn
            // 
            this.textBoxTurn.Enabled = false;
            this.textBoxTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTurn.Location = new System.Drawing.Point(346, 557);
            this.textBoxTurn.Name = "textBoxTurn";
            this.textBoxTurn.Size = new System.Drawing.Size(58, 20);
            this.textBoxTurn.TabIndex = 12;
            // 
            // labelPourcentage
            // 
            this.labelPourcentage.AutoSize = true;
            this.labelPourcentage.Location = new System.Drawing.Point(52, 448);
            this.labelPourcentage.Name = "labelPourcentage";
            this.labelPourcentage.Size = new System.Drawing.Size(117, 13);
            this.labelPourcentage.TabIndex = 13;
            this.labelPourcentage.Text = "Pourcentage vivantes: ";
            // 
            // numericUpDownPourcentage
            // 
            this.numericUpDownPourcentage.Location = new System.Drawing.Point(169, 446);
            this.numericUpDownPourcentage.Name = "numericUpDownPourcentage";
            this.numericUpDownPourcentage.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownPourcentage.TabIndex = 14;
            this.numericUpDownPourcentage.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // pictureBoxJeu
            // 
            this.pictureBoxJeu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxJeu.Image")));
            this.pictureBoxJeu.Location = new System.Drawing.Point(12, 36);
            this.pictureBoxJeu.Name = "pictureBoxJeu";
            this.pictureBoxJeu.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxJeu.TabIndex = 0;
            this.pictureBoxJeu.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerUnModèleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chargerUnModèleToolStripMenuItem
            // 
            this.chargerUnModèleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modèle1ToolStripMenuItem,
            this.modèle2ToolStripMenuItem,
            this.modèle3ToolStripMenuItem});
            this.chargerUnModèleToolStripMenuItem.Name = "chargerUnModèleToolStripMenuItem";
            this.chargerUnModèleToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.chargerUnModèleToolStripMenuItem.Text = "Charger un modèle";
            // 
            // modèle1ToolStripMenuItem
            // 
            this.modèle1ToolStripMenuItem.Name = "modèle1ToolStripMenuItem";
            this.modèle1ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.modèle1ToolStripMenuItem.Text = "Modèle 1";
            this.modèle1ToolStripMenuItem.Click += new System.EventHandler(this.modèle1ToolStripMenuItem_Click);
            // 
            // modèle2ToolStripMenuItem
            // 
            this.modèle2ToolStripMenuItem.Name = "modèle2ToolStripMenuItem";
            this.modèle2ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.modèle2ToolStripMenuItem.Text = "Modèle 2";
            this.modèle2ToolStripMenuItem.Click += new System.EventHandler(this.modèle2ToolStripMenuItem_Click);
            // 
            // modèle3ToolStripMenuItem
            // 
            this.modèle3ToolStripMenuItem.Name = "modèle3ToolStripMenuItem";
            this.modèle3ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.modèle3ToolStripMenuItem.Text = "Modèle 3";
            this.modèle3ToolStripMenuItem.Click += new System.EventHandler(this.modèle3ToolStripMenuItem_Click);
            // 
            // radioButtonModeBW
            // 
            this.radioButtonModeBW.AutoSize = true;
            this.radioButtonModeBW.Location = new System.Drawing.Point(6, 39);
            this.radioButtonModeBW.Name = "radioButtonModeBW";
            this.radioButtonModeBW.Size = new System.Drawing.Size(85, 17);
            this.radioButtonModeBW.TabIndex = 17;
            this.radioButtonModeBW.Text = "Noir et blanc";
            this.radioButtonModeBW.UseVisualStyleBackColor = true;
            this.radioButtonModeBW.CheckedChanged += new System.EventHandler(this.radioButtonModeBW_CheckedChanged);
            // 
            // radioButtonModeColor
            // 
            this.radioButtonModeColor.AutoSize = true;
            this.radioButtonModeColor.Checked = true;
            this.radioButtonModeColor.Location = new System.Drawing.Point(6, 19);
            this.radioButtonModeColor.Name = "radioButtonModeColor";
            this.radioButtonModeColor.Size = new System.Drawing.Size(61, 17);
            this.radioButtonModeColor.TabIndex = 18;
            this.radioButtonModeColor.TabStop = true;
            this.radioButtonModeColor.Text = "Couleur";
            this.radioButtonModeColor.UseVisualStyleBackColor = true;
            this.radioButtonModeColor.CheckedChanged += new System.EventHandler(this.radioButtonModeColor_CheckedChanged);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonModeBW);
            this.groupBoxMode.Controls.Add(this.radioButtonModeColor);
            this.groupBoxMode.Location = new System.Drawing.Point(12, 534);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(157, 62);
            this.groupBoxMode.TabIndex = 20;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // buttonFS
            // 
            this.buttonFS.Location = new System.Drawing.Point(169, 568);
            this.buttonFS.Name = "buttonFS";
            this.buttonFS.Size = new System.Drawing.Size(84, 22);
            this.buttonFS.TabIndex = 37;
            this.buttonFS.Text = "Full screen";
            this.buttonFS.UseVisualStyleBackColor = true;
            this.buttonFS.Click += new System.EventHandler(this.buttonFS_Click);
            // 
            // FormJeuVie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 610);
            this.Controls.Add(this.buttonFS);
            this.Controls.Add(this.pictureBoxJeu);
            this.Controls.Add(this.numericUpDownPourcentage);
            this.Controls.Add(this.labelPourcentage);
            this.Controls.Add(this.textBoxTurn);
            this.Controls.Add(this.textBoxNbAlive);
            this.Controls.Add(this.labelFrame);
            this.Controls.Add(this.labelNbVivantes);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.buttonInitialise);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFastForward);
            this.Controls.Add(this.buttonPlayPause);
            this.Controls.Add(this.buttonSlow);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormJeuVie";
            this.Text = "Jeu de la Vie";
            this.Load += new System.EventHandler(this.FormJeuVie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPourcentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJeu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonSlow;
        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.Button buttonFastForward;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonInitialise;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Timer timerLoop;
        private System.Windows.Forms.Label labelNbVivantes;
        private System.Windows.Forms.Label labelFrame;
        private System.Windows.Forms.TextBox textBoxNbAlive;
        private System.Windows.Forms.TextBox textBoxTurn;
        private System.Windows.Forms.Label labelPourcentage;
        private System.Windows.Forms.NumericUpDown numericUpDownPourcentage;
        private System.Windows.Forms.PictureBox pictureBoxJeu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chargerUnModèleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modèle1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modèle2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modèle3ToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonModeBW;
        private System.Windows.Forms.RadioButton radioButtonModeColor;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.Button buttonFS;
    }
}

