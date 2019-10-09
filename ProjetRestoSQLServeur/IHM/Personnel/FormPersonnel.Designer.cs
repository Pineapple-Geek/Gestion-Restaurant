namespace ProjetRestoSQLServeur.IHM.Personnel
{
  partial class FormPersonnel
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
            this.lv_Serveur = new System.Windows.Forms.ListView();
            this.idArticle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomServeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenomServeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.etatServeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bouton_Supprimer = new System.Windows.Forms.Button();
            this.Bouton_Ajouter = new System.Windows.Forms.Button();
            this.Bouton_Modifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gestion des serveurs";
            // 
            // btAcceuil
            // 
            this.btAcceuil.Location = new System.Drawing.Point(1, 1);
            this.btAcceuil.Name = "btAcceuil";
            this.btAcceuil.Size = new System.Drawing.Size(131, 42);
            this.btAcceuil.TabIndex = 22;
            this.btAcceuil.Text = "Accueil";
            this.btAcceuil.UseVisualStyleBackColor = true;
            this.btAcceuil.Click += new System.EventHandler(this.btAcceuil_Click);
            // 
            // lv_Serveur
            // 
            this.lv_Serveur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idArticle,
            this.nomServeur,
            this.prenomServeur,
            this.etatServeur});
            this.lv_Serveur.FullRowSelect = true;
            this.lv_Serveur.HideSelection = false;
            this.lv_Serveur.Location = new System.Drawing.Point(38, 94);
            this.lv_Serveur.MultiSelect = false;
            this.lv_Serveur.Name = "lv_Serveur";
            this.lv_Serveur.Size = new System.Drawing.Size(685, 272);
            this.lv_Serveur.TabIndex = 21;
            this.lv_Serveur.UseCompatibleStateImageBehavior = false;
            this.lv_Serveur.View = System.Windows.Forms.View.Details;
            // 
            // idArticle
            // 
            this.idArticle.Text = "ID";
            this.idArticle.Width = 0;
            // 
            // nomServeur
            // 
            this.nomServeur.Text = "Nom du Serveur";
            this.nomServeur.Width = 230;
            // 
            // prenomServeur
            // 
            this.prenomServeur.Text = "Prénom du Serveur";
            this.prenomServeur.Width = 230;
            // 
            // etatServeur
            // 
            this.etatServeur.Text = "État du Serveur";
            this.etatServeur.Width = 220;
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Location = new System.Drawing.Point(501, 372);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(130, 32);
            this.Bouton_Supprimer.TabIndex = 20;
            this.Bouton_Supprimer.Text = "Supprimer";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            this.Bouton_Supprimer.Click += new System.EventHandler(this.Bouton_Supprimer_Click);
            // 
            // Bouton_Ajouter
            // 
            this.Bouton_Ajouter.Location = new System.Drawing.Point(103, 372);
            this.Bouton_Ajouter.Name = "Bouton_Ajouter";
            this.Bouton_Ajouter.Size = new System.Drawing.Size(133, 32);
            this.Bouton_Ajouter.TabIndex = 19;
            this.Bouton_Ajouter.Text = "Ajouter un serveur";
            this.Bouton_Ajouter.UseVisualStyleBackColor = true;
            this.Bouton_Ajouter.Click += new System.EventHandler(this.Bouton_Ajouter_Click);
            // 
            // Bouton_Modifier
            // 
            this.Bouton_Modifier.Location = new System.Drawing.Point(297, 372);
            this.Bouton_Modifier.Name = "Bouton_Modifier";
            this.Bouton_Modifier.Size = new System.Drawing.Size(121, 32);
            this.Bouton_Modifier.TabIndex = 18;
            this.Bouton_Modifier.Text = "Modifier";
            this.Bouton_Modifier.UseVisualStyleBackColor = true;
            this.Bouton_Modifier.Click += new System.EventHandler(this.Bouton_Modifier_Click);
            // 
            // FormPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAcceuil);
            this.Controls.Add(this.lv_Serveur);
            this.Controls.Add(this.Bouton_Supprimer);
            this.Controls.Add(this.Bouton_Ajouter);
            this.Controls.Add(this.Bouton_Modifier);
            this.Name = "FormPersonnel";
            this.Text = "Gestion du Personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btAcceuil;
    private System.Windows.Forms.ListView lv_Serveur;
    private System.Windows.Forms.ColumnHeader idArticle;
    private System.Windows.Forms.ColumnHeader nomServeur;
    private System.Windows.Forms.ColumnHeader prenomServeur;
    private System.Windows.Forms.ColumnHeader etatServeur;
    private System.Windows.Forms.Button Bouton_Supprimer;
    private System.Windows.Forms.Button Bouton_Ajouter;
    private System.Windows.Forms.Button Bouton_Modifier;
  }
}