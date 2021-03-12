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
    public partial class Liste_Operation : Form
    {
        public Liste_Operation()
        {
            InitializeComponent();
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            new SqlDataAdapter($"select * from ligneMedecinOperation where dateOperation between" +
                $" '{FirstDate.Text}' and '{LastDate.Text}'", new SqlConnection(Global.connectionString))
                .Fill(dataSet, "ligneOperation");

            ListOperationCrystalReport report = new ListOperationCrystalReport();
            report.SetDataSource(dataSet.Tables[0]);
            report.SetParameterValue("FirstDate", FirstDate.Text);
            report.SetParameterValue("LastDate", LastDate.Text);

            crystalReportViewer1.ReportSource = report;

        }
    }
}
