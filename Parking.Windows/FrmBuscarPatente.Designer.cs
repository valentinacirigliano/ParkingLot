namespace Parking.Windows
{
    partial class FrmBuscarPatente
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
            this.CancelButton = new FontAwesome.Sharp.IconButton();
            this.BuscarPatenteButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PatenteTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelButton.IconColor = System.Drawing.Color.Red;
            this.CancelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelButton.Location = new System.Drawing.Point(212, 111);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(97, 63);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BuscarPatenteButton
            // 
            this.BuscarPatenteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarPatenteButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BuscarPatenteButton.IconColor = System.Drawing.Color.LimeGreen;
            this.BuscarPatenteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuscarPatenteButton.Location = new System.Drawing.Point(32, 111);
            this.BuscarPatenteButton.Name = "BuscarPatenteButton";
            this.BuscarPatenteButton.Size = new System.Drawing.Size(97, 63);
            this.BuscarPatenteButton.TabIndex = 1;
            this.BuscarPatenteButton.Text = "Buscar";
            this.BuscarPatenteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarPatenteButton.UseVisualStyleBackColor = true;
            this.BuscarPatenteButton.Click += new System.EventHandler(this.BuscarPatenteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patente:";
            // 
            // PatenteTextBox
            // 
            this.PatenteTextBox.Location = new System.Drawing.Point(143, 47);
            this.PatenteTextBox.MaxLength = 7;
            this.PatenteTextBox.Name = "PatenteTextBox";
            this.PatenteTextBox.Size = new System.Drawing.Size(100, 20);
            this.PatenteTextBox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscarPatente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 198);
            this.Controls.Add(this.PatenteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BuscarPatenteButton);
            this.Name = "FrmBuscarPatente";
            this.Text = "FrmBuscarPatente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton CancelButton;
        private FontAwesome.Sharp.IconButton BuscarPatenteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatenteTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}