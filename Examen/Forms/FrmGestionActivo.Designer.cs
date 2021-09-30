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
            // FrmGestionActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.rtbActivoFijoView);
            this.Name = "FrmGestionActivo";
            this.Text = "FrmGestionActivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbActivoFijoView;
        private System.Windows.Forms.Button btnNuevo;
    }
}