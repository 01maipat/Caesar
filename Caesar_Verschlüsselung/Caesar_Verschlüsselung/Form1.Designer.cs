﻿namespace Caesar_Verschlüsselung
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
            this.txt_entschlüssels_eingabe = new System.Windows.Forms.TextBox();
            this.btn_entschlüsseln = new System.Windows.Forms.Button();
            this.txt_entschlüsseln_ausgabe = new System.Windows.Forms.TextBox();
            this.txt_schlüssel = new System.Windows.Forms.TextBox();
            this.btn_end = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txteingabe
            // 
            this.txteingabe.Location = new System.Drawing.Point(12, 54);
            this.txteingabe.Name = "txteingabe";
            this.txteingabe.Size = new System.Drawing.Size(685, 20);
            this.txteingabe.TabIndex = 0;
            this.txteingabe.TextChanged += new System.EventHandler(this.txteingabe_TextChanged);
            // 
            // btn_verschlüsseln
            // 
            this.btn_verschlüsseln.Location = new System.Drawing.Point(12, 80);
            this.btn_verschlüsseln.Name = "btn_verschlüsseln";
            this.btn_verschlüsseln.Size = new System.Drawing.Size(685, 53);
            this.btn_verschlüsseln.TabIndex = 1;
            this.btn_verschlüsseln.Text = "Verschlüsseln";
            this.btn_verschlüsseln.UseVisualStyleBackColor = true;
            this.btn_verschlüsseln.Click += new System.EventHandler(this.btn_verschlüsseln_Click);
            // 
            // txtausgabe
            // 
            this.txtausgabe.Location = new System.Drawing.Point(12, 139);
            this.txtausgabe.Name = "txtausgabe";
            this.txtausgabe.ReadOnly = true;
            this.txtausgabe.Size = new System.Drawing.Size(685, 20);
            this.txtausgabe.TabIndex = 2;
            this.txtausgabe.TextChanged += new System.EventHandler(this.txtausgabe_TextChanged);
            // 
            // txt_entschlüssels_eingabe
            // 
            this.txt_entschlüssels_eingabe.Location = new System.Drawing.Point(12, 251);
            this.txt_entschlüssels_eingabe.Name = "txt_entschlüssels_eingabe";
            this.txt_entschlüssels_eingabe.Size = new System.Drawing.Size(685, 20);
            this.txt_entschlüssels_eingabe.TabIndex = 3;
            this.txt_entschlüssels_eingabe.TextChanged += new System.EventHandler(this.txt_entschlüssels_eingabe_TextChanged);
            // 
            // btn_entschlüsseln
            // 
            this.btn_entschlüsseln.Location = new System.Drawing.Point(12, 277);
            this.btn_entschlüsseln.Name = "btn_entschlüsseln";
            this.btn_entschlüsseln.Size = new System.Drawing.Size(685, 63);
            this.btn_entschlüsseln.TabIndex = 4;
            this.btn_entschlüsseln.Text = "Entschlüsseln";
            this.btn_entschlüsseln.UseVisualStyleBackColor = true;
            this.btn_entschlüsseln.Click += new System.EventHandler(this.btn_entschlüsseln_Click);
            // 
            // txt_entschlüsseln_ausgabe
            // 
            this.txt_entschlüsseln_ausgabe.Location = new System.Drawing.Point(12, 346);
            this.txt_entschlüsseln_ausgabe.Name = "txt_entschlüsseln_ausgabe";
            this.txt_entschlüsseln_ausgabe.ReadOnly = true;
            this.txt_entschlüsseln_ausgabe.Size = new System.Drawing.Size(685, 20);
            this.txt_entschlüsseln_ausgabe.TabIndex = 5;
            this.txt_entschlüsseln_ausgabe.TextChanged += new System.EventHandler(this.txt_entschlüsseln_ausgabe_TextChanged);
            // 
            // txt_schlüssel
            // 
            this.txt_schlüssel.Location = new System.Drawing.Point(303, 194);
            this.txt_schlüssel.Name = "txt_schlüssel";
            this.txt_schlüssel.Size = new System.Drawing.Size(117, 20);
            this.txt_schlüssel.TabIndex = 6;
            this.txt_schlüssel.Text = "Schlüssel";
            this.txt_schlüssel.Click += new System.EventHandler(this.txt_schlüssel_Click);
            this.txt_schlüssel.TextChanged += new System.EventHandler(this.txt_schlüssel_TextChanged);
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_end.Location = new System.Drawing.Point(668, 5);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(29, 24);
            this.btn_end.TabIndex = 7;
            this.btn_end.Text = "X";
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Caesar Verschlüsselung";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.txt_schlüssel);
            this.Controls.Add(this.txt_entschlüsseln_ausgabe);
            this.Controls.Add(this.btn_entschlüsseln);
            this.Controls.Add(this.txt_entschlüssels_eingabe);
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
        private System.Windows.Forms.TextBox txt_entschlüssels_eingabe;
        private System.Windows.Forms.Button btn_entschlüsseln;
        private System.Windows.Forms.TextBox txt_entschlüsseln_ausgabe;
        private System.Windows.Forms.TextBox txt_schlüssel;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Label label1;
    }
}

