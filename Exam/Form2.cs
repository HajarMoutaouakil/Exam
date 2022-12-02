using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Engibutton_Click(object sender, EventArgs e)
        {
            string form = "";
            if (Q_ouverte.Checked == true)
            {
                form = Q_ouverte.Text;
                Form3 form3 = new Form3();
                form3.Show();
            }
            if (QCM.Checked == true)
            {
                form = QCM.Text;
                Form4 form4 = new Form4();
                form4.Show();
            }
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-43NSE72\\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("insert into examen values (@N_Exam,@Nom_classe,@Nbre_EtudiantS,@Date_Debut,@Date_Fin,@Type_d'exam,@Nbre_TentativeS)", cnx);
            cmd.Parameters.AddWithValue("@N_Exam", int.Parse(N_exam.Text));
            cmd.Parameters.AddWithValue("@Nom_classe", nom_classe.Text);
            cmd.Parameters.AddWithValue("@Nbre_EtudiantS", int.Parse(nbre_etudiant.Text));
            cmd.Parameters.AddWithValue("@Date_Debut", DateTime.Parse(datedebut.Text));
            cmd.Parameters.AddWithValue("@Date_Fin", DateTime.Parse(datefin.Text));
            cmd.Parameters.AddWithValue("@Type_d'exam", form);
            cmd.Parameters.AddWithValue("@Nbre_TentativeS", int.Parse(nbre_tentative.Text));
            cmd.ExecuteNonQuery();
            cnx.Close();
            
        }

        private void annuler_button_Click(object sender, EventArgs e)
        {
            N_exam.Text = "";
            nom_classe.Text = "";
            nbre_etudiant.Text = "";
            datedebut.Text = "";
            datefin.Text = "";
            nbre_tentative.Text = "";
        }
    }
}
