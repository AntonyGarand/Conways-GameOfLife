namespace JeuVie
{
    partial class contrôles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contrôles));
            this.numericUpDownPourcentage = new System.Windows.Forms.NumericUpDown();
            this.labelPourcentage = new System.Windows.Forms.Label();
            this.textBoxTurn = new System.Windows.Forms.TextBox();
            this.textBoxNbAlive = new System.Windows.Forms.TextBox();
            this.labelFrame = new System.Windows.Forms.Label();
            this.labelNbVivantes = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.buttonInitialise = new System.Windows.Forms.Button();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonModeBW = new System.Windows.Forms.RadioButton();
            this.radioButtonModeColor = new System.Windows.Forms.RadioButton();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFastForward = new System.Windows.Forms.Button();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.buttonSlow = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.timerLoop = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownMaxX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxY = new System.Windows.Forms.NumericUpDown();
            this.labelNbCellX = new System.Windows.Forms.Label();
            this.labelCellY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPourcentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.groupBoxMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPourcentage
            // 
            this.numericUpDownPourcentage.Location = new System.Drawing.Point(166, 7);
            this.numericUpDownPourcentage.Name = "numericUpDownPourcentage";
            this.numericUpDownPourcentage.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownPourcentage.TabIndex = 34;
            this.numericUpDownPourcentage.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // labelPourcentage
            // 
            this.labelPourcentage.AutoSize = true;
            this.labelPourcentage.Location = new System.Drawing.Point(49, 9);
            this.labelPourcentage.Name = "labelPourcentage";
            this.labelPourcentage.Size = new System.Drawing.Size(117, 13);
            this.labelPourcentage.TabIndex = 33;
            this.labelPourcentage.Text = "Pourcentage vivantes: ";
            // 
            // textBoxTurn
            // 
            this.textBoxTurn.Enabled = false;
            this.textBoxTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTurn.Location = new System.Drawing.Point(343, 118);
            this.textBoxTurn.Name = "textBoxTurn";
            this.textBoxTurn.Size = new System.Drawing.Size(58, 20);
            this.textBoxTurn.TabIndex = 32;
            // 
            // textBoxNbAlive
            // 
            this.textBoxNbAlive.Enabled = false;
            this.textBoxNbAlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNbAlive.Location = new System.Drawing.Point(343, 95);
            this.textBoxNbAlive.Name = "textBoxNbAlive";
            this.textBoxNbAlive.Size = new System.Drawing.Size(58, 20);
            this.textBoxNbAlive.TabIndex = 31;
            // 
            // labelFrame
            // 
            this.labelFrame.AutoSize = true;
            this.labelFrame.Location = new System.Drawing.Point(258, 121);
            this.labelFrame.Name = "labelFrame";
            this.labelFrame.Size = new System.Drawing.Size(73, 13);
            this.labelFrame.TabIndex = 30;
            this.labelFrame.Text = "Tour numéro: ";
            // 
            // labelNbVivantes
            // 
            this.labelNbVivantes.AutoSize = true;
            this.labelNbVivantes.Location = new System.Drawing.Point(185, 98);
            this.labelNbVivantes.Name = "labelNbVivantes";
            this.labelNbVivantes.Size = new System.Drawing.Size(146, 13);
            this.labelNbVivantes.TabIndex = 29;
            this.labelNbVivantes.Text = "Nombre de cellules vivantes: ";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(264, 144);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(67, 13);
            this.labelSpeed.TabIndex = 28;
            this.labelSpeed.Text = "Vitesse (fps):";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(343, 142);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownSpeed.TabIndex = 27;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numericUpDownSpeed_ValueChanged);
            // 
            // buttonInitialise
            // 
            this.buttonInitialise.Location = new System.Drawing.Point(241, 4);
            this.buttonInitialise.Name = "buttonInitialise";
            this.buttonInitialise.Size = new System.Drawing.Size(120, 23);
            this.buttonInitialise.TabIndex = 26;
            this.buttonInitialise.Text = "Initialiser";
            this.buttonInitialise.UseVisualStyleBackColor = true;
            this.buttonInitialise.Click += new System.EventHandler(this.buttonInitialise_Click);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonModeBW);
            this.groupBoxMode.Controls.Add(this.radioButtonModeColor);
            this.groupBoxMode.Location = new System.Drawing.Point(9, 95);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(95, 62);
            this.groupBoxMode.TabIndex = 35;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
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
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonNext.Image")));
            this.buttonNext.Location = new System.Drawing.Point(348, 33);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(61, 55);
            this.buttonNext.TabIndex = 25;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFastForward
            // 
            this.buttonFastForward.Enabled = false;
            this.buttonFastForward.Image = ((System.Drawing.Image)(resources.GetObject("buttonFastForward.Image")));
            this.buttonFastForward.Location = new System.Drawing.Point(266, 33);
            this.buttonFastForward.Name = "buttonFastForward";
            this.buttonFastForward.Size = new System.Drawing.Size(61, 55);
            this.buttonFastForward.TabIndex = 24;
            this.buttonFastForward.UseVisualStyleBackColor = true;
            this.buttonFastForward.Click += new System.EventHandler(this.buttonFastForward_Click);
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.Enabled = false;
            this.buttonPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlayPause.Image")));
            this.buttonPlayPause.Location = new System.Drawing.Point(180, 33);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(61, 55);
            this.buttonPlayPause.TabIndex = 23;
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
            // 
            // buttonSlow
            // 
            this.buttonSlow.Enabled = false;
            this.buttonSlow.Image = ((System.Drawing.Image)(resources.GetObject("buttonSlow.Image")));
            this.buttonSlow.Location = new System.Drawing.Point(95, 33);
            this.buttonSlow.Name = "buttonSlow";
            this.buttonSlow.Size = new System.Drawing.Size(61, 55);
            this.buttonSlow.TabIndex = 22;
            this.buttonSlow.UseVisualStyleBackColor = true;
            this.buttonSlow.Click += new System.EventHandler(this.buttonSlow_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Enabled = false;
            this.buttonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrevious.Image")));
            this.buttonPrevious.Location = new System.Drawing.Point(9, 33);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(61, 55);
            this.buttonPrevious.TabIndex = 21;
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // timerLoop
            // 
            this.timerLoop.Tick += new System.EventHandler(this.timerLoop_Tick_1);
            // 
            // numericUpDownMaxX
            // 
            this.numericUpDownMaxX.Location = new System.Drawing.Point(180, 119);
            this.numericUpDownMaxX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxX.Name = "numericUpDownMaxX";
            this.numericUpDownMaxX.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownMaxX.TabIndex = 36;
            this.numericUpDownMaxX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxX.ValueChanged += new System.EventHandler(this.numericUpDownMaxX_ValueChanged);
            // 
            // numericUpDownMaxY
            // 
            this.numericUpDownMaxY.Location = new System.Drawing.Point(180, 142);
            this.numericUpDownMaxY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxY.Name = "numericUpDownMaxY";
            this.numericUpDownMaxY.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownMaxY.TabIndex = 37;
            this.numericUpDownMaxY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxY.ValueChanged += new System.EventHandler(this.numericUpDownMaxY_ValueChanged);
            // 
            // labelNbCellX
            // 
            this.labelNbCellX.AutoSize = true;
            this.labelNbCellX.Location = new System.Drawing.Point(106, 120);
            this.labelNbCellX.Name = "labelNbCellX";
            this.labelNbCellX.Size = new System.Drawing.Size(79, 13);
            this.labelNbCellX.TabIndex = 38;
            this.labelNbCellX.Text = "Nb cellules (x): ";
            // 
            // labelCellY
            // 
            this.labelCellY.AutoSize = true;
            this.labelCellY.Location = new System.Drawing.Point(106, 143);
            this.labelCellY.Name = "labelCellY";
            this.labelCellY.Size = new System.Drawing.Size(79, 13);
            this.labelCellY.TabIndex = 39;
            this.labelCellY.Text = "Nb cellules (y): ";
            // 
            // contrôles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 169);
            this.Controls.Add(this.numericUpDownMaxY);
            this.Controls.Add(this.numericUpDownMaxX);
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
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.labelCellY);
            this.Controls.Add(this.labelNbCellX);
            this.Name = "contrôles";
            this.Text = "contrôles";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPourcentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPourcentage;
        private System.Windows.Forms.Label labelPourcentage;
        private System.Windows.Forms.TextBox textBoxTurn;
        private System.Windows.Forms.TextBox textBoxNbAlive;
        private System.Windows.Forms.Label labelFrame;
        private System.Windows.Forms.Label labelNbVivantes;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Button buttonInitialise;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFastForward;
        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.Button buttonSlow;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioButtonModeBW;
        private System.Windows.Forms.RadioButton radioButtonModeColor;
        private System.Windows.Forms.Timer timerLoop;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxX;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxY;
        private System.Windows.Forms.Label labelNbCellX;
        private System.Windows.Forms.Label labelCellY;
    }
}