namespace GeoApp
{
    partial class ucUser
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveDisplayName = new System.Windows.Forms.Button();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveDisplayName
            // 
            this.btnSaveDisplayName.Location = new System.Drawing.Point(94, 278);
            this.btnSaveDisplayName.Name = "btnSaveDisplayName";
            this.btnSaveDisplayName.Size = new System.Drawing.Size(160, 23);
            this.btnSaveDisplayName.TabIndex = 1;
            this.btnSaveDisplayName.Text = "Weiter";
            this.btnSaveDisplayName.UseVisualStyleBackColor = true;
            this.btnSaveDisplayName.Click += new System.EventHandler(this.SaveDisplayName);
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(94, 242);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(160, 20);
            this.tbDisplayName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geo Quiz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Benutzername";
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDisplayName);
            this.Controls.Add(this.btnSaveDisplayName);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(357, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveDisplayName;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
