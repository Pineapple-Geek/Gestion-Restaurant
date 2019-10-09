namespace ProjetRestoSQLServeur
{
  partial class Form1
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
            this.btCommande = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btCarte = new System.Windows.Forms.Button();
            this.btTable = new System.Windows.Forms.Button();
            this.btPersonnel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCommande
            // 
            this.btCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCommande.ForeColor = System.Drawing.Color.DarkRed;
            this.btCommande.Location = new System.Drawing.Point(151, 34);
            this.btCommande.Name = "btCommande";
            this.btCommande.Size = new System.Drawing.Size(300, 60);
            this.btCommande.TabIndex = 0;
            this.btCommande.Text = "Gérer les Commandes";
            this.btCommande.UseVisualStyleBackColor = true;
            this.btCommande.Click += new System.EventHandler(this.btCommande_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configuration du restaurant";
            // 
            // btCarte
            // 
            this.btCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarte.Location = new System.Drawing.Point(37, 167);
            this.btCarte.Name = "btCarte";
            this.btCarte.Size = new System.Drawing.Size(128, 60);
            this.btCarte.TabIndex = 2;
            this.btCarte.Text = "Gérer la carte";
            this.btCarte.UseVisualStyleBackColor = true;
            this.btCarte.Click += new System.EventHandler(this.btCarte_Click);
            // 
            // btTable
            // 
            this.btTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTable.Location = new System.Drawing.Point(222, 167);
            this.btTable.Name = "btTable";
            this.btTable.Size = new System.Drawing.Size(128, 60);
            this.btTable.TabIndex = 3;
            this.btTable.Text = "Gérer la tables";
            this.btTable.UseVisualStyleBackColor = true;
            this.btTable.Click += new System.EventHandler(this.btTable_Click);
            // 
            // btPersonnel
            // 
            this.btPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPersonnel.Location = new System.Drawing.Point(411, 167);
            this.btPersonnel.Name = "btPersonnel";
            this.btPersonnel.Size = new System.Drawing.Size(128, 60);
            this.btPersonnel.TabIndex = 4;
            this.btPersonnel.Text = "Gérer le personnel";
            this.btPersonnel.UseVisualStyleBackColor = true;
            this.btPersonnel.Click += new System.EventHandler(this.btPersonnel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.btPersonnel);
            this.Controls.Add(this.btTable);
            this.Controls.Add(this.btCarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCommande);
            this.Name = "Form1";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btCommande;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btCarte;
    private System.Windows.Forms.Button btTable;
    private System.Windows.Forms.Button btPersonnel;
  }
}

