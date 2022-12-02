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
    public partial class Form3 : Form
    {
        SqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
        }

        private void Engibutton_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-43NSE72\\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");
            cnx.Open();
            cmd = new SqlCommand("insert into QO values (@N_question,@Question,@Réponse,@Points_ajoutés,@Points_soustrait)", cnx);
            cmd.Parameters.AddWithValue("@N_question", int.Parse(N_question.Text));
            cmd.Parameters.AddWithValue("@Question", Question.Text);
            cmd.Parameters.AddWithValue("@Réponse", Réponse.Text);
            cmd.Parameters.AddWithValue("@Points_ajoutés", int.Parse(Points_ajoutés.Text));
            cmd.Parameters.AddWithValue("@Points_soustrait", int.Parse(Points_soustrait.Text));
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void annuler_button_Click(object sender, EventArgs e)
        {
            N_question.Text = "";
            Question.Text = "";
            Réponse.Text = "";
            Points_ajoutés.Text = "";
            Points_soustrait.Text = "";
        }
    }
}
