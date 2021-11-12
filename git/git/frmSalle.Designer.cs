namespace git
{
    partial class frmSalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalle));
            this.Accueil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalle)).BeginInit();
            this.SuspendLayout();
            // 
            // Accueil
            // 
            this.Accueil.Location = new System.Drawing.Point(329, 388);
            this.Accueil.Name = "Accueil";
            this.Accueil.Size = new System.Drawing.Size(160, 36);
            this.Accueil.TabIndex = 0;
            this.Accueil.Text = "Accueil";
            this.Accueil.UseVisualStyleBackColor = true;
            this.Accueil.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(298, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestionnaire des salles";
            this.label1.UseMnemonic = false;
            // 
            // dgvSalle
            // 
            this.dgvSalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalle.Location = new System.Drawing.Point(188, 99);
            this.dgvSalle.Name = "dgvSalle";
            this.dgvSalle.Size = new System.Drawing.Size(442, 212);
            this.dgvSalle.TabIndex = 2;
            // 
            // frmSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Accueil);
            this.Name = "frmSalle";
            this.Text = "frmSalle";
            this.Load += new System.EventHandler(this.frmSalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Accueil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSalle;
    }
}