using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Exam
    {
        private int id_examen;
        private DateTime date;
        private int temps;
        private String matiere;
        Exercice Exercice;

        public void setIdExam(int id)
        {
            id_examen = id;
        }
        public int getIdExam()
        {
            return id_examen;
        }
        public void setDate(DateTime d)
        {
            date = d;
        }
        public DateTime getDate()
        {
            return date;    
        }
        public void setTemps(int t)
        {
            temps = t;
        }
        public int getTemps()
        {
            return temps;   
        }
        public void setMatiere(String m)
        {
            matiere = m;
        }
        public String getMatiere()
        {
            return matiere;
        }
    }

    class QCM
    {

        private int id_qcm;

        public void setIdQCM(int id)
        {
            id_qcm = id;
        }
        public int getIdQCM()
        {
            return id_qcm;
        }
    }

    class Exercice
    {

        private int id_exercice;
        private int num_exercice;
        private String type;

        public 
        public void setIdExercice(int id)
        {
            id_exercice = id;
        }
        public int getIdExercice()
        {
            return id_exercice;
        }
        public void setNumExercice(int num)
        {
            num_exercice = num;
        }
        public int getNumExercice()
        {
            return num_exercice;
        }

        public void setType(String t)
        {
            type = t;
        }
        public String getType()
        {
            return type;
        }
    }

    class Question
    {

        private int id_question;
        private int num_question;
        public void setIdQuestion(int id)
        {
            id_question = id;
        }
        public int getIdQuestion()
        {
            return id_question;
        }

        public void setNumQuestion(int num)
        {
            num_question = num;
        }

        public int getNumQuestion()
        {
            return num_question;
        }
    }
    class Reponse
    {

        private int id_reponse;
        private int num_reponse;

        public void setNumReponse(int num)
        {
            num_reponse = num;
        }

        public int getNumQuestion()
        {
            return num_reponse;
        }

        public void setIdReponse(int id)
        {
            id_reponse = id;
        }

        public int getIdReponse()
        {
            return id_reponse;
        }
    }
}
