namespace ProjetRestoSQLServeur.IHM.Table
{
  partial class FormTable
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
            this.lv_Table = new System.Windows.Forms.ListView();
            this.numTablee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bnPlaceTablee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bouton_Supprimer = new System.Windows.Forms.Button();
            this.Bouton_Ajouter = new System.Windows.Forms.Button();
            this.Bouton_Modifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gestion des tables";
            // 
            // btAcceuil
            // 
            this.btAcceuil.Location = new System.Drawing.Point(3, 3);
            this.btAcceuil.Name = "btAcceuil";
            this.btAcceuil.Size = new System.Drawing.Size(131, 42);
            this.btAcceuil.TabIndex = 28;
            this.btAcceuil.Text = "Accueil";
            this.btAcceuil.UseVisualStyleBackColor = true;
            this.btAcceuil.Click += new System.EventHandler(this.btAcceuil_Click);
            // 
            // lv_Table
            // 
            this.lv_Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numTablee,
            this.bnPlaceTablee});
            this.lv_Table.FullRowSelect = true;
            this.lv_Table.HideSelection = false;
            this.lv_Table.Location = new System.Drawing.Point(40, 96);
            this.lv_Table.MultiSelect = false;
            this.lv_Table.Name = "lv_Table";
            this.lv_Table.Size = new System.Drawing.Size(685, 272);
            this.lv_Table.TabIndex = 27;
            this.lv_Table.UseCompatibleStateImageBehavior = false;
            this.lv_Table.View = System.Windows.Forms.View.Details;
            // 
            // numTablee
            // 
            this.numTablee.Text = "Numéro de Table";
            this.numTablee.Width = 330;
            // 
            // bnPlaceTablee
            // 
            this.bnPlaceTablee.Text = "Nombre de Place";
            this.bnPlaceTablee.Width = 350;
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Location = new System.Drawing.Point(503, 374);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(130, 32);
            this.Bouton_Supprimer.TabIndex = 26;
            this.Bouton_Supprimer.Text = "Supprimer";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            this.Bouton_Supprimer.Click += new System.EventHandler(this.Bouton_Supprimer_Click);
            // 
            // Bouton_Ajouter
            // 
            this.Bouton_Ajouter.Location = new System.Drawing.Point(105, 374);
            this.Bouton_Ajouter.Name = "Bouton_Ajouter";
            this.Bouton_Ajouter.Size = new System.Drawing.Size(133, 32);
            this.Bouton_Ajouter.TabIndex = 25;
            this.Bouton_Ajouter.Text = "Ajouter une table";
            this.Bouton_Ajouter.UseVisualStyleBackColor = true;
            this.Bouton_Ajouter.Click += new System.EventHandler(this.Bouton_Ajouter_Click);
            // 
            // Bouton_Modifier
            // 
            this.Bouton_Modifier.Location = new System.Drawing.Point(299, 374);
            this.Bouton_Modifier.Name = "Bouton_Modifier";
            this.Bouton_Modifier.Size = new System.Drawing.Size(121, 32);
            this.Bouton_Modifier.TabIndex = 24;
            this.Bouton_Modifier.Text = "Modifier";
            this.Bouton_Modifier.UseVisualStyleBackColor = true;
            this.Bouton_Modifier.Click += new System.EventHandler(this.Bouton_Modifier_Click);
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAcceuil);
            this.Controls.Add(this.lv_Table);
            this.Controls.Add(this.Bouton_Supprimer);
            this.Controls.Add(this.Bouton_Ajouter);
            this.Controls.Add(this.Bouton_Modifier);
            this.Name = "FormTable";
            this.Text = "FormTable";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btAcceuil;
    private System.Windows.Forms.ListView lv_Table;
    private System.Windows.Forms.ColumnHeader numTablee;
    private System.Windows.Forms.ColumnHeader bnPlaceTablee;
    private System.Windows.Forms.Button Bouton_Supprimer;
    private System.Windows.Forms.Button Bouton_Ajouter;
    private System.Windows.Forms.Button Bouton_Modifier;
  }
}