using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFM_AGain
{
    public partial class Gestion_Medecin : Form
    {
        public Gestion_Medecin()
        {
            InitializeComponent();
        }

        private void Gestion_Medecin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopitalDataSet.specialite' table. You can move, or remove it, as needed.
            this.specialiteTableAdapter.Fill(this.hopitalDataSet.specialite);
            // TODO: This line of code loads data into the 'hopitalDataSet.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.hopitalDataSet.medecin);
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                this.medecinBindingSource.RemoveCurrent();
                MessageBox.Show("la supprission a ete effectue");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                MessageBox.Show("remplir les champs", "Error");
                return;
            }
            try
            {
                this.medecinBindingSource.EndEdit();
                MessageBox.Show("la modification a ete effectue");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                MessageBox.Show("remplir les champs","Error");
                return;
            }
            try
            {
                this.medecinBindingSource.EndEdit();
                MessageBox.Show("l'ajout a ete ajoute");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            this.medecinBindingSource.AddNew();
        }

        private void dernier_Click(object sender, EventArgs e)
        {
            this.medecinBindingSource.MoveLast();
        }

        private void precedent_Click(object sender, EventArgs e)
        {
            this.medecinBindingSource.MovePrevious();
        }

        private void suivant_Click(object sender, EventArgs e)
        {
            this.medecinBindingSource.MoveNext();
        }

        private void premier_Click(object sender, EventArgs e)
        {
            this.medecinBindingSource.MoveFirst();
        }
        private bool Validate()
        {
            foreach (Control control in this.Controls)
                if(control is TextBox)
                    if (string.IsNullOrEmpty(control.Text))
                        return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.medecinTableAdapter.Update(this.hopitalDataSet.medecin);
                MessageBox.Show("l'enregistrement","Termine");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
