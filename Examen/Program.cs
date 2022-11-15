using System;
using System.Collections;
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
            Console.WriteLine("Hello world!");
        }
    }

    class Exam
    {
        private int id_examen;
        private DateTime date;
        private int duree;
        private String titre;
        private bool ferme;
        private Reponse reponse;
        private LinkedList<Question> question = new LinkedList<Question>();
        public void setFerme(bool s)
        {
            ferme = s;
            
        }
        public bool getFerme()
        {
            return ferme;
        }
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
        public void setDuree(int t)
        {
            duree = t;
        }
        public int getDuree()
        {
            return duree;   
        }
        public void setTitre(String t)
        {
            titre = t;
        }
        public String getTitre()
        {
            return titre;
        }
    }

    class Question
    {

        private int id_question;
        private int num_question;
        private float note;

        public Question(String question, Reponse reponse)
        {

        }
        public void setNote(float n)
        {
            note = n;
        }

        public float getNote()
        {
            return note;
        }
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

    class QCM : Question
    {
        public QCM(string question, Reponse reponse, Proposition proposition) : base(question, reponse)
        {
        }
    }

    class Proposition { 
        private int id_proposition;
        private string titre;
        private int note;
        public void setIdProposition(int num)
        {
            id_proposition = num;
        }

        public int getIdProposition()
        {
            return id_proposition;
        }
        public void setTitre(String t)
        {
            titre = t;
        }

        public String getTitre()
        {
            return titre;
        }
        public void setNote(int n)
        {
            note = n;
        }

        public int getNote()
        {
            return note;
        }
    }

    class Reponse
    {

        private int id_reponse;
        private String titre;
        private int note;

        public void setTitre(String t)
        {
            titre = t;
        }

        public String getTitre()
        {
            return titre;
        }

        public void setIdReponse(int id)
        {
            id_reponse = id;
        }

        public int getIdReponse()
        {
            return id_reponse;
        }

        public void setNote(int n)
        {
            note = n;
        }

        public int getNote()
        {
            return note;
        }
    }
}
