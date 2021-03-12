
namespace EFM_AGain
{
    partial class Gestion_Medecin
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
            this.label1 = new System.Windows.Forms.Label();
            this.cin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.premier = new System.Windows.Forms.Button();
            this.idMedecin = new System.Windows.Forms.ComboBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.specialite = new System.Windows.Forms.ComboBox();
            this.suivant = new System.Windows.Forms.Button();
            this.precedent = new System.Windows.Forms.Button();
            this.dernier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.nouveau = new System.Windows.Forms.Button();
            this.hopitalDataSet = new EFM_AGain.hopitalDataSet();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinTableAdapter = new EFM_AGain.hopitalDataSetTableAdapters.medecinTableAdapter();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecialiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialiteTableAdapter = new EFM_AGain.hopitalDataSetTableAdapters.specialiteTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "cin";
            // 
            // cin
            // 
            this.cin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "cin", true));
            this.cin.Location = new System.Drawing.Point(172, 53);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(100, 20);
            this.cin.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedecinDataGridViewTextBoxColumn,
            this.cinDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.idSpecialiteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medecinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(103, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // premier
            // 
            this.premier.Location = new System.Drawing.Point(344, 87);
            this.premier.Name = "premier";
            this.premier.Size = new System.Drawing.Size(75, 23);
            this.premier.TabIndex = 3;
            this.premier.Text = "|<<";
            this.premier.UseVisualStyleBackColor = true;
            this.premier.Click += new System.EventHandler(this.premier_Click);
            // 
            // idMedecin
            // 
            this.idMedecin.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medecinBindingSource, "idMedecin", true));
            this.idMedecin.DataSource = this.medecinBindingSource;
            this.idMedecin.DisplayMember = "idMedecin";
            this.idMedecin.FormattingEnabled = true;
            this.idMedecin.Location = new System.Drawing.Point(621, 169);
            this.idMedecin.Name = "idMedecin";
            this.idMedecin.Size = new System.Drawing.Size(72, 21);
            this.idMedecin.TabIndex = 4;
            this.idMedecin.ValueMember = "idMedecin";
            // 
            // prenom
            // 
            this.prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "prenom", true));
            this.prenom.Location = new System.Drawing.Point(172, 147);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "prenom";
            // 
            // nom
            // 
            this.nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "nom", true));
            this.nom.Location = new System.Drawing.Point(172, 97);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "telephone";
            // 
            // telephone
            // 
            this.telephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "telephone", true));
            this.telephone.Location = new System.Drawing.Point(172, 185);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(100, 20);
            this.telephone.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "specialite";
            // 
            // specialite
            // 
            this.specialite.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medecinBindingSource, "idSpecialite", true));
            this.specialite.DataSource = this.specialiteBindingSource;
            this.specialite.DisplayMember = "libelle";
            this.specialite.FormattingEnabled = true;
            this.specialite.Location = new System.Drawing.Point(172, 229);
            this.specialite.Name = "specialite";
            this.specialite.Size = new System.Drawing.Size(100, 21);
            this.specialite.TabIndex = 13;
            this.specialite.ValueMember = "idSpecialite";
            // 
            // suivant
            // 
            this.suivant.Location = new System.Drawing.Point(344, 127);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(75, 23);
            this.suivant.TabIndex = 3;
            this.suivant.Text = ">>";
            this.suivant.UseVisualStyleBackColor = true;
            this.suivant.Click += new System.EventHandler(this.suivant_Click);
            // 
            // precedent
            // 
            this.precedent.Location = new System.Drawing.Point(344, 166);
            this.precedent.Name = "precedent";
            this.precedent.Size = new System.Drawing.Size(75, 23);
            this.precedent.TabIndex = 3;
            this.precedent.Text = "<<";
            this.precedent.UseVisualStyleBackColor = true;
            this.precedent.Click += new System.EventHandler(this.precedent_Click);
            // 
            // dernier
            // 
            this.dernier.Location = new System.Drawing.Point(344, 209);
            this.dernier.Name = "dernier";
            this.dernier.Size = new System.Drawing.Size(75, 23);
            this.dernier.TabIndex = 3;
            this.dernier.Text = ">>|";
            this.dernier.UseVisualStyleBackColor = true;
            this.dernier.Click += new System.EventHandler(this.dernier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(435, 209);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(75, 23);
            this.supprimer.TabIndex = 14;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(435, 166);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(75, 23);
            this.modifier.TabIndex = 15;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(435, 127);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 16;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // nouveau
            // 
            this.nouveau.Location = new System.Drawing.Point(435, 87);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(75, 23);
            this.nouveau.TabIndex = 17;
            this.nouveau.Text = "Nouveau";
            this.nouveau.UseVisualStyleBackColor = true;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
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
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            this.idMedecinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinDataGridViewTextBoxColumn
            // 
            this.cinDataGridViewTextBoxColumn.DataPropertyName = "cin";
            this.cinDataGridViewTextBoxColumn.HeaderText = "cin";
            this.cinDataGridViewTextBoxColumn.Name = "cinDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // idSpecialiteDataGridViewTextBoxColumn
            // 
            this.idSpecialiteDataGridViewTextBoxColumn.DataPropertyName = "idSpecialite";
            this.idSpecialiteDataGridViewTextBoxColumn.HeaderText = "idSpecialite";
            this.idSpecialiteDataGridViewTextBoxColumn.Name = "idSpecialiteDataGridViewTextBoxColumn";
            // 
            // specialiteBindingSource
            // 
            this.specialiteBindingSource.DataMember = "specialite";
            this.specialiteBindingSource.DataSource = this.hopitalDataSet;
            // 
            // specialiteTableAdapter
            // 
            this.specialiteTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "idMedecin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestion_Medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.specialite);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idMedecin);
            this.Controls.Add(this.dernier);
            this.Controls.Add(this.precedent);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.premier);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Medecin";
            this.Text = "Gestion_Medecin";
            this.Load += new System.EventHandler(this.Gestion_Medecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialiteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button premier;
        private System.Windows.Forms.ComboBox idMedecin;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox specialite;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.Button precedent;
        private System.Windows.Forms.Button dernier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button nouveau;
        private hopitalDataSet hopitalDataSet;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private hopitalDataSetTableAdapters.medecinTableAdapter medecinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecialiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource specialiteBindingSource;
        private hopitalDataSetTableAdapters.specialiteTableAdapter specialiteTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}