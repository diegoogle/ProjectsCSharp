namespace ADO.NET
{
  partial class DlgBuscar
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
      this.btCancelar = new System.Windows.Forms.Button();
      this.btAceptar = new System.Windows.Forms.Button();
      this.ctBuscar = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btCancelar
      // 
      this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btCancelar.Location = new System.Drawing.Point(265, 52);
      this.btCancelar.Name = "btCancelar";
      this.btCancelar.Size = new System.Drawing.Size(75, 23);
      this.btCancelar.TabIndex = 17;
      this.btCancelar.Text = "Cancelar";
      // 
      // btAceptar
      // 
      this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btAceptar.Location = new System.Drawing.Point(265, 24);
      this.btAceptar.Name = "btAceptar";
      this.btAceptar.Size = new System.Drawing.Size(75, 23);
      this.btAceptar.TabIndex = 16;
      this.btAceptar.Text = "Aceptar";
      // 
      // ctBuscar
      // 
      this.ctBuscar.Location = new System.Drawing.Point(76, 26);
      this.ctBuscar.Name = "ctBuscar";
      this.ctBuscar.Size = new System.Drawing.Size(173, 20);
      this.ctBuscar.TabIndex = 12;
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.Location = new System.Drawing.Point(9, 26);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(61, 13);
      this.Label1.TabIndex = 9;
      this.Label1.Text = "Buscar por:";
      // 
      // DlgBuscar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(352, 106);
      this.Controls.Add(this.btCancelar);
      this.Controls.Add(this.btAceptar);
      this.Controls.Add(this.ctBuscar);
      this.Controls.Add(this.Label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "DlgBuscar";
      this.Text = "Buscar";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btCancelar;
    private System.Windows.Forms.Button btAceptar;
    internal System.Windows.Forms.TextBox ctBuscar;
    private System.Windows.Forms.Label Label1;
  }
}