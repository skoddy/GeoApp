namespace GeoApp
{
    partial class ucHighscore
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
            this.panMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbOnlyMine = new System.Windows.Forms.CheckBox();
            this.panHighscore = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvHighscores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panMenu.SuspendLayout();
            this.panHighscore.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.btnBack);
            this.panMenu.Controls.Add(this.cbOnlyMine);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMenu.Location = new System.Drawing.Point(0, 567);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(357, 30);
            this.panMenu.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbOnlyMine
            // 
            this.cbOnlyMine.AutoSize = true;
            this.cbOnlyMine.Location = new System.Drawing.Point(84, 3);
            this.cbOnlyMine.Name = "cbOnlyMine";
            this.cbOnlyMine.Size = new System.Drawing.Size(116, 17);
            this.cbOnlyMine.TabIndex = 3;
            this.cbOnlyMine.Text = "Nur meine Einträge";
            this.cbOnlyMine.UseVisualStyleBackColor = true;
            this.cbOnlyMine.CheckedChanged += new System.EventHandler(this.cbOnlyMine_CheckedChanged);
            // 
            // panHighscore
            // 
            this.panHighscore.Controls.Add(this.groupBox1);
            this.panHighscore.Controls.Add(this.lvHighscores);
            this.panHighscore.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHighscore.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panHighscore.Location = new System.Drawing.Point(0, 0);
            this.panHighscore.Name = "panHighscore";
            this.panHighscore.Size = new System.Drawing.Size(357, 561);
            this.panHighscore.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.MinimumSize = new System.Drawing.Size(350, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highscores";
            // 
            // lvHighscores
            // 
            this.lvHighscores.BackColor = System.Drawing.SystemColors.Window;
            this.lvHighscores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvHighscores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHighscores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHighscores.Location = new System.Drawing.Point(3, 65);
            this.lvHighscores.Name = "lvHighscores";
            this.lvHighscores.Size = new System.Drawing.Size(350, 434);
            this.lvHighscores.TabIndex = 3;
            this.lvHighscores.UseCompatibleStateImageBehavior = false;
            this.lvHighscores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rank";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Spieler";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Punkte";
            this.columnHeader3.Width = 53;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum";
            this.columnHeader4.Width = 91;
            // 
            // ucHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panHighscore);
            this.Name = "ucHighscore";
            this.Size = new System.Drawing.Size(357, 597);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.panHighscore.ResumeLayout(false);
            this.panHighscore.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panMenu;
        private System.Windows.Forms.FlowLayoutPanel panHighscore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvHighscores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox cbOnlyMine;
    }
}
