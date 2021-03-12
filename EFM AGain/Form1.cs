using System;
using System.Windows.Forms;

namespace EFM_AGain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ouvreForm(new Gestion_Medecin());
        }

        private void gestionDesMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ouvreForm(new Gestion_Medecin());
        }
        private void ouvreForm(Form form)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void rechercheMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ouvreForm(new Recherche_Medecin());
        }

        private void gestionDeLigneDoperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ouvreForm(new Gestion_Operation());
        }

        private void letatDoperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ouvreForm(new Liste_Operation());
        }

        private void operationParMedecinEtatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ouvreForm(new Operation_Par_Client_Etat());
        }
    }
}
