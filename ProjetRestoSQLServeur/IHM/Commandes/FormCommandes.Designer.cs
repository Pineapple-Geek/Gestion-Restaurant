namespace ProjetRestoSQLServeur.IHM.Commandes
{
  partial class FormCommandes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btAcceuil = new System.Windows.Forms.Button();
            this.lv_Commande = new System.Windows.Forms.ListView();
            this.idCommande = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.heureCommande = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idServeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.termine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bouton_LibTable = new System.Windows.Forms.Button();
            this.Bouton_NewCommande = new System.Windows.Forms.Button();
            this.Bouton_NewConso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gestion des Commandes";
            // 
            // btAcceuil
            // 
            this.btAcceuil.Location = new System.Drawing.Point(0, 0);
            this.btAcceuil.Name = "btAcceuil";
            this.btAcceuil.Size = new System.Drawing.Size(131, 42);
            this.btAcceuil.TabIndex = 28;
            this.btAcceuil.Text = "Accueil";
            this.btAcceuil.UseVisualStyleBackColor = true;
            this.btAcceuil.Click += new System.EventHandler(this.btAcceuil_Click);
            // 
            // lv_Commande
            // 
            this.lv_Commande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCommande,
            this.heureCommande,
            this.numTable,
            this.idServeur,
            this.termine});
            this.lv_Commande.FullRowSelect = true;
            this.lv_Commande.Location = new System.Drawing.Point(37, 93);
            this.lv_Commande.MultiSelect = false;
            this.lv_Commande.Name = "lv_Commande";
            this.lv_Commande.Size = new System.Drawing.Size(685, 272);
            this.lv_Commande.TabIndex = 27;
            this.lv_Commande.UseCompatibleStateImageBehavior = false;
            this.lv_Commande.View = System.Windows.Forms.View.Details;
            // 
            // idCommande
            // 
            this.idCommande.Text = "ID";
            this.idCommande.Width = 80;
            // 
            // heureCommande
            // 
            this.heureCommande.Text = "Date/Heure de la commande";
            this.heureCommande.Width = 201;
            // 
            // numTable
            // 
            this.numTable.Text = "Numéro de table";
            this.numTable.Width = 100;
            // 
            // idServeur
            // 
            this.idServeur.Text = "ID Serveur";
            this.idServeur.Width = 100;
            // 
            // termine
            // 
            this.termine.Text = "Etat de la commande";
            this.termine.Width = 200;
            // 
            // Bouton_LibTable
            // 
            this.Bouton_LibTable.Location = new System.Drawing.Point(500, 371);
            this.Bouton_LibTable.Name = "Bouton_LibTable";
            this.Bouton_LibTable.Size = new System.Drawing.Size(130, 32);
            this.Bouton_LibTable.TabIndex = 26;
            this.Bouton_LibTable.Text = "Liberer la table";
            this.Bouton_LibTable.UseVisualStyleBackColor = true;
            // 
            // Bouton_NewCommande
            // 
            this.Bouton_NewCommande.Location = new System.Drawing.Point(102, 371);
            this.Bouton_NewCommande.Name = "Bouton_NewCommande";
            this.Bouton_NewCommande.Size = new System.Drawing.Size(133, 32);
            this.Bouton_NewCommande.TabIndex = 25;
            this.Bouton_NewCommande.Text = "Nouvelle commande";
            this.Bouton_NewCommande.UseVisualStyleBackColor = true;
            this.Bouton_NewCommande.Click += new System.EventHandler(this.Bouton_NewCommande_Click);
            // 
            // Bouton_NewConso
            // 
            this.Bouton_NewConso.Location = new System.Drawing.Point(296, 371);
            this.Bouton_NewConso.Name = "Bouton_NewConso";
            this.Bouton_NewConso.Size = new System.Drawing.Size(147, 32);
            this.Bouton_NewConso.TabIndex = 24;
            this.Bouton_NewConso.Text = "Ajouter une consomation";
            this.Bouton_NewConso.UseVisualStyleBackColor = true;
            // 
            // FormCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAcceuil);
            this.Controls.Add(this.lv_Commande);
            this.Controls.Add(this.Bouton_LibTable);
            this.Controls.Add(this.Bouton_NewCommande);
            this.Controls.Add(this.Bouton_NewConso);
            this.Name = "FormCommandes";
            this.Text = "Gestion des Commandes";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btAcceuil;
    private System.Windows.Forms.ListView lv_Commande;
    private System.Windows.Forms.ColumnHeader idCommande;
    private System.Windows.Forms.ColumnHeader heureCommande;
    private System.Windows.Forms.ColumnHeader numTable;
    private System.Windows.Forms.ColumnHeader idServeur;
    private System.Windows.Forms.ColumnHeader termine;
    private System.Windows.Forms.Button Bouton_LibTable;
    private System.Windows.Forms.Button Bouton_NewCommande;
    private System.Windows.Forms.Button Bouton_NewConso;
  }
}