namespace Calculadora
{
  partial class Form1
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
      this.btTantoPorCiento = new System.Windows.Forms.Button();
      this.btIgual = new System.Windows.Forms.Button();
      this.btComaDec = new System.Windows.Forms.Button();
      this.btDigito0 = new System.Windows.Forms.Button();
      this.btMas = new System.Windows.Forms.Button();
      this.btPor = new System.Windows.Forms.Button();
      this.btDigito3 = new System.Windows.Forms.Button();
      this.btDigito2 = new System.Windows.Forms.Button();
      this.btDigito1 = new System.Windows.Forms.Button();
      this.btMenos = new System.Windows.Forms.Button();
      this.btDividir = new System.Windows.Forms.Button();
      this.btDigito6 = new System.Windows.Forms.Button();
      this.btDigito5 = new System.Windows.Forms.Button();
      this.btDigito4 = new System.Windows.Forms.Button();
      this.btIniciar = new System.Windows.Forms.Button();
      this.btBorrarEntrada = new System.Windows.Forms.Button();
      this.btDigito9 = new System.Windows.Forms.Button();
      this.btDigito8 = new System.Windows.Forms.Button();
      this.btDigito7 = new System.Windows.Forms.Button();
      this.etPantalla = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btTantoPorCiento
      // 
      this.btTantoPorCiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btTantoPorCiento.Location = new System.Drawing.Point(196, 162);
      this.btTantoPorCiento.Name = "btTantoPorCiento";
      this.btTantoPorCiento.Size = new System.Drawing.Size(37, 30);
      this.btTantoPorCiento.TabIndex = 38;
      this.btTantoPorCiento.Text = "%";
      this.btTantoPorCiento.Click += new System.EventHandler(this.btTantoPorCiento_Click);
      // 
      // btIgual
      // 
      this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btIgual.Location = new System.Drawing.Point(153, 162);
      this.btIgual.Name = "btIgual";
      this.btIgual.Size = new System.Drawing.Size(37, 30);
      this.btIgual.TabIndex = 37;
      this.btIgual.Text = "=";
      this.btIgual.Click += new System.EventHandler(this.btOperacion_Click);
      // 
      // btComaDec
      // 
      this.btComaDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btComaDec.Location = new System.Drawing.Point(97, 162);
      this.btComaDec.Name = "btComaDec";
      this.btComaDec.Size = new System.Drawing.Size(37, 30);
      this.btComaDec.TabIndex = 30;
      this.btComaDec.Text = ",";
      this.btComaDec.Click += new System.EventHandler(this.btComaDec_Click);
      // 
      // btDigito0
      // 
      this.btDigito0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDigito0.Location = new System.Drawing.Point(11, 162);
      this.btDigito0.Name = "btDigito0";
      this.btDigito0.Size = new System.Drawing.Size(80, 30);
      this.btDigito0.TabIndex = 20;
      this.btDigito0.Text = "0";
      this.btDigito0.Click += new System.EventHandler(this.btDigito_Click);
      // 
      // btMas
      // 
      this.btMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btMas.Location = new System.Drawing.Point(196, 126);
      this.btMas.Name = "btMas";
      this.btMas.Size = new System.Drawing.Size(37, 30);
      this.btMas.TabIndex = 36;
      this.btMas.Text = "+";
      this.btMas.Click += new System.EventHandler(this.btOperacion_Click);
      // 
      // btPor
      // 
      this.btPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btPor.Location = new System.Drawing.Point(153, 126);
      this.btPor.Name = "btPor";
      this.btPor.Size = new System.Drawing.Size(37, 30);
      this.btPor.TabIndex = 35;
      this.btPor.Text = "x";
      this.btPor.Click += new System.EventHandler(this.btOperacion_Click);
      // 
      // btDigito3
      // 
      this.btDigito3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDigito3.Location = new System.Drawing.Point(97, 126);
      this.btDigito3.Name = "btDigito3";
      this.btDigito3.Size = new System.Drawing.Size(37, 30);
      this.btDigito3.TabIndex = 23;
      this.btDigito3.Text = "3";
      this.btDigito3.Click += new System.EventHandler(this.btDigito_Click);
      // 
      // btDigito2
      // 
      this.btDigito2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDigito2.Location = new System.Drawing.Point(54, 126);
      this.btDigito2.Name = "btDigito2";
      this.btDigito2.Size = new System.Drawing.Size(37, 30);
      this.btDigito2.TabIndex = 22;
      this.btDigito2.Text = "2";
      this.btDigito2.Click += new System.EventHandler(this.btDigito_Click);
      // 
      // btDigito1
      // 
      this.btDigito1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDigito1.Location = new System.Drawing.Point(11, 126);
      this.btDigito1.Name = "btDigito1";
      this.btDigito1.Size = new System.Drawing.Size(37, 30);
      this.btDigito1.TabIndex = 21;
      this.btDigito1.Text = "1";
      this.btDigito1.Click += new System.EventHandler(this.btDigito_Click);
      // 
      // btMenos
      // 
      this.btMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btMenos.Location = new System.Drawing.Point(196, 90);
      this.btMenos.Name = "btMenos";
      this.btMenos.Size = new System.Drawing.Size(37, 30);
      this.btMenos.TabIndex = 34;
      this.btMenos.Text = "-";
      this.btMenos.Click += new System.EventHandler(this.btOperacion_Click);
      // 
      // btDividir
      // 
      this.btDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDividir.Location = new System.Drawing.Point(153, 90);
      this.btDividir.Name = "btDividir";
      this.btDividir.Size = new System.Drawing.Size(37, 30);
      this.btDividir.TabIndex = 33;
      this.btDividir.Text = "/";
      this.btDividir.Click += new System.EventHandler(this.btOperacion_Click);
      // 
      // btDigito6
      // 
      this.btDigito6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDigito6.Location = new System.Drawing.Point(97, 90);
      this.btDigito6.Name = "btDigito6";
      this.btDigito6.Size = new System.Drawing.Size(37, 30);
      this.btDigito6.TabIndex = 26;
      this.btDigito6.Text = "6";
      this.btDigito6.Click += new System.EventHandler(this.btDigito_Click);
      // 
      // btDigito5
      // 
      this.btDigito5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDigito5.Location = new System.Drawing.Point(54, 90);
      this.btDigito5.Name = "btDigito5";
      this.btDigito5.Size = new System.Drawing.Size(37, 30);
      this.btDigito5.TabIndex = 25;
      this.btDigito5.Text = "5";
      this.btDigito5.Click += new System.EventHandler(this.btDigito_Click);
      // 
      // btDigito4
      // 
      this.btDigito4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDigito4.Location = new System.Drawing.Point(11, 90);
      this.btDigito4.Name = "btDigito4";
      this.btDigito4.Size = new System.Drawing.Size(37, 30);
      this.btDigito4.TabIndex = 24;
      this.btDigito4.Text = "4";
      this.btDigito4.Click += new System.EventHandler(this.btDigito_Click);
      // 
      // btIniciar
      // 
      this.btIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btIniciar.Location = new System.Drawing.Point(153, 54);
      this.btIniciar.Name = "btIniciar";
      this.btIniciar.Size = new System.Drawing.Size(37, 30);
      this.btIniciar.TabIndex = 31;
      this.btIniciar.Text = "C";
      this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
      // 
      // btBorrarEntrada
      // 
      this.btBorrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btBorrarEntrada.Location = new System.Drawing.Point(196, 54);
      this.btBorrarEntrada.Name = "btBorrarEntrada";
      this.btBorrarEntrada.Size = new System.Drawing.Size(37, 30);
      this.btBorrarEntrada.TabIndex = 32;
      this.btBorrarEntrada.Text = "CE";
      this.btBorrarEntrada.Click += new System.EventHandler(this.btBorrarEntrada_Click);
      // 
      // btDigito9
      // 
      this.btDigito9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDigito9.Location = new System.Drawing.Point(97, 54);
      this.btDigito9.Name = "btDigito9";
      this.btDigito9.Size = new System.Drawing.Size(37, 30);
      this.btDigito9.TabIndex = 29;
      this.btDigito9.Text = "9";
      this.btDigito9.Click += new System.EventHandler(this.btDigito_Click);
      // 
      // btDigito8
      // 
      this.btDigito8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDigito8.Location = new System.Drawing.Point(54, 54);
      this.btDigito8.Name = "btDigito8";
      this.btDigito8.Size = new System.Drawing.Size(37, 30);
      this.btDigito8.TabIndex = 28;
      this.btDigito8.Text = "8";
      this.btDigito8.Click += new System.EventHandler(this.btDigito_Click);
      // 
      // btDigito7
      // 
      this.btDigito7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btDigito7.Location = new System.Drawing.Point(11, 54);
      this.btDigito7.Name = "btDigito7";
      this.btDigito7.Size = new System.Drawing.Size(37, 30);
      this.btDigito7.TabIndex = 27;
      this.btDigito7.Text = "7";
      this.btDigito7.Click += new System.EventHandler(this.btDigito_Click);
      // 
      // etPantalla
      // 
      this.etPantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.etPantalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.etPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.etPantalla.Location = new System.Drawing.Point(11, 12);
      this.etPantalla.Name = "etPantalla";
      this.etPantalla.Size = new System.Drawing.Size(222, 27);
      this.etPantalla.TabIndex = 39;
      this.etPantalla.Text = "0,";
      this.etPantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(245, 204);
      this.Controls.Add(this.btTantoPorCiento);
      this.Controls.Add(this.btIgual);
      this.Controls.Add(this.btComaDec);
      this.Controls.Add(this.btDigito0);
      this.Controls.Add(this.btMas);
      this.Controls.Add(this.btPor);
      this.Controls.Add(this.btDigito3);
      this.Controls.Add(this.btDigito2);
      this.Controls.Add(this.btDigito1);
      this.Controls.Add(this.btMenos);
      this.Controls.Add(this.btDividir);
      this.Controls.Add(this.btDigito6);
      this.Controls.Add(this.btDigito5);
      this.Controls.Add(this.btDigito4);
      this.Controls.Add(this.btIniciar);
      this.Controls.Add(this.btBorrarEntrada);
      this.Controls.Add(this.btDigito9);
      this.Controls.Add(this.btDigito8);
      this.Controls.Add(this.btDigito7);
      this.Controls.Add(this.etPantalla);
      this.Name = "Form1";
      this.Text = "Calculadora";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btTantoPorCiento;
    private System.Windows.Forms.Button btIgual;
    private System.Windows.Forms.Button btComaDec;
    private System.Windows.Forms.Button btDigito0;
    private System.Windows.Forms.Button btMas;
    private System.Windows.Forms.Button btPor;
    private System.Windows.Forms.Button btDigito3;
    private System.Windows.Forms.Button btDigito2;
    private System.Windows.Forms.Button btDigito1;
    private System.Windows.Forms.Button btMenos;
    private System.Windows.Forms.Button btDividir;
    private System.Windows.Forms.Button btDigito6;
    private System.Windows.Forms.Button btDigito5;
    private System.Windows.Forms.Button btDigito4;
    private System.Windows.Forms.Button btIniciar;
    private System.Windows.Forms.Button btBorrarEntrada;
    private System.Windows.Forms.Button btDigito9;
    private System.Windows.Forms.Button btDigito8;
    private System.Windows.Forms.Button btDigito7;
    private System.Windows.Forms.Label etPantalla;
  }
}
