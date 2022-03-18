namespace Ejercicio_3
{
    partial class Lista_Usuarios
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
            this.lista_users_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lista_users_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_users_dataGridView
            // 
            this.lista_users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_users_dataGridView.Location = new System.Drawing.Point(35, 99);
            this.lista_users_dataGridView.Name = "lista_users_dataGridView";
            this.lista_users_dataGridView.Size = new System.Drawing.Size(727, 324);
            this.lista_users_dataGridView.TabIndex = 0;
            // 
            // Lista_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lista_users_dataGridView);
            this.Name = "Lista_Usuarios";
            this.Text = "Lista_Usuarios";
            this.Load += new System.EventHandler(this.Lista_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista_users_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lista_users_dataGridView;
    }
}