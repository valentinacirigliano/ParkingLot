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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrillaPanel = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.UltimoIconButton = new FontAwesome.Sharp.IconButton();
            this.SiguienteIconButton = new FontAwesome.Sharp.IconButton();
            this.AnteriorIconButton = new FontAwesome.Sharp.IconButton();
            this.PrimeroIconButton = new FontAwesome.Sharp.IconButton();
            this.FiltroIconButton = new FontAwesome.Sharp.IconButton();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.ToolBarPanel.Controls.Add(this.BorrarIconButton);
            this.ToolBarPanel.Controls.Add(this.UltimoIconButton);
            this.ToolBarPanel.Controls.Add(this.SiguienteIconButton);
            this.ToolBarPanel.Controls.Add(this.AnteriorIconButton);
            this.ToolBarPanel.Controls.Add(this.PrimeroIconButton);
            this.ToolBarPanel.Controls.Add(this.FiltroIconButton);
            this.ToolBarPanel.Controls.Add(this.IngresarIconButton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(837, 100);
            this.ToolBarPanel.TabIndex = 4;
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
            // UltimoIconButton
            // 
            this.UltimoIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UltimoIconButton.IconChar = FontAwesome.Sharp.IconChar.ForwardFast;
            this.UltimoIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.UltimoIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UltimoIconButton.Location = new System.Drawing.Point(763, 19);
            this.UltimoIconButton.Name = "UltimoIconButton";
            this.UltimoIconButton.Size = new System.Drawing.Size(62, 63);
            this.UltimoIconButton.TabIndex = 2;
            this.UltimoIconButton.Text = "Último";
            this.UltimoIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UltimoIconButton.UseVisualStyleBackColor = true;
            this.UltimoIconButton.Click += new System.EventHandler(this.UltimoIconButton_Click);
            // 
            // SiguienteIconButton
            // 
            this.SiguienteIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SiguienteIconButton.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.SiguienteIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.SiguienteIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SiguienteIconButton.Location = new System.Drawing.Point(695, 19);
            this.SiguienteIconButton.Name = "SiguienteIconButton";
            this.SiguienteIconButton.Size = new System.Drawing.Size(62, 63);
            this.SiguienteIconButton.TabIndex = 2;
            this.SiguienteIconButton.Text = "Siguiente";
            this.SiguienteIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SiguienteIconButton.UseVisualStyleBackColor = true;
            this.SiguienteIconButton.Click += new System.EventHandler(this.SiguienteIconButton_Click);
            // 
            // AnteriorIconButton
            // 
            this.AnteriorIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnteriorIconButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.AnteriorIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.AnteriorIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AnteriorIconButton.Location = new System.Drawing.Point(627, 19);
            this.AnteriorIconButton.Name = "AnteriorIconButton";
            this.AnteriorIconButton.Size = new System.Drawing.Size(62, 63);
            this.AnteriorIconButton.TabIndex = 2;
            this.AnteriorIconButton.Text = "Anterior";
            this.AnteriorIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AnteriorIconButton.UseVisualStyleBackColor = true;
            this.AnteriorIconButton.Click += new System.EventHandler(this.AnteriorIconButton_Click);
            // 
            // PrimeroIconButton
            // 
            this.PrimeroIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrimeroIconButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.PrimeroIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.PrimeroIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PrimeroIconButton.Location = new System.Drawing.Point(559, 19);
            this.PrimeroIconButton.Name = "PrimeroIconButton";
            this.PrimeroIconButton.Size = new System.Drawing.Size(62, 63);
            this.PrimeroIconButton.TabIndex = 2;
            this.PrimeroIconButton.Text = "Primero";
            this.PrimeroIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrimeroIconButton.UseVisualStyleBackColor = true;
            this.PrimeroIconButton.Click += new System.EventHandler(this.PrimeroIconButton_Click);
            // 
            // FiltroIconButton
            // 
            this.FiltroIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltroIconButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.FiltroIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.FiltroIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FiltroIconButton.Location = new System.Drawing.Point(436, 19);
            this.FiltroIconButton.Name = "FiltroIconButton";
            this.FiltroIconButton.Size = new System.Drawing.Size(62, 63);
            this.FiltroIconButton.TabIndex = 2;
            this.FiltroIconButton.Text = "Filtrar";
            this.FiltroIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltroIconButton.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GrillaPanel;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Panel ToolBarPanel;
        private FontAwesome.Sharp.IconButton UltimoIconButton;
        private FontAwesome.Sharp.IconButton SiguienteIconButton;
        private FontAwesome.Sharp.IconButton AnteriorIconButton;
        private FontAwesome.Sharp.IconButton PrimeroIconButton;
        private FontAwesome.Sharp.IconButton FiltroIconButton;
        private FontAwesome.Sharp.IconButton IngresarIconButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoLugar;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
    }
}