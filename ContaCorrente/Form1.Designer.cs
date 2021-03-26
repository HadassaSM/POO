
namespace ContaCorrente
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
            this.btndepositar = new System.Windows.Forms.Button();
            this.btnsacar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.txttitular = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.txtconta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndepositar
            // 
            this.btndepositar.Location = new System.Drawing.Point(12, 188);
            this.btndepositar.Name = "btndepositar";
            this.btndepositar.Size = new System.Drawing.Size(106, 46);
            this.btndepositar.TabIndex = 0;
            this.btndepositar.Text = "DEPOSITAR";
            this.btndepositar.UseVisualStyleBackColor = true;
            this.btndepositar.Click += new System.EventHandler(this.btndepositar_Click);
            // 
            // btnsacar
            // 
            this.btnsacar.Location = new System.Drawing.Point(124, 188);
            this.btnsacar.Name = "btnsacar";
            this.btnsacar.Size = new System.Drawing.Size(106, 46);
            this.btnsacar.TabIndex = 1;
            this.btnsacar.Text = "SACAR";
            this.btnsacar.UseVisualStyleBackColor = true;
            this.btnsacar.Click += new System.EventHandler(this.btnsacar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(12, 240);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(218, 65);
            this.btnlimpar.TabIndex = 2;
            this.btnlimpar.Text = "LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // txttitular
            // 
            this.txttitular.Location = new System.Drawing.Point(12, 27);
            this.txttitular.Name = "txttitular";
            this.txttitular.Size = new System.Drawing.Size(218, 23);
            this.txttitular.TabIndex = 3;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(12, 159);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(218, 23);
            this.txtvalor.TabIndex = 4;
            this.txtvalor.Text = "0";
            // 
            // txtsaldo
            // 
            this.txtsaldo.Location = new System.Drawing.Point(12, 115);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(218, 23);
            this.txtsaldo.TabIndex = 5;
            this.txtsaldo.Text = "0";
            // 
            // txtconta
            // 
            this.txtconta.Location = new System.Drawing.Point(12, 71);
            this.txtconta.Name = "txtconta";
            this.txtconta.Size = new System.Drawing.Size(218, 23);
            this.txtconta.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titular da Conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Conta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Saldo da Conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor de Operação:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 314);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtconta);
            this.Controls.Add(this.txtsaldo);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txttitular);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsacar);
            this.Controls.Add(this.btndepositar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndepositar;
        private System.Windows.Forms.Button btnsacar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.TextBox txttitular;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.TextBox txtconta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

