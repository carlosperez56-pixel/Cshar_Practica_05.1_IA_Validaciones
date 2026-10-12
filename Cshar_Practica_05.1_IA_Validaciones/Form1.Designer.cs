
namespace Cshar_Practica_05._1_IA_Validaciones
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
            this.butlimpiar = new System.Windows.Forms.Button();
            this.butguardar = new System.Windows.Forms.Button();
            this.groupgenero = new System.Windows.Forms.GroupBox();
            this.radotro = new System.Windows.Forms.RadioButton();
            this.radfeme = new System.Windows.Forms.RadioButton();
            this.radMascu = new System.Windows.Forms.RadioButton();
            this.texestatura = new System.Windows.Forms.TextBox();
            this.texedad = new System.Windows.Forms.TextBox();
            this.textelefono = new System.Windows.Forms.TextBox();
            this.texapellido = new System.Windows.Forms.TextBox();
            this.texnombres = new System.Windows.Forms.TextBox();
            this.lblestatura = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.groupgenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // butlimpiar
            // 
            this.butlimpiar.BackColor = System.Drawing.Color.Aqua;
            this.butlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlimpiar.Location = new System.Drawing.Point(322, 361);
            this.butlimpiar.Name = "butlimpiar";
            this.butlimpiar.Size = new System.Drawing.Size(126, 56);
            this.butlimpiar.TabIndex = 25;
            this.butlimpiar.Text = "Limpiar";
            this.butlimpiar.UseVisualStyleBackColor = false;
            // 
            // butguardar
            // 
            this.butguardar.BackColor = System.Drawing.Color.Aqua;
            this.butguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butguardar.Location = new System.Drawing.Point(179, 361);
            this.butguardar.Name = "butguardar";
            this.butguardar.Size = new System.Drawing.Size(115, 56);
            this.butguardar.TabIndex = 24;
            this.butguardar.Text = "Guardar";
            this.butguardar.UseVisualStyleBackColor = false;
            // 
            // groupgenero
            // 
            this.groupgenero.BackColor = System.Drawing.Color.DarkGray;
            this.groupgenero.Controls.Add(this.radotro);
            this.groupgenero.Controls.Add(this.radfeme);
            this.groupgenero.Controls.Add(this.radMascu);
            this.groupgenero.Location = new System.Drawing.Point(167, 243);
            this.groupgenero.Name = "groupgenero";
            this.groupgenero.Size = new System.Drawing.Size(322, 93);
            this.groupgenero.TabIndex = 23;
            this.groupgenero.TabStop = false;
            this.groupgenero.Text = "Genero";
            this.groupgenero.Enter += new System.EventHandler(this.groupgenero_Enter);
            // 
            // radotro
            // 
            this.radotro.AutoSize = true;
            this.radotro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radotro.Location = new System.Drawing.Point(253, 45);
            this.radotro.Name = "radotro";
            this.radotro.Size = new System.Drawing.Size(61, 21);
            this.radotro.TabIndex = 2;
            this.radotro.TabStop = true;
            this.radotro.Text = "Otro";
            this.radotro.UseVisualStyleBackColor = true;
            // 
            // radfeme
            // 
            this.radfeme.AutoSize = true;
            this.radfeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radfeme.Location = new System.Drawing.Point(136, 45);
            this.radfeme.Name = "radfeme";
            this.radfeme.Size = new System.Drawing.Size(99, 21);
            this.radfeme.TabIndex = 1;
            this.radfeme.TabStop = true;
            this.radfeme.Text = "Femenino";
            this.radfeme.UseVisualStyleBackColor = true;
            // 
            // radMascu
            // 
            this.radMascu.AutoSize = true;
            this.radMascu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMascu.Location = new System.Drawing.Point(0, 45);
            this.radMascu.Name = "radMascu";
            this.radMascu.Size = new System.Drawing.Size(101, 21);
            this.radMascu.TabIndex = 0;
            this.radMascu.TabStop = true;
            this.radMascu.Text = "Masculino";
            this.radMascu.UseVisualStyleBackColor = true;
            // 
            // texestatura
            // 
            this.texestatura.Location = new System.Drawing.Point(306, 194);
            this.texestatura.Name = "texestatura";
            this.texestatura.Size = new System.Drawing.Size(142, 22);
            this.texestatura.TabIndex = 22;
            // 
            // texedad
            // 
            this.texedad.Location = new System.Drawing.Point(306, 153);
            this.texedad.Name = "texedad";
            this.texedad.Size = new System.Drawing.Size(142, 22);
            this.texedad.TabIndex = 21;
            // 
            // textelefono
            // 
            this.textelefono.Location = new System.Drawing.Point(306, 105);
            this.textelefono.Name = "textelefono";
            this.textelefono.Size = new System.Drawing.Size(142, 22);
            this.textelefono.TabIndex = 20;
            // 
            // texapellido
            // 
            this.texapellido.Location = new System.Drawing.Point(306, 65);
            this.texapellido.Name = "texapellido";
            this.texapellido.Size = new System.Drawing.Size(142, 22);
            this.texapellido.TabIndex = 19;
            // 
            // texnombres
            // 
            this.texnombres.Location = new System.Drawing.Point(306, 29);
            this.texnombres.Name = "texnombres";
            this.texnombres.Size = new System.Drawing.Size(142, 22);
            this.texnombres.TabIndex = 18;
            // 
            // lblestatura
            // 
            this.lblestatura.AutoSize = true;
            this.lblestatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestatura.Location = new System.Drawing.Point(196, 194);
            this.lblestatura.Name = "lblestatura";
            this.lblestatura.Size = new System.Drawing.Size(92, 20);
            this.lblestatura.TabIndex = 17;
            this.lblestatura.Text = "Estatura: ";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(196, 153);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(63, 20);
            this.lbledad.TabIndex = 16;
            this.lbledad.Text = "Edad: ";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.BackColor = System.Drawing.Color.IndianRed;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltelefono.Location = new System.Drawing.Point(196, 110);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(93, 20);
            this.lbltelefono.TabIndex = 15;
            this.lbltelefono.Text = "Telefono: ";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(196, 65);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(98, 20);
            this.lblapellido.TabIndex = 14;
            this.lblapellido.Text = "Apellidos: ";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombres.Location = new System.Drawing.Point(196, 29);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(96, 20);
            this.lblnombres.TabIndex = 13;
            this.lblnombres.Text = "Nombres: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butlimpiar);
            this.Controls.Add(this.butguardar);
            this.Controls.Add(this.groupgenero);
            this.Controls.Add(this.texestatura);
            this.Controls.Add(this.texedad);
            this.Controls.Add(this.textelefono);
            this.Controls.Add(this.texapellido);
            this.Controls.Add(this.texnombres);
            this.Controls.Add(this.lblestatura);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombres);
            this.Name = "Form1";
            this.Text = "Validación _ IA";
            this.groupgenero.ResumeLayout(false);
            this.groupgenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butlimpiar;
        private System.Windows.Forms.Button butguardar;
        private System.Windows.Forms.GroupBox groupgenero;
        private System.Windows.Forms.RadioButton radotro;
        private System.Windows.Forms.RadioButton radfeme;
        private System.Windows.Forms.RadioButton radMascu;
        private System.Windows.Forms.TextBox texestatura;
        private System.Windows.Forms.TextBox texedad;
        private System.Windows.Forms.TextBox textelefono;
        private System.Windows.Forms.TextBox texapellido;
        private System.Windows.Forms.TextBox texnombres;
        private System.Windows.Forms.Label lblestatura;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblnombres;
    }
}

