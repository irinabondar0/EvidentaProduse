using System;
using System.Configuration;
using LibrarieModele;
using NivelStocareDate;
using System.Threading.Tasks;

namespace EvidentaProduse_Consola
{
    class Program
    {
        static void Main()
        {
            /* Produs produs = new Produs();
             string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
             AdministrareProduse_FisierText adminProduse = new AdministrareProduse_FisierText(numeFisier);
             int nrProduse = 0;
             adminProduse.GetProduse(out nrProduse);

             Producator producator = new Producator();
             string nume_Fisier = ConfigurationManager.AppSettings["Nume_Fisier"];
             AdministrareProducatori_FisierText adminProducatori = new AdministrareProducatori_FisierText(nume_Fisier);
             int nrProducatori = 0;
             adminProducatori.GetProducatori(out nrProducatori);*/

            LibrarieModele.Produs produs = new LibrarieModele.Produs(0, null, null, null);
            LibrarieModele.Producator producator = new LibrarieModele.Producator(0, null);

            string FilePath = "evidenta.txt";
            string filePath = "evidentaproducatori.txt";

            AdministrareProduse_FisierText adminProduse = new AdministrareProduse_FisierText(FilePath);
            AdministrareProducatori_FisierText adminProducatori = new AdministrareProducatori_FisierText(filePath);

            int nrProduse = 0;
            int nrProducatori = 0;


            string optiune;
            do
            {
                Console.WriteLine("\n A. Introducere informatii produs");
                Console.WriteLine("\n B. Salvare produs in fisier");
                Console.WriteLine("\n C. Afisare produs");
                Console.WriteLine("\n D. Afisare produse din fisier\n");
                
                Console.WriteLine("\n E. Introducere informatii producator");
                Console.WriteLine("\n F. Salvare producator in fisier");
                Console.WriteLine("\n G. Afisare producator din fisier");
                Console.WriteLine("\n H. Afisare producatori din fisier");
               
                Console.WriteLine("\n X. Inchidere program");
                Console.WriteLine("\nAlegeti o optiune :");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        produs = CitireProdusTastatura();
                        break;
                    case "C":
                        AfisareProdus(produs);
                        break;

                    case "D":
                        Produs[] produse = adminProduse.GetProduse(out nrProduse);
                        AfisareProduse(produse, nrProduse);
                        break;

                    case "B":
                        int idProdus = nrProduse + 1;
                        produs.IdProdus = idProdus;
                        adminProduse.AddProdus(produs);
                        nrProduse = nrProduse + 1;

                        break;

                    case "E":
                        producator = CitireProducatorTastatura();
                        break;


                    case "G":
                        AfisareProducator(producator);
                        break;

                    case "H":
                        Producator[] producatori = adminProducatori.GetProducatori(out nrProducatori);
                        AfisareProducatori(producatori, nrProducatori);

                        break;

                    case "F":
                        int idProducator = nrProducatori + 1;
                        producator.IdProducator = idProducator;
                        adminProducatori.AddProducator(producator);
                        nrProducatori = nrProducatori + 1;

                        break;
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static void AfisareProdus(Produs produs)
        {
            string infoProdus = string.Format("Produsul cu id-ul #{0} este {1}, culoarea {2} si pretul {3} lei.",
                    produs.IdProdus,
                    produs.Nume ?? " NECUNOSCUT ",
                    produs.Culoare ?? "NECUNOSCUT",
                    produs.Pret ?? "NECUNOSCUT");

            Console.WriteLine(infoProdus);
        }

        public static void AfisareProduse(Produs[] produse, int nrProduse)
        {
            Console.WriteLine("Produsele sunt:");
            for (int contor = 0; contor < nrProduse; contor++)
            {
                AfisareProdus(produse[contor]);
            }
        }

        public static Produs CitireProdusTastatura()
        {
            Console.WriteLine("Introduceti numele produsului :");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti culoarea acestuia :");
            string culoare = Console.ReadLine();

            Console.WriteLine("Introduceti pretul produsului :");
            string pret = Console.ReadLine();

            Produs produs = new Produs( 0,nume, culoare, pret);

          

            return produs;
        }

        //PRODUCATOR CITIRE / AFISARE 

         public static void AfisareProducator(Producator producator)
        {
            string infoProducator = string.Format("Producatorul cu id-ul {0} este : {1}.",
                producator.IdProducator,
                producator.Nume ?? " NECUNOSCUT ");

            Console.WriteLine(infoProducator);
        }

        public static void AfisareProducatori(Producator[] producatori , int nrProducatori)
        {
            Console.WriteLine("Producatorii sunt:");
            for (int contor = 0; contor < nrProducatori; contor++)
            {
                AfisareProducator(producatori[contor]);
            }
        }

        public static Producator CitireProducatorTastatura()
        {
            Console.WriteLine("Introduceti numele producatorului :");
            string nume = Console.ReadLine();

            Producator producator = new Producator(0,nume);

            return producator;
        }

    }

}
