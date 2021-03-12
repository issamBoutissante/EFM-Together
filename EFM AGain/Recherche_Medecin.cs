using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFM_AGain
{
    public partial class Recherche_Medecin : Form
    {
        public Recherche_Medecin()
        {
            InitializeComponent();
        }

        private void Recherche_Medecin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopitalDataSet.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.hopitalDataSet.medecin);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboChoix.Text != "idSpecialite")
            {
                this.medecinBindingSource.Filter = $"subString({comboChoix.Text},1,{textBox1.Text.Length}) ='{textBox1.Text}'";
                return;
            }
            this.medecinBindingSource.Filter = $"idSpecialite ={textBox1.Text}";
        }
    }
}
