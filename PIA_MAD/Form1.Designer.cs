namespace PIA_MAD
{
    partial class FRM_Login
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
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_Registro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Login
            // 
            this.BTN_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.Location = new System.Drawing.Point(39, 123);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(97, 54);
            this.BTN_Login.TabIndex = 0;
            this.BTN_Login.Text = "Iniciar Sesion";
            this.BTN_Login.UseVisualStyleBackColor = true;
            // 
            // BTN_Registro
            // 
            this.BTN_Registro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Registro.Location = new System.Drawing.Point(153, 123);
            this.BTN_Registro.Name = "BTN_Registro";
            this.BTN_Registro.Size = new System.Drawing.Size(97, 54);
            this.BTN_Registro.TabIndex = 1;
            this.BTN_Registro.Text = "Registrar";
            this.BTN_Registro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Usuario.Location = new System.Drawing.Point(142, 36);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(140, 28);
            this.TXT_Usuario.TabIndex = 4;
            // 
            // TXT_Password
            // 
            this.TXT_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Password.Location = new System.Drawing.Point(142, 74);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.PasswordChar = '*';
            this.TXT_Password.Size = new System.Drawing.Size(140, 28);
            this.TXT_Password.TabIndex = 5;
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 211);
            this.Controls.Add(this.TXT_Password);
            this.Controls.Add(this.TXT_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Registro);
            this.Controls.Add(this.BTN_Login);
            this.Name = "FRM_Login";
            this.Text = "BIENVENIDO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_Registro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Password;
    }
}

