using LibrarieModele;
using LibrarieModele.Enumerari;

using NivelStocareDate;

using System;
using System.Collections;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        AdministrareProduse_FisierText adminProduse;

        private Label lblHeaderNume;
        private Label lblHeaderCuloare;
        private Label lblHeaderPret;
   

        private Label[] lblsNume;
        private Label[] lblsCuloare;
        private Label[] lblsPret;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 600;

        ArrayList aniSelectati = new ArrayList();

        ArrayList StariSelectate = new ArrayList();

        public Form1()
        {


            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminProduse = new AdministrareProduse_FisierText(caleCompletaFisier);

            InitializeComponent();

            //setare proprietati
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Informatii produs";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaProduse();
        }

        private void AfiseazaProduse()
        {
            //adaugare control de tip Label pentru 'Nume';
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "Nume";
            lblHeaderNume.Left = OFFSET_X + 0;
            lblHeaderNume.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderNume);

            //adaugare control de tip Label pentru 'Culoare';
            lblHeaderCuloare = new Label();
            lblHeaderCuloare.Width = LATIME_CONTROL;
            lblHeaderCuloare.Text = "Culoare";
            lblHeaderCuloare.Left = DIMENSIUNE_PAS_X + OFFSET_X;
            lblHeaderCuloare.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderCuloare);

           

            //adaugare control de tip Label pentru 'Pret';
            lblHeaderPret = new Label();
            lblHeaderPret.Width = LATIME_CONTROL;
            lblHeaderPret.Text = "Pret";
            lblHeaderPret.Left = 2 * DIMENSIUNE_PAS_X + OFFSET_X;
            lblHeaderPret.ForeColor = Color.Black;
            this.Controls.Add(lblHeaderPret);

            ArrayList produse = adminProduse.GetProduse();

            int nrProduse = produse.Count;
            lblsNume = new Label[nrProduse];
            lblsCuloare = new Label[nrProduse];
            lblsPret = new Label[nrProduse];

            int i = 0;
            foreach (Produs produs in produse)
            {
                //adaugare control de tip Label pentru numele produselor;
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = produs.Nume;
                lblsNume[i].Left = OFFSET_X + 0;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                //adaugare control de tip Label pentru culoarea produselor
                lblsCuloare[i] = new Label();
                lblsCuloare[i].Width = LATIME_CONTROL;
                lblsCuloare[i].Text = produs.Culoare;
                lblsCuloare[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsCuloare[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsCuloare[i]);

                //adaugare control de tip Label pentru pretul produselor
                lblsPret[i] = new Label();
                lblsPret[i].Width = LATIME_CONTROL;
                lblsPret[i].Text = produs.Pret;
                lblsPret[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsPret[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPret[i]);
                i++;
            }

        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValide())
            {
                lblHeaderCuloare.ForeColor = Color.Red;
                lblHeaderNume.ForeColor = Color.Red;
                lblHeaderPret.ForeColor = Color.Red;

                return;
            }

            Produs p = new Produs(0, txtNume.Text, txtCuloare.Text, txtPret.Text);

            AnFabricatie anselectat = GetAnFabricatieSelectat();

            p.An = anselectat;

            p.Stari = new ArrayList();
            p.Stari.AddRange(StariSelectate);

            
            adminProduse.AddProdus(p);
            lblMesaj.Text = "Produsul a fost adaugat ";

            ResetareControale();
        }

        private bool DateIntrareValide()
        {
            if (StariSelectate.Count>1)
            {
                return false;
            }
            return true;
        }

        private void CkbStari_CheckedChanged(object sender , EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;
            string StareaSelectata = checkBoxControl.Text;
            if (checkBoxControl.Checked == true)
                StariSelectate.Add(StareaSelectata);
            else
                StariSelectate.Remove(StareaSelectata);
        }

        private void ResetareControale()
        {
            txtNume.Text = txtCuloare.Text = txtPret.Text = string.Empty;


            rdbAnul2021.Checked = false;
            rdbAnul2022.Checked = false;
            rdbAnul2023.Checked = false;

            ckbNOU.Checked = false;
            ckbSECOND_HAND.Checked = false;

            StariSelectate.Clear();
            lblMesaj.Text = string.Empty;
        }

        private AnFabricatie GetAnFabricatieSelectat()
        {
            if (rdbAnul2021.Checked)
                return AnFabricatie.Anul2021;

            if (rdbAnul2022.Checked)
                return AnFabricatie.Anul2022;

            if (rdbAnul2023.Checked)
                return AnFabricatie.Anul2023;

            

            return AnFabricatie.Anul2021;
        }
        private void BtnAfiseaza_Click(object sender , EventArgs e)
        {
            AfiseazaProduse();
            this.Width = 1000;
        }

        
    }
}
