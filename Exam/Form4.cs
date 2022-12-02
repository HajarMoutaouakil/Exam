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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Engibutton_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-43NSE72\\SQLEXPRESS;Initial Catalog=Exam;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("insert into QCM values (@N_question,@Question,@Prop1,@Prop2,@Prop3,@Points_ajoutés,@Points_soustrait)", cnx);
            cmd.Parameters.AddWithValue("@N_question", int.Parse(N_question.Text));
            cmd.Parameters.AddWithValue("@Question", Question.Text);
            cmd.Parameters.AddWithValue("@Prop1", Prop1.Text);
            cmd.Parameters.AddWithValue("@Prop2", Prop2.Text);
            cmd.Parameters.AddWithValue("@Prop3", Prop3.Text);
            cmd.Parameters.AddWithValue("@Points_ajoutés", int.Parse(Points_ajoutés.Text));
            cmd.Parameters.AddWithValue("@Points_soustrait", int.Parse(Points_soustrait.Text));
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void annuler_button_Click(object sender, EventArgs e)
        {
            N_question.Text = "";
            Question.Text = "";
            Prop1.Text = "";
            Prop2.Text = "";
            Prop3.Text = "";
            Points_ajoutés.Text = "";
            Points_soustrait.Text = "";
        }
    }
}
