using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Etudiant
    {
        private String Nom;
        private string Prenom;
        private int n_etudiant;

    }

    public class Evaluation
    {
        private DateTime DateDebut;
        private DateTime DateFin;
        private float Note;
    }
    public class Question
    {
        public System.Collections.ArrayList evaluation;

        private float NbreDePoints;

    }
    public class QuestionOverte : Question
    {
        public int ReponseVraie()
        {
            return 1;
        }

        public int ReponseFausse()
        {
            return 0;
        }

        public int NiveauDeCertitude()
        {
            return 0;
        }

        private int PointsGagne;
        private int PointPerdue;

    }


    public class Qcm : Question
    {
        private int NbreDeChoix;

    }
    public class Reponse
    {

        private char Text;

    }

    public class Propostion
    {
    }
}
