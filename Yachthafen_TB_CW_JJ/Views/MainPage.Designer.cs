namespace Yachthafen_TB_CW_JJ
{
    partial class MainPage
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kundenButton = new System.Windows.Forms.Button();
            this.liegeplatzButton = new System.Windows.Forms.Button();
            this.buchungButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.kundenButton);
            this.panelMenu.Controls.Add(this.liegeplatzButton);
            this.panelMenu.Controls.Add(this.buchungButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(281, 673);
            this.panelMenu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "CTJ Yacht Charter";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(280, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 615);
            this.panel1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Yachthafen_TB_CW_JJ.Properties.Resources.icons8_macos_minimieren_30;
            this.button2.Location = new System.Drawing.Point(1392, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 52);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Yachthafen_TB_CW_JJ.Properties.Resources.icons8_macos_schließen_30;
            this.button1.Location = new System.Drawing.Point(1428, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 52);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kundenButton
            // 
            this.kundenButton.FlatAppearance.BorderSize = 0;
            this.kundenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kundenButton.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kundenButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kundenButton.Image = global::Yachthafen_TB_CW_JJ.Properties.Resources.icons8_geschlechtsneutraler_benutzer_60;
            this.kundenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kundenButton.Location = new System.Drawing.Point(-4, 315);
            this.kundenButton.Margin = new System.Windows.Forms.Padding(4);
            this.kundenButton.Name = "kundenButton";
            this.kundenButton.Size = new System.Drawing.Size(293, 89);
            this.kundenButton.TabIndex = 18;
            this.kundenButton.Text = "Kundenverwaltung";
            this.kundenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kundenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kundenButton.UseVisualStyleBackColor = true;
            this.kundenButton.Click += new System.EventHandler(this.kundenButton_Click);
            // 
            // liegeplatzButton
            // 
            this.liegeplatzButton.FlatAppearance.BorderSize = 0;
            this.liegeplatzButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.liegeplatzButton.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liegeplatzButton.ForeColor = System.Drawing.Color.Transparent;
            this.liegeplatzButton.Image = global::Yachthafen_TB_CW_JJ.Properties.Resources.icons8_segelboot_60;
            this.liegeplatzButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.liegeplatzButton.Location = new System.Drawing.Point(-4, 134);
            this.liegeplatzButton.Margin = new System.Windows.Forms.Padding(4);
            this.liegeplatzButton.Name = "liegeplatzButton";
            this.liegeplatzButton.Size = new System.Drawing.Size(293, 81);
            this.liegeplatzButton.TabIndex = 14;
            this.liegeplatzButton.Text = "Liegeplatzübersicht";
            this.liegeplatzButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.liegeplatzButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.liegeplatzButton.UseVisualStyleBackColor = true;
            this.liegeplatzButton.Click += new System.EventHandler(this.liegeplatzButton_Click);
            // 
            // buchungButton
            // 
            this.buchungButton.FlatAppearance.BorderSize = 0;
            this.buchungButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buchungButton.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buchungButton.ForeColor = System.Drawing.Color.White;
            this.buchungButton.Image = global::Yachthafen_TB_CW_JJ.Properties.Resources.icons8_offenes_buch_60;
            this.buchungButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buchungButton.Location = new System.Drawing.Point(-4, 223);
            this.buchungButton.Margin = new System.Windows.Forms.Padding(4);
            this.buchungButton.Name = "buchungButton";
            this.buchungButton.Size = new System.Drawing.Size(296, 84);
            this.buchungButton.TabIndex = 17;
            this.buchungButton.Text = "Buchungsverwaltung";
            this.buchungButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buchungButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buchungButton.UseVisualStyleBackColor = true;
            this.buchungButton.Click += new System.EventHandler(this.buchungButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-4, -9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1487, 72);
            this.panel2.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1474, 673);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.Text = "CTJ Luxury Yacht Charter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button liegeplatzButton;
        private System.Windows.Forms.Button buchungButton;
        private System.Windows.Forms.Button kundenButton;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
    }
}

