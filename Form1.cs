using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibrarieModele;

using NivelStocareDate;

namespace InterfataUtilizator_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Label lblNume;
        private TextBox txtNume;

        private Label lblCod;
        private TextBox txtCod;

        private Label lblCuloare;
        private TextBox txtCuloare;

        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        public Form1()
        {
           
            
            InitializeComponent();

            //setare proprietati
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "Informatii produs";

            

            //adaugare control de tip Label pentru 'Nume';
            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume";
            lblNume.BackColor = Color.LightBlue;
            this.Controls.Add(lblNume);

            //adaugare control de tip TextBox pentru 'Nume';
            txtNume = new TextBox();
            txtNume.Width = LATIME_CONTROL;
            txtNume.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(txtNume);


            //adaugare control de tip Label pentru 'Cod';
            lblCod = new Label();
            lblCod.Width = LATIME_CONTROL;
            lblCod.Text = "Cod:";
            lblCod.Top = DIMENSIUNE_PAS_Y;
            lblCod.BackColor = Color.LightBlue;
            this.Controls.Add(lblCod);

            //adaugare control de tip TextBox pentru 'Cod'
            txtCod = new TextBox();
            txtCod.Width = LATIME_CONTROL;
            txtCod.Location = new Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtCod);

            //adaugare control de tip Label pentru 'Culoare';
            lblCuloare = new Label();
            lblCuloare.Width = LATIME_CONTROL;
            lblCuloare.Text = "Culoare";
            lblCuloare.Top = DIMENSIUNE_PAS_Y*2;
            lblCuloare.BackColor = Color.LightBlue;
            this.Controls.Add(lblCuloare);

            //adaugare control de tip TextBox pentru 'Culoare';
            txtCuloare = new TextBox();
            txtCuloare.Width = LATIME_CONTROL;
            txtCuloare.Location = new Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y*2);
            this.Controls.Add(txtCuloare);
        }
    }
}
