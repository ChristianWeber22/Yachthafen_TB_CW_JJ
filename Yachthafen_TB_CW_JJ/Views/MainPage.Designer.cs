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
            this.kundenButton = new System.Windows.Forms.Button();
            this.liegeplatzButton = new System.Windows.Forms.Button();
            this.buchungButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.kundenButton);
            this.panelMenu.Controls.Add(this.liegeplatzButton);
            this.panelMenu.Controls.Add(this.buchungButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(281, 673);
            this.panelMenu.TabIndex = 19;
            // 
            // kundenButton
            // 
            this.kundenButton.FlatAppearance.BorderSize = 0;
            this.kundenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kundenButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kundenButton.Image = global::Yachthafen_TB_CW_JJ.Properties.Resources.icons8_geschlechtsneutraler_benutzer_60;
            this.kundenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kundenButton.Location = new System.Drawing.Point(0, 306);
            this.kundenButton.Margin = new System.Windows.Forms.Padding(4);
            this.kundenButton.Name = "kundenButton";
            this.kundenButton.Size = new System.Drawing.Size(277, 58);
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
            this.liegeplatzButton.ForeColor = System.Drawing.Color.Transparent;
            this.liegeplatzButton.Image = global::Yachthafen_TB_CW_JJ.Properties.Resources.icons8_segelboot_60;
            this.liegeplatzButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.liegeplatzButton.Location = new System.Drawing.Point(0, 132);
            this.liegeplatzButton.Margin = new System.Windows.Forms.Padding(4);
            this.liegeplatzButton.Name = "liegeplatzButton";
            this.liegeplatzButton.Size = new System.Drawing.Size(277, 59);
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
            this.buchungButton.ForeColor = System.Drawing.Color.White;
            this.buchungButton.Image = global::Yachthafen_TB_CW_JJ.Properties.Resources.icons8_offenes_buch_60;
            this.buchungButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buchungButton.Location = new System.Drawing.Point(0, 218);
            this.buchungButton.Margin = new System.Windows.Forms.Padding(4);
            this.buchungButton.Name = "buchungButton";
            this.buchungButton.Size = new System.Drawing.Size(277, 58);
            this.buchungButton.TabIndex = 17;
            this.buchungButton.Text = "Buchungsverwaltung";
            this.buchungButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buchungButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buchungButton.UseVisualStyleBackColor = true;
            this.buchungButton.Click += new System.EventHandler(this.buchungButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(273, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 661);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "CJT Yacht Charter";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1474, 673);
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
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button liegeplatzButton;
        private System.Windows.Forms.Button buchungButton;
        private System.Windows.Forms.Button kundenButton;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

