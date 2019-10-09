namespace ProjetRestoSQLServeur.IHM.Commandes.Nouveau
{
  partial class FormCommandesNouveau
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
            this.label5 = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.CB_NumTable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Ajouter = new System.Windows.Forms.Button();
            this.CB_IdServeur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nouvelle Commande";
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(0, -1);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(98, 33);
            this.retour.TabIndex = 31;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // CB_NumTable
            // 
            this.CB_NumTable.FormattingEnabled = true;
            this.CB_NumTable.Location = new System.Drawing.Point(222, 100);
            this.CB_NumTable.Name = "CB_NumTable";
            this.CB_NumTable.Size = new System.Drawing.Size(129, 21);
            this.CB_NumTable.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Numéro de table";
            // 
            // B_Ajouter
            // 
            this.B_Ajouter.Location = new System.Drawing.Point(222, 248);
            this.B_Ajouter.Name = "B_Ajouter";
            this.B_Ajouter.Size = new System.Drawing.Size(129, 45);
            this.B_Ajouter.TabIndex = 28;
            this.B_Ajouter.Text = "Ajouter";
            this.B_Ajouter.UseVisualStyleBackColor = true;
            this.B_Ajouter.Click += new System.EventHandler(this.B_Ajouter_Click);
            // 
            // CB_IdServeur
            // 
            this.CB_IdServeur.FormattingEnabled = true;
            this.CB_IdServeur.Location = new System.Drawing.Point(224, 164);
            this.CB_IdServeur.Name = "CB_IdServeur";
            this.CB_IdServeur.Size = new System.Drawing.Size(129, 21);
            this.CB_IdServeur.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nom du Serveur";
            // 
            // FormCommandesNouveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 330);
            this.Controls.Add(this.CB_IdServeur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.CB_NumTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.B_Ajouter);
            this.Name = "FormCommandesNouveau";
            this.Text = "FormCommandesNouveau";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button retour;
    private System.Windows.Forms.ComboBox CB_NumTable;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button B_Ajouter;
    private System.Windows.Forms.ComboBox CB_IdServeur;
    private System.Windows.Forms.Label label1;
  }
}