
namespace TV
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label_stato_tv = new System.Windows.Forms.Label();
            this.label_canale = new System.Windows.Forms.Label();
            this.label_volume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(675, 393);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(113, 46);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Accesnsione server";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label_stato_tv
            // 
            this.label_stato_tv.AutoSize = true;
            this.label_stato_tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stato_tv.ForeColor = System.Drawing.Color.White;
            this.label_stato_tv.Location = new System.Drawing.Point(339, 186);
            this.label_stato_tv.Name = "label_stato_tv";
            this.label_stato_tv.Size = new System.Drawing.Size(153, 38);
            this.label_stato_tv.TabIndex = 4;
            this.label_stato_tv.Text = "SPENTO";
            this.label_stato_tv.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_canale
            // 
            this.label_canale.AutoSize = true;
            this.label_canale.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_canale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_canale.Location = new System.Drawing.Point(35, 169);
            this.label_canale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_canale.Name = "label_canale";
            this.label_canale.Size = new System.Drawing.Size(36, 39);
            this.label_canale.TabIndex = 5;
            this.label_canale.Text = "5";
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_volume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_volume.Location = new System.Drawing.Point(33, 220);
            this.label_volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(55, 39);
            this.label_volume.TabIndex = 6;
            this.label_volume.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.label_canale);
            this.Controls.Add(this.label_stato_tv);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label_stato_tv;
        private System.Windows.Forms.Label label_canale;
        private System.Windows.Forms.Label label_volume;
    }
}

