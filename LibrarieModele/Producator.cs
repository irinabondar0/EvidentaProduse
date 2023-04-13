using System;

namespace LibrarieModele
{
    public class Producator
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int NUME = 1;

        public int IdProducator { get; set; }
        public string Nume { get; set; }
        
        

        //contructor implicit
        public Producator()
        {
            Nume = string.Empty;

        }

        //constructor cu parametri
        public Producator(int idProducator, string nume)
        {
            this.Nume = nume;
            this.IdProducator = idProducator;
        }

        public Producator(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdProducator=Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            
        }


        public string Info()
        {
            string info = string.Format("Producatorul {0} este {1} ",
                IdProducator.ToString(),
                (Nume ?? "NECUNOSCUT ")) ;
            return info;
        }


        public string ConversieLaSir_PentruFisier()
        {


            string obiectProducatorPentruFisier = string.Format("{1}{0}{2}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdProducator.ToString(),
                (Nume ?? " NECUNOSCUT "));

            return obiectProducatorPentruFisier;
        }

    }
}

