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
    public partial class Gestion_Operation : Form
    {
        public Gestion_Operation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gestion_Operation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hopitalDataSet.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.hopitalDataSet.medecin);
            // TODO: This line of code loads data into the 'hopitalDataSet.ligneMedecinOperation' table. You can move, or remove it, as needed.
            this.ligneMedecinOperationTableAdapter.Fill(this.hopitalDataSet.ligneMedecinOperation);
            // TODO: This line of code loads data into the 'hopitalDataSet.operation' table. You can move, or remove it, as needed.
            this.operationTableAdapter.Fill(this.hopitalDataSet.operation);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.operationBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.operationBindingSource.EndEdit();
                this.operationTableAdapter.Update(this.hopitalDataSet.operation);
                MessageBox.Show("L'ajout a ete effectue","Termine");
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.ligneMedecinOperationBindingSource.EndEdit();
                this.ligneMedecinOperationTableAdapter.Update(this.hopitalDataSet.ligneMedecinOperation);
                MessageBox.Show("L'ajout a ete effectue", "Termine");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ligneMedecinOperationBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"exec spGetNombreOperation '{dateOperation.Text}',{idSpecialite.Text}", new SqlConnection(Global.connectionString));
            try
            {
                command.Connection.Open();
                nombreOperation.Text = command.ExecuteScalar().ToString();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
