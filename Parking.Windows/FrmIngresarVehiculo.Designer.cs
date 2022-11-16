namespace Parking.Windows
{
    partial class FrmIngresarVehiculo
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PatenteTextBox = new System.Windows.Forms.TextBox();
            this.TarifaCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VehiculoCB = new System.Windows.Forms.ComboBox();
            this.AgregarVehiculo = new FontAwesome.Sharp.IconButton();
            this.CancelButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de vehículo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tarifa:";
            // 
            // PatenteTextBox
            // 
            this.PatenteTextBox.Location = new System.Drawing.Point(129, 115);
            this.PatenteTextBox.MaxLength = 7;
            this.PatenteTextBox.Name = "PatenteTextBox";
            this.PatenteTextBox.Size = new System.Drawing.Size(76, 20);
            this.PatenteTextBox.TabIndex = 2;
            // 
            // TarifaCB
            // 
            this.TarifaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TarifaCB.FormattingEnabled = true;
            this.TarifaCB.Location = new System.Drawing.Point(129, 77);
            this.TarifaCB.Name = "TarifaCB";
            this.TarifaCB.Size = new System.Drawing.Size(228, 21);
            this.TarifaCB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Patente:";
            // 
            // VehiculoCB
            // 
            this.VehiculoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehiculoCB.FormattingEnabled = true;
            this.VehiculoCB.Location = new System.Drawing.Point(129, 40);
            this.VehiculoCB.Name = "VehiculoCB";
            this.VehiculoCB.Size = new System.Drawing.Size(228, 21);
            this.VehiculoCB.TabIndex = 0;
            this.VehiculoCB.SelectedIndexChanged += new System.EventHandler(this.VehiculoCB_SelectedIndexChanged);
            // 
            // AgregarVehiculo
            // 
            this.AgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarVehiculo.IconChar = FontAwesome.Sharp.IconChar.CarOn;
            this.AgregarVehiculo.IconColor = System.Drawing.Color.LimeGreen;
            this.AgregarVehiculo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarVehiculo.Location = new System.Drawing.Point(35, 167);
            this.AgregarVehiculo.Name = "AgregarVehiculo";
            this.AgregarVehiculo.Size = new System.Drawing.Size(97, 63);
            this.AgregarVehiculo.TabIndex = 3;
            this.AgregarVehiculo.Text = "Agregar";
            this.AgregarVehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregarVehiculo.UseVisualStyleBackColor = true;
            this.AgregarVehiculo.Click += new System.EventHandler(this.AgregarVehiculo_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelButton.IconColor = System.Drawing.Color.Red;
            this.CancelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelButton.Location = new System.Drawing.Point(267, 167);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(97, 63);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.AgregarVehiculo_Click);
            // 
            // FrmIngresarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 267);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AgregarVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatenteTextBox);
            this.Controls.Add(this.TarifaCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VehiculoCB);
            this.Name = "FrmIngresarVehiculo";
            this.Text = "FrmIngresarVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatenteTextBox;
        private System.Windows.Forms.ComboBox TarifaCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VehiculoCB;
        private FontAwesome.Sharp.IconButton CancelButton;
        private FontAwesome.Sharp.IconButton AgregarVehiculo;
    }
}