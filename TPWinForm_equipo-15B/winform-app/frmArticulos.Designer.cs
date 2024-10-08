﻿namespace winform_app
{
    partial class frmArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Tbusqueda = new System.Windows.Forms.TextBox();
            this.LBusqueda = new System.Windows.Forms.Label();
            this.CBcampo = new System.Windows.Forms.ComboBox();
            this.LbCampo = new System.Windows.Forms.Label();
            this.CbCriterio = new System.Windows.Forms.ComboBox();
            this.LbCriterio = new System.Windows.Forms.Label();
            this.LbFiltro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(17, 88);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(605, 296);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgbArticulos_SelectionChanged);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbArticulo.Location = new System.Drawing.Point(625, 88);
            this.pbArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(391, 296);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbArticulo.TabIndex = 1;
            this.pbArticulo.TabStop = false;
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCatalogo.Location = new System.Drawing.Point(19, 12);
            this.lblCatalogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(126, 25);
            this.lblCatalogo.TabIndex = 2;
            this.lblCatalogo.Text = "CATALOGO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 402);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Tbusqueda
            // 
            this.Tbusqueda.Location = new System.Drawing.Point(87, 63);
            this.Tbusqueda.Name = "Tbusqueda";
            this.Tbusqueda.Size = new System.Drawing.Size(207, 20);
            this.Tbusqueda.TabIndex = 4;
            this.Tbusqueda.UseWaitCursor = true;
            this.Tbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbusqueda_KeyPress);
            // 
            // LBusqueda
            // 
            this.LBusqueda.AutoSize = true;
            this.LBusqueda.Location = new System.Drawing.Point(26, 70);
            this.LBusqueda.Name = "LBusqueda";
            this.LBusqueda.Size = new System.Drawing.Size(55, 13);
            this.LBusqueda.TabIndex = 5;
            this.LBusqueda.Text = "Busqueda";
            // 
            // CBcampo
            // 
            this.CBcampo.FormattingEnabled = true;
            this.CBcampo.Location = new System.Drawing.Point(113, 436);
            this.CBcampo.Name = "CBcampo";
            this.CBcampo.Size = new System.Drawing.Size(121, 21);
            this.CBcampo.TabIndex = 6;
            // 
            // LbCampo
            // 
            this.LbCampo.AutoSize = true;
            this.LbCampo.Location = new System.Drawing.Point(72, 439);
            this.LbCampo.Name = "LbCampo";
            this.LbCampo.Size = new System.Drawing.Size(43, 13);
            this.LbCampo.TabIndex = 7;
            this.LbCampo.Text = "Campo:";
            // 
            // CbCriterio
            // 
            this.CbCriterio.FormattingEnabled = true;
            this.CbCriterio.Location = new System.Drawing.Point(344, 435);
            this.CbCriterio.Name = "CbCriterio";
            this.CbCriterio.Size = new System.Drawing.Size(121, 21);
            this.CbCriterio.TabIndex = 8;
            this.CbCriterio.SelectedIndexChanged += new System.EventHandler(this.CbCriterio_SelectedIndexChanged);
            // 
            // LbCriterio
            // 
            this.LbCriterio.AutoSize = true;
            this.LbCriterio.Location = new System.Drawing.Point(296, 439);
            this.LbCriterio.Name = "LbCriterio";
            this.LbCriterio.Size = new System.Drawing.Size(42, 13);
            this.LbCriterio.TabIndex = 9;
            this.LbCriterio.Text = "Criterio:";
            // 
            // LbFiltro
            // 
            this.LbFiltro.AutoSize = true;
            this.LbFiltro.Location = new System.Drawing.Point(523, 439);
            this.LbFiltro.Name = "LbFiltro";
            this.LbFiltro.Size = new System.Drawing.Size(35, 13);
            this.LbFiltro.TabIndex = 10;
            this.LbFiltro.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(564, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 11;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(708, 426);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(96, 38);
            this.BotonBuscar.TabIndex = 12;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 469);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LbFiltro);
            this.Controls.Add(this.LbCriterio);
            this.Controls.Add(this.CbCriterio);
            this.Controls.Add(this.LbCampo);
            this.Controls.Add(this.CBcampo);
            this.Controls.Add(this.LBusqueda);
            this.Controls.Add(this.Tbusqueda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(915, 476);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox Tbusqueda;
        private System.Windows.Forms.Label LBusqueda;
        private System.Windows.Forms.ComboBox CBcampo;
        private System.Windows.Forms.Label LbCampo;
        private System.Windows.Forms.ComboBox CbCriterio;
        private System.Windows.Forms.Label LbCriterio;
        private System.Windows.Forms.Label LbFiltro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BotonBuscar;
    }
}