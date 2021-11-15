namespace git
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
            this.cours = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.gestionClasses.Location = new System.Drawing.Point(93, 96);
            this.gestionClasses.Name = "gestionClasses";
            this.gestionClasses.Size = new System.Drawing.Size(131, 59);
            this.gestionClasses.TabIndex = 1;
            this.gestionClasses.Text = "gestion Classes";
            this.gestionClasses.UseVisualStyleBackColor = true;
            this.gestionClasses.Click += new System.EventHandler(this.gestionClasses_Click);
            // 
            // cours
            // 
            this.cours.Location = new System.Drawing.Point(269, 196);
            this.cours.Name = "cours";
            this.cours.Size = new System.Drawing.Size(131, 59);
            this.cours.TabIndex = 2;
            this.cours.Text = "gestion Cours";
            this.cours.UseVisualStyleBackColor = true;
            this.cours.Click += new System.EventHandler(this.cours_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "gestion eleves";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cours);
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
        private System.Windows.Forms.Button cours;
        private System.Windows.Forms.Button button1;
    }
}

