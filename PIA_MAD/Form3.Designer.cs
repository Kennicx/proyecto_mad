namespace PIA_MAD
{
    partial class FRM_Biblia
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
            this.TXT_Busqueda = new System.Windows.Forms.TextBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.CB_Idiomas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Version = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Testamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Libro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_Versiculo = new System.Windows.Forms.ComboBox();
            this.DGV_Consulta = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TXT_Pasaje = new System.Windows.Forms.TextBox();
            this.MENU = new System.Windows.Forms.MenuStrip();
            this.M_Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.M_ModificarContra = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Historial = new System.Windows.Forms.ToolStripMenuItem();
            this.M_Favoritos = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Consulta)).BeginInit();
            this.MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_Busqueda
            // 
            this.TXT_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Busqueda.Location = new System.Drawing.Point(38, 57);
            this.TXT_Busqueda.Name = "TXT_Busqueda";
            this.TXT_Busqueda.Size = new System.Drawing.Size(469, 26);
            this.TXT_Busqueda.TabIndex = 0;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Buscar.Location = new System.Drawing.Point(513, 57);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(79, 26);
            this.BTN_Buscar.TabIndex = 1;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            // 
            // CB_Idiomas
            // 
            this.CB_Idiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Idiomas.FormattingEnabled = true;
            this.CB_Idiomas.Location = new System.Drawing.Point(9, 131);
            this.CB_Idiomas.Name = "CB_Idiomas";
            this.CB_Idiomas.Size = new System.Drawing.Size(106, 28);
            this.CB_Idiomas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Idioma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Version:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CB_Version
            // 
            this.CB_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Version.FormattingEnabled = true;
            this.CB_Version.Location = new System.Drawing.Point(121, 131);
            this.CB_Version.Name = "CB_Version";
            this.CB_Version.Size = new System.Drawing.Size(106, 28);
            this.CB_Version.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Testamento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CB_Testamento
            // 
            this.CB_Testamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Testamento.FormattingEnabled = true;
            this.CB_Testamento.Location = new System.Drawing.Point(233, 131);
            this.CB_Testamento.Name = "CB_Testamento";
            this.CB_Testamento.Size = new System.Drawing.Size(106, 28);
            this.CB_Testamento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Libro:";
            // 
            // CB_Libro
            // 
            this.CB_Libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Libro.FormattingEnabled = true;
            this.CB_Libro.Location = new System.Drawing.Point(345, 131);
            this.CB_Libro.Name = "CB_Libro";
            this.CB_Libro.Size = new System.Drawing.Size(106, 28);
            this.CB_Libro.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Versiculo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CB_Versiculo
            // 
            this.CB_Versiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Versiculo.FormattingEnabled = true;
            this.CB_Versiculo.Location = new System.Drawing.Point(458, 131);
            this.CB_Versiculo.Name = "CB_Versiculo";
            this.CB_Versiculo.Size = new System.Drawing.Size(106, 28);
            this.CB_Versiculo.TabIndex = 12;
            // 
            // DGV_Consulta
            // 
            this.DGV_Consulta.AllowUserToAddRows = false;
            this.DGV_Consulta.AllowUserToDeleteRows = false;
            this.DGV_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Consulta.Location = new System.Drawing.Point(8, 174);
            this.DGV_Consulta.Name = "DGV_Consulta";
            this.DGV_Consulta.ReadOnly = true;
            this.DGV_Consulta.Size = new System.Drawing.Size(662, 588);
            this.DGV_Consulta.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(676, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 62);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ver Pasaje";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(676, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 62);
            this.button2.TabIndex = 16;
            this.button2.Text = "Añadir a Favoritos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TXT_Pasaje
            // 
            this.TXT_Pasaje.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TXT_Pasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Pasaje.HideSelection = false;
            this.TXT_Pasaje.Location = new System.Drawing.Point(802, 174);
            this.TXT_Pasaje.Multiline = true;
            this.TXT_Pasaje.Name = "TXT_Pasaje";
            this.TXT_Pasaje.ReadOnly = true;
            this.TXT_Pasaje.Size = new System.Drawing.Size(413, 588);
            this.TXT_Pasaje.TabIndex = 17;
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
            this.MENU.Size = new System.Drawing.Size(1227, 29);
            this.MENU.TabIndex = 18;
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
            // M_ModificarContra
            // 
            this.M_ModificarContra.Name = "M_ModificarContra";
            this.M_ModificarContra.Size = new System.Drawing.Size(229, 26);
            this.M_ModificarContra.Text = "Modificar Contraseña";
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
            // FRM_Biblia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 795);
            this.Controls.Add(this.TXT_Pasaje);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_Consulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB_Versiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Libro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Testamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Idiomas);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.TXT_Busqueda);
            this.Controls.Add(this.MENU);
            this.MainMenuStrip = this.MENU;
            this.Name = "FRM_Biblia";
            this.Text = "BIBLIA";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Consulta)).EndInit();
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Busqueda;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.ComboBox CB_Idiomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Version;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Testamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Libro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_Versiculo;
        private System.Windows.Forms.DataGridView DGV_Consulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TXT_Pasaje;
        private System.Windows.Forms.MenuStrip MENU;
        private System.Windows.Forms.ToolStripMenuItem M_Inicio;
        private System.Windows.Forms.ToolStripMenuItem M_Perfil;
        private System.Windows.Forms.ToolStripMenuItem M_Historial;
        private System.Windows.Forms.ToolStripMenuItem M_Favoritos;
        private System.Windows.Forms.ToolStripMenuItem M_ModificarContra;
    }
}