using LibrarieModele.Enumerari;

using System;
using System.Collections;
using System.Linq;


namespace LibrarieModele
{
    public class Produs
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        
        private const bool SUCCES = true;
      

        private const int ID = 0;
        private const int NUME = 1;
        private const int CULOARE = 2;
        private const int PRET = 3;
        private const int AN = 4;
        private const int STARI = 5;
        

        public int IdProdus { get; set; } 
        public string Nume { get; set; }
        public string Culoare { get; set; }
        public string Pret { get; set; }

        public AnFabricatie An { get; set; }

        public ArrayList Stari { get; set; }

        public string StariAsString
        {
            get
            {
                return string.Join(SEPARATOR_SECUNDAR_FISIER.ToString(), Stari.ToArray());
            }
        }

        //contructor implicit
        public Produs()
        {
            Nume = Culoare = Pret= string.Empty;
            
        }

        //constructor cu parametri
        public Produs(int idProdus, string nume,string culoare, string pret)
        {
            this.IdProdus = idProdus;
            this.Nume = nume;
            this.Culoare = culoare;
            this.Pret = pret;
            
        }

        public Produs(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdProdus =Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Culoare = dateFisier[CULOARE];
            Pret = dateFisier[PRET];
            An = (AnFabricatie)Enum.Parse(typeof(AnFabricatie), dateFisier[AN]);
            Stari = new ArrayList();
            Stari.AddRange(dateFisier[STARI].Split(SEPARATOR_SECUNDAR_FISIER));
        }


        public string Info()
        {
            string info = string.Format("Id:{0} Nume:{1} Culoare:{2} Pret :{3}", 
                IdProdus.ToString(),
                (Nume ?? " NECUNOSCUT "),
                (Culoare ?? "NECUNOSCUT"),
                (Pret ?? "NECUNOSCUT"));

            return info;
        }



    public string ConversieLaSir_PentruFisier()
        {

            

            string obiectProdusPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdProdus.ToString(),
                (Nume ?? " NECUNOSCUT "),
                (Culoare ?? "NECUNOSCUT"),
                (Pret ?? "NECUNOSCUT"),
                An,
                StariAsString);

            return obiectProdusPentruFisier;
        }
       
    }
}

