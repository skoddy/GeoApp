namespace GeoApp
{
    partial class ucQuizConfig
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
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panQuiz = new System.Windows.Forms.FlowLayoutPanel();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpQuestionMode = new System.Windows.Forms.GroupBox();
            this.panQuestionMode = new System.Windows.Forms.FlowLayoutPanel();
            this.rbCountryQuestions = new System.Windows.Forms.RadioButton();
            this.rbCapitalQuestions = new System.Windows.Forms.RadioButton();
            this.rbFlagQuestions = new System.Windows.Forms.RadioButton();
            this.grpAnswerMode = new System.Windows.Forms.GroupBox();
            this.panAnswerMode = new System.Windows.Forms.FlowLayoutPanel();
            this.rbCountryAnswers = new System.Windows.Forms.RadioButton();
            this.rbCapitalAnswers = new System.Windows.Forms.RadioButton();
            this.rbFlagAnswers = new System.Windows.Forms.RadioButton();
            this.grpContinent = new System.Windows.Forms.GroupBox();
            this.panContinent = new System.Windows.Forms.FlowLayoutPanel();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbAfrica = new System.Windows.Forms.RadioButton();
            this.rbAsia = new System.Windows.Forms.RadioButton();
            this.rbOceania = new System.Windows.Forms.RadioButton();
            this.rbEurope = new System.Windows.Forms.RadioButton();
            this.rbNorthAmerica = new System.Windows.Forms.RadioButton();
            this.rbSouthAmerica = new System.Windows.Forms.RadioButton();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.panMenu.SuspendLayout();
            this.panQuiz.SuspendLayout();
            this.grpData.SuspendLayout();
            this.grpQuestionMode.SuspendLayout();
            this.panQuestionMode.SuspendLayout();
            this.grpAnswerMode.SuspendLayout();
            this.panAnswerMode.SuspendLayout();
            this.grpContinent.SuspendLayout();
            this.panContinent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.btnStartQuiz);
            this.panMenu.Controls.Add(this.btnHighscore);
            this.panMenu.Controls.Add(this.btnCancel);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panMenu.Location = new System.Drawing.Point(0, 567);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(357, 30);
            this.panMenu.TabIndex = 5;
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Enabled = false;
            this.btnStartQuiz.Location = new System.Drawing.Point(279, 3);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnStartQuiz.TabIndex = 0;
            this.btnStartQuiz.Text = "Start!";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelConfig);
            // 
            // panQuiz
            // 
            this.panQuiz.Controls.Add(this.grpData);
            this.panQuiz.Controls.Add(this.grpQuestionMode);
            this.panQuiz.Controls.Add(this.grpAnswerMode);
            this.panQuiz.Controls.Add(this.grpContinent);
            this.panQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.panQuiz.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panQuiz.Location = new System.Drawing.Point(0, 0);
            this.panQuiz.Name = "panQuiz";
            this.panQuiz.Size = new System.Drawing.Size(357, 561);
            this.panQuiz.TabIndex = 4;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.label3);
            this.grpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpData.Location = new System.Drawing.Point(3, 3);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(353, 55);
            this.grpData.TabIndex = 1;
            this.grpData.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Einstellungen";
            // 
            // grpQuestionMode
            // 
            this.grpQuestionMode.AutoSize = true;
            this.grpQuestionMode.Controls.Add(this.panQuestionMode);
            this.grpQuestionMode.Location = new System.Drawing.Point(3, 64);
            this.grpQuestionMode.MinimumSize = new System.Drawing.Size(350, 0);
            this.grpQuestionMode.Name = "grpQuestionMode";
            this.grpQuestionMode.Size = new System.Drawing.Size(353, 118);
            this.grpQuestionMode.TabIndex = 2;
            this.grpQuestionMode.TabStop = false;
            this.grpQuestionMode.Text = "Fragen";
            // 
            // panQuestionMode
            // 
            this.panQuestionMode.Controls.Add(this.rbCountryQuestions);
            this.panQuestionMode.Controls.Add(this.rbCapitalQuestions);
            this.panQuestionMode.Controls.Add(this.rbFlagQuestions);
            this.panQuestionMode.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panQuestionMode.Location = new System.Drawing.Point(7, 19);
            this.panQuestionMode.Name = "panQuestionMode";
            this.panQuestionMode.Size = new System.Drawing.Size(340, 80);
            this.panQuestionMode.TabIndex = 4;
            // 
            // rbCountryQuestions
            // 
            this.rbCountryQuestions.AutoSize = true;
            this.rbCountryQuestions.Location = new System.Drawing.Point(3, 3);
            this.rbCountryQuestions.Name = "rbCountryQuestions";
            this.rbCountryQuestions.Size = new System.Drawing.Size(58, 17);
            this.rbCountryQuestions.TabIndex = 0;
            this.rbCountryQuestions.Tag = "Country";
            this.rbCountryQuestions.Text = "Länder";
            this.rbCountryQuestions.UseVisualStyleBackColor = true;
            this.rbCountryQuestions.Click += new System.EventHandler(this.SetQuestionType);
            // 
            // rbCapitalQuestions
            // 
            this.rbCapitalQuestions.AutoSize = true;
            this.rbCapitalQuestions.Location = new System.Drawing.Point(3, 26);
            this.rbCapitalQuestions.Name = "rbCapitalQuestions";
            this.rbCapitalQuestions.Size = new System.Drawing.Size(83, 17);
            this.rbCapitalQuestions.TabIndex = 1;
            this.rbCapitalQuestions.Tag = "Capital";
            this.rbCapitalQuestions.Text = "Hauptstädte";
            this.rbCapitalQuestions.UseVisualStyleBackColor = true;
            this.rbCapitalQuestions.Click += new System.EventHandler(this.SetQuestionType);
            // 
            // rbFlagQuestions
            // 
            this.rbFlagQuestions.AutoSize = true;
            this.rbFlagQuestions.Location = new System.Drawing.Point(3, 49);
            this.rbFlagQuestions.Name = "rbFlagQuestions";
            this.rbFlagQuestions.Size = new System.Drawing.Size(63, 17);
            this.rbFlagQuestions.TabIndex = 2;
            this.rbFlagQuestions.Tag = "Flag";
            this.rbFlagQuestions.Text = "Flaggen";
            this.rbFlagQuestions.UseVisualStyleBackColor = true;
            this.rbFlagQuestions.Click += new System.EventHandler(this.SetQuestionType);
            // 
            // grpAnswerMode
            // 
            this.grpAnswerMode.AutoSize = true;
            this.grpAnswerMode.Controls.Add(this.panAnswerMode);
            this.grpAnswerMode.Enabled = false;
            this.grpAnswerMode.Location = new System.Drawing.Point(3, 188);
            this.grpAnswerMode.MinimumSize = new System.Drawing.Size(350, 0);
            this.grpAnswerMode.Name = "grpAnswerMode";
            this.grpAnswerMode.Size = new System.Drawing.Size(353, 120);
            this.grpAnswerMode.TabIndex = 3;
            this.grpAnswerMode.TabStop = false;
            this.grpAnswerMode.Text = "Anworten";
            // 
            // panAnswerMode
            // 
            this.panAnswerMode.Controls.Add(this.rbCountryAnswers);
            this.panAnswerMode.Controls.Add(this.rbCapitalAnswers);
            this.panAnswerMode.Controls.Add(this.rbFlagAnswers);
            this.panAnswerMode.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panAnswerMode.Location = new System.Drawing.Point(7, 19);
            this.panAnswerMode.Name = "panAnswerMode";
            this.panAnswerMode.Size = new System.Drawing.Size(340, 82);
            this.panAnswerMode.TabIndex = 4;
            // 
            // rbCountryAnswers
            // 
            this.rbCountryAnswers.AutoSize = true;
            this.rbCountryAnswers.Location = new System.Drawing.Point(3, 3);
            this.rbCountryAnswers.Name = "rbCountryAnswers";
            this.rbCountryAnswers.Size = new System.Drawing.Size(58, 17);
            this.rbCountryAnswers.TabIndex = 3;
            this.rbCountryAnswers.Tag = "Country";
            this.rbCountryAnswers.Text = "Länder";
            this.rbCountryAnswers.UseVisualStyleBackColor = true;
            this.rbCountryAnswers.Click += new System.EventHandler(this.SetAnswerType);
            // 
            // rbCapitalAnswers
            // 
            this.rbCapitalAnswers.AutoSize = true;
            this.rbCapitalAnswers.Location = new System.Drawing.Point(3, 26);
            this.rbCapitalAnswers.Name = "rbCapitalAnswers";
            this.rbCapitalAnswers.Size = new System.Drawing.Size(83, 17);
            this.rbCapitalAnswers.TabIndex = 4;
            this.rbCapitalAnswers.Tag = "Capital";
            this.rbCapitalAnswers.Text = "Hauptstädte";
            this.rbCapitalAnswers.UseVisualStyleBackColor = true;
            this.rbCapitalAnswers.Click += new System.EventHandler(this.SetAnswerType);
            // 
            // rbFlagAnswers
            // 
            this.rbFlagAnswers.AutoSize = true;
            this.rbFlagAnswers.Location = new System.Drawing.Point(3, 49);
            this.rbFlagAnswers.Name = "rbFlagAnswers";
            this.rbFlagAnswers.Size = new System.Drawing.Size(63, 17);
            this.rbFlagAnswers.TabIndex = 5;
            this.rbFlagAnswers.Tag = "Flag";
            this.rbFlagAnswers.Text = "Flaggen";
            this.rbFlagAnswers.UseVisualStyleBackColor = true;
            this.rbFlagAnswers.Click += new System.EventHandler(this.SetAnswerType);
            // 
            // grpContinent
            // 
            this.grpContinent.AutoSize = true;
            this.grpContinent.Controls.Add(this.panContinent);
            this.grpContinent.Enabled = false;
            this.grpContinent.Location = new System.Drawing.Point(3, 314);
            this.grpContinent.MinimumSize = new System.Drawing.Size(350, 0);
            this.grpContinent.Name = "grpContinent";
            this.grpContinent.Size = new System.Drawing.Size(353, 87);
            this.grpContinent.TabIndex = 4;
            this.grpContinent.TabStop = false;
            this.grpContinent.Text = "Kontinent";
            // 
            // panContinent
            // 
            this.panContinent.Controls.Add(this.rbAll);
            this.panContinent.Controls.Add(this.rbAfrica);
            this.panContinent.Controls.Add(this.rbAsia);
            this.panContinent.Controls.Add(this.rbOceania);
            this.panContinent.Controls.Add(this.rbEurope);
            this.panContinent.Controls.Add(this.rbNorthAmerica);
            this.panContinent.Controls.Add(this.rbSouthAmerica);
            this.panContinent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panContinent.Location = new System.Drawing.Point(7, 19);
            this.panContinent.Name = "panContinent";
            this.panContinent.Size = new System.Drawing.Size(340, 49);
            this.panContinent.TabIndex = 4;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(3, 3);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(42, 17);
            this.rbAll.TabIndex = 3;
            this.rbAll.Tag = "All";
            this.rbAll.Text = "Alle";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.SetContinent);
            // 
            // rbAfrica
            // 
            this.rbAfrica.AutoSize = true;
            this.rbAfrica.Location = new System.Drawing.Point(3, 26);
            this.rbAfrica.Name = "rbAfrica";
            this.rbAfrica.Size = new System.Drawing.Size(52, 17);
            this.rbAfrica.TabIndex = 9;
            this.rbAfrica.Tag = "Africa";
            this.rbAfrica.Text = "Afrika";
            this.rbAfrica.UseVisualStyleBackColor = true;
            this.rbAfrica.CheckedChanged += new System.EventHandler(this.SetContinent);
            // 
            // rbAsia
            // 
            this.rbAsia.AutoSize = true;
            this.rbAsia.Location = new System.Drawing.Point(61, 3);
            this.rbAsia.Name = "rbAsia";
            this.rbAsia.Size = new System.Drawing.Size(51, 17);
            this.rbAsia.TabIndex = 5;
            this.rbAsia.Tag = "Asia";
            this.rbAsia.Text = "Asien";
            this.rbAsia.UseVisualStyleBackColor = true;
            this.rbAsia.CheckedChanged += new System.EventHandler(this.SetContinent);
            // 
            // rbOceania
            // 
            this.rbOceania.AutoSize = true;
            this.rbOceania.Location = new System.Drawing.Point(61, 26);
            this.rbOceania.Name = "rbOceania";
            this.rbOceania.Size = new System.Drawing.Size(71, 17);
            this.rbOceania.TabIndex = 8;
            this.rbOceania.Tag = "Oceania";
            this.rbOceania.Text = "Australien";
            this.rbOceania.UseVisualStyleBackColor = true;
            this.rbOceania.CheckedChanged += new System.EventHandler(this.SetContinent);
            // 
            // rbEurope
            // 
            this.rbEurope.AutoSize = true;
            this.rbEurope.Location = new System.Drawing.Point(138, 3);
            this.rbEurope.Name = "rbEurope";
            this.rbEurope.Size = new System.Drawing.Size(59, 17);
            this.rbEurope.TabIndex = 4;
            this.rbEurope.Tag = "Europe";
            this.rbEurope.Text = "Europa";
            this.rbEurope.UseVisualStyleBackColor = true;
            this.rbEurope.CheckedChanged += new System.EventHandler(this.SetContinent);
            // 
            // rbNorthAmerica
            // 
            this.rbNorthAmerica.AutoSize = true;
            this.rbNorthAmerica.Location = new System.Drawing.Point(138, 26);
            this.rbNorthAmerica.Name = "rbNorthAmerica";
            this.rbNorthAmerica.Size = new System.Drawing.Size(89, 17);
            this.rbNorthAmerica.TabIndex = 6;
            this.rbNorthAmerica.Tag = "North America";
            this.rbNorthAmerica.Text = "Nord Amerika";
            this.rbNorthAmerica.UseVisualStyleBackColor = true;
            this.rbNorthAmerica.CheckedChanged += new System.EventHandler(this.SetContinent);
            // 
            // rbSouthAmerica
            // 
            this.rbSouthAmerica.AutoSize = true;
            this.rbSouthAmerica.Location = new System.Drawing.Point(233, 3);
            this.rbSouthAmerica.Name = "rbSouthAmerica";
            this.rbSouthAmerica.Size = new System.Drawing.Size(85, 17);
            this.rbSouthAmerica.TabIndex = 7;
            this.rbSouthAmerica.Tag = "South America";
            this.rbSouthAmerica.Text = "Süd Amerika";
            this.rbSouthAmerica.UseVisualStyleBackColor = true;
            this.rbSouthAmerica.CheckedChanged += new System.EventHandler(this.SetContinent);
            // 
            // btnHighscore
            // 
            this.btnHighscore.Location = new System.Drawing.Point(198, 3);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(75, 23);
            this.btnHighscore.TabIndex = 3;
            this.btnHighscore.Text = "Highscore";
            this.btnHighscore.UseVisualStyleBackColor = true;
            this.btnHighscore.Click += new System.EventHandler(this.btnHighscore_Click);
            // 
            // ucQuizConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panQuiz);
            this.Name = "ucQuizConfig";
            this.Size = new System.Drawing.Size(357, 597);
            this.panMenu.ResumeLayout(false);
            this.panQuiz.ResumeLayout(false);
            this.panQuiz.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpQuestionMode.ResumeLayout(false);
            this.panQuestionMode.ResumeLayout(false);
            this.panQuestionMode.PerformLayout();
            this.grpAnswerMode.ResumeLayout(false);
            this.panAnswerMode.ResumeLayout(false);
            this.panAnswerMode.PerformLayout();
            this.grpContinent.ResumeLayout(false);
            this.panContinent.ResumeLayout(false);
            this.panContinent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panMenu;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel panQuiz;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpQuestionMode;
        private System.Windows.Forms.FlowLayoutPanel panQuestionMode;
        private System.Windows.Forms.RadioButton rbCountryQuestions;
        private System.Windows.Forms.RadioButton rbCapitalQuestions;
        private System.Windows.Forms.RadioButton rbFlagQuestions;
        private System.Windows.Forms.GroupBox grpAnswerMode;
        private System.Windows.Forms.FlowLayoutPanel panAnswerMode;
        private System.Windows.Forms.RadioButton rbCountryAnswers;
        private System.Windows.Forms.RadioButton rbCapitalAnswers;
        private System.Windows.Forms.RadioButton rbFlagAnswers;
        private System.Windows.Forms.GroupBox grpContinent;
        private System.Windows.Forms.FlowLayoutPanel panContinent;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbEurope;
        private System.Windows.Forms.RadioButton rbAsia;
        private System.Windows.Forms.RadioButton rbNorthAmerica;
        private System.Windows.Forms.RadioButton rbSouthAmerica;
        private System.Windows.Forms.RadioButton rbOceania;
        private System.Windows.Forms.RadioButton rbAfrica;
        private System.Windows.Forms.Button btnHighscore;
    }
}
