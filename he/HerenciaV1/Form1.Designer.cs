
namespace HerenciaV1
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
            this.INFORMACION = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CUADRADO = new System.Windows.Forms.RadioButton();
            this.TRIANGULO = new System.Windows.Forms.RadioButton();
            this.RECTANGULO = new System.Windows.Forms.RadioButton();
            this.P_REGULAR = new System.Windows.Forms.RadioButton();
            this.P_IRREGULAR = new System.Windows.Forms.RadioButton();
            this.CIRCULO = new System.Windows.Forms.RadioButton();
            this.CUBO = new System.Windows.Forms.RadioButton();
            this.PRISMA = new System.Windows.Forms.RadioButton();
            this.ESFERA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.B_GUARDAR = new System.Windows.Forms.Button();
            this.B_INFO = new System.Windows.Forms.Button();
            this.B_DIBUJAR = new System.Windows.Forms.Button();
            this.B_EXPORTAR = new System.Windows.Forms.Button();
            this.B_LIMPIAR = new System.Windows.Forms.Button();
            this.B_CALCULAR = new System.Windows.Forms.Button();
            this.IMAGEN = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // INFORMACION
            // 
            this.INFORMACION.Location = new System.Drawing.Point(269, 204);
            this.INFORMACION.Name = "INFORMACION";
            this.INFORMACION.Size = new System.Drawing.Size(210, 307);
            this.INFORMACION.TabIndex = 0;
            this.INFORMACION.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONSTRUCTOR DE FIGURAS GEOMETRICAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_CALCULAR);
            this.groupBox1.Controls.Add(this.B_LIMPIAR);
            this.groupBox1.Controls.Add(this.B_EXPORTAR);
            this.groupBox1.Controls.Add(this.B_DIBUJAR);
            this.groupBox1.Controls.Add(this.B_INFO);
            this.groupBox1.Controls.Add(this.B_GUARDAR);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ESFERA);
            this.groupBox1.Controls.Add(this.PRISMA);
            this.groupBox1.Controls.Add(this.CUBO);
            this.groupBox1.Controls.Add(this.CIRCULO);
            this.groupBox1.Controls.Add(this.P_IRREGULAR);
            this.groupBox1.Controls.Add(this.P_REGULAR);
            this.groupBox1.Controls.Add(this.RECTANGULO);
            this.groupBox1.Controls.Add(this.TRIANGULO);
            this.groupBox1.Controls.Add(this.CUADRADO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CUADRADO
            // 
            this.CUADRADO.AutoSize = true;
            this.CUADRADO.Location = new System.Drawing.Point(10, 64);
            this.CUADRADO.Name = "CUADRADO";
            this.CUADRADO.Size = new System.Drawing.Size(86, 17);
            this.CUADRADO.TabIndex = 2;
            this.CUADRADO.TabStop = true;
            this.CUADRADO.Text = "CUADRADO";
            this.CUADRADO.UseVisualStyleBackColor = true;
            // 
            // TRIANGULO
            // 
            this.TRIANGULO.AutoSize = true;
            this.TRIANGULO.Location = new System.Drawing.Point(102, 64);
            this.TRIANGULO.Name = "TRIANGULO";
            this.TRIANGULO.Size = new System.Drawing.Size(88, 17);
            this.TRIANGULO.TabIndex = 3;
            this.TRIANGULO.TabStop = true;
            this.TRIANGULO.Text = "TRIANGULO";
            this.TRIANGULO.UseVisualStyleBackColor = true;
            // 
            // RECTANGULO
            // 
            this.RECTANGULO.AutoSize = true;
            this.RECTANGULO.Location = new System.Drawing.Point(196, 64);
            this.RECTANGULO.Name = "RECTANGULO";
            this.RECTANGULO.Size = new System.Drawing.Size(99, 17);
            this.RECTANGULO.TabIndex = 4;
            this.RECTANGULO.TabStop = true;
            this.RECTANGULO.Text = "RECTANGULO";
            this.RECTANGULO.UseVisualStyleBackColor = true;
            // 
            // P_REGULAR
            // 
            this.P_REGULAR.AutoSize = true;
            this.P_REGULAR.Location = new System.Drawing.Point(301, 64);
            this.P_REGULAR.Name = "P_REGULAR";
            this.P_REGULAR.Size = new System.Drawing.Size(136, 17);
            this.P_REGULAR.TabIndex = 5;
            this.P_REGULAR.TabStop = true;
            this.P_REGULAR.Text = "POLIGONO REGULAR";
            this.P_REGULAR.UseVisualStyleBackColor = true;
            // 
            // P_IRREGULAR
            // 
            this.P_IRREGULAR.AutoSize = true;
            this.P_IRREGULAR.Location = new System.Drawing.Point(10, 87);
            this.P_IRREGULAR.Name = "P_IRREGULAR";
            this.P_IRREGULAR.Size = new System.Drawing.Size(147, 17);
            this.P_IRREGULAR.TabIndex = 6;
            this.P_IRREGULAR.TabStop = true;
            this.P_IRREGULAR.Text = "POLIGONO IRREGULAR";
            this.P_IRREGULAR.UseVisualStyleBackColor = true;
            // 
            // CIRCULO
            // 
            this.CIRCULO.AutoSize = true;
            this.CIRCULO.Location = new System.Drawing.Point(163, 87);
            this.CIRCULO.Name = "CIRCULO";
            this.CIRCULO.Size = new System.Drawing.Size(72, 17);
            this.CIRCULO.TabIndex = 7;
            this.CIRCULO.TabStop = true;
            this.CIRCULO.Text = "CIRCULO";
            this.CIRCULO.UseVisualStyleBackColor = true;
            // 
            // CUBO
            // 
            this.CUBO.AutoSize = true;
            this.CUBO.Location = new System.Drawing.Point(241, 87);
            this.CUBO.Name = "CUBO";
            this.CUBO.Size = new System.Drawing.Size(55, 17);
            this.CUBO.TabIndex = 8;
            this.CUBO.TabStop = true;
            this.CUBO.Text = "CUBO";
            this.CUBO.UseVisualStyleBackColor = true;
            // 
            // PRISMA
            // 
            this.PRISMA.AutoSize = true;
            this.PRISMA.Location = new System.Drawing.Point(301, 87);
            this.PRISMA.Name = "PRISMA";
            this.PRISMA.Size = new System.Drawing.Size(66, 17);
            this.PRISMA.TabIndex = 9;
            this.PRISMA.TabStop = true;
            this.PRISMA.Text = "PRISMA";
            this.PRISMA.UseVisualStyleBackColor = true;
            // 
            // ESFERA
            // 
            this.ESFERA.AutoSize = true;
            this.ESFERA.Location = new System.Drawing.Point(373, 87);
            this.ESFERA.Name = "ESFERA";
            this.ESFERA.Size = new System.Drawing.Size(67, 17);
            this.ESFERA.TabIndex = 10;
            this.ESFERA.TabStop = true;
            this.ESFERA.Text = "ESFERA";
            this.ESFERA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "INGRESA MEDIDA DEL LADO, ARISTA, RADIO ETC";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // B_GUARDAR
            // 
            this.B_GUARDAR.Location = new System.Drawing.Point(373, 124);
            this.B_GUARDAR.Name = "B_GUARDAR";
            this.B_GUARDAR.Size = new System.Drawing.Size(75, 23);
            this.B_GUARDAR.TabIndex = 13;
            this.B_GUARDAR.Text = "GUARDAR";
            this.B_GUARDAR.UseVisualStyleBackColor = true;
            // 
            // B_INFO
            // 
            this.B_INFO.Location = new System.Drawing.Point(9, 153);
            this.B_INFO.Name = "B_INFO";
            this.B_INFO.Size = new System.Drawing.Size(87, 23);
            this.B_INFO.TabIndex = 14;
            this.B_INFO.Text = "INFORMACION";
            this.B_INFO.UseVisualStyleBackColor = true;
            // 
            // B_DIBUJAR
            // 
            this.B_DIBUJAR.Location = new System.Drawing.Point(102, 153);
            this.B_DIBUJAR.Name = "B_DIBUJAR";
            this.B_DIBUJAR.Size = new System.Drawing.Size(75, 23);
            this.B_DIBUJAR.TabIndex = 15;
            this.B_DIBUJAR.Text = "DIBUJAR";
            this.B_DIBUJAR.UseVisualStyleBackColor = true;
            // 
            // B_EXPORTAR
            // 
            this.B_EXPORTAR.Location = new System.Drawing.Point(183, 153);
            this.B_EXPORTAR.Name = "B_EXPORTAR";
            this.B_EXPORTAR.Size = new System.Drawing.Size(75, 23);
            this.B_EXPORTAR.TabIndex = 16;
            this.B_EXPORTAR.Text = "EXPORTAR";
            this.B_EXPORTAR.UseVisualStyleBackColor = true;
            // 
            // B_LIMPIAR
            // 
            this.B_LIMPIAR.Location = new System.Drawing.Point(264, 153);
            this.B_LIMPIAR.Name = "B_LIMPIAR";
            this.B_LIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.B_LIMPIAR.TabIndex = 17;
            this.B_LIMPIAR.Text = "LIMPIAR";
            this.B_LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // B_CALCULAR
            // 
            this.B_CALCULAR.Location = new System.Drawing.Point(345, 153);
            this.B_CALCULAR.Name = "B_CALCULAR";
            this.B_CALCULAR.Size = new System.Drawing.Size(75, 23);
            this.B_CALCULAR.TabIndex = 18;
            this.B_CALCULAR.Text = "CALCULAR";
            this.B_CALCULAR.UseVisualStyleBackColor = true;
            // 
            // IMAGEN
            // 
            this.IMAGEN.Location = new System.Drawing.Point(12, 204);
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.Size = new System.Drawing.Size(246, 307);
            this.IMAGEN.TabIndex = 3;
            this.IMAGEN.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 527);
            this.Controls.Add(this.IMAGEN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.INFORMACION);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox INFORMACION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_CALCULAR;
        private System.Windows.Forms.Button B_LIMPIAR;
        private System.Windows.Forms.Button B_EXPORTAR;
        private System.Windows.Forms.Button B_DIBUJAR;
        private System.Windows.Forms.Button B_INFO;
        private System.Windows.Forms.Button B_GUARDAR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ESFERA;
        private System.Windows.Forms.RadioButton PRISMA;
        private System.Windows.Forms.RadioButton CUBO;
        private System.Windows.Forms.RadioButton CIRCULO;
        private System.Windows.Forms.RadioButton P_IRREGULAR;
        private System.Windows.Forms.RadioButton P_REGULAR;
        private System.Windows.Forms.RadioButton RECTANGULO;
        private System.Windows.Forms.RadioButton TRIANGULO;
        private System.Windows.Forms.RadioButton CUADRADO;
        private System.Windows.Forms.PictureBox IMAGEN;
    }
}

