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
    public partial class Operation_Par_Client_Etat : Form
    {
        public Operation_Par_Client_Etat()
        {
            InitializeComponent();
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            new SqlDataAdapter($"select * from ligneMedecinOperation l join medecin m on l.idMedecin = m.idMedecin join operation o " +
                $"on l.idOperation = o.idOperation where l.idMedecin={medecinCombo.SelectedValue};",
                new SqlConnection(Global.connectionString))
                .Fill(dataSet, "opParMedecin");
            OperationsParClientCrystalReport report = new OperationsParClientCrystalReport();
            report.SetDataSource(dataSet.Tables[0]);
            crystalReportViewer1.ReportSource = report;
        }

        private void Operation_Par_Client_Etat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopitalDataSet.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.hopitalDataSet.medecin);

        }
    }
}
