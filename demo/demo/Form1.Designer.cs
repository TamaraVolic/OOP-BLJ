
namespace demo
{
    partial class Form1
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
            this.buttonEinzahlen = new System.Windows.Forms.Button();
            this.txtBetrag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAbheben = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEinzahlen
            // 
            this.buttonEinzahlen.Location = new System.Drawing.Point(520, 125);
            this.buttonEinzahlen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEinzahlen.Name = "buttonEinzahlen";
            this.buttonEinzahlen.Size = new System.Drawing.Size(269, 49);
            this.buttonEinzahlen.TabIndex = 0;
            this.buttonEinzahlen.Text = "Einzahlen";
            this.buttonEinzahlen.UseVisualStyleBackColor = true;
            this.buttonEinzahlen.Click += new System.EventHandler(this.buttonEinzahlen_Click);
            // 
            // txtBetrag
            // 
            this.txtBetrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBetrag.Location = new System.Drawing.Point(235, 119);
            this.txtBetrag.Margin = new System.Windows.Forms.Padding(4);
            this.txtBetrag.Name = "txtBetrag";
            this.txtBetrag.Size = new System.Drawing.Size(259, 35);
            this.txtBetrag.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Betrag:";
            // 
            // buttonAbheben
            // 
            this.buttonAbheben.Location = new System.Drawing.Point(520, 199);
            this.buttonAbheben.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAbheben.Name = "buttonAbheben";
            this.buttonAbheben.Size = new System.Drawing.Size(269, 49);
            this.buttonAbheben.TabIndex = 3;
            this.buttonAbheben.Text = "Abheben";
            this.buttonAbheben.UseVisualStyleBackColor = true;
            this.buttonAbheben.Click += new System.EventHandler(this.buttonAbheben_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aktueller Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(325, 345);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(464, 35);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(855, 411);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAbheben);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBetrag);
            this.Controls.Add(this.buttonEinzahlen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEinzahlen;
        private System.Windows.Forms.TextBox txtBetrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAbheben;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
    }
}

