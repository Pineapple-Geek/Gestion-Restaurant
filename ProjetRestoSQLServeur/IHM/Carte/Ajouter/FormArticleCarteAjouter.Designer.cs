namespace ProjetRestoSQLServeur
{
  partial class FomArticleCarteAjouter
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
      this.TB_Prix_Plat = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.B_AjServFin = new System.Windows.Forms.Button();
      this.TB_Nom_Plat = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.TB_Photo_Plat = new System.Windows.Forms.TextBox();
      this.CB_Type_Plats = new System.Windows.Forms.ComboBox();
      this.retour = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // TB_Prix_Plat
      // 
      this.TB_Prix_Plat.Location = new System.Drawing.Point(222, 139);
      this.TB_Prix_Plat.Name = "TB_Prix_Plat";
      this.TB_Prix_Plat.Size = new System.Drawing.Size(129, 20);
      this.TB_Prix_Plat.TabIndex = 12;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(114, 142);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Prix :";
      // 
      // B_AjServFin
      // 
      this.B_AjServFin.Location = new System.Drawing.Point(222, 273);
      this.B_AjServFin.Name = "B_AjServFin";
      this.B_AjServFin.Size = new System.Drawing.Size(129, 45);
      this.B_AjServFin.TabIndex = 10;
      this.B_AjServFin.Text = "Ajouter";
      this.B_AjServFin.UseVisualStyleBackColor = true;
      this.B_AjServFin.Click += new System.EventHandler(this.B_AjServFin_Click);
      // 
      // TB_Nom_Plat
      // 
      this.TB_Nom_Plat.Location = new System.Drawing.Point(222, 90);
      this.TB_Nom_Plat.Name = "TB_Nom_Plat";
      this.TB_Nom_Plat.Size = new System.Drawing.Size(129, 20);
      this.TB_Nom_Plat.TabIndex = 9;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(114, 93);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Nom de l\'article";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(114, 188);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 13;
      this.label3.Text = "Lien photo :";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(114, 234);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 13);
      this.label4.TabIndex = 14;
      this.label4.Text = "Catégorie";
      // 
      // TB_Photo_Plat
      // 
      this.TB_Photo_Plat.Location = new System.Drawing.Point(222, 185);
      this.TB_Photo_Plat.Name = "TB_Photo_Plat";
      this.TB_Photo_Plat.Size = new System.Drawing.Size(129, 20);
      this.TB_Photo_Plat.TabIndex = 15;
      // 
      // CB_Type_Plats
      // 
      this.CB_Type_Plats.FormattingEnabled = true;
      this.CB_Type_Plats.Location = new System.Drawing.Point(222, 231);
      this.CB_Type_Plats.Name = "CB_Type_Plats";
      this.CB_Type_Plats.Size = new System.Drawing.Size(129, 21);
      this.CB_Type_Plats.TabIndex = 16;
      // 
      // retour
      // 
      this.retour.Location = new System.Drawing.Point(0, 0);
      this.retour.Name = "retour";
      this.retour.Size = new System.Drawing.Size(98, 33);
      this.retour.TabIndex = 26;
      this.retour.Text = "Retour";
      this.retour.UseVisualStyleBackColor = true;
      this.retour.Click += new System.EventHandler(this.retour_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(167, 36);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(232, 20);
      this.label5.TabIndex = 27;
      this.label5.Text = "Ajouter un artiche à la carte";
      // 
      // FomArticleCarteAjouter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(549, 330);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.retour);
      this.Controls.Add(this.CB_Type_Plats);
      this.Controls.Add(this.TB_Photo_Plat);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.TB_Prix_Plat);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.B_AjServFin);
      this.Controls.Add(this.TB_Nom_Plat);
      this.Controls.Add(this.label1);
      this.Name = "FomArticleCarteAjouter";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ajouter un article à la carte";
      this.Load += new System.EventHandler(this.FPAjouter_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TB_Prix_Plat;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button B_AjServFin;
    private System.Windows.Forms.TextBox TB_Nom_Plat;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox TB_Photo_Plat;
    private System.Windows.Forms.ComboBox CB_Type_Plats;
    private System.Windows.Forms.Button retour;
    private System.Windows.Forms.Label label5;
  }
}