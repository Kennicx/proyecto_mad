namespace PIA_MAD
{
    partial class FRM_Favoritos
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
            this.DGV_Favoritos = new System.Windows.Forms.DataGridView();
            this.TXT_Favorito = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MENU = new System.Windows.Forms.MenuStrip();
            this.M_Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Historial = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Favoritos = new System.Windows.Forms.ToolStripMenuItem();
            this.M_ModificarContra = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Favoritos)).BeginInit();
            this.MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Favoritos
            // 
            this.DGV_Favoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Favoritos.Location = new System.Drawing.Point(12, 50);
            this.DGV_Favoritos.Name = "DGV_Favoritos";
            this.DGV_Favoritos.Size = new System.Drawing.Size(458, 487);
            this.DGV_Favoritos.TabIndex = 0;
            // 
            // TXT_Favorito
            // 
            this.TXT_Favorito.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TXT_Favorito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Favorito.HideSelection = false;
            this.TXT_Favorito.Location = new System.Drawing.Point(602, 50);
            this.TXT_Favorito.Multiline = true;
            this.TXT_Favorito.Name = "TXT_Favorito";
            this.TXT_Favorito.ReadOnly = true;
            this.TXT_Favorito.Size = new System.Drawing.Size(318, 487);
            this.TXT_Favorito.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(476, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 62);
            this.button2.TabIndex = 19;
            this.button2.Text = "Eliminar Favorito";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(476, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 62);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ver Favorito";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MENU
            // 
            this.MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_Inicio,
            this.M_Perfil,
            this.M_Historial,
            this.M_Favoritos});
            this.MENU.Location = new System.Drawing.Point(0, 0);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(943, 29);
            this.MENU.TabIndex = 21;
            this.MENU.Text = "MENU";
            // 
            // M_Inicio
            // 
            this.M_Inicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Inicio.Name = "M_Inicio";
            this.M_Inicio.Size = new System.Drawing.Size(59, 25);
            this.M_Inicio.Text = "Inicio";
            // 
            // M_Perfil
            // 
            this.M_Perfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_ModificarContra});
            this.M_Perfil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Perfil.Name = "M_Perfil";
            this.M_Perfil.Size = new System.Drawing.Size(57, 25);
            this.M_Perfil.Text = "Perfil";
            // 
            // M_Historial
            // 
            this.M_Historial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Historial.Name = "M_Historial";
            this.M_Historial.Size = new System.Drawing.Size(80, 25);
            this.M_Historial.Text = "Historial";
            // 
            // M_Favoritos
            // 
            this.M_Favoritos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_Favoritos.Name = "M_Favoritos";
            this.M_Favoritos.Size = new System.Drawing.Size(85, 25);
            this.M_Favoritos.Text = "Favoritos";
            // 
            // M_ModificarContra
            // 
            this.M_ModificarContra.Name = "M_ModificarContra";
            this.M_ModificarContra.Size = new System.Drawing.Size(229, 26);
            this.M_ModificarContra.Text = "Modificar Contraseña";
            // 
            // FRM_Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 573);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.TXT_Favorito);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_Favoritos);
            this.Name = "FRM_Favoritos";
            this.Text = "FAVORITOS";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Favoritos)).EndInit();
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Favoritos;
        private System.Windows.Forms.TextBox TXT_Favorito;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip MENU;
        private System.Windows.Forms.ToolStripMenuItem M_Inicio;
        private System.Windows.Forms.ToolStripMenuItem M_Perfil;
        private System.Windows.Forms.ToolStripMenuItem M_Historial;
        private System.Windows.Forms.ToolStripMenuItem M_Favoritos;
        private System.Windows.Forms.ToolStripMenuItem M_ModificarContra;
    }
}