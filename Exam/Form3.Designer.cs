namespace Exam
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.N_question = new System.Windows.Forms.TextBox();
            this.Question = new System.Windows.Forms.TextBox();
            this.Réponse = new System.Windows.Forms.TextBox();
            this.Points_ajoutés = new System.Windows.Forms.TextBox();
            this.Points_soustrait = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.annuler_button = new System.Windows.Forms.Button();
            this.Engibutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // N_question
            // 
            this.N_question.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_question.Location = new System.Drawing.Point(289, 77);
            this.N_question.Name = "N_question";
            this.N_question.Size = new System.Drawing.Size(220, 26);
            this.N_question.TabIndex = 0;
            // 
            // Question
            // 
            this.Question.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(289, 124);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(283, 67);
            this.Question.TabIndex = 1;
            // 
            // Réponse
            // 
            this.Réponse.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Réponse.Location = new System.Drawing.Point(290, 197);
            this.Réponse.Multiline = true;
            this.Réponse.Name = "Réponse";
            this.Réponse.Size = new System.Drawing.Size(282, 64);
            this.Réponse.TabIndex = 2;
            // 
            // Points_ajoutés
            // 
            this.Points_ajoutés.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points_ajoutés.Location = new System.Drawing.Point(289, 276);
            this.Points_ajoutés.Name = "Points_ajoutés";
            this.Points_ajoutés.Size = new System.Drawing.Size(220, 26);
            this.Points_ajoutés.TabIndex = 3;
            // 
            // Points_soustrait
            // 
            this.Points_soustrait.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points_soustrait.Location = new System.Drawing.Point(289, 311);
            this.Points_soustrait.Name = "Points_soustrait";
            this.Points_soustrait.Size = new System.Drawing.Size(220, 26);
            this.Points_soustrait.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numéro de la question:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "La question :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "La réponse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Points ajoutés :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Points soustrait :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(219, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "QUESTIONS OUVERTES :";
            // 
            // annuler_button
            // 
            this.annuler_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler_button.Location = new System.Drawing.Point(432, 352);
            this.annuler_button.Name = "annuler_button";
            this.annuler_button.Size = new System.Drawing.Size(95, 35);
            this.annuler_button.TabIndex = 14;
            this.annuler_button.Text = "Annuler";
            this.annuler_button.UseVisualStyleBackColor = true;
            this.annuler_button.Click += new System.EventHandler(this.annuler_button_Click);
            // 
            // Engibutton
            // 
            this.Engibutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Engibutton.Location = new System.Drawing.Point(87, 352);
            this.Engibutton.Name = "Engibutton";
            this.Engibutton.Size = new System.Drawing.Size(95, 35);
            this.Engibutton.TabIndex = 13;
            this.Engibutton.Text = "Enregistrer";
            this.Engibutton.UseVisualStyleBackColor = true;
            this.Engibutton.Click += new System.EventHandler(this.Engibutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 387);
            this.Controls.Add(this.annuler_button);
            this.Controls.Add(this.Engibutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Points_soustrait);
            this.Controls.Add(this.Points_ajoutés);
            this.Controls.Add(this.Réponse);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.N_question);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox N_question;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.TextBox Réponse;
        private System.Windows.Forms.TextBox Points_ajoutés;
        private System.Windows.Forms.TextBox Points_soustrait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button annuler_button;
        private System.Windows.Forms.Button Engibutton;
    }
}