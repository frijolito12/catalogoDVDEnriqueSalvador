namespace App_CatalogoCD
{
    partial class frm_salida
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
            this.tbxSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxSalida
            // 
            this.tbxSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSalida.Location = new System.Drawing.Point(0, 0);
            this.tbxSalida.Multiline = true;
            this.tbxSalida.Name = "tbxSalida";
            this.tbxSalida.ReadOnly = true;
            this.tbxSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxSalida.Size = new System.Drawing.Size(284, 262);
            this.tbxSalida.TabIndex = 0;
            // 
            // frm_salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tbxSalida);
            this.Name = "frm_salida";
            this.Text = "frm_salida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSalida;
    }
}