namespace PIA_MAD
{
    partial class FRM_ModificarContraseña
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
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Regresar = new System.Windows.Forms.Button();
            this.BTN_Actualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_Password
            // 
            this.TXT_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Password.Location = new System.Drawing.Point(207, 42);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.PasswordChar = '*';
            this.TXT_Password.Size = new System.Drawing.Size(199, 28);
            this.TXT_Password.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña nueva: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(207, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(199, 28);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Confirmar contraseña:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTN_Regresar
            // 
            this.BTN_Regresar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Regresar.Location = new System.Drawing.Point(202, 125);
            this.BTN_Regresar.Name = "BTN_Regresar";
            this.BTN_Regresar.Size = new System.Drawing.Size(97, 54);
            this.BTN_Regresar.TabIndex = 11;
            this.BTN_Regresar.Text = "Regresar";
            this.BTN_Regresar.UseVisualStyleBackColor = true;
            // 
            // BTN_Actualizar
            // 
            this.BTN_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Actualizar.Location = new System.Drawing.Point(88, 125);
            this.BTN_Actualizar.Name = "BTN_Actualizar";
            this.BTN_Actualizar.Size = new System.Drawing.Size(97, 54);
            this.BTN_Actualizar.TabIndex = 10;
            this.BTN_Actualizar.Text = "Actualizar";
            this.BTN_Actualizar.UseVisualStyleBackColor = true;
            // 
            // FRM_ModificarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 206);
            this.Controls.Add(this.BTN_Regresar);
            this.Controls.Add(this.BTN_Actualizar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_Password);
            this.Controls.Add(this.label2);
            this.Name = "FRM_ModificarContraseña";
            this.Text = "MODIFICAR CONTRASEÑA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Regresar;
        private System.Windows.Forms.Button BTN_Actualizar;
    }
}