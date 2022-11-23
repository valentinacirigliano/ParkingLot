namespace Parking.Windows
{
    partial class FrmLugares
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrillaPanel = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.RefrescarButton = new FontAwesome.Sharp.IconButton();
            this.LugaresLibresButton = new FontAwesome.Sharp.IconButton();
            this.VerEnGarage = new FontAwesome.Sharp.IconButton();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.TextoLabel = new System.Windows.Forms.Label();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.IngresarIconButton = new FontAwesome.Sharp.IconButton();
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
            this.GrillaPanel.Size = new System.Drawing.Size(837, 350);
            this.GrillaPanel.TabIndex = 5;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLugar,
            this.colNivel,
            this.colTipoLugar});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(837, 350);
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
            // colNivel
            // 
            this.colNivel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNivel.HeaderText = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colNivel.ReadOnly = true;
            // 
            // colTipoLugar
            // 
            this.colTipoLugar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTipoLugar.HeaderText = "Tipo";
            this.colTipoLugar.Name = "colTipoLugar";
            this.colTipoLugar.ReadOnly = true;
            this.colTipoLugar.Width = 64;
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.LightGray;
            this.ToolBarPanel.Controls.Add(this.RefrescarButton);
            this.ToolBarPanel.Controls.Add(this.LugaresLibresButton);
            this.ToolBarPanel.Controls.Add(this.VerEnGarage);
            this.ToolBarPanel.Controls.Add(this.cantidadLabel);
            this.ToolBarPanel.Controls.Add(this.TextoLabel);
            this.ToolBarPanel.Controls.Add(this.BorrarIconButton);
            this.ToolBarPanel.Controls.Add(this.IngresarIconButton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(837, 100);
            this.ToolBarPanel.TabIndex = 4;
            // 
            // RefrescarButton
            // 
            this.RefrescarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefrescarButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.RefrescarButton.IconColor = System.Drawing.Color.DimGray;
            this.RefrescarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefrescarButton.Location = new System.Drawing.Point(486, 19);
            this.RefrescarButton.Name = "RefrescarButton";
            this.RefrescarButton.Size = new System.Drawing.Size(76, 63);
            this.RefrescarButton.TabIndex = 8;
            this.RefrescarButton.Text = "Todos";
            this.RefrescarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefrescarButton.UseVisualStyleBackColor = true;
            this.RefrescarButton.Click += new System.EventHandler(this.RefrescarButton_Click);
            // 
            // LugaresLibresButton
            // 
            this.LugaresLibresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LugaresLibresButton.IconChar = FontAwesome.Sharp.IconChar.ArrowUpShortWide;
            this.LugaresLibresButton.IconColor = System.Drawing.Color.DimGray;
            this.LugaresLibresButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LugaresLibresButton.Location = new System.Drawing.Point(322, 19);
            this.LugaresLibresButton.Name = "LugaresLibresButton";
            this.LugaresLibresButton.Size = new System.Drawing.Size(76, 63);
            this.LugaresLibresButton.TabIndex = 8;
            this.LugaresLibresButton.Text = "Libres";
            this.LugaresLibresButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LugaresLibresButton.UseVisualStyleBackColor = true;
            this.LugaresLibresButton.Click += new System.EventHandler(this.LugaresLibresButton_Click);
            // 
            // VerEnGarage
            // 
            this.VerEnGarage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerEnGarage.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.VerEnGarage.IconColor = System.Drawing.Color.DimGray;
            this.VerEnGarage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VerEnGarage.Location = new System.Drawing.Point(404, 19);
            this.VerEnGarage.Name = "VerEnGarage";
            this.VerEnGarage.Size = new System.Drawing.Size(76, 63);
            this.VerEnGarage.TabIndex = 8;
            this.VerEnGarage.Text = "Ocupados";
            this.VerEnGarage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VerEnGarage.UseVisualStyleBackColor = true;
            this.VerEnGarage.Click += new System.EventHandler(this.VerEnGarage_Click);
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadLabel.Location = new System.Drawing.Point(808, 19);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(17, 17);
            this.cantidadLabel.TabIndex = 7;
            this.cantidadLabel.Text = "0";
            // 
            // TextoLabel
            // 
            this.TextoLabel.AutoSize = true;
            this.TextoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoLabel.Location = new System.Drawing.Point(596, 19);
            this.TextoLabel.Name = "TextoLabel";
            this.TextoLabel.Size = new System.Drawing.Size(89, 17);
            this.TextoLabel.TabIndex = 7;
            this.TextoLabel.Text = "Ubicaciones:";
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarIconButton.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.BorrarIconButton.IconColor = System.Drawing.Color.Red;
            this.BorrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarIconButton.Location = new System.Drawing.Point(138, 19);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(97, 63);
            this.BorrarIconButton.TabIndex = 6;
            this.BorrarIconButton.Text = "Retirar";
            this.BorrarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarIconButton.UseVisualStyleBackColor = true;
            this.BorrarIconButton.Click += new System.EventHandler(this.BorrarIconButton_Click);
            // 
            // IngresarIconButton
            // 
            this.IngresarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngresarIconButton.IconChar = FontAwesome.Sharp.IconChar.CarOn;
            this.IngresarIconButton.IconColor = System.Drawing.Color.LimeGreen;
            this.IngresarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IngresarIconButton.Location = new System.Drawing.Point(13, 19);
            this.IngresarIconButton.Name = "IngresarIconButton";
            this.IngresarIconButton.Size = new System.Drawing.Size(97, 63);
            this.IngresarIconButton.TabIndex = 5;
            this.IngresarIconButton.Text = "Ingresar";
            this.IngresarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IngresarIconButton.UseVisualStyleBackColor = true;
            this.IngresarIconButton.Click += new System.EventHandler(this.IngresarIconButton_Click);
            // 
            // FrmLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.GrillaPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.Name = "FrmLugares";
            this.Text = "FrmLugares";
            this.Load += new System.EventHandler(this.FrmLugares_Load);
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
        private FontAwesome.Sharp.IconButton IngresarIconButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoLugar;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label TextoLabel;
        private FontAwesome.Sharp.IconButton VerEnGarage;
        private FontAwesome.Sharp.IconButton RefrescarButton;
        private FontAwesome.Sharp.IconButton LugaresLibresButton;
    }
}