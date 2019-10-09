namespace ProjetRestoSQLServeur.IHM.Personnel.Ajouter
{
  partial class FormPersonnelAjouter
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
            this.B_Retour = new System.Windows.Forms.Button();
            this.CB_Etat_Serveur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Prenom_Serveur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_AjouterServeur = new System.Windows.Forms.Button();
            this.TB_Nom_Serveur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ajouter un serveur au personnel";
            // 
            // B_Retour
            // 
            this.B_Retour.Location = new System.Drawing.Point(3, 2);
            this.B_Retour.Name = "B_Retour";
            this.B_Retour.Size = new System.Drawing.Size(98, 33);
            this.B_Retour.TabIndex = 46;
            this.B_Retour.Text = "Retour";
            this.B_Retour.UseVisualStyleBackColor = true;
            this.B_Retour.Click += new System.EventHandler(this.B_Retour_Click);
            // 
            // CB_Etat_Serveur
            // 
            this.CB_Etat_Serveur.FormattingEnabled = true;
            this.CB_Etat_Serveur.Location = new System.Drawing.Point(225, 183);
            this.CB_Etat_Serveur.Name = "CB_Etat_Serveur";
            this.CB_Etat_Serveur.Size = new System.Drawing.Size(129, 21);
            this.CB_Etat_Serveur.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "État du serveur";
            // 
            // TB_Prenom_Serveur
            // 
            this.TB_Prenom_Serveur.Location = new System.Drawing.Point(225, 141);
            this.TB_Prenom_Serveur.Name = "TB_Prenom_Serveur";
            this.TB_Prenom_Serveur.Size = new System.Drawing.Size(129, 20);
            this.TB_Prenom_Serveur.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Prenom du serveur";
            // 
            // B_AjouterServeur
            // 
            this.B_AjouterServeur.Location = new System.Drawing.Point(225, 225);
            this.B_AjouterServeur.Name = "B_AjouterServeur";
            this.B_AjouterServeur.Size = new System.Drawing.Size(129, 45);
            this.B_AjouterServeur.TabIndex = 41;
            this.B_AjouterServeur.Text = "Ajouter";
            this.B_AjouterServeur.UseVisualStyleBackColor = true;
            this.B_AjouterServeur.Click += new System.EventHandler(this.B_AjouterServeur_Click);
            // 
            // TB_Nom_Serveur
            // 
            this.TB_Nom_Serveur.Location = new System.Drawing.Point(225, 92);
            this.TB_Nom_Serveur.Name = "TB_Nom_Serveur";
            this.TB_Nom_Serveur.Size = new System.Drawing.Size(129, 20);
            this.TB_Nom_Serveur.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nom du serveur";
            // 
            // FormPersonnelAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 283);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.B_Retour);
            this.Controls.Add(this.CB_Etat_Serveur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Prenom_Serveur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_AjouterServeur);
            this.Controls.Add(this.TB_Nom_Serveur);
            this.Controls.Add(this.label1);
            this.Name = "FormPersonnelAjouter";
            this.Text = "Ajouter un Serveur";
            this.Load += new System.EventHandler(this.FormPersonnelAjouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button B_Retour;
    private System.Windows.Forms.ComboBox CB_Etat_Serveur;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox TB_Prenom_Serveur;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button B_AjouterServeur;
    private System.Windows.Forms.TextBox TB_Nom_Serveur;
    private System.Windows.Forms.Label label1;
  }
}