namespace ProjetRestoSQLServeur.IHM.Table.Ajouter
{
  partial class FormTableAjouter
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
            this.B_AjouterTable = new System.Windows.Forms.Button();
            this.TB_Nombre_Place = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Ajouter une Table";
            // 
            // B_Retour
            // 
            this.B_Retour.Location = new System.Drawing.Point(1, 2);
            this.B_Retour.Name = "B_Retour";
            this.B_Retour.Size = new System.Drawing.Size(98, 33);
            this.B_Retour.TabIndex = 55;
            this.B_Retour.Text = "Retour";
            this.B_Retour.UseVisualStyleBackColor = true;
            this.B_Retour.Click += new System.EventHandler(this.B_Retour_Click);
            // 
            // B_AjouterTable
            // 
            this.B_AjouterTable.Location = new System.Drawing.Point(223, 174);
            this.B_AjouterTable.Name = "B_AjouterTable";
            this.B_AjouterTable.Size = new System.Drawing.Size(129, 45);
            this.B_AjouterTable.TabIndex = 50;
            this.B_AjouterTable.Text = "Ajouter";
            this.B_AjouterTable.UseVisualStyleBackColor = true;
            this.B_AjouterTable.Click += new System.EventHandler(this.B_AjouterTable_Click);
            // 
            // TB_Nombre_Place
            // 
            this.TB_Nombre_Place.Location = new System.Drawing.Point(223, 111);
            this.TB_Nombre_Place.Name = "TB_Nombre_Place";
            this.TB_Nombre_Place.Size = new System.Drawing.Size(129, 20);
            this.TB_Nombre_Place.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre de Place";
            // 
            // FormTableAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 231);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.B_Retour);
            this.Controls.Add(this.B_AjouterTable);
            this.Controls.Add(this.TB_Nombre_Place);
            this.Controls.Add(this.label1);
            this.Name = "FormTableAjouter";
            this.Text = "FormTableAjouter";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button B_Retour;
    private System.Windows.Forms.Button B_AjouterTable;
    private System.Windows.Forms.TextBox TB_Nombre_Place;
    private System.Windows.Forms.Label label1;
  }
}