
namespace EFM_AGain
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesMedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheMedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeLigneDoperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letatDoperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationParMedecinEtatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesMedecinToolStripMenuItem,
            this.rechercheMedecinToolStripMenuItem,
            this.gestionDeLigneDoperationToolStripMenuItem,
            this.letatDoperationToolStripMenuItem,
            this.operationParMedecinEtatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesMedecinToolStripMenuItem
            // 
            this.gestionDesMedecinToolStripMenuItem.Name = "gestionDesMedecinToolStripMenuItem";
            this.gestionDesMedecinToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.gestionDesMedecinToolStripMenuItem.Text = "Gestion des Medecin";
            this.gestionDesMedecinToolStripMenuItem.Click += new System.EventHandler(this.gestionDesMedecinToolStripMenuItem_Click);
            // 
            // rechercheMedecinToolStripMenuItem
            // 
            this.rechercheMedecinToolStripMenuItem.Name = "rechercheMedecinToolStripMenuItem";
            this.rechercheMedecinToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.rechercheMedecinToolStripMenuItem.Text = "Recherche Medecin";
            this.rechercheMedecinToolStripMenuItem.Click += new System.EventHandler(this.rechercheMedecinToolStripMenuItem_Click);
            // 
            // gestionDeLigneDoperationToolStripMenuItem
            // 
            this.gestionDeLigneDoperationToolStripMenuItem.Name = "gestionDeLigneDoperationToolStripMenuItem";
            this.gestionDeLigneDoperationToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.gestionDeLigneDoperationToolStripMenuItem.Text = "Gestion de Ligne d\'operation";
            this.gestionDeLigneDoperationToolStripMenuItem.Click += new System.EventHandler(this.gestionDeLigneDoperationToolStripMenuItem_Click);
            // 
            // letatDoperationToolStripMenuItem
            // 
            this.letatDoperationToolStripMenuItem.Name = "letatDoperationToolStripMenuItem";
            this.letatDoperationToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.letatDoperationToolStripMenuItem.Text = "L\'etat d\'operation";
            this.letatDoperationToolStripMenuItem.Click += new System.EventHandler(this.letatDoperationToolStripMenuItem_Click);
            // 
            // operationParMedecinEtatToolStripMenuItem
            // 
            this.operationParMedecinEtatToolStripMenuItem.Name = "operationParMedecinEtatToolStripMenuItem";
            this.operationParMedecinEtatToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.operationParMedecinEtatToolStripMenuItem.Text = "Operation Par Medecin Etat";
            this.operationParMedecinEtatToolStripMenuItem.Click += new System.EventHandler(this.operationParMedecinEtatToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMedecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheMedecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeLigneDoperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letatDoperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationParMedecinEtatToolStripMenuItem;
    }
}

