using LibrarieModele;

using System;
using System.Collections;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareProduse_FisierText
    {
        private const int ID_PRIMUL_PRODUS = 1;
        private const int INCREMENT = 1;

        private string numeFisier;


        public AdministrareProduse_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddProdus(Produs produs)
        {
            produs.IdProdus = GetId();
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(produs.ConversieLaSir_PentruFisier());
            }
        }

        public ArrayList GetProduse()
        {
            ArrayList produse = new ArrayList();

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Produs produs = new Produs(linieFisier);
                    produse.Add(produs);
                }
            }

            return produse;
        }

        public Produs GetProdus(string nume, string culoare, string pret)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Produs produs  = new Produs(linieFisier);
                    if (produs.Nume.Equals(nume) && produs.Culoare.Equals(culoare) && produs.Pret.Equals(pret))

                        return produs;
                }
            }

            return null;
        }
        private int GetId()
        {
            int IdProdus = ID_PRIMUL_PRODUS;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Produs produs = new Produs(linieFisier);
                    IdProdus = produs.IdProdus + INCREMENT;
                }
            }

            return IdProdus;
        }


    }
}