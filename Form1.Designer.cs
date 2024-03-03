namespace TPMOD3_1302220126
{
    partial class Form1
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
            this.inputNama = new System.Windows.Forms.TextBox();
            this.keluar = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(140, 112);
            this.inputNama.Multiline = true;
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(261, 65);
            this.inputNama.TabIndex = 0;
            this.inputNama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // keluar
            // 
            this.keluar.AutoSize = true;
            this.keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar.Location = new System.Drawing.Point(167, 226);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(149, 37);
            this.keluar.TabIndex = 1;
            this.keluar.Text = "OUTPUT";
            this.keluar.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(469, 123);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(220, 54);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "submit";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 506);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.inputNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.Label keluar;
        private System.Windows.Forms.Button inputButton;
    }
}

