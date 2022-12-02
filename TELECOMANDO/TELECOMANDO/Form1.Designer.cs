
namespace TELECOMANDO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.canale_successivo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.canale_precedente = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Spegni_Accendi = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Abbassa_volume = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Alza_volume = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // canale_successivo
            // 
            this.canale_successivo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.canale_successivo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.canale_successivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.canale_successivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.canale_successivo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.canale_successivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.canale_successivo.ForeColor = System.Drawing.Color.White;
            this.canale_successivo.Location = new System.Drawing.Point(100, 159);
            this.canale_successivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.canale_successivo.Name = "canale_successivo";
            this.canale_successivo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.canale_successivo.Size = new System.Drawing.Size(42, 46);
            this.canale_successivo.TabIndex = 0;
            this.canale_successivo.Text = "CH+";
            this.canale_successivo.Click += new System.EventHandler(this.canale_successivo_Click);
            // 
            // canale_precedente
            // 
            this.canale_precedente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.canale_precedente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.canale_precedente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.canale_precedente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.canale_precedente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.canale_precedente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.canale_precedente.ForeColor = System.Drawing.Color.White;
            this.canale_precedente.Location = new System.Drawing.Point(100, 203);
            this.canale_precedente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.canale_precedente.Name = "canale_precedente";
            this.canale_precedente.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.canale_precedente.Size = new System.Drawing.Size(42, 46);
            this.canale_precedente.TabIndex = 1;
            this.canale_precedente.Text = "CH -";
            this.canale_precedente.Click += new System.EventHandler(this.canale_precedente_Click);
            // 
            // Spegni_Accendi
            // 
            this.Spegni_Accendi.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Spegni_Accendi.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Spegni_Accendi.Image = ((System.Drawing.Image)(resources.GetObject("Spegni_Accendi.Image")));
            this.Spegni_Accendi.ImageOffset = new System.Drawing.Point(0, 0);
            this.Spegni_Accendi.ImageRotate = 0F;
            this.Spegni_Accendi.Location = new System.Drawing.Point(76, 89);
            this.Spegni_Accendi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Spegni_Accendi.Name = "Spegni_Accendi";
            this.Spegni_Accendi.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Spegni_Accendi.Size = new System.Drawing.Size(42, 46);
            this.Spegni_Accendi.TabIndex = 4;
            this.Spegni_Accendi.Click += new System.EventHandler(this.Spegni_Accendi_Click);
            // 
            // Abbassa_volume
            // 
            this.Abbassa_volume.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Abbassa_volume.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Abbassa_volume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Abbassa_volume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Abbassa_volume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Abbassa_volume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Abbassa_volume.ForeColor = System.Drawing.Color.White;
            this.Abbassa_volume.Location = new System.Drawing.Point(46, 203);
            this.Abbassa_volume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Abbassa_volume.Name = "Abbassa_volume";
            this.Abbassa_volume.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Abbassa_volume.Size = new System.Drawing.Size(42, 46);
            this.Abbassa_volume.TabIndex = 5;
            this.Abbassa_volume.Text = "VOL -";
            this.Abbassa_volume.Click += new System.EventHandler(this.Abbassa_volume_Click);
            // 
            // Alza_volume
            // 
            this.Alza_volume.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Alza_volume.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Alza_volume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Alza_volume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Alza_volume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Alza_volume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Alza_volume.ForeColor = System.Drawing.Color.White;
            this.Alza_volume.Location = new System.Drawing.Point(46, 159);
            this.Alza_volume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Alza_volume.Name = "Alza_volume";
            this.Alza_volume.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Alza_volume.Size = new System.Drawing.Size(42, 46);
            this.Alza_volume.TabIndex = 6;
            this.Alza_volume.Text = "VOL+";
            this.Alza_volume.Click += new System.EventHandler(this.Alza_volume_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(189, 363);
            this.Controls.Add(this.Alza_volume);
            this.Controls.Add(this.Abbassa_volume);
            this.Controls.Add(this.Spegni_Accendi);
            this.Controls.Add(this.canale_precedente);
            this.Controls.Add(this.canale_successivo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton canale_successivo;
        private Guna.UI2.WinForms.Guna2CircleButton canale_precedente;
        private Guna.UI2.WinForms.Guna2ImageButton Spegni_Accendi;
        private Guna.UI2.WinForms.Guna2CircleButton Abbassa_volume;
        private Guna.UI2.WinForms.Guna2CircleButton Alza_volume;
    }
}

