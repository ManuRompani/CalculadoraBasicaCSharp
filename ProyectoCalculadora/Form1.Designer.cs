namespace ProyectoCalculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonPotencia = new System.Windows.Forms.Button();
            this.buttonRaiz = new System.Windows.Forms.Button();
            this.buttonMultiplicar = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.buttonRestar = new System.Windows.Forms.Button();
            this.buttonSumar = new System.Windows.Forms.Button();
            this.buttonResultado = new System.Windows.Forms.Button();
            this.buttonComa = new System.Windows.Forms.Button();
            this.buttonCero = new System.Windows.Forms.Button();
            this.buttonCambioSigno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(2, 2);
            this.txtResultado.MaxLength = 10;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(269, 54);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(63, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(114, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(12, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(63, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(114, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(12, 151);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(63, 151);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonC.Location = new System.Drawing.Point(63, 100);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(45, 45);
            this.buttonC.TabIndex = 9;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCE.Location = new System.Drawing.Point(12, 100);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(45, 45);
            this.buttonCE.TabIndex = 10;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(114, 151);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBorrar.Location = new System.Drawing.Point(114, 100);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(45, 45);
            this.buttonBorrar.TabIndex = 12;
            this.buttonBorrar.Text = "←";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonPotencia
            // 
            this.buttonPotencia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPotencia.Location = new System.Drawing.Point(216, 100);
            this.buttonPotencia.Name = "buttonPotencia";
            this.buttonPotencia.Size = new System.Drawing.Size(45, 45);
            this.buttonPotencia.TabIndex = 14;
            this.buttonPotencia.Tag = "²";
            this.buttonPotencia.Text = " x²";
            this.buttonPotencia.UseVisualStyleBackColor = true;
            this.buttonPotencia.Click += new System.EventHandler(this.btnCalculo);
            // 
            // buttonRaiz
            // 
            this.buttonRaiz.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRaiz.Location = new System.Drawing.Point(165, 100);
            this.buttonRaiz.Name = "buttonRaiz";
            this.buttonRaiz.Size = new System.Drawing.Size(45, 45);
            this.buttonRaiz.TabIndex = 13;
            this.buttonRaiz.Tag = "√";
            this.buttonRaiz.Text = "√";
            this.buttonRaiz.UseVisualStyleBackColor = true;
            this.buttonRaiz.Click += new System.EventHandler(this.btnCalculo);
            // 
            // buttonMultiplicar
            // 
            this.buttonMultiplicar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiplicar.Location = new System.Drawing.Point(216, 151);
            this.buttonMultiplicar.Name = "buttonMultiplicar";
            this.buttonMultiplicar.Size = new System.Drawing.Size(45, 45);
            this.buttonMultiplicar.TabIndex = 16;
            this.buttonMultiplicar.Tag = "X";
            this.buttonMultiplicar.Text = "X";
            this.buttonMultiplicar.UseVisualStyleBackColor = true;
            this.buttonMultiplicar.Click += new System.EventHandler(this.btnCalculo);
            // 
            // buttonDividir
            // 
            this.buttonDividir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDividir.Location = new System.Drawing.Point(165, 151);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(45, 45);
            this.buttonDividir.TabIndex = 15;
            this.buttonDividir.Tag = "∕";
            this.buttonDividir.Text = "∕";
            this.buttonDividir.UseVisualStyleBackColor = true;
            this.buttonDividir.Click += new System.EventHandler(this.btnCalculo);
            // 
            // buttonRestar
            // 
            this.buttonRestar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRestar.Location = new System.Drawing.Point(216, 202);
            this.buttonRestar.Name = "buttonRestar";
            this.buttonRestar.Size = new System.Drawing.Size(45, 45);
            this.buttonRestar.TabIndex = 18;
            this.buttonRestar.Tag = "−";
            this.buttonRestar.Text = "−";
            this.buttonRestar.UseVisualStyleBackColor = true;
            this.buttonRestar.Click += new System.EventHandler(this.btnCalculo);
            // 
            // buttonSumar
            // 
            this.buttonSumar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSumar.Location = new System.Drawing.Point(165, 202);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(45, 45);
            this.buttonSumar.TabIndex = 17;
            this.buttonSumar.Tag = "+";
            this.buttonSumar.Text = "+";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Click += new System.EventHandler(this.btnCalculo);
            // 
            // buttonResultado
            // 
            this.buttonResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResultado.Location = new System.Drawing.Point(165, 253);
            this.buttonResultado.Name = "buttonResultado";
            this.buttonResultado.Size = new System.Drawing.Size(96, 45);
            this.buttonResultado.TabIndex = 19;
            this.buttonResultado.Text = "=";
            this.buttonResultado.UseVisualStyleBackColor = true;
            this.buttonResultado.Click += new System.EventHandler(this.buttonResultado_Click);
            // 
            // buttonComa
            // 
            this.buttonComa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonComa.Location = new System.Drawing.Point(114, 304);
            this.buttonComa.Name = "buttonComa";
            this.buttonComa.Size = new System.Drawing.Size(45, 45);
            this.buttonComa.TabIndex = 22;
            this.buttonComa.Text = ",";
            this.buttonComa.UseVisualStyleBackColor = true;
            this.buttonComa.Click += new System.EventHandler(this.buttonComa_Click);
            // 
            // buttonCero
            // 
            this.buttonCero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCero.Location = new System.Drawing.Point(63, 304);
            this.buttonCero.Name = "buttonCero";
            this.buttonCero.Size = new System.Drawing.Size(45, 45);
            this.buttonCero.TabIndex = 21;
            this.buttonCero.Text = "0";
            this.buttonCero.UseVisualStyleBackColor = true;
            this.buttonCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // buttonCambioSigno
            // 
            this.buttonCambioSigno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCambioSigno.Location = new System.Drawing.Point(12, 304);
            this.buttonCambioSigno.Name = "buttonCambioSigno";
            this.buttonCambioSigno.Size = new System.Drawing.Size(45, 45);
            this.buttonCambioSigno.TabIndex = 20;
            this.buttonCambioSigno.Text = "+/−";
            this.buttonCambioSigno.UseVisualStyleBackColor = true;
            this.buttonCambioSigno.Click += new System.EventHandler(this.buttonCambioSigno_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(273, 367);
            this.Controls.Add(this.buttonComa);
            this.Controls.Add(this.buttonCero);
            this.Controls.Add(this.buttonCambioSigno);
            this.Controls.Add(this.buttonResultado);
            this.Controls.Add(this.buttonRestar);
            this.Controls.Add(this.buttonSumar);
            this.Controls.Add(this.buttonMultiplicar);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.buttonPotencia);
            this.Controls.Add(this.buttonRaiz);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(289, 406);
            this.MinimumSize = new System.Drawing.Size(289, 406);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora By Manu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private TextBox txtResultado;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button buttonC;
        private Button buttonCE;
        private Button button9;
        private Button buttonBorrar;
        private Button buttonPotencia;
        private Button buttonRaiz;
        private Button buttonMultiplicar;
        private Button buttonDividir;
        private Button buttonRestar;
        private Button buttonSumar;
        private Button buttonResultado;
        private Button buttonComa;
        private Button buttonCero;
        private Button buttonCambioSigno;
    }
}