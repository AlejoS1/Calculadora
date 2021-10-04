
namespace evaluacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbltabla = new System.Windows.Forms.Label();
            this.LblLimite = new System.Windows.Forms.Label();
            this.BttMultiplicar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Bttlimpiar = new System.Windows.Forms.Button();
            this.Bttsumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbltabla
            // 
            this.Lbltabla.AutoSize = true;
            this.Lbltabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltabla.Location = new System.Drawing.Point(41, 43);
            this.Lbltabla.Name = "Lbltabla";
            this.Lbltabla.Size = new System.Drawing.Size(54, 25);
            this.Lbltabla.TabIndex = 0;
            this.Lbltabla.Text = "tabla";
            // 
            // LblLimite
            // 
            this.LblLimite.AutoSize = true;
            this.LblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLimite.Location = new System.Drawing.Point(179, 43);
            this.LblLimite.Name = "LblLimite";
            this.LblLimite.Size = new System.Drawing.Size(63, 25);
            this.LblLimite.TabIndex = 1;
            this.LblLimite.Text = "Limite";
            // 
            // BttMultiplicar
            // 
            this.BttMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttMultiplicar.Location = new System.Drawing.Point(320, 57);
            this.BttMultiplicar.Name = "BttMultiplicar";
            this.BttMultiplicar.Size = new System.Drawing.Size(153, 60);
            this.BttMultiplicar.TabIndex = 2;
            this.BttMultiplicar.Text = "Multiplicar";
            this.BttMultiplicar.UseVisualStyleBackColor = true;
            this.BttMultiplicar.Click += new System.EventHandler(this.BttMultiplicar_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 279);
            this.listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 30);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(149, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 30);
            this.textBox2.TabIndex = 5;
            // 
            // Bttlimpiar
            // 
            this.Bttlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttlimpiar.Location = new System.Drawing.Point(338, 241);
            this.Bttlimpiar.Name = "Bttlimpiar";
            this.Bttlimpiar.Size = new System.Drawing.Size(110, 53);
            this.Bttlimpiar.TabIndex = 6;
            this.Bttlimpiar.Text = "Limpiar";
            this.Bttlimpiar.UseVisualStyleBackColor = true;
            this.Bttlimpiar.Click += new System.EventHandler(this.Bttlimpiar_Click);
            // 
            // Bttsumar
            // 
            this.Bttsumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttsumar.Location = new System.Drawing.Point(339, 143);
            this.Bttsumar.Name = "Bttsumar";
            this.Bttsumar.Size = new System.Drawing.Size(109, 59);
            this.Bttsumar.TabIndex = 7;
            this.Bttsumar.Text = "Sumar";
            this.Bttsumar.UseVisualStyleBackColor = true;
            this.Bttsumar.Click += new System.EventHandler(this.Bttsumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bttsumar);
            this.Controls.Add(this.Bttlimpiar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BttMultiplicar);
            this.Controls.Add(this.LblLimite);
            this.Controls.Add(this.Lbltabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbltabla;
        private System.Windows.Forms.Label LblLimite;
        private System.Windows.Forms.Button BttMultiplicar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Bttlimpiar;
        private System.Windows.Forms.Button Bttsumar;
    }
}

