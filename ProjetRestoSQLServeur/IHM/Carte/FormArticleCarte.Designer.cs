namespace ProjetRestoSQLServeur
{
  partial class FormArticleCarte
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
            this.lv_Article = new System.Windows.Forms.ListView();
            this.idArticle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.designationArticle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prixArticle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.photoArticle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomCatArticle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bouton_Supprimer = new System.Windows.Forms.Button();
            this.Bouton_Ajouter = new System.Windows.Forms.Button();
            this.Bouton_Modifier = new System.Windows.Forms.Button();
            this.btAcceuil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_Article
            // 
            this.lv_Article.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idArticle,
            this.designationArticle,
            this.prixArticle,
            this.photoArticle,
            this.NomCatArticle});
            this.lv_Article.FullRowSelect = true;
            this.lv_Article.Location = new System.Drawing.Point(36, 93);
            this.lv_Article.MultiSelect = false;
            this.lv_Article.Name = "lv_Article";
            this.lv_Article.Size = new System.Drawing.Size(685, 272);
            this.lv_Article.TabIndex = 9;
            this.lv_Article.UseCompatibleStateImageBehavior = false;
            this.lv_Article.View = System.Windows.Forms.View.Details;
            // 
            // idArticle
            // 
            this.idArticle.Text = "ID";
            this.idArticle.Width = 0;
            // 
            // designationArticle
            // 
            this.designationArticle.Text = "Designation";
            this.designationArticle.Width = 200;
            // 
            // prixArticle
            // 
            this.prixArticle.Text = "Prix";
            // 
            // photoArticle
            // 
            this.photoArticle.Text = "Lien de la photo";
            this.photoArticle.Width = 150;
            // 
            // NomCatArticle
            // 
            this.NomCatArticle.Text = "Nom de la categorie";
            this.NomCatArticle.Width = 200;
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Location = new System.Drawing.Point(499, 371);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(130, 32);
            this.Bouton_Supprimer.TabIndex = 7;
            this.Bouton_Supprimer.Text = "Supprimer";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            this.Bouton_Supprimer.Click += new System.EventHandler(this.Bouton_Supprimer_Click);
            // 
            // Bouton_Ajouter
            // 
            this.Bouton_Ajouter.Location = new System.Drawing.Point(101, 371);
            this.Bouton_Ajouter.Name = "Bouton_Ajouter";
            this.Bouton_Ajouter.Size = new System.Drawing.Size(133, 32);
            this.Bouton_Ajouter.TabIndex = 6;
            this.Bouton_Ajouter.Text = "Ajouter un article";
            this.Bouton_Ajouter.UseVisualStyleBackColor = true;
            this.Bouton_Ajouter.Click += new System.EventHandler(this.Bouton_Ajouter_Click);
            // 
            // Bouton_Modifier
            // 
            this.Bouton_Modifier.Location = new System.Drawing.Point(295, 371);
            this.Bouton_Modifier.Name = "Bouton_Modifier";
            this.Bouton_Modifier.Size = new System.Drawing.Size(121, 32);
            this.Bouton_Modifier.TabIndex = 5;
            this.Bouton_Modifier.Text = "Modifier";
            this.Bouton_Modifier.UseVisualStyleBackColor = true;
            this.Bouton_Modifier.Click += new System.EventHandler(this.Bouton_Modifier_Click);
            // 
            // btAcceuil
            // 
            this.btAcceuil.Location = new System.Drawing.Point(-1, 0);
            this.btAcceuil.Name = "btAcceuil";
            this.btAcceuil.Size = new System.Drawing.Size(131, 42);
            this.btAcceuil.TabIndex = 16;
            this.btAcceuil.Text = "Accueil";
            this.btAcceuil.UseVisualStyleBackColor = true;
            this.btAcceuil.Click += new System.EventHandler(this.btAcceuil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des articles de la carte";
            // 
            // FormArticleCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAcceuil);
            this.Controls.Add(this.lv_Article);
            this.Controls.Add(this.Bouton_Supprimer);
            this.Controls.Add(this.Bouton_Ajouter);
            this.Controls.Add(this.Bouton_Modifier);
            this.Name = "FormArticleCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Gestion de la carte";
            this.Load += new System.EventHandler(this.FormPlats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView lv_Article;
    private System.Windows.Forms.ColumnHeader idArticle;
    private System.Windows.Forms.ColumnHeader designationArticle;
    private System.Windows.Forms.ColumnHeader prixArticle;
    private System.Windows.Forms.ColumnHeader photoArticle;
    private System.Windows.Forms.ColumnHeader NomCatArticle;
    private System.Windows.Forms.Button Bouton_Supprimer;
    private System.Windows.Forms.Button Bouton_Ajouter;
    private System.Windows.Forms.Button Bouton_Modifier;
    private System.Windows.Forms.Button btAcceuil;
    private System.Windows.Forms.Label label1;
  }
}

