
namespace ProrobTest
{
    partial class Form1
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
            this.sliderSetPosition = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.annullaButton = new ProrobTest.CustomControls.AnnullaButton();
            this.confirmButton = new ProrobTest.CustomControls.ConfirmButton();
            this.closeSubMarkerButton = new ProrobTest.CustomControls.CloseSubMarkerButton();
            this.closeMarkerButton = new ProrobTest.CustomControls.CloseMarkerButton();
            this.openSubMarkerButton = new ProrobTest.CustomControls.OpenSubMarkerButton();
            this.openMarkerButton = new ProrobTest.CustomControls.OpenMarkerButton();
            this.debugStateLabel = new ProrobTest.DebugStateLabel();
            this.markerPanel = new ProrobTest.MarkerPanel();
            this.cursorPanel = new ProrobTest.CursorPanel();
            this.sliderPositionLabel = new ProrobTest.SliderPositionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.sliderSetPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // sliderSetPosition
            // 
            this.sliderSetPosition.Location = new System.Drawing.Point(339, 707);
            this.sliderSetPosition.Maximum = 4000;
            this.sliderSetPosition.Name = "sliderSetPosition";
            this.sliderSetPosition.Size = new System.Drawing.Size(514, 45);
            this.sliderSetPosition.TabIndex = 0;
            this.sliderSetPosition.Scroll += new System.EventHandler(this.sliderSetPosition_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slider Position:";
            // 
            // annullaButton
            // 
            this.annullaButton.Location = new System.Drawing.Point(645, 756);
            this.annullaButton.Name = "annullaButton";
            this.annullaButton.Size = new System.Drawing.Size(100, 100);
            this.annullaButton.TabIndex = 17;
            this.annullaButton.Text = "ANNULLA";
            this.annullaButton.UseVisualStyleBackColor = true;
            this.annullaButton.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(464, 756);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 100);
            this.confirmButton.TabIndex = 16;
            this.confirmButton.Text = "CONFERMA";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // closeSubMarkerButton
            // 
            this.closeSubMarkerButton.Location = new System.Drawing.Point(705, 503);
            this.closeSubMarkerButton.Name = "closeSubMarkerButton";
            this.closeSubMarkerButton.Size = new System.Drawing.Size(100, 100);
            this.closeSubMarkerButton.TabIndex = 15;
            this.closeSubMarkerButton.Text = "Chiusura Sotto-Marcatore";
            this.closeSubMarkerButton.UseVisualStyleBackColor = true;
            this.closeSubMarkerButton.Click += new System.EventHandler(this.buttonChiusuraSottoMarcatore_Click);
            // 
            // closeMarkerButton
            // 
            this.closeMarkerButton.Location = new System.Drawing.Point(900, 503);
            this.closeMarkerButton.Name = "closeMarkerButton";
            this.closeMarkerButton.Size = new System.Drawing.Size(100, 100);
            this.closeMarkerButton.TabIndex = 14;
            this.closeMarkerButton.Text = "Chiusura Marcatore";
            this.closeMarkerButton.UseVisualStyleBackColor = true;
            this.closeMarkerButton.Click += new System.EventHandler(this.buttonChiusuraMarcatore_Click);
            // 
            // openSubMarkerButton
            // 
            this.openSubMarkerButton.Location = new System.Drawing.Point(348, 503);
            this.openSubMarkerButton.Name = "openSubMarkerButton";
            this.openSubMarkerButton.Size = new System.Drawing.Size(100, 100);
            this.openSubMarkerButton.TabIndex = 13;
            this.openSubMarkerButton.Text = "Apertura Sotto-Marcatore";
            this.openSubMarkerButton.UseVisualStyleBackColor = true;
            this.openSubMarkerButton.Click += new System.EventHandler(this.buttonAperturaSottoMarcatore_Click);
            // 
            // openMarkerButton
            // 
            this.openMarkerButton.Location = new System.Drawing.Point(207, 503);
            this.openMarkerButton.Name = "openMarkerButton";
            this.openMarkerButton.Size = new System.Drawing.Size(100, 100);
            this.openMarkerButton.TabIndex = 12;
            this.openMarkerButton.Text = "Apertura Marcatore";
            this.openMarkerButton.UseVisualStyleBackColor = true;
            this.openMarkerButton.Click += new System.EventHandler(this.buttonAperturaMarcatore_Click);
            // 
            // debugStateLabel
            // 
            this.debugStateLabel.AutoSize = true;
            this.debugStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugStateLabel.Location = new System.Drawing.Point(334, 105);
            this.debugStateLabel.Name = "debugStateLabel";
            this.debugStateLabel.Size = new System.Drawing.Size(188, 26);
            this.debugStateLabel.TabIndex = 11;
            this.debugStateLabel.Text = "debugStateLabel1";
            // 
            // markerPanel
            // 
            this.markerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.markerPanel.Location = new System.Drawing.Point(182, 283);
            this.markerPanel.Name = "markerPanel";
            this.markerPanel.Size = new System.Drawing.Size(850, 143);
            this.markerPanel.TabIndex = 10;
            // 
            // cursorPanel
            // 
            this.cursorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cursorPanel.Location = new System.Drawing.Point(182, 204);
            this.cursorPanel.Name = "cursorPanel";
            this.cursorPanel.Size = new System.Drawing.Size(850, 50);
            this.cursorPanel.TabIndex = 9;
            // 
            // sliderPositionLabel
            // 
            this.sliderPositionLabel.AutoSize = true;
            this.sliderPositionLabel.Location = new System.Drawing.Point(461, 652);
            this.sliderPositionLabel.Name = "sliderPositionLabel";
            this.sliderPositionLabel.Size = new System.Drawing.Size(100, 13);
            this.sliderPositionLabel.TabIndex = 2;
            this.sliderPositionLabel.Text = "sliderPositionLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 868);
            this.Controls.Add(this.annullaButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.closeSubMarkerButton);
            this.Controls.Add(this.closeMarkerButton);
            this.Controls.Add(this.openSubMarkerButton);
            this.Controls.Add(this.openMarkerButton);
            this.Controls.Add(this.debugStateLabel);
            this.Controls.Add(this.markerPanel);
            this.Controls.Add(this.cursorPanel);
            this.Controls.Add(this.sliderPositionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sliderSetPosition);
            this.Name = "Form1";
            this.Text = "9";
            ((System.ComponentModel.ISupportInitialize)(this.sliderSetPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar sliderSetPosition;
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
    }
}

