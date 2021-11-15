namespace git
{
    partial class frmEnseignant
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
            this.Accueil = new System.Windows.Forms.Button();
            this.dgvProf = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).BeginInit();
            this.SuspendLayout();
            // 
            // Accueil
            // 
            this.Accueil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Accueil.Location = new System.Drawing.Point(344, 356);
            this.Accueil.Name = "Accueil";
            this.Accueil.Size = new System.Drawing.Size(131, 37);
            this.Accueil.TabIndex = 3;
            this.Accueil.Text = "Accueil";
            this.Accueil.UseVisualStyleBackColor = false;
            this.Accueil.Click += new System.EventHandler(this.Accueil_Click);
            // 
            // dgvProf
            // 
            this.dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProf.Location = new System.Drawing.Point(12, 85);
            this.dgvProf.Name = "dgvProf";
            this.dgvProf.Size = new System.Drawing.Size(776, 231);
            this.dgvProf.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(290, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestionnaire des Enseignants";
            // 
            // frmEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::git.Properties.Resources.arton106647;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProf);
            this.Controls.Add(this.Accueil);
            this.Name = "frmEnseignant";
            this.Text = "frmEnseignant";
            this.Load += new System.EventHandler(this.frmEnseignant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Accueil;
        private System.Windows.Forms.DataGridView dgvProf;
        private System.Windows.Forms.Label label1;
    }
}