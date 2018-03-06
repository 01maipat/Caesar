namespace Caesar_Verschlüsselung
{
    partial class form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txteingabe = new System.Windows.Forms.TextBox();
            this.btn_verschlüsseln = new System.Windows.Forms.Button();
            this.txtausgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txteingabe
            // 
            this.txteingabe.Location = new System.Drawing.Point(12, 35);
            this.txteingabe.Name = "txteingabe";
            this.txteingabe.Size = new System.Drawing.Size(685, 20);
            this.txteingabe.TabIndex = 0;
            // 
            // btn_verschlüsseln
            // 
            this.btn_verschlüsseln.Location = new System.Drawing.Point(12, 61);
            this.btn_verschlüsseln.Name = "btn_verschlüsseln";
            this.btn_verschlüsseln.Size = new System.Drawing.Size(685, 53);
            this.btn_verschlüsseln.TabIndex = 1;
            this.btn_verschlüsseln.Text = "Verschlüsseln";
            this.btn_verschlüsseln.UseVisualStyleBackColor = true;
            // 
            // txtausgabe
            // 
            this.txtausgabe.Enabled = false;
            this.txtausgabe.Location = new System.Drawing.Point(12, 120);
            this.txtausgabe.Name = "txtausgabe";
            this.txtausgabe.Size = new System.Drawing.Size(685, 20);
            this.txtausgabe.TabIndex = 2;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 412);
            this.Controls.Add(this.txtausgabe);
            this.Controls.Add(this.btn_verschlüsseln);
            this.Controls.Add(this.txteingabe);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txteingabe;
        private System.Windows.Forms.Button btn_verschlüsseln;
        private System.Windows.Forms.TextBox txtausgabe;
    }
}

