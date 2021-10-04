
namespace evaluacion
{
    partial class sumador
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
            this.LblNumero1 = new System.Windows.Forms.Label();
            this.LblNumero2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Bttsumar = new System.Windows.Forms.Button();
            this.Lblresultado = new System.Windows.Forms.Label();
            this.Bttlimpiar = new System.Windows.Forms.Button();
            this.Bttrestar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNumero1
            // 
            this.LblNumero1.AutoSize = true;
            this.LblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero1.Location = new System.Drawing.Point(68, 46);
            this.LblNumero1.Name = "LblNumero1";
            this.LblNumero1.Size = new System.Drawing.Size(167, 25);
            this.LblNumero1.TabIndex = 0;
            this.LblNumero1.Text = "Ingrese Numero 1";
            // 
            // LblNumero2
            // 
            this.LblNumero2.AutoSize = true;
            this.LblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero2.Location = new System.Drawing.Point(68, 144);
            this.LblNumero2.Name = "LblNumero2";
            this.LblNumero2.Size = new System.Drawing.Size(167, 25);
            this.LblNumero2.TabIndex = 1;
            this.LblNumero2.Text = "Ingrese Numero 2";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(71, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 30);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(67, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 30);
            this.textBox2.TabIndex = 3;
            // 
            // Bttsumar
            // 
            this.Bttsumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttsumar.Location = new System.Drawing.Point(256, 121);
            this.Bttsumar.Name = "Bttsumar";
            this.Bttsumar.Size = new System.Drawing.Size(83, 71);
            this.Bttsumar.TabIndex = 4;
            this.Bttsumar.Text = "+";
            this.Bttsumar.UseVisualStyleBackColor = true;
            this.Bttsumar.Click += new System.EventHandler(this.Bttsumar_Click);
            // 
            // Lblresultado
            // 
            this.Lblresultado.AutoSize = true;
            this.Lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblresultado.Location = new System.Drawing.Point(411, 144);
            this.Lblresultado.Name = "Lblresultado";
            this.Lblresultado.Size = new System.Drawing.Size(0, 25);
            this.Lblresultado.TabIndex = 5;
            // 
            // Bttlimpiar
            // 
            this.Bttlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttlimpiar.Location = new System.Drawing.Point(88, 291);
            this.Bttlimpiar.Name = "Bttlimpiar";
            this.Bttlimpiar.Size = new System.Drawing.Size(92, 46);
            this.Bttlimpiar.TabIndex = 6;
            this.Bttlimpiar.Text = "Limpiar";
            this.Bttlimpiar.UseVisualStyleBackColor = true;
            this.Bttlimpiar.Click += new System.EventHandler(this.Bttlimpiar_Click);
            // 
            // Bttrestar
            // 
            this.Bttrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttrestar.Location = new System.Drawing.Point(242, 291);
            this.Bttrestar.Name = "Bttrestar";
            this.Bttrestar.Size = new System.Drawing.Size(97, 46);
            this.Bttrestar.TabIndex = 7;
            this.Bttrestar.Text = "Restar";
            this.Bttrestar.UseVisualStyleBackColor = true;
            this.Bttrestar.Click += new System.EventHandler(this.Bttrestar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(403, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sumador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bttrestar);
            this.Controls.Add(this.Bttlimpiar);
            this.Controls.Add(this.Lblresultado);
            this.Controls.Add(this.Bttsumar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblNumero2);
            this.Controls.Add(this.LblNumero1);
            this.Name = "sumador";
            this.Text = "sumador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumero1;
        private System.Windows.Forms.Label LblNumero2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Bttsumar;
        private System.Windows.Forms.Label Lblresultado;
        private System.Windows.Forms.Button Bttlimpiar;
        private System.Windows.Forms.Button Bttrestar;
        private System.Windows.Forms.Button button1;
    }
}