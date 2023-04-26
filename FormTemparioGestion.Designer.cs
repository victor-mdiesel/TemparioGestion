namespace TemparioGestion
{
    partial class FormTemparioGestion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTemparioGestion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BotonEjecutar = new System.Windows.Forms.ToolStripButton();
            this.BotonCerrar = new System.Windows.Forms.ToolStripButton();
            this.GrillaResumen = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.ComboBox();
            this.GrillaDetalle = new System.Windows.Forms.DataGridView();
            this.MenuTemp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuAbrirTempario = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Seccion = new System.Windows.Forms.ComboBox();
            this.GrillaDetalleArmado = new System.Windows.Forms.DataGridView();
            this.GrillaRepuestos = new System.Windows.Forms.DataGridView();
            this.GrupoDet = new System.Windows.Forms.GroupBox();
            this.GrupoRep = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDetalle)).BeginInit();
            this.MenuTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDetalleArmado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRepuestos)).BeginInit();
            this.GrupoDet.SuspendLayout();
            this.GrupoRep.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BotonEjecutar,
            this.BotonCerrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1145, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BotonEjecutar
            // 
            this.BotonEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("BotonEjecutar.Image")));
            this.BotonEjecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonEjecutar.Name = "BotonEjecutar";
            this.BotonEjecutar.Size = new System.Drawing.Size(69, 22);
            this.BotonEjecutar.Text = "Ejecutar";
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCerrar.Image")));
            this.BotonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(59, 22);
            this.BotonCerrar.Text = "Cerrar";
            // 
            // GrillaResumen
            // 
            this.GrillaResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaResumen.Location = new System.Drawing.Point(0, 82);
            this.GrillaResumen.Name = "GrillaResumen";
            this.GrillaResumen.Size = new System.Drawing.Size(1145, 171);
            this.GrillaResumen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Marca";
            // 
            // Marca
            // 
            this.Marca.FormattingEnabled = true;
            this.Marca.Location = new System.Drawing.Point(100, 55);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(200, 21);
            this.Marca.TabIndex = 1;
            // 
            // GrillaDetalle
            // 
            this.GrillaDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDetalle.ContextMenuStrip = this.MenuTemp;
            this.GrillaDetalle.Location = new System.Drawing.Point(0, 12);
            this.GrillaDetalle.Name = "GrillaDetalle";
            this.GrillaDetalle.Size = new System.Drawing.Size(555, 217);
            this.GrillaDetalle.TabIndex = 33;
            // 
            // MenuTemp
            // 
            this.MenuTemp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbrirTempario});
            this.MenuTemp.Name = "MenuTemp";
            this.MenuTemp.Size = new System.Drawing.Size(152, 26);
            // 
            // MenuAbrirTempario
            // 
            this.MenuAbrirTempario.Name = "MenuAbrirTempario";
            this.MenuAbrirTempario.Size = new System.Drawing.Size(151, 22);
            this.MenuAbrirTempario.Text = "Abrir tempario";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1145, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Sección";
            // 
            // Seccion
            // 
            this.Seccion.FormattingEnabled = true;
            this.Seccion.Location = new System.Drawing.Point(100, 28);
            this.Seccion.Name = "Seccion";
            this.Seccion.Size = new System.Drawing.Size(200, 21);
            this.Seccion.TabIndex = 0;
            // 
            // GrillaDetalleArmado
            // 
            this.GrillaDetalleArmado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaDetalleArmado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDetalleArmado.ContextMenuStrip = this.MenuTemp;
            this.GrillaDetalleArmado.Location = new System.Drawing.Point(0, 235);
            this.GrillaDetalleArmado.Name = "GrillaDetalleArmado";
            this.GrillaDetalleArmado.Size = new System.Drawing.Size(555, 208);
            this.GrillaDetalleArmado.TabIndex = 37;
            // 
            // GrillaRepuestos
            // 
            this.GrillaRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaRepuestos.ContextMenuStrip = this.MenuTemp;
            this.GrillaRepuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaRepuestos.Location = new System.Drawing.Point(3, 16);
            this.GrillaRepuestos.Name = "GrillaRepuestos";
            this.GrillaRepuestos.Size = new System.Drawing.Size(432, 424);
            this.GrillaRepuestos.TabIndex = 38;
            // 
            // GrupoDet
            // 
            this.GrupoDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GrupoDet.Controls.Add(this.GrillaDetalle);
            this.GrupoDet.Controls.Add(this.GrillaDetalleArmado);
            this.GrupoDet.Location = new System.Drawing.Point(0, 259);
            this.GrupoDet.Name = "GrupoDet";
            this.GrupoDet.Size = new System.Drawing.Size(561, 449);
            this.GrupoDet.TabIndex = 39;
            this.GrupoDet.TabStop = false;
            // 
            // GrupoRep
            // 
            this.GrupoRep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GrupoRep.Controls.Add(this.GrillaRepuestos);
            this.GrupoRep.Location = new System.Drawing.Point(567, 259);
            this.GrupoRep.Name = "GrupoRep";
            this.GrupoRep.Size = new System.Drawing.Size(438, 443);
            this.GrupoRep.TabIndex = 40;
            this.GrupoRep.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Modelo";
            // 
            // Modelo
            // 
            this.Modelo.FormattingEnabled = true;
            this.Modelo.Location = new System.Drawing.Point(357, 55);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(200, 21);
            this.Modelo.TabIndex = 41;
            // 
            // FormTemparioGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 733);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.GrupoRep);
            this.Controls.Add(this.GrupoDet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Seccion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.GrillaResumen);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormTemparioGestion";
            this.Text = "Resumen Temparios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDetalle)).EndInit();
            this.MenuTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDetalleArmado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaRepuestos)).EndInit();
            this.GrupoDet.ResumeLayout(false);
            this.GrupoRep.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BotonEjecutar;
        private System.Windows.Forms.ToolStripButton BotonCerrar;
        private System.Windows.Forms.DataGridView GrillaResumen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Marca;
        private System.Windows.Forms.DataGridView GrillaDetalle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Seccion;
        private System.Windows.Forms.DataGridView GrillaDetalleArmado;
        private System.Windows.Forms.DataGridView GrillaRepuestos;
        private System.Windows.Forms.ContextMenuStrip MenuTemp;
        private System.Windows.Forms.ToolStripMenuItem MenuAbrirTempario;
        private System.Windows.Forms.GroupBox GrupoDet;
        private System.Windows.Forms.GroupBox GrupoRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Modelo;
    }
}

