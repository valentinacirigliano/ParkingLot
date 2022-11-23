namespace Parking.Windows
{
    partial class FrmInicio
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
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.RolLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contenedorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraMenuStrip = new System.Windows.Forms.MenuStrip();
            this.LugaresMenu = new FontAwesome.Sharp.IconMenuItem();
            this.IngresosMenu = new FontAwesome.Sharp.IconMenuItem();
            this.EgresosMenu = new FontAwesome.Sharp.IconMenuItem();
            this.TarifasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.VentasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.TituloMenuStrip = new System.Windows.Forms.MenuStrip();
            this.BarraMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.ForeColor = System.Drawing.Color.White;
            this.UsuarioLabel.Location = new System.Drawing.Point(1207, 0);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(64, 17);
            this.UsuarioLabel.TabIndex = 9;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // RolLabel
            // 
            this.RolLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RolLabel.AutoSize = true;
            this.RolLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.RolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolLabel.ForeColor = System.Drawing.Color.White;
            this.RolLabel.Location = new System.Drawing.Point(1207, 26);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(29, 17);
            this.RolLabel.TabIndex = 10;
            this.RolLabel.Text = "Rol";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1123, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1123, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuario:";
            // 
            // contenedorPanel
            // 
            this.contenedorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorPanel.Location = new System.Drawing.Point(0, 127);
            this.contenedorPanel.Name = "contenedorPanel";
            this.contenedorPanel.Size = new System.Drawing.Size(1021, 444);
            this.contenedorPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Estacionamiento";
            // 
            // BarraMenuStrip
            // 
            this.BarraMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LugaresMenu,
            this.IngresosMenu,
            this.EgresosMenu,
            this.TarifasMenu,
            this.VentasMenu});
            this.BarraMenuStrip.Location = new System.Drawing.Point(0, 54);
            this.BarraMenuStrip.Name = "BarraMenuStrip";
            this.BarraMenuStrip.Size = new System.Drawing.Size(1021, 73);
            this.BarraMenuStrip.TabIndex = 5;
            this.BarraMenuStrip.Text = "menuStrip1";
            // 
            // LugaresMenu
            // 
            this.LugaresMenu.AutoSize = false;
            this.LugaresMenu.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.LugaresMenu.IconColor = System.Drawing.Color.Black;
            this.LugaresMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LugaresMenu.IconSize = 50;
            this.LugaresMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LugaresMenu.Name = "LugaresMenu";
            this.LugaresMenu.Size = new System.Drawing.Size(80, 69);
            this.LugaresMenu.Text = "Lugares";
            this.LugaresMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LugaresMenu.ToolTipText = "Ver todos los lugares";
            this.LugaresMenu.Click += new System.EventHandler(this.LugaresMenu_Click);
            // 
            // IngresosMenu
            // 
            this.IngresosMenu.AutoSize = false;
            this.IngresosMenu.IconChar = FontAwesome.Sharp.IconChar.CarTunnel;
            this.IngresosMenu.IconColor = System.Drawing.Color.Black;
            this.IngresosMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IngresosMenu.IconSize = 50;
            this.IngresosMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IngresosMenu.Name = "IngresosMenu";
            this.IngresosMenu.Size = new System.Drawing.Size(80, 69);
            this.IngresosMenu.Text = "Ingresos";
            this.IngresosMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IngresosMenu.ToolTipText = "Ver vehículos ingresados";
            this.IngresosMenu.Click += new System.EventHandler(this.IngresosMenu_Click);
            // 
            // EgresosMenu
            // 
            this.EgresosMenu.AutoSize = false;
            this.EgresosMenu.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.EgresosMenu.IconColor = System.Drawing.Color.Black;
            this.EgresosMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EgresosMenu.IconSize = 50;
            this.EgresosMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EgresosMenu.Name = "EgresosMenu";
            this.EgresosMenu.Size = new System.Drawing.Size(80, 69);
            this.EgresosMenu.Text = "Egresos";
            this.EgresosMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EgresosMenu.ToolTipText = "Ver vehículos egresados";
            this.EgresosMenu.Click += new System.EventHandler(this.EgresosMenu_Click);
            // 
            // TarifasMenu
            // 
            this.TarifasMenu.AutoSize = false;
            this.TarifasMenu.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.TarifasMenu.IconColor = System.Drawing.Color.Black;
            this.TarifasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TarifasMenu.IconSize = 50;
            this.TarifasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TarifasMenu.Name = "TarifasMenu";
            this.TarifasMenu.Size = new System.Drawing.Size(80, 69);
            this.TarifasMenu.Text = "Tarifas";
            this.TarifasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TarifasMenu.ToolTipText = "Ver tarifas actuales";
            this.TarifasMenu.Click += new System.EventHandler(this.TarifasMenu_Click);
            // 
            // VentasMenu
            // 
            this.VentasMenu.AutoSize = false;
            this.VentasMenu.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.VentasMenu.IconColor = System.Drawing.Color.Black;
            this.VentasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VentasMenu.IconSize = 50;
            this.VentasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VentasMenu.Name = "VentasMenu";
            this.VentasMenu.Size = new System.Drawing.Size(0, 0);
            this.VentasMenu.Text = "Ventas";
            this.VentasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TituloMenuStrip
            // 
            this.TituloMenuStrip.AutoSize = false;
            this.TituloMenuStrip.BackColor = System.Drawing.Color.Khaki;
            this.TituloMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TituloMenuStrip.Name = "TituloMenuStrip";
            this.TituloMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TituloMenuStrip.Size = new System.Drawing.Size(1021, 54);
            this.TituloMenuStrip.TabIndex = 6;
            this.TituloMenuStrip.Text = "menuStrip2";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 571);
            this.Controls.Add(this.contenedorPanel);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.RolLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraMenuStrip);
            this.Controls.Add(this.TituloMenuStrip);
            this.Name = "FrmInicio";
            this.Text = "Sistema de Estacionamiento";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.BarraMenuStrip.ResumeLayout(false);
            this.BarraMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label RolLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel contenedorPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip BarraMenuStrip;
        private FontAwesome.Sharp.IconMenuItem LugaresMenu;
        private FontAwesome.Sharp.IconMenuItem IngresosMenu;
        private FontAwesome.Sharp.IconMenuItem EgresosMenu;
        private FontAwesome.Sharp.IconMenuItem TarifasMenu;
        private FontAwesome.Sharp.IconMenuItem VentasMenu;
        private System.Windows.Forms.MenuStrip TituloMenuStrip;
    }
}

