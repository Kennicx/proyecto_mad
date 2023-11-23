namespace PIA_MAD
{
    partial class FRM_Historial
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
            this.DGV_Historial = new System.Windows.Forms.DataGridView();
            this.MENU = new System.Windows.Forms.MenuStrip();
            this.M_Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Historial = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Favoritos = new System.Windows.Forms.ToolStripMenuItem();
            this.M_ModificarContra = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historial)).BeginInit();
            this.MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Historial
            // 
            this.DGV_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Historial.Location = new System.Drawing.Point(12, 44);
            this.DGV_Historial.Name = "DGV_Historial";
            this.DGV_Historial.Size = new System.Drawing.Size(773, 484);
            this.DGV_Historial.TabIndex = 1;
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
            this.MENU.Size = new System.Drawing.Size(797, 29);
            this.MENU.TabIndex = 19;
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
            this.M_ModificarContra.Size = new System.Drawing.Size(197, 26);
            this.M_ModificarContra.Text = "Modificar Contra";
            // 
            // FRM_Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 540);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.DGV_Historial);
            this.Name = "FRM_Historial";
            this.Text = "HISTORIAL";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historial)).EndInit();
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Historial;
        private System.Windows.Forms.MenuStrip MENU;
        private System.Windows.Forms.ToolStripMenuItem M_Inicio;
        private System.Windows.Forms.ToolStripMenuItem M_Perfil;
        private System.Windows.Forms.ToolStripMenuItem M_Historial;
        private System.Windows.Forms.ToolStripMenuItem M_Favoritos;
        private System.Windows.Forms.ToolStripMenuItem M_ModificarContra;
    }
}