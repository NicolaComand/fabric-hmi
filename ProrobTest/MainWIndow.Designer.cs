
namespace ProrobTest
{
    partial class MainWIndow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWIndow));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalLengthLabel = new ProrobTest.CustomControls.TotalLengthLabel();
            this.nMarkerLabel = new ProrobTest.CustomControls.NMarkerLabel();
            this.nSplicesLabel = new ProrobTest.CustomControls.NSplicesLabel();
            this.currentPositionLabel = new ProrobTest.CurrentPositionLabel();
            this.watchLabel1 = new ProrobTest.WatchLabel();
            this.debugStateLabel = new ProrobTest.DebugStateLabel();
            this.markerPanel = new ProrobTest.MarkerPanel();
            this.cursorPanel = new ProrobTest.CursorPanel();
            this.sliderPositionLabel1 = new ProrobTest.SliderPositionLabel();
            this.sliderPositionLabel = new ProrobTest.SliderPositionLabel();
            this.closeMarkerButton = new ProrobTest.CustomControls.CloseMarkerButton();
            this.closeSubMarkerButton = new ProrobTest.CustomControls.CloseSubMarkerButton();
            this.openMarkerButton = new ProrobTest.CustomControls.OpenMarkerButton();
            this.openSubMarkerButton = new ProrobTest.CustomControls.OpenSubMarkerButton();
            this.annullaButton = new ProrobTest.CustomControls.AnnullaButton();
            this.confirmButton = new ProrobTest.CustomControls.ConfirmButton();
            this.customTrackBar = new ProrobTest.CustomTrackBar();
            this.markersLength1 = new ProrobTest.CustomControls.MarkersLength();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 779);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slider Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(624, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Current Position";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.watchLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 87);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProrobTest.Properties.Resources.UpperControls;
            this.pictureBox4.Location = new System.Drawing.Point(521, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(519, 66);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::ProrobTest.Properties.Resources.ButtonUscita;
            this.exitButton.Location = new System.Drawing.Point(1104, 19);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 48);
            this.exitButton.TabIndex = 2;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProrobTest.Properties.Resources.LogoCaron;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Markers Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "N° Splices";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(830, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "N° Markers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1051, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Absolute Position";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.closeMarkerButton);
            this.panel2.Controls.Add(this.closeSubMarkerButton);
            this.panel2.Controls.Add(this.openMarkerButton);
            this.panel2.Controls.Add(this.openSubMarkerButton);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(148, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 164);
            this.panel2.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(70, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "START";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1001, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "STOP";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.annullaButton);
            this.panel3.Controls.Add(this.confirmButton);
            this.panel3.Location = new System.Drawing.Point(570, 637);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 116);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Location = new System.Drawing.Point(0, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 781);
            this.panel4.TabIndex = 26;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProrobTest.Properties.Resources.SideControls;
            this.pictureBox5.Location = new System.Drawing.Point(3, 28);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(112, 265);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox3.Location = new System.Drawing.Point(148, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1120, 3);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(148, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1120, 3);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 641);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "AC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1153, 641);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 26);
            this.label9.TabIndex = 23;
            this.label9.Text = "LD";
            // 
            // totalLengthLabel
            // 
            this.totalLengthLabel.AutoSize = true;
            this.totalLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLengthLabel.Location = new System.Drawing.Point(221, 221);
            this.totalLengthLabel.Name = "totalLengthLabel";
            this.totalLengthLabel.Size = new System.Drawing.Size(25, 26);
            this.totalLengthLabel.TabIndex = 30;
            this.totalLengthLabel.Text = "0";
            // 
            // nMarkerLabel
            // 
            this.nMarkerLabel.AutoSize = true;
            this.nMarkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMarkerLabel.Location = new System.Drawing.Point(883, 221);
            this.nMarkerLabel.Name = "nMarkerLabel";
            this.nMarkerLabel.Size = new System.Drawing.Size(25, 26);
            this.nMarkerLabel.TabIndex = 29;
            this.nMarkerLabel.Text = "0";
            // 
            // nSplicesLabel
            // 
            this.nSplicesLabel.AutoSize = true;
            this.nSplicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSplicesLabel.Location = new System.Drawing.Point(659, 221);
            this.nSplicesLabel.Name = "nSplicesLabel";
            this.nSplicesLabel.Size = new System.Drawing.Size(25, 26);
            this.nSplicesLabel.TabIndex = 28;
            this.nSplicesLabel.Text = "0";
            // 
            // currentPositionLabel
            // 
            this.currentPositionLabel.AutoSize = true;
            this.currentPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPositionLabel.Location = new System.Drawing.Point(684, 136);
            this.currentPositionLabel.Name = "currentPositionLabel";
            this.currentPositionLabel.Size = new System.Drawing.Size(64, 26);
            this.currentPositionLabel.TabIndex = 27;
            this.currentPositionLabel.Text = "4000";
            // 
            // watchLabel1
            // 
            this.watchLabel1.AutoSize = true;
            this.watchLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.watchLabel1.Location = new System.Drawing.Point(1181, 30);
            this.watchLabel1.Name = "watchLabel1";
            this.watchLabel1.Size = new System.Drawing.Size(91, 26);
            this.watchLabel1.TabIndex = 1;
            this.watchLabel1.Text = "9:18:01";
            // 
            // debugStateLabel
            // 
            this.debugStateLabel.AutoSize = true;
            this.debugStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugStateLabel.Location = new System.Drawing.Point(176, 115);
            this.debugStateLabel.Name = "debugStateLabel";
            this.debugStateLabel.Size = new System.Drawing.Size(188, 26);
            this.debugStateLabel.TabIndex = 11;
            this.debugStateLabel.Text = "debugStateLabel1";
            // 
            // markerPanel
            // 
            this.markerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.markerPanel.Location = new System.Drawing.Point(148, 318);
            this.markerPanel.Name = "markerPanel";
            this.markerPanel.Size = new System.Drawing.Size(1120, 143);
            this.markerPanel.TabIndex = 10;
            // 
            // cursorPanel
            // 
            this.cursorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cursorPanel.Location = new System.Drawing.Point(148, 292);
            this.cursorPanel.Name = "cursorPanel";
            this.cursorPanel.Size = new System.Drawing.Size(1120, 20);
            this.cursorPanel.TabIndex = 9;
            // 
            // sliderPositionLabel1
            // 
            this.sliderPositionLabel1.AutoSize = true;
            this.sliderPositionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderPositionLabel1.Location = new System.Drawing.Point(1120, 221);
            this.sliderPositionLabel1.Name = "sliderPositionLabel1";
            this.sliderPositionLabel1.Size = new System.Drawing.Size(64, 26);
            this.sliderPositionLabel1.TabIndex = 2;
            this.sliderPositionLabel1.Text = "4000";
            // 
            // sliderPositionLabel
            // 
            this.sliderPositionLabel.AutoSize = true;
            this.sliderPositionLabel.Location = new System.Drawing.Point(491, 779);
            this.sliderPositionLabel.Name = "sliderPositionLabel";
            this.sliderPositionLabel.Size = new System.Drawing.Size(100, 13);
            this.sliderPositionLabel.TabIndex = 2;
            this.sliderPositionLabel.Text = "sliderPositionLabel1";
            // 
            // closeMarkerButton
            // 
            this.closeMarkerButton.FlatAppearance.BorderSize = 0;
            this.closeMarkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeMarkerButton.Image = ((System.Drawing.Image)(resources.GetObject("closeMarkerButton.Image")));
            this.closeMarkerButton.Location = new System.Drawing.Point(976, 31);
            this.closeMarkerButton.Name = "closeMarkerButton";
            this.closeMarkerButton.Size = new System.Drawing.Size(100, 100);
            this.closeMarkerButton.TabIndex = 14;
            this.closeMarkerButton.UseVisualStyleBackColor = true;
            this.closeMarkerButton.Click += new System.EventHandler(this.buttonChiusuraMarcatore_Click);
            // 
            // closeSubMarkerButton
            // 
            this.closeSubMarkerButton.FlatAppearance.BorderSize = 0;
            this.closeSubMarkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeSubMarkerButton.Image = ((System.Drawing.Image)(resources.GetObject("closeSubMarkerButton.Image")));
            this.closeSubMarkerButton.Location = new System.Drawing.Point(667, 31);
            this.closeSubMarkerButton.Name = "closeSubMarkerButton";
            this.closeSubMarkerButton.Size = new System.Drawing.Size(100, 100);
            this.closeSubMarkerButton.TabIndex = 15;
            this.closeSubMarkerButton.UseVisualStyleBackColor = true;
            this.closeSubMarkerButton.Click += new System.EventHandler(this.buttonChiusuraSottoMarcatore_Click);
            // 
            // openMarkerButton
            // 
            this.openMarkerButton.FlatAppearance.BorderSize = 0;
            this.openMarkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openMarkerButton.Image = ((System.Drawing.Image)(resources.GetObject("openMarkerButton.Image")));
            this.openMarkerButton.Location = new System.Drawing.Point(49, 31);
            this.openMarkerButton.Name = "openMarkerButton";
            this.openMarkerButton.Size = new System.Drawing.Size(100, 100);
            this.openMarkerButton.TabIndex = 12;
            this.openMarkerButton.UseVisualStyleBackColor = true;
            this.openMarkerButton.Click += new System.EventHandler(this.buttonAperturaMarcatore_Click);
            // 
            // openSubMarkerButton
            // 
            this.openSubMarkerButton.FlatAppearance.BorderSize = 0;
            this.openSubMarkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSubMarkerButton.Image = ((System.Drawing.Image)(resources.GetObject("openSubMarkerButton.Image")));
            this.openSubMarkerButton.Location = new System.Drawing.Point(358, 31);
            this.openSubMarkerButton.Name = "openSubMarkerButton";
            this.openSubMarkerButton.Size = new System.Drawing.Size(100, 100);
            this.openSubMarkerButton.TabIndex = 13;
            this.openSubMarkerButton.UseVisualStyleBackColor = true;
            this.openSubMarkerButton.Click += new System.EventHandler(this.buttonAperturaSottoMarcatore_Click);
            // 
            // annullaButton
            // 
            this.annullaButton.FlatAppearance.BorderSize = 0;
            this.annullaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annullaButton.Image = global::ProrobTest.Properties.Resources.ButtonAnnulla;
            this.annullaButton.Location = new System.Drawing.Point(151, 8);
            this.annullaButton.Name = "annullaButton";
            this.annullaButton.Size = new System.Drawing.Size(100, 100);
            this.annullaButton.TabIndex = 17;
            this.annullaButton.UseVisualStyleBackColor = true;
            this.annullaButton.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Image = global::ProrobTest.Properties.Resources.ButtonConfirm;
            this.confirmButton.Location = new System.Drawing.Point(29, 8);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 100);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // customTrackBar
            // 
            this.customTrackBar.Location = new System.Drawing.Point(393, 811);
            this.customTrackBar.Name = "customTrackBar";
            this.customTrackBar.Size = new System.Drawing.Size(603, 45);
            this.customTrackBar.TabIndex = 18;
            this.customTrackBar.Scroll += new System.EventHandler(this.sliderSetPosition_Scroll);
            // 
            // markersLength1
            // 
            this.markersLength1.AutoSize = true;
            this.markersLength1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markersLength1.Location = new System.Drawing.Point(468, 221);
            this.markersLength1.Name = "markersLength1";
            this.markersLength1.Size = new System.Drawing.Size(25, 26);
            this.markersLength1.TabIndex = 31;
            this.markersLength1.Text = "0";
            // 
            // MainWIndow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 868);
            this.Controls.Add(this.markersLength1);
            this.Controls.Add(this.totalLengthLabel);
            this.Controls.Add(this.nMarkerLabel);
            this.Controls.Add(this.nSplicesLabel);
            this.Controls.Add(this.currentPositionLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.debugStateLabel);
            this.Controls.Add(this.markerPanel);
            this.Controls.Add(this.cursorPanel);
            this.Controls.Add(this.sliderPositionLabel1);
            this.Controls.Add(this.sliderPositionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.customTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWIndow";
            this.Text = "9";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private SliderPositionLabel sliderPositionLabel;
        private CursorPanel cursorPanel;
        private MarkerPanel markerPanel;
        private DebugStateLabel debugStateLabel;
        private CustomControls.OpenMarkerButton openMarkerButton;
        private CustomControls.OpenSubMarkerButton openSubMarkerButton;
        private CustomControls.CloseMarkerButton closeMarkerButton;
        private CustomControls.CloseSubMarkerButton closeSubMarkerButton;
        private CustomControls.ConfirmButton confirmButton;
        private CustomControls.AnnullaButton annullaButton;
        private CustomTrackBar customTrackBar;
        private SliderPositionLabel sliderPositionLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WatchLabel watchLabel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CurrentPositionLabel currentPositionLabel;
        private CustomControls.NSplicesLabel nSplicesLabel;
        private CustomControls.NMarkerLabel nMarkerLabel;
        private CustomControls.TotalLengthLabel totalLengthLabel;
        private CustomControls.MarkersLength markersLength1;
    }
}

