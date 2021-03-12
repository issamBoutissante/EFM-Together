
namespace EFM_AGain
{
    partial class Operation_Par_Client_Etat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.medecinCombo = new System.Windows.Forms.ComboBox();
            this.Imprimer = new System.Windows.Forms.Button();
            this.hopitalDataSet = new EFM_AGain.hopitalDataSet();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinTableAdapter = new EFM_AGain.hopitalDataSetTableAdapters.medecinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 62);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 388);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "medecin";
            // 
            // medecinCombo
            // 
            this.medecinCombo.DataSource = this.medecinBindingSource;
            this.medecinCombo.DisplayMember = "idMedecin";
            this.medecinCombo.FormattingEnabled = true;
            this.medecinCombo.Location = new System.Drawing.Point(172, 25);
            this.medecinCombo.Name = "medecinCombo";
            this.medecinCombo.Size = new System.Drawing.Size(121, 21);
            this.medecinCombo.TabIndex = 2;
            this.medecinCombo.ValueMember = "idMedecin";
            // 
            // Imprimer
            // 
            this.Imprimer.Location = new System.Drawing.Point(312, 25);
            this.Imprimer.Name = "Imprimer";
            this.Imprimer.Size = new System.Drawing.Size(75, 23);
            this.Imprimer.TabIndex = 3;
            this.Imprimer.Text = "Imprimer";
            this.Imprimer.UseVisualStyleBackColor = true;
            this.Imprimer.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // hopitalDataSet
            // 
            this.hopitalDataSet.DataSetName = "hopitalDataSet";
            this.hopitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medecinBindingSource
            // 
            this.medecinBindingSource.DataMember = "medecin";
            this.medecinBindingSource.DataSource = this.hopitalDataSet;
            // 
            // medecinTableAdapter
            // 
            this.medecinTableAdapter.ClearBeforeFill = true;
            // 
            // Operation_Par_Client_Etat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Imprimer);
            this.Controls.Add(this.medecinCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operation_Par_Client_Etat";
            this.Text = "Operation_Par_Client_Etat";
            this.Load += new System.EventHandler(this.Operation_Par_Client_Etat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox medecinCombo;
        private System.Windows.Forms.Button Imprimer;
        private hopitalDataSet hopitalDataSet;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private hopitalDataSetTableAdapters.medecinTableAdapter medecinTableAdapter;
    }
}