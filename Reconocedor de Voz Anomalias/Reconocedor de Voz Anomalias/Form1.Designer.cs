namespace Reconocedor_de_Voz_Anomalias
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
            this.components = new System.ComponentModel.Container();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMecanica = new System.Windows.Forms.Button();
            this.btnOtro = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.btnElectrica = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(246, 421);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(140, 45);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(12, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 45);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnMecanica
            // 
            this.btnMecanica.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnMecanica.FlatAppearance.BorderSize = 3;
            this.btnMecanica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMecanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMecanica.Location = new System.Drawing.Point(105, 35);
            this.btnMecanica.Name = "btnMecanica";
            this.btnMecanica.Size = new System.Drawing.Size(193, 51);
            this.btnMecanica.TabIndex = 1;
            this.btnMecanica.Text = "Mecánica";
            this.btnMecanica.UseVisualStyleBackColor = true;
            this.btnMecanica.Click += new System.EventHandler(this.btnMecanica_Click);
            // 
            // btnOtro
            // 
            this.btnOtro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOtro.FlatAppearance.BorderSize = 3;
            this.btnOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtro.Location = new System.Drawing.Point(105, 337);
            this.btnOtro.Name = "btnOtro";
            this.btnOtro.Size = new System.Drawing.Size(193, 52);
            this.btnOtro.TabIndex = 4;
            this.btnOtro.Text = "Otra";
            this.btnOtro.UseVisualStyleBackColor = true;
            this.btnOtro.Click += new System.EventHandler(this.btnOtro_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.FlatAppearance.BorderSize = 3;
            this.btnSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.Location = new System.Drawing.Point(105, 233);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(193, 52);
            this.btnSeguridad.TabIndex = 3;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // btnElectrica
            // 
            this.btnElectrica.FlatAppearance.BorderSize = 3;
            this.btnElectrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElectrica.Location = new System.Drawing.Point(105, 135);
            this.btnElectrica.Name = "btnElectrica";
            this.btnElectrica.Size = new System.Drawing.Size(193, 52);
            this.btnElectrica.TabIndex = 2;
            this.btnElectrica.Text = "Eléctrica";
            this.btnElectrica.UseVisualStyleBackColor = true;
            this.btnElectrica.Click += new System.EventHandler(this.btnElectrica_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(396, 478);
            this.Controls.Add(this.btnMecanica);
            this.Controls.Add(this.btnOtro);
            this.Controls.Add(this.btnSeguridad);
            this.Controls.Add(this.btnElectrica);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMecanica;
        private System.Windows.Forms.Button btnOtro;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Button btnElectrica;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

