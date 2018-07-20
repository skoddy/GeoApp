namespace GeoApp
{
    partial class Form1
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
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.grpQuestion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAnswers
            // 
            this.grpAnswers.Location = new System.Drawing.Point(3, 109);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(200, 174);
            this.grpAnswers.TabIndex = 0;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Anworten";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(6, 16);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(35, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "label1";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(150, 3);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "Weiter";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.lblQuestion);
            this.grpQuestion.Location = new System.Drawing.Point(3, 3);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(200, 100);
            this.grpQuestion.TabIndex = 3;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpResult);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grpQuestion);
            this.panel1.Controls.Add(this.grpAnswers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 450);
            this.panel1.TabIndex = 4;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblResult);
            this.grpResult.Location = new System.Drawing.Point(3, 289);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(200, 100);
            this.grpResult.TabIndex = 6;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Ergebnis";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(5, 20);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAnswer);
            this.panel2.Controls.Add(this.btnNextQuestion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 52);
            this.panel2.TabIndex = 5;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(69, 3);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.Text = "Antworten";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResult;
    }
}

