namespace ProjetRestoSQLServeur.IHM.Table.Modifier
{
  partial class FormTableModifier
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
            this.TB_Nbr_Place = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_ModifierTable = new System.Windows.Forms.Button();
            this.TB_Num_Table = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Modifier une Table";
            // 
            // B_Retour
            // 
            this.B_Retour.Location = new System.Drawing.Point(1, 0);
            this.B_Retour.Name = "B_Retour";
            this.B_Retour.Size = new System.Drawing.Size(98, 33);
            this.B_Retour.TabIndex = 62;
            this.B_Retour.Text = "Retour";
            this.B_Retour.UseVisualStyleBackColor = true;
            this.B_Retour.Click += new System.EventHandler(this.B_Retour_Click);
            // 
            // TB_Nbr_Place
            // 
            this.TB_Nbr_Place.Location = new System.Drawing.Point(223, 129);
            this.TB_Nbr_Place.Name = "TB_Nbr_Place";
            this.TB_Nbr_Place.Size = new System.Drawing.Size(129, 20);
            this.TB_Nbr_Place.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nombre de Place";
            // 
            // B_ModifierTable
            // 
            this.B_ModifierTable.Location = new System.Drawing.Point(223, 172);
            this.B_ModifierTable.Name = "B_ModifierTable";
            this.B_ModifierTable.Size = new System.Drawing.Size(129, 45);
            this.B_ModifierTable.TabIndex = 59;
            this.B_ModifierTable.Text = "Modifier";
            this.B_ModifierTable.UseVisualStyleBackColor = true;
            this.B_ModifierTable.Click += new System.EventHandler(this.B_ModifierTable_Click);
            // 
            // TB_Num_Table
            // 
            this.TB_Num_Table.Location = new System.Drawing.Point(223, 80);
            this.TB_Num_Table.Name = "TB_Num_Table";
            this.TB_Num_Table.Size = new System.Drawing.Size(129, 20);
            this.TB_Num_Table.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Numéro de la Table";
            // 
            // FormTableModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 231);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.B_Retour);
            this.Controls.Add(this.TB_Nbr_Place);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_ModifierTable);
            this.Controls.Add(this.TB_Num_Table);
            this.Controls.Add(this.label1);
            this.Name = "FormTableModifier";
            this.Text = "FormTableModifier";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button B_Retour;
    private System.Windows.Forms.TextBox TB_Nbr_Place;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button B_ModifierTable;
    private System.Windows.Forms.TextBox TB_Num_Table;
    private System.Windows.Forms.Label label1;
  }
}