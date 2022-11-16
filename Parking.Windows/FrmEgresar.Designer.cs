namespace Parking.Windows
{
    partial class FrmEgresar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patenteLabel = new System.Windows.Forms.Label();
            this.TarifaTiempoLabel = new System.Windows.Forms.Label();
            this.fechaIngresoLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TarifaPrecioLabel = new System.Windows.Forms.Label();
            this.cantidadNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarifa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha y hora de ingreso:";
            // 
            // patenteLabel
            // 
            this.patenteLabel.AutoSize = true;
            this.patenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patenteLabel.Location = new System.Drawing.Point(182, 27);
            this.patenteLabel.Name = "patenteLabel";
            this.patenteLabel.Size = new System.Drawing.Size(64, 17);
            this.patenteLabel.TabIndex = 0;
            this.patenteLabel.Text = "Patente";
            // 
            // TarifaTiempoLabel
            // 
            this.TarifaTiempoLabel.AutoSize = true;
            this.TarifaTiempoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarifaTiempoLabel.Location = new System.Drawing.Point(182, 55);
            this.TarifaTiempoLabel.Name = "TarifaTiempoLabel";
            this.TarifaTiempoLabel.Size = new System.Drawing.Size(51, 17);
            this.TarifaTiempoLabel.TabIndex = 0;
            this.TarifaTiempoLabel.Text = "Tarifa";
            // 
            // fechaIngresoLabel
            // 
            this.fechaIngresoLabel.AutoSize = true;
            this.fechaIngresoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIngresoLabel.Location = new System.Drawing.Point(182, 84);
            this.fechaIngresoLabel.Name = "fechaIngresoLabel";
            this.fechaIngresoLabel.Size = new System.Drawing.Size(52, 17);
            this.fechaIngresoLabel.TabIndex = 0;
            this.fechaIngresoLabel.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Precio unitario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cantidad:";
            // 
            // TarifaPrecioLabel
            // 
            this.TarifaPrecioLabel.AutoSize = true;
            this.TarifaPrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarifaPrecioLabel.Location = new System.Drawing.Point(173, 187);
            this.TarifaPrecioLabel.Name = "TarifaPrecioLabel";
            this.TarifaPrecioLabel.Size = new System.Drawing.Size(44, 17);
            this.TarifaPrecioLabel.TabIndex = 1;
            this.TarifaPrecioLabel.Text = "$0.00";
            // 
            // cantidadNumeric
            // 
            this.cantidadNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadNumeric.Location = new System.Drawing.Point(176, 217);
            this.cantidadNumeric.Name = "cantidadNumeric";
            this.cantidadNumeric.Size = new System.Drawing.Size(45, 23);
            this.cantidadNumeric.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.patenteLabel);
            this.groupBox1.Controls.Add(this.TarifaTiempoLabel);
            this.groupBox1.Controls.Add(this.fechaIngresoLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del vehículo";
            // 
            // OKIconButton
            // 
            this.OKIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.OKIconButton.IconColor = System.Drawing.Color.Lime;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(55, 303);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(97, 63);
            this.OKIconButton.TabIndex = 7;
            this.OKIconButton.Text = "Egresar";
            this.OKIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OKIconButton.UseVisualStyleBackColor = true;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.Red;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(176, 303);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(97, 63);
            this.CancelarIconButton.TabIndex = 7;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarIconButton.UseVisualStyleBackColor = true;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEgresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 398);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cantidadNumeric);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TarifaPrecioLabel);
            this.Controls.Add(this.label7);
            this.Name = "FrmEgresar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEgresar";
            this.Load += new System.EventHandler(this.FrmEgresar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label patenteLabel;
        private System.Windows.Forms.Label TarifaTiempoLabel;
        private System.Windows.Forms.Label fechaIngresoLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TarifaPrecioLabel;
        private System.Windows.Forms.NumericUpDown cantidadNumeric;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}