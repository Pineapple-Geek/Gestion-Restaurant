namespace ProjetRestoSQLServeur
{
  partial class FormArticleCarteModif
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
      this.CB_Type_Plats = new System.Windows.Forms.ComboBox();
      this.TB_Photo_Plat = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.TB_Prix_Plat = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.B_ModifFin = new System.Windows.Forms.Button();
      this.TB_Nom_Plat = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.TB_Id_Plat = new System.Windows.Forms.TextBox();
      this.retour = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // CB_Type_Plats
      // 
      this.CB_Type_Plats.FormattingEnabled = true;
      this.CB_Type_Plats.Location = new System.Drawing.Point(152, 236);
      this.CB_Type_Plats.Name = "CB_Type_Plats";
      this.CB_Type_Plats.Size = new System.Drawing.Size(143, 21);
      this.CB_Type_Plats.TabIndex = 25;
      // 
      // TB_Photo_Plat
      // 
      this.TB_Photo_Plat.Location = new System.Drawing.Point(152, 190);
      this.TB_Photo_Plat.Name = "TB_Photo_Plat";
      this.TB_Photo_Plat.Size = new System.Drawing.Size(143, 20);
      this.TB_Photo_Plat.TabIndex = 24;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(44, 239);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(37, 13);
      this.label4.TabIndex = 23;
      this.label4.Text = "Type :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(44, 189);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 22;
      this.label3.Text = "Lien photo :";
      // 
      // TB_Prix_Plat
      // 
      this.TB_Prix_Plat.Location = new System.Drawing.Point(152, 144);
      this.TB_Prix_Plat.Name = "TB_Prix_Plat";
      this.TB_Prix_Plat.Size = new System.Drawing.Size(143, 20);
      this.TB_Prix_Plat.TabIndex = 21;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(44, 147);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 13);
      this.label2.TabIndex = 20;
      this.label2.Text = "Prix :";
      // 
      // B_ModifFin
      // 
      this.B_ModifFin.Location = new System.Drawing.Point(152, 280);
      this.B_ModifFin.Name = "B_ModifFin";
      this.B_ModifFin.Size = new System.Drawing.Size(143, 44);
      this.B_ModifFin.TabIndex = 19;
      this.B_ModifFin.Text = "Modifier";
      this.B_ModifFin.UseVisualStyleBackColor = true;
      this.B_ModifFin.Click += new System.EventHandler(this.B_ModifFin_Click);
      // 
      // TB_Nom_Plat
      // 
      this.TB_Nom_Plat.Location = new System.Drawing.Point(152, 95);
      this.TB_Nom_Plat.Name = "TB_Nom_Plat";
      this.TB_Nom_Plat.Size = new System.Drawing.Size(143, 20);
      this.TB_Nom_Plat.TabIndex = 18;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(44, 98);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 13);
      this.label1.TabIndex = 17;
      this.label1.Text = "Nom du plat :";
      // 
      // TB_Id_Plat
      // 
      this.TB_Id_Plat.Location = new System.Drawing.Point(342, 95);
      this.TB_Id_Plat.Name = "TB_Id_Plat";
      this.TB_Id_Plat.Size = new System.Drawing.Size(100, 20);
      this.TB_Id_Plat.TabIndex = 26;
      this.TB_Id_Plat.Visible = false;
      // 
      // retour
      // 
      this.retour.Location = new System.Drawing.Point(0, 0);
      this.retour.Name = "retour";
      this.retour.Size = new System.Drawing.Size(98, 33);
      this.retour.TabIndex = 27;
      this.retour.Text = "Retour";
      this.retour.UseVisualStyleBackColor = true;
      this.retour.Click += new System.EventHandler(this.retour_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(161, 46);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(242, 20);
      this.label5.TabIndex = 28;
      this.label5.Text = "Modifier un article de la carte";
      // 
      // FormArticleCarteModif
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(588, 352);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.retour);
      this.Controls.Add(this.TB_Id_Plat);
      this.Controls.Add(this.CB_Type_Plats);
      this.Controls.Add(this.TB_Photo_Plat);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.TB_Prix_Plat);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.B_ModifFin);
      this.Controls.Add(this.TB_Nom_Plat);
      this.Controls.Add(this.label1);
      this.Name = "FormArticleCarteModif";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Modifier un article de la carte";
      this.Load += new System.EventHandler(this.FormArticleCarteModif_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox CB_Type_Plats;
    private System.Windows.Forms.TextBox TB_Photo_Plat;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox TB_Prix_Plat;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button B_ModifFin;
    private System.Windows.Forms.TextBox TB_Nom_Plat;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TB_Id_Plat;
    private System.Windows.Forms.Button retour;
    private System.Windows.Forms.Label label5;
  }
}
