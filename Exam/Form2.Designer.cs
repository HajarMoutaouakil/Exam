namespace Exam
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Q_ouverte = new System.Windows.Forms.RadioButton();
            this.QCM = new System.Windows.Forms.RadioButton();
            this.Engibutton = new System.Windows.Forms.Button();
            this.nom_classe = new System.Windows.Forms.TextBox();
            this.annuler_button = new System.Windows.Forms.Button();
            this.nbre_etudiant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.N_exam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nbre_tentative = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datedebut = new System.Windows.Forms.TextBox();
            this.datefin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date de début :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de fin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom de la classe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "La forme de l\'examen :";
            // 
            // Q_ouverte
            // 
            this.Q_ouverte.AutoSize = true;
            this.Q_ouverte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q_ouverte.Location = new System.Drawing.Point(378, 258);
            this.Q_ouverte.Name = "Q_ouverte";
            this.Q_ouverte.Size = new System.Drawing.Size(143, 22);
            this.Q_ouverte.TabIndex = 4;
            this.Q_ouverte.TabStop = true;
            this.Q_ouverte.Text = "Question ouverte";
            this.Q_ouverte.UseVisualStyleBackColor = true;
            // 
            // QCM
            // 
            this.QCM.AutoSize = true;
            this.QCM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QCM.Location = new System.Drawing.Point(378, 286);
            this.QCM.Name = "QCM";
            this.QCM.Size = new System.Drawing.Size(63, 22);
            this.QCM.TabIndex = 5;
            this.QCM.TabStop = true;
            this.QCM.Text = "QCM";
            this.QCM.UseVisualStyleBackColor = true;
            // 
            // Engibutton
            // 
            this.Engibutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Engibutton.Location = new System.Drawing.Point(136, 351);
            this.Engibutton.Name = "Engibutton";
            this.Engibutton.Size = new System.Drawing.Size(95, 35);
            this.Engibutton.TabIndex = 6;
            this.Engibutton.Text = "Enregistrer";
            this.Engibutton.UseVisualStyleBackColor = true;
            this.Engibutton.Click += new System.EventHandler(this.Engibutton_Click);
            // 
            // nom_classe
            // 
            this.nom_classe.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_classe.Location = new System.Drawing.Point(377, 95);
            this.nom_classe.Name = "nom_classe";
            this.nom_classe.Size = new System.Drawing.Size(198, 22);
            this.nom_classe.TabIndex = 9;
            // 
            // annuler_button
            // 
            this.annuler_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler_button.Location = new System.Drawing.Point(481, 351);
            this.annuler_button.Name = "annuler_button";
            this.annuler_button.Size = new System.Drawing.Size(95, 35);
            this.annuler_button.TabIndex = 12;
            this.annuler_button.Text = "Annuler";
            this.annuler_button.UseVisualStyleBackColor = true;
            this.annuler_button.Click += new System.EventHandler(this.annuler_button_Click);
            // 
            // nbre_etudiant
            // 
            this.nbre_etudiant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbre_etudiant.Location = new System.Drawing.Point(378, 135);
            this.nbre_etudiant.Name = "nbre_etudiant";
            this.nbre_etudiant.Size = new System.Drawing.Size(198, 22);
            this.nbre_etudiant.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre des étudiants :";
            // 
            // N_exam
            // 
            this.N_exam.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_exam.Location = new System.Drawing.Point(378, 62);
            this.N_exam.Name = "N_exam";
            this.N_exam.Size = new System.Drawing.Size(198, 22);
            this.N_exam.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Numero de l\'examen :";
            // 
            // nbre_tentative
            // 
            this.nbre_tentative.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbre_tentative.Location = new System.Drawing.Point(378, 316);
            this.nbre_tentative.Name = "nbre_tentative";
            this.nbre_tentative.Size = new System.Drawing.Size(198, 22);
            this.nbre_tentative.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(133, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre des tentatives :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(198, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(345, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Informations sur l\'exam :";
            // 
            // datedebut
            // 
            this.datedebut.Location = new System.Drawing.Point(378, 175);
            this.datedebut.Name = "datedebut";
            this.datedebut.Size = new System.Drawing.Size(196, 20);
            this.datedebut.TabIndex = 20;
            this.datedebut.Text = "M/J/A";
            // 
            // datefin
            // 
            this.datefin.Location = new System.Drawing.Point(377, 219);
            this.datefin.Name = "datefin";
            this.datefin.Size = new System.Drawing.Size(196, 20);
            this.datefin.TabIndex = 21;
            this.datefin.Text = "M/J/A";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 387);
            this.Controls.Add(this.datefin);
            this.Controls.Add(this.datedebut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nbre_tentative);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.N_exam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nbre_etudiant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.annuler_button);
            this.Controls.Add(this.nom_classe);
            this.Controls.Add(this.Engibutton);
            this.Controls.Add(this.QCM);
            this.Controls.Add(this.Q_ouverte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Q_ouverte;
        private System.Windows.Forms.RadioButton QCM;
        private System.Windows.Forms.Button Engibutton;
        private System.Windows.Forms.TextBox nom_classe;
        private System.Windows.Forms.Button annuler_button;
        private System.Windows.Forms.TextBox nbre_etudiant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox N_exam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nbre_tentative;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox datedebut;
        private System.Windows.Forms.TextBox datefin;
    }
}