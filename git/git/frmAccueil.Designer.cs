﻿namespace git
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.label1 = new System.Windows.Forms.Label();
            this.gestionClasses = new System.Windows.Forms.Button();
            this.GestionSalles = new System.Windows.Forms.Button();
            this.GestionEnseignant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(237, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = " Lycée Général d’Ingénierie Technique ";
            // 
            // gestionClasses
            // 
            this.gestionClasses.Location = new System.Drawing.Point(101, 107);
            this.gestionClasses.Name = "gestionClasses";
            this.gestionClasses.Size = new System.Drawing.Size(131, 59);
            this.gestionClasses.TabIndex = 1;
            this.gestionClasses.Text = "gestion Classes";
            this.gestionClasses.UseVisualStyleBackColor = true;
            this.gestionClasses.Click += new System.EventHandler(this.gestionClasses_Click);
            // 
            // GestionSalles
            // 
            this.GestionSalles.Location = new System.Drawing.Point(296, 107);
            this.GestionSalles.Name = "GestionSalles";
            this.GestionSalles.Size = new System.Drawing.Size(131, 59);
            this.GestionSalles.TabIndex = 2;
            this.GestionSalles.Text = "gestion Salles";
            this.GestionSalles.UseVisualStyleBackColor = true;
            this.GestionSalles.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionEnseignant
            // 
            this.GestionEnseignant.Location = new System.Drawing.Point(101, 207);
            this.GestionEnseignant.Name = "GestionEnseignant";
            this.GestionEnseignant.Size = new System.Drawing.Size(131, 59);
            this.GestionEnseignant.TabIndex = 3;
            this.GestionEnseignant.Text = "gestion Enseignants";
            this.GestionEnseignant.UseVisualStyleBackColor = true;
            this.GestionEnseignant.Click += new System.EventHandler(this.GestionEnseignant_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GestionEnseignant);
            this.Controls.Add(this.GestionSalles);
            this.Controls.Add(this.gestionClasses);
            this.Controls.Add(this.label1);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.frmAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gestionClasses;
        private System.Windows.Forms.Button GestionSalles;
        private System.Windows.Forms.Button GestionEnseignant;
    }
}

