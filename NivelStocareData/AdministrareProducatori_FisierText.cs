using LibrarieModele;
using System.IO;

namespace NivelStocareDate
{
    public class AdministrareProducatori_FisierText
    {
        private const int NR_MAX_PRODUCATORI = 20;
        private string nume_Fisier;


        public AdministrareProducatori_FisierText(string nume_Fisier)
        {
            this.nume_Fisier = nume_Fisier;
            Stream streamFisierText = File.Open(nume_Fisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddProducator(Producator producator )
        {
 
            using (StreamWriter streamWriterFisierText = new StreamWriter(nume_Fisier, true))
            {
                streamWriterFisierText.WriteLine(producator.ConversieLaSir_PentruFisier());
            }
        }

        public Producator[] GetProducatori(out int nrProducatori)
        {
            Producator[] producatori = new Producator [NR_MAX_PRODUCATORI];

            using (StreamReader streamReader = new StreamReader(nume_Fisier))
            {
                string linieFisier;
                nrProducatori = 0;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    producatori[nrProducatori++] = new Producator(linieFisier);
                }
            }

            return producatori;
        }
    }
}