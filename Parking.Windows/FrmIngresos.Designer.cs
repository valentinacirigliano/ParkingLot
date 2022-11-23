namespace Parking.Windows
{
    partial class FrmIngresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrillaPanel = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.RefrescarButton = new FontAwesome.Sharp.IconButton();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.TextoLabel = new System.Windows.Forms.Label();
            this.VerEnGarage = new FontAwesome.Sharp.IconButton();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.BuscarPatente = new FontAwesome.Sharp.IconButton();
            this.GrillaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.ToolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaPanel
            // 
            this.GrillaPanel.Controls.Add(this.DatosDataGridView);
            this.GrillaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaPanel.Location = new System.Drawing.Point(0, 100);
            this.GrillaPanel.Name = "GrillaPanel";
            this.GrillaPanel.Size = new System.Drawing.Size(865, 350);
            this.GrillaPanel.TabIndex = 7;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLugar,
            this.colPatente,
            this.colFecha,
            this.colTipoVehiculo});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(865, 350);
            this.DatosDataGridView.TabIndex = 1;
            this.DatosDataGridView.SelectionChanged += new System.EventHandler(this.DatosDataGridView_SelectionChanged);
            // 
            // colLugar
            // 
            this.colLugar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLugar.HeaderText = "Lugar";
            this.colLugar.Name = "colLugar";
            this.colLugar.ReadOnly = true;
            // 
            // colPatente
            // 
            this.colPatente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPatente.HeaderText = "Patente";
            this.colPatente.Name = "colPatente";
            this.colPatente.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFecha.HeaderText = "Fecha Ingreso";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colTipoVehiculo
            // 
            this.colTipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoVehiculo.HeaderText = "Tipo de vehículo";
            this.colTipoVehiculo.Name = "colTipoVehiculo";
            this.colTipoVehiculo.ReadOnly = true;
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.LightGray;
            this.ToolBarPanel.Controls.Add(this.RefrescarButton);
            this.ToolBarPanel.Controls.Add(this.CantidadLabel);
            this.ToolBarPanel.Controls.Add(this.TextoLabel);
            this.ToolBarPanel.Controls.Add(this.BuscarPatente);
            this.ToolBarPanel.Controls.Add(this.VerEnGarage);
            this.ToolBarPanel.Controls.Add(this.BorrarIconButton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(865, 100);
            this.ToolBarPanel.TabIndex = 6;
            // 
            // RefrescarButton
            // 
            this.RefrescarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefrescarButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.RefrescarButton.IconColor = System.Drawing.Color.DimGray;
            this.RefrescarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefrescarButton.Location = new System.Drawing.Point(476, 19);
            this.RefrescarButton.Name = "RefrescarButton";
            this.RefrescarButton.Size = new System.Drawing.Size(76, 63);
            this.RefrescarButton.TabIndex = 10;
            this.RefrescarButton.Text = "Todos";
            this.RefrescarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefrescarButton.UseVisualStyleBackColor = true;
            this.RefrescarButton.Click += new System.EventHandler(this.RefrescarButton_Click);
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(733, 19);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(17, 17);
            this.CantidadLabel.TabIndex = 8;
            this.CantidadLabel.Text = "0";
            // 
            // TextoLabel
            // 
            this.TextoLabel.AutoSize = true;
            this.TextoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoLabel.Location = new System.Drawing.Point(580, 19);
            this.TextoLabel.Name = "TextoLabel";
            this.TextoLabel.Size = new System.Drawing.Size(147, 17);
            this.TextoLabel.TabIndex = 9;
            this.TextoLabel.Text = "Vehículos ingresados:";
            // 
            // VerEnGarage
            // 
            this.VerEnGarage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerEnGarage.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.VerEnGarage.IconColor = System.Drawing.Color.DimGray;
            this.VerEnGarage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VerEnGarage.Location = new System.Drawing.Point(394, 19);
            this.VerEnGarage.Name = "VerEnGarage";
            this.VerEnGarage.Size = new System.Drawing.Size(76, 63);
            this.VerEnGarage.TabIndex = 6;
            this.VerEnGarage.Text = "En garage";
            this.VerEnGarage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VerEnGarage.UseVisualStyleBackColor = true;
            this.VerEnGarage.Click += new System.EventHandler(this.VerEnGarage_Click);
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarIconButton.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.BorrarIconButton.IconColor = System.Drawing.Color.Red;
            this.BorrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarIconButton.Location = new System.Drawing.Point(28, 19);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(97, 63);
            this.BorrarIconButton.TabIndex = 6;
            this.BorrarIconButton.Text = "Retirar";
            this.BorrarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarIconButton.UseVisualStyleBackColor = true;
            this.BorrarIconButton.Click += new System.EventHandler(this.BorrarIconButton_Click);
            // 
            // BuscarPatente
            // 
            this.BuscarPatente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarPatente.IconChar = FontAwesome.Sharp.IconChar.IdCardClip;
            this.BuscarPatente.IconColor = System.Drawing.Color.DimGray;
            this.BuscarPatente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuscarPatente.Location = new System.Drawing.Point(312, 19);
            this.BuscarPatente.Name = "BuscarPatente";
            this.BuscarPatente.Size = new System.Drawing.Size(76, 63);
            this.BuscarPatente.TabIndex = 6;
            this.BuscarPatente.Text = "Patente";
            this.BuscarPatente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarPatente.UseVisualStyleBackColor = true;
            this.BuscarPatente.Click += new System.EventHandler(this.BuscarPatente_Click);
            // 
            // FrmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.GrillaPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.Name = "FrmIngresos";
            this.Text = "FrmIngresos";
            this.Load += new System.EventHandler(this.FrmIngresos_Load);
            this.GrillaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ToolBarPanel.ResumeLayout(false);
            this.ToolBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GrillaPanel;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Panel ToolBarPanel;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoVehiculo;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.Label TextoLabel;
        private FontAwesome.Sharp.IconButton VerEnGarage;
        private FontAwesome.Sharp.IconButton RefrescarButton;
        private FontAwesome.Sharp.IconButton BuscarPatente;
    }
}