namespace GeoApp
{
    partial class ucQuiz
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
            this.panQuiz = new System.Windows.Forms.FlowLayoutPanel();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.panAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.rbAnswerOne = new System.Windows.Forms.RadioButton();
            this.rbAnswerTwo = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panQuiz.SuspendLayout();
            this.grpData.SuspendLayout();
            this.grpQuestion.SuspendLayout();
            this.grpAnswers.SuspendLayout();
            this.panAnswers.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panQuiz
            // 
            this.panQuiz.Controls.Add(this.grpData);
            this.panQuiz.Controls.Add(this.grpQuestion);
            this.panQuiz.Controls.Add(this.grpAnswers);
            this.panQuiz.Controls.Add(this.grpResult);
            this.panQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.panQuiz.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panQuiz.Location = new System.Drawing.Point(0, 0);
            this.panQuiz.Name = "panQuiz";
            this.panQuiz.Size = new System.Drawing.Size(357, 561);
            this.panQuiz.TabIndex = 0;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.label4);
            this.grpData.Controls.Add(this.label3);
            this.grpData.Location = new System.Drawing.Point(3, 3);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(350, 55);
            this.grpData.TabIndex = 1;
            this.grpData.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Punkte: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Zeit: 00:00";
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.label1);
            this.grpQuestion.Location = new System.Drawing.Point(3, 64);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(350, 61);
            this.grpQuestion.TabIndex = 0;
            this.grpQuestion.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Das hier ist eine Frage!\r\n\r\n\r\nl\r\n";
            // 
            // grpAnswers
            // 
            this.grpAnswers.AutoSize = true;
            this.grpAnswers.Controls.Add(this.panAnswers);
            this.grpAnswers.Location = new System.Drawing.Point(3, 131);
            this.grpAnswers.MinimumSize = new System.Drawing.Size(350, 0);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(353, 142);
            this.grpAnswers.TabIndex = 1;
            this.grpAnswers.TabStop = false;
            // 
            // panAnswers
            // 
            this.panAnswers.Controls.Add(this.rbAnswerOne);
            this.panAnswers.Controls.Add(this.rbAnswerTwo);
            this.panAnswers.Controls.Add(this.radioButton3);
            this.panAnswers.Controls.Add(this.radioButton4);
            this.panAnswers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panAnswers.Location = new System.Drawing.Point(7, 19);
            this.panAnswers.Name = "panAnswers";
            this.panAnswers.Size = new System.Drawing.Size(340, 104);
            this.panAnswers.TabIndex = 4;
            // 
            // rbAnswerOne
            // 
            this.rbAnswerOne.AutoSize = true;
            this.rbAnswerOne.Location = new System.Drawing.Point(3, 3);
            this.rbAnswerOne.Name = "rbAnswerOne";
            this.rbAnswerOne.Size = new System.Drawing.Size(85, 17);
            this.rbAnswerOne.TabIndex = 0;
            this.rbAnswerOne.TabStop = true;
            this.rbAnswerOne.Text = "radioButton1";
            this.rbAnswerOne.UseVisualStyleBackColor = true;
            // 
            // rbAnswerTwo
            // 
            this.rbAnswerTwo.AutoSize = true;
            this.rbAnswerTwo.Location = new System.Drawing.Point(3, 26);
            this.rbAnswerTwo.Name = "rbAnswerTwo";
            this.rbAnswerTwo.Size = new System.Drawing.Size(85, 17);
            this.rbAnswerTwo.TabIndex = 1;
            this.rbAnswerTwo.TabStop = true;
            this.rbAnswerTwo.Text = "radioButton2";
            this.rbAnswerTwo.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 72);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblResult);
            this.grpResult.Location = new System.Drawing.Point(3, 279);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(350, 58);
            this.grpResult.TabIndex = 2;
            this.grpResult.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(3, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(344, 39);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Das hier ist eine Anwort?\r\n\r\nkkjh\r\nhjk\r\nhjk\r\nhjk\r\nhjk";
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.btnNextQuestion);
            this.panMenu.Controls.Add(this.btnAnswer);
            this.panMenu.Controls.Add(this.btnCancel);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panMenu.Location = new System.Drawing.Point(0, 567);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(357, 30);
            this.panMenu.TabIndex = 3;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(279, 3);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 0;
            this.btnNextQuestion.Text = "Weiter";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(198, 3);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 1;
            this.btnAnswer.Text = "Anworten";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panQuiz);
            this.Name = "ucQuiz";
            this.Size = new System.Drawing.Size(357, 597);
            this.panQuiz.ResumeLayout(false);
            this.panQuiz.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpQuestion.ResumeLayout(false);
            this.grpAnswers.ResumeLayout(false);
            this.panAnswers.ResumeLayout(false);
            this.panAnswers.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panQuiz;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbAnswerTwo;
        private System.Windows.Forms.RadioButton rbAnswerOne;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.FlowLayoutPanel panMenu;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.FlowLayoutPanel panAnswers;
    }
}
