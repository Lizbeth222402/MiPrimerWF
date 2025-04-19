namespace MiPrimerWF
{
    partial class Frm_Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Numero1 = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.txt_Numero2 = new System.Windows.Forms.TextBox();
            this.btn_Suma = new System.Windows.Forms.Button();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.btn_Restar = new System.Windows.Forms.Button();
            this.btn_Multiplicar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(24, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(26, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // txt_Numero1
            // 
            this.txt_Numero1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_Numero1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero1.Location = new System.Drawing.Point(203, 76);
            this.txt_Numero1.Multiline = true;
            this.txt_Numero1.Name = "txt_Numero1";
            this.txt_Numero1.Size = new System.Drawing.Size(289, 33);
            this.txt_Numero1.TabIndex = 6;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_Resultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.Location = new System.Drawing.Point(203, 208);
            this.txt_Resultado.Multiline = true;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(289, 33);
            this.txt_Resultado.TabIndex = 7;
            // 
            // txt_Numero2
            // 
            this.txt_Numero2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_Numero2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero2.Location = new System.Drawing.Point(203, 143);
            this.txt_Numero2.Multiline = true;
            this.txt_Numero2.Name = "txt_Numero2";
            this.txt_Numero2.Size = new System.Drawing.Size(289, 33);
            this.txt_Numero2.TabIndex = 8;
            // 
            // btn_Suma
            // 
            this.btn_Suma.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Suma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Suma.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suma.Location = new System.Drawing.Point(35, 310);
            this.btn_Suma.Name = "btn_Suma";
            this.btn_Suma.Size = new System.Drawing.Size(118, 49);
            this.btn_Suma.TabIndex = 9;
            this.btn_Suma.Text = "Suma";
            this.btn_Suma.UseVisualStyleBackColor = false;
            this.btn_Suma.Click += new System.EventHandler(this.btn_Suma_Click);
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Dividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Dividir.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dividir.Location = new System.Drawing.Point(35, 403);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(118, 49);
            this.btn_Dividir.TabIndex = 10;
            this.btn_Dividir.Text = "Dividir";
            this.btn_Dividir.UseVisualStyleBackColor = false;
            this.btn_Dividir.Click += new System.EventHandler(this.btn_Dividir_Click);
            // 
            // btn_Restar
            // 
            this.btn_Restar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Restar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Restar.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restar.Location = new System.Drawing.Point(236, 310);
            this.btn_Restar.Name = "btn_Restar";
            this.btn_Restar.Size = new System.Drawing.Size(134, 49);
            this.btn_Restar.TabIndex = 11;
            this.btn_Restar.Text = "Restar";
            this.btn_Restar.UseVisualStyleBackColor = false;
            this.btn_Restar.Click += new System.EventHandler(this.btn_Restar_Click);
            // 
            // btn_Multiplicar
            // 
            this.btn_Multiplicar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Multiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Multiplicar.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiplicar.Location = new System.Drawing.Point(236, 403);
            this.btn_Multiplicar.Name = "btn_Multiplicar";
            this.btn_Multiplicar.Size = new System.Drawing.Size(134, 49);
            this.btn_Multiplicar.TabIndex = 12;
            this.btn_Multiplicar.Text = "Multiplicar";
            this.btn_Multiplicar.UseVisualStyleBackColor = false;
            this.btn_Multiplicar.Click += new System.EventHandler(this.btn_Multiplicar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LightCoral;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(434, 358);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(134, 49);
            this.btnlimpiar.TabIndex = 13;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Frm_Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(598, 531);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btn_Multiplicar);
            this.Controls.Add(this.btn_Restar);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.btn_Suma);
            this.Controls.Add(this.txt_Numero2);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Numero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Calculadora";
            this.Load += new System.EventHandler(this.Frm_Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Numero1;
        public System.Windows.Forms.TextBox txt_Resultado;
        public System.Windows.Forms.TextBox txt_Numero2;
        public System.Windows.Forms.Button btn_Suma;
        public System.Windows.Forms.Button btn_Dividir;
        public System.Windows.Forms.Button btn_Restar;
        public System.Windows.Forms.Button btn_Multiplicar;
        public System.Windows.Forms.Button btnlimpiar;
    }
}