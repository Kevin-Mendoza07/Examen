namespace Examen.Forms
{
    partial class FrmGestionActivo
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
            this.rtbActivoFijoView = new System.Windows.Forms.RichTextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbActivoFijoView
            // 
            this.rtbActivoFijoView.Location = new System.Drawing.Point(57, 44);
            this.rtbActivoFijoView.Name = "rtbActivoFijoView";
            this.rtbActivoFijoView.ReadOnly = true;
            this.rtbActivoFijoView.Size = new System.Drawing.Size(647, 341);
            this.rtbActivoFijoView.TabIndex = 0;
            this.rtbActivoFijoView.Text = "";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(611, 407);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(27, 13);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(64, 13);
            this.lblBuscador.TabIndex = 2;
            this.lblBuscador.Text = "Buscar por: ";
            // 
            // cmbFinder
            // 
            this.cmbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "TipoActivo",
            "Id ",
            "Codigo"});
            this.cmbFinder.Location = new System.Drawing.Point(97, 10);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(192, 21);
            this.cmbFinder.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(678, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmGestionActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.rtbActivoFijoView);
            this.Name = "FrmGestionActivo";
            this.Text = "FrmGestionActivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbActivoFijoView;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
    }
}