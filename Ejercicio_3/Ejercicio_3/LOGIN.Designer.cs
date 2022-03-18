namespace Ejercicio_3
{
    partial class LOGIN
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
            this.ingreso_button = new System.Windows.Forms.Button();
            this.cerrar_button = new System.Windows.Forms.Button();
            this.contra_textBox = new System.Windows.Forms.TextBox();
            this.usuario_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ingreso_button
            // 
            this.ingreso_button.Location = new System.Drawing.Point(38, 201);
            this.ingreso_button.Name = "ingreso_button";
            this.ingreso_button.Size = new System.Drawing.Size(75, 23);
            this.ingreso_button.TabIndex = 0;
            this.ingreso_button.Text = "Ingresar";
            this.ingreso_button.UseVisualStyleBackColor = true;
            this.ingreso_button.Click += new System.EventHandler(this.ingreso_button_Click);
            // 
            // cerrar_button
            // 
            this.cerrar_button.Location = new System.Drawing.Point(187, 201);
            this.cerrar_button.Name = "cerrar_button";
            this.cerrar_button.Size = new System.Drawing.Size(75, 23);
            this.cerrar_button.TabIndex = 1;
            this.cerrar_button.Text = "Cerrar";
            this.cerrar_button.UseVisualStyleBackColor = true;
            this.cerrar_button.Click += new System.EventHandler(this.cerrar_button_Click);
            // 
            // contra_textBox
            // 
            this.contra_textBox.Location = new System.Drawing.Point(137, 136);
            this.contra_textBox.Name = "contra_textBox";
            this.contra_textBox.Size = new System.Drawing.Size(144, 20);
            this.contra_textBox.TabIndex = 2;
            // 
            // usuario_textBox
            // 
            this.usuario_textBox.Location = new System.Drawing.Point(137, 26);
            this.usuario_textBox.Name = "usuario_textBox";
            this.usuario_textBox.Size = new System.Drawing.Size(144, 20);
            this.usuario_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese su Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese su Contraseña: ";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuario_textBox);
            this.Controls.Add(this.contra_textBox);
            this.Controls.Add(this.cerrar_button);
            this.Controls.Add(this.ingreso_button);
            this.Name = "LOGIN";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ingreso_button;
        private System.Windows.Forms.Button cerrar_button;
        private System.Windows.Forms.TextBox contra_textBox;
        private System.Windows.Forms.TextBox usuario_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

