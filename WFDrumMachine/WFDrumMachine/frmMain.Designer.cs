using System.Windows.Forms;

namespace WFDrumMachine
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.dgvTab1 = new System.Windows.Forms.DataGridView();
            this.imageList_Componenti = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTab2 = new System.Windows.Forms.DataGridView();
            this.nudLoops1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBPMMultiplier = new System.Windows.Forms.ComboBox();
            this.nudLoops2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddHHOpen1 = new System.Windows.Forms.Button();
            this.btnAddHHClose1 = new System.Windows.Forms.Button();
            this.btnAddRide1 = new System.Windows.Forms.Button();
            this.btnAddKick1 = new System.Windows.Forms.Button();
            this.btnAddSnare1 = new System.Windows.Forms.Button();
            this.btnAddTom11 = new System.Windows.Forms.Button();
            this.btnAddTom21 = new System.Windows.Forms.Button();
            this.btnAddCrash1 = new System.Windows.Forms.Button();
            this.btnAddChina1 = new System.Windows.Forms.Button();
            this.btnAddCrash2 = new System.Windows.Forms.Button();
            this.btnAddChina2 = new System.Windows.Forms.Button();
            this.btnAddTom12 = new System.Windows.Forms.Button();
            this.btnAddTom22 = new System.Windows.Forms.Button();
            this.btnAddSnare2 = new System.Windows.Forms.Button();
            this.btnAddKick2 = new System.Windows.Forms.Button();
            this.btnAddRide2 = new System.Windows.Forms.Button();
            this.btnAddHHClose2 = new System.Windows.Forms.Button();
            this.btnAddHHOpen2 = new System.Windows.Forms.Button();
            this.btnClearTab1 = new System.Windows.Forms.Button();
            this.btnClearTab2 = new System.Windows.Forms.Button();
            this.txbBPMValue = new System.Windows.Forms.TextBox();
            this.tbBPM = new System.Windows.Forms.TrackBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ckbRipetiTraccia = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoops1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoops2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBPM)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.Location = new System.Drawing.Point(481, 37);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(68, 36);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(798, 31);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 46);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "0/4";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTab1
            // 
            this.dgvTab1.AllowUserToAddRows = false;
            this.dgvTab1.AllowUserToDeleteRows = false;
            this.dgvTab1.AllowUserToResizeColumns = false;
            this.dgvTab1.AllowUserToResizeRows = false;
            this.dgvTab1.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgvTab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab1.Location = new System.Drawing.Point(36, 106);
            this.dgvTab1.MultiSelect = false;
            this.dgvTab1.Name = "dgvTab1";
            this.dgvTab1.ReadOnly = true;
            this.dgvTab1.RowHeadersVisible = false;
            this.dgvTab1.RowTemplate.Height = 30;
            this.dgvTab1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTab1.ShowRowErrors = false;
            this.dgvTab1.Size = new System.Drawing.Size(1006, 295);
            this.dgvTab1.TabIndex = 4;
            this.dgvTab1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_CellClick);
            this.dgvTab1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab_CellDoubleClick);
            this.dgvTab1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTab1_CellMouseClick);
            this.dgvTab1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTab_KeyDown);
            // 
            // imageList_Componenti
            // 
            this.imageList_Componenti.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Componenti.ImageStream")));
            this.imageList_Componenti.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Componenti.Images.SetKeyName(0, "HiHatOpen_24.png");
            this.imageList_Componenti.Images.SetKeyName(1, "HiHatClose_24.png");
            this.imageList_Componenti.Images.SetKeyName(2, "Ride_24.png");
            this.imageList_Componenti.Images.SetKeyName(3, "Snare_24.png");
            this.imageList_Componenti.Images.SetKeyName(4, "kick_24.png");
            this.imageList_Componenti.Images.SetKeyName(5, "Tom1_24.png");
            this.imageList_Componenti.Images.SetKeyName(6, "Tom2_24.png");
            this.imageList_Componenti.Images.SetKeyName(7, "Crash_24.png");
            this.imageList_Componenti.Images.SetKeyName(8, "China_24.png");
            this.imageList_Componenti.Images.SetKeyName(9, "PointBlue.png");
            this.imageList_Componenti.Images.SetKeyName(10, "Erase.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(656, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Battuta:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bpm:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTab2
            // 
            this.dgvTab2.AllowUserToAddRows = false;
            this.dgvTab2.AllowUserToDeleteRows = false;
            this.dgvTab2.AllowUserToResizeColumns = false;
            this.dgvTab2.AllowUserToResizeRows = false;
            this.dgvTab2.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgvTab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab2.Location = new System.Drawing.Point(36, 442);
            this.dgvTab2.MultiSelect = false;
            this.dgvTab2.Name = "dgvTab2";
            this.dgvTab2.ReadOnly = true;
            this.dgvTab2.RowHeadersVisible = false;
            this.dgvTab2.RowTemplate.Height = 30;
            this.dgvTab2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTab2.ShowRowErrors = false;
            this.dgvTab2.Size = new System.Drawing.Size(1006, 295);
            this.dgvTab2.TabIndex = 9;
            this.dgvTab2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab2_CellClick);
            this.dgvTab2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab2_CellDoubleClick);
            this.dgvTab2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTab2_CellMouseClick);
            // 
            // nudLoops1
            // 
            this.nudLoops1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudLoops1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudLoops1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLoops1.ForeColor = System.Drawing.Color.White;
            this.nudLoops1.Location = new System.Drawing.Point(1002, 77);
            this.nudLoops1.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudLoops1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoops1.Name = "nudLoops1";
            this.nudLoops1.Size = new System.Drawing.Size(36, 23);
            this.nudLoops1.TabIndex = 11;
            this.nudLoops1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(950, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loops:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(300, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "X";
            // 
            // cmbBPMMultiplier
            // 
            this.cmbBPMMultiplier.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbBPMMultiplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBPMMultiplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBPMMultiplier.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cmbBPMMultiplier.ForeColor = System.Drawing.Color.White;
            this.cmbBPMMultiplier.FormattingEnabled = true;
            this.cmbBPMMultiplier.Location = new System.Drawing.Point(336, 29);
            this.cmbBPMMultiplier.Name = "cmbBPMMultiplier";
            this.cmbBPMMultiplier.Size = new System.Drawing.Size(44, 23);
            this.cmbBPMMultiplier.TabIndex = 13;
            this.cmbBPMMultiplier.SelectedIndexChanged += new System.EventHandler(this.cmbBPMMultiplier_SelectedIndexChanged);
            // 
            // nudLoops2
            // 
            this.nudLoops2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudLoops2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudLoops2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.nudLoops2.ForeColor = System.Drawing.Color.White;
            this.nudLoops2.Location = new System.Drawing.Point(1002, 413);
            this.nudLoops2.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudLoops2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLoops2.Name = "nudLoops2";
            this.nudLoops2.Size = new System.Drawing.Size(36, 23);
            this.nudLoops2.TabIndex = 15;
            this.nudLoops2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(950, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Loops:";
            // 
            // btnAddHHOpen1
            // 
            this.btnAddHHOpen1.FlatAppearance.BorderSize = 0;
            this.btnAddHHOpen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHHOpen1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddHHOpen1.Location = new System.Drawing.Point(3, 130);
            this.btnAddHHOpen1.Name = "btnAddHHOpen1";
            this.btnAddHHOpen1.Size = new System.Drawing.Size(31, 31);
            this.btnAddHHOpen1.TabIndex = 16;
            this.btnAddHHOpen1.UseVisualStyleBackColor = true;
            this.btnAddHHOpen1.Click += new System.EventHandler(this.btnAddHHOpen_Click);
            // 
            // btnAddHHClose1
            // 
            this.btnAddHHClose1.FlatAppearance.BorderSize = 0;
            this.btnAddHHClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHHClose1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddHHClose1.Location = new System.Drawing.Point(3, 160);
            this.btnAddHHClose1.Name = "btnAddHHClose1";
            this.btnAddHHClose1.Size = new System.Drawing.Size(31, 31);
            this.btnAddHHClose1.TabIndex = 17;
            this.btnAddHHClose1.UseVisualStyleBackColor = true;
            this.btnAddHHClose1.Click += new System.EventHandler(this.btnAddHHClose_Click);
            // 
            // btnAddRide1
            // 
            this.btnAddRide1.FlatAppearance.BorderSize = 0;
            this.btnAddRide1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRide1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddRide1.Location = new System.Drawing.Point(3, 190);
            this.btnAddRide1.Name = "btnAddRide1";
            this.btnAddRide1.Size = new System.Drawing.Size(31, 31);
            this.btnAddRide1.TabIndex = 18;
            this.btnAddRide1.UseVisualStyleBackColor = true;
            this.btnAddRide1.Click += new System.EventHandler(this.btnAddRide_Click);
            // 
            // btnAddKick1
            // 
            this.btnAddKick1.FlatAppearance.BorderSize = 0;
            this.btnAddKick1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKick1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddKick1.Location = new System.Drawing.Point(3, 250);
            this.btnAddKick1.Name = "btnAddKick1";
            this.btnAddKick1.Size = new System.Drawing.Size(31, 31);
            this.btnAddKick1.TabIndex = 19;
            this.btnAddKick1.UseVisualStyleBackColor = true;
            this.btnAddKick1.Click += new System.EventHandler(this.btnAddKick_Click);
            // 
            // btnAddSnare1
            // 
            this.btnAddSnare1.FlatAppearance.BorderSize = 0;
            this.btnAddSnare1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSnare1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSnare1.Location = new System.Drawing.Point(3, 220);
            this.btnAddSnare1.Name = "btnAddSnare1";
            this.btnAddSnare1.Size = new System.Drawing.Size(31, 31);
            this.btnAddSnare1.TabIndex = 20;
            this.btnAddSnare1.UseVisualStyleBackColor = true;
            this.btnAddSnare1.Click += new System.EventHandler(this.btnAddSnare_Click);
            // 
            // btnAddTom11
            // 
            this.btnAddTom11.FlatAppearance.BorderSize = 0;
            this.btnAddTom11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTom11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTom11.Location = new System.Drawing.Point(3, 280);
            this.btnAddTom11.Name = "btnAddTom11";
            this.btnAddTom11.Size = new System.Drawing.Size(31, 31);
            this.btnAddTom11.TabIndex = 22;
            this.btnAddTom11.UseVisualStyleBackColor = true;
            this.btnAddTom11.Click += new System.EventHandler(this.btnAddTom1_Click);
            // 
            // btnAddTom21
            // 
            this.btnAddTom21.FlatAppearance.BorderSize = 0;
            this.btnAddTom21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTom21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTom21.Location = new System.Drawing.Point(3, 310);
            this.btnAddTom21.Name = "btnAddTom21";
            this.btnAddTom21.Size = new System.Drawing.Size(31, 31);
            this.btnAddTom21.TabIndex = 21;
            this.btnAddTom21.UseVisualStyleBackColor = true;
            this.btnAddTom21.Click += new System.EventHandler(this.btnAddTom2_Click);
            // 
            // btnAddCrash1
            // 
            this.btnAddCrash1.FlatAppearance.BorderSize = 0;
            this.btnAddCrash1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCrash1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCrash1.Location = new System.Drawing.Point(3, 340);
            this.btnAddCrash1.Name = "btnAddCrash1";
            this.btnAddCrash1.Size = new System.Drawing.Size(31, 31);
            this.btnAddCrash1.TabIndex = 24;
            this.btnAddCrash1.UseVisualStyleBackColor = true;
            this.btnAddCrash1.Click += new System.EventHandler(this.btnAddCrash_Click);
            // 
            // btnAddChina1
            // 
            this.btnAddChina1.FlatAppearance.BorderSize = 0;
            this.btnAddChina1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChina1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddChina1.Location = new System.Drawing.Point(3, 370);
            this.btnAddChina1.Name = "btnAddChina1";
            this.btnAddChina1.Size = new System.Drawing.Size(31, 31);
            this.btnAddChina1.TabIndex = 23;
            this.btnAddChina1.UseVisualStyleBackColor = true;
            this.btnAddChina1.Click += new System.EventHandler(this.btnAddChina_Click);
            // 
            // btnAddCrash2
            // 
            this.btnAddCrash2.FlatAppearance.BorderSize = 0;
            this.btnAddCrash2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCrash2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCrash2.Location = new System.Drawing.Point(3, 676);
            this.btnAddCrash2.Name = "btnAddCrash2";
            this.btnAddCrash2.Size = new System.Drawing.Size(31, 31);
            this.btnAddCrash2.TabIndex = 33;
            this.btnAddCrash2.UseVisualStyleBackColor = true;
            this.btnAddCrash2.Click += new System.EventHandler(this.btnAddCrash2_Click);
            // 
            // btnAddChina2
            // 
            this.btnAddChina2.FlatAppearance.BorderSize = 0;
            this.btnAddChina2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChina2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddChina2.Location = new System.Drawing.Point(3, 706);
            this.btnAddChina2.Name = "btnAddChina2";
            this.btnAddChina2.Size = new System.Drawing.Size(31, 31);
            this.btnAddChina2.TabIndex = 32;
            this.btnAddChina2.UseVisualStyleBackColor = true;
            this.btnAddChina2.Click += new System.EventHandler(this.btnAddChina2_Click);
            // 
            // btnAddTom12
            // 
            this.btnAddTom12.FlatAppearance.BorderSize = 0;
            this.btnAddTom12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTom12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTom12.Location = new System.Drawing.Point(3, 616);
            this.btnAddTom12.Name = "btnAddTom12";
            this.btnAddTom12.Size = new System.Drawing.Size(31, 31);
            this.btnAddTom12.TabIndex = 31;
            this.btnAddTom12.UseVisualStyleBackColor = true;
            this.btnAddTom12.Click += new System.EventHandler(this.btnAddTom12_Click);
            // 
            // btnAddTom22
            // 
            this.btnAddTom22.FlatAppearance.BorderSize = 0;
            this.btnAddTom22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTom22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTom22.Location = new System.Drawing.Point(3, 646);
            this.btnAddTom22.Name = "btnAddTom22";
            this.btnAddTom22.Size = new System.Drawing.Size(31, 31);
            this.btnAddTom22.TabIndex = 30;
            this.btnAddTom22.UseVisualStyleBackColor = true;
            this.btnAddTom22.Click += new System.EventHandler(this.btnAddTom22_Click);
            // 
            // btnAddSnare2
            // 
            this.btnAddSnare2.FlatAppearance.BorderSize = 0;
            this.btnAddSnare2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSnare2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSnare2.Location = new System.Drawing.Point(3, 556);
            this.btnAddSnare2.Name = "btnAddSnare2";
            this.btnAddSnare2.Size = new System.Drawing.Size(31, 31);
            this.btnAddSnare2.TabIndex = 29;
            this.btnAddSnare2.UseVisualStyleBackColor = true;
            this.btnAddSnare2.Click += new System.EventHandler(this.btnAddSnare2_Click);
            // 
            // btnAddKick2
            // 
            this.btnAddKick2.FlatAppearance.BorderSize = 0;
            this.btnAddKick2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKick2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddKick2.Location = new System.Drawing.Point(3, 586);
            this.btnAddKick2.Name = "btnAddKick2";
            this.btnAddKick2.Size = new System.Drawing.Size(31, 31);
            this.btnAddKick2.TabIndex = 28;
            this.btnAddKick2.UseVisualStyleBackColor = true;
            this.btnAddKick2.Click += new System.EventHandler(this.btnAddKick2_Click);
            // 
            // btnAddRide2
            // 
            this.btnAddRide2.FlatAppearance.BorderSize = 0;
            this.btnAddRide2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRide2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddRide2.Location = new System.Drawing.Point(3, 526);
            this.btnAddRide2.Name = "btnAddRide2";
            this.btnAddRide2.Size = new System.Drawing.Size(31, 31);
            this.btnAddRide2.TabIndex = 27;
            this.btnAddRide2.UseVisualStyleBackColor = true;
            this.btnAddRide2.Click += new System.EventHandler(this.btnAddRide2_Click);
            // 
            // btnAddHHClose2
            // 
            this.btnAddHHClose2.FlatAppearance.BorderSize = 0;
            this.btnAddHHClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHHClose2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddHHClose2.Location = new System.Drawing.Point(3, 496);
            this.btnAddHHClose2.Name = "btnAddHHClose2";
            this.btnAddHHClose2.Size = new System.Drawing.Size(31, 31);
            this.btnAddHHClose2.TabIndex = 26;
            this.btnAddHHClose2.UseVisualStyleBackColor = true;
            this.btnAddHHClose2.Click += new System.EventHandler(this.btnAddHHClose2_Click);
            // 
            // btnAddHHOpen2
            // 
            this.btnAddHHOpen2.FlatAppearance.BorderSize = 0;
            this.btnAddHHOpen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHHOpen2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddHHOpen2.Location = new System.Drawing.Point(3, 466);
            this.btnAddHHOpen2.Name = "btnAddHHOpen2";
            this.btnAddHHOpen2.Size = new System.Drawing.Size(31, 31);
            this.btnAddHHOpen2.TabIndex = 25;
            this.btnAddHHOpen2.UseVisualStyleBackColor = true;
            this.btnAddHHOpen2.Click += new System.EventHandler(this.btnAddHHOpen2_Click);
            // 
            // btnClearTab1
            // 
            this.btnClearTab1.FlatAppearance.BorderSize = 0;
            this.btnClearTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTab1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearTab1.Image = ((System.Drawing.Image)(resources.GetObject("btnClearTab1.Image")));
            this.btnClearTab1.Location = new System.Drawing.Point(3, 100);
            this.btnClearTab1.Name = "btnClearTab1";
            this.btnClearTab1.Size = new System.Drawing.Size(31, 31);
            this.btnClearTab1.TabIndex = 34;
            this.btnClearTab1.UseVisualStyleBackColor = true;
            this.btnClearTab1.Click += new System.EventHandler(this.btnClearTab1_Click);
            // 
            // btnClearTab2
            // 
            this.btnClearTab2.FlatAppearance.BorderSize = 0;
            this.btnClearTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTab2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearTab2.Image = ((System.Drawing.Image)(resources.GetObject("btnClearTab2.Image")));
            this.btnClearTab2.Location = new System.Drawing.Point(3, 436);
            this.btnClearTab2.Name = "btnClearTab2";
            this.btnClearTab2.Size = new System.Drawing.Size(31, 31);
            this.btnClearTab2.TabIndex = 35;
            this.btnClearTab2.UseVisualStyleBackColor = true;
            this.btnClearTab2.Click += new System.EventHandler(this.btnClearTab2_Click);
            // 
            // txbBPMValue
            // 
            this.txbBPMValue.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txbBPMValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBPMValue.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold);
            this.txbBPMValue.ForeColor = System.Drawing.Color.White;
            this.txbBPMValue.Location = new System.Drawing.Point(228, 15);
            this.txbBPMValue.Name = "txbBPMValue";
            this.txbBPMValue.ReadOnly = true;
            this.txbBPMValue.Size = new System.Drawing.Size(69, 53);
            this.txbBPMValue.TabIndex = 36;
            this.txbBPMValue.Text = "120";
            this.txbBPMValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbBPMValue.TextChanged += new System.EventHandler(this.txbBPMValue_TextChanged);
            // 
            // tbBPM
            // 
            this.tbBPM.LargeChange = 1;
            this.tbBPM.Location = new System.Drawing.Point(144, 61);
            this.tbBPM.Maximum = 240;
            this.tbBPM.Minimum = 60;
            this.tbBPM.Name = "tbBPM";
            this.tbBPM.Size = new System.Drawing.Size(236, 45);
            this.tbBPM.TabIndex = 37;
            this.tbBPM.TickFrequency = 6;
            this.tbBPM.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbBPM.Value = 60;
            this.tbBPM.Scroll += new System.EventHandler(this.tbBPM_Scroll);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.strumentiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip.TabIndex = 40;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caricaTabToolStripMenuItem,
            this.salvaTabToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // caricaTabToolStripMenuItem
            // 
            this.caricaTabToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.caricaTabToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.caricaTabToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("caricaTabToolStripMenuItem.Image")));
            this.caricaTabToolStripMenuItem.Name = "caricaTabToolStripMenuItem";
            this.caricaTabToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.caricaTabToolStripMenuItem.Text = "Apri...";
            this.caricaTabToolStripMenuItem.Click += new System.EventHandler(this.caricaTabToolStripMenuItem_Click);
            // 
            // salvaTabToolStripMenuItem
            // 
            this.salvaTabToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.salvaTabToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salvaTabToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salvaTabToolStripMenuItem.Image")));
            this.salvaTabToolStripMenuItem.Name = "salvaTabToolStripMenuItem";
            this.salvaTabToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.salvaTabToolStripMenuItem.Text = "Salva con nome...";
            this.salvaTabToolStripMenuItem.Click += new System.EventHandler(this.salvaTabToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.esciToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // strumentiToolStripMenuItem
            // 
            this.strumentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.strumentiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.strumentiToolStripMenuItem.Name = "strumentiToolStripMenuItem";
            this.strumentiToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.strumentiToolStripMenuItem.Text = "Strumenti";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // ckbRipetiTraccia
            // 
            this.ckbRipetiTraccia.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbRipetiTraccia.AutoSize = true;
            this.ckbRipetiTraccia.BackColor = System.Drawing.Color.Transparent;
            this.ckbRipetiTraccia.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.ckbRipetiTraccia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ckbRipetiTraccia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ckbRipetiTraccia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbRipetiTraccia.Font = new System.Drawing.Font("Calibri", 10.75F, System.Drawing.FontStyle.Bold);
            this.ckbRipetiTraccia.ForeColor = System.Drawing.Color.White;
            this.ckbRipetiTraccia.Location = new System.Drawing.Point(930, 12);
            this.ckbRipetiTraccia.Name = "ckbRipetiTraccia";
            this.ckbRipetiTraccia.Size = new System.Drawing.Size(99, 28);
            this.ckbRipetiTraccia.TabIndex = 41;
            this.ckbRipetiTraccia.Text = "Ripeti Traccia";
            this.ckbRipetiTraccia.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(462, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "By daniele.franceschini@live.it";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1050, 747);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckbRipetiTraccia);
            this.Controls.Add(this.tbBPM);
            this.Controls.Add(this.txbBPMValue);
            this.Controls.Add(this.btnClearTab2);
            this.Controls.Add(this.btnClearTab1);
            this.Controls.Add(this.btnAddCrash2);
            this.Controls.Add(this.btnAddChina2);
            this.Controls.Add(this.btnAddTom12);
            this.Controls.Add(this.btnAddTom22);
            this.Controls.Add(this.btnAddSnare2);
            this.Controls.Add(this.btnAddKick2);
            this.Controls.Add(this.btnAddRide2);
            this.Controls.Add(this.btnAddHHClose2);
            this.Controls.Add(this.btnAddHHOpen2);
            this.Controls.Add(this.btnAddCrash1);
            this.Controls.Add(this.btnAddChina1);
            this.Controls.Add(this.btnAddTom11);
            this.Controls.Add(this.btnAddTom21);
            this.Controls.Add(this.btnAddSnare1);
            this.Controls.Add(this.btnAddKick1);
            this.Controls.Add(this.btnAddRide1);
            this.Controls.Add(this.btnAddHHClose1);
            this.Controls.Add(this.btnAddHHOpen1);
            this.Controls.Add(this.nudLoops2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBPMMultiplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudLoops1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTab2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTab1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drum Machine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoops1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoops2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBPM)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridView dgvTab1;
        private System.Windows.Forms.ImageList imageList_Componenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTab2;
        private System.Windows.Forms.NumericUpDown nudLoops1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBPMMultiplier;
        private System.Windows.Forms.NumericUpDown nudLoops2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddHHOpen1;
        private System.Windows.Forms.Button btnAddHHClose1;
        private System.Windows.Forms.Button btnAddRide1;
        private System.Windows.Forms.Button btnAddKick1;
        private System.Windows.Forms.Button btnAddSnare1;
        private System.Windows.Forms.Button btnAddTom11;
        private System.Windows.Forms.Button btnAddTom21;
        private System.Windows.Forms.Button btnAddCrash1;
        private System.Windows.Forms.Button btnAddChina1;
        private System.Windows.Forms.Button btnAddCrash2;
        private System.Windows.Forms.Button btnAddChina2;
        private System.Windows.Forms.Button btnAddTom12;
        private System.Windows.Forms.Button btnAddTom22;
        private System.Windows.Forms.Button btnAddSnare2;
        private System.Windows.Forms.Button btnAddKick2;
        private System.Windows.Forms.Button btnAddRide2;
        private System.Windows.Forms.Button btnAddHHClose2;
        private System.Windows.Forms.Button btnAddHHOpen2;
        private System.Windows.Forms.Button btnClearTab1;
        private System.Windows.Forms.Button btnClearTab2;
        private TextBox txbBPMValue;
        private TrackBar tbBPM;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem caricaTabToolStripMenuItem;
        private ToolStripMenuItem salvaTabToolStripMenuItem;
        private ToolStripMenuItem esciToolStripMenuItem;
        private ToolStripMenuItem strumentiToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private CheckBox ckbRipetiTraccia;
        private Label label6;

        
    }
}

