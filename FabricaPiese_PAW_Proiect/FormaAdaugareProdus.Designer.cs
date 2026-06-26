namespace FabricaPiese_PAW_Proiect
{
    partial class FormaAdaugareProdus
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
            this.tb_codProdus = new System.Windows.Forms.TextBox();
            this.tb_numeProdus = new System.Windows.Forms.TextBox();
            this.tb_greutate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tipProdus = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_codProdus
            // 
            this.tb_codProdus.Location = new System.Drawing.Point(58, 49);
            this.tb_codProdus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_codProdus.Name = "tb_codProdus";
            this.tb_codProdus.Size = new System.Drawing.Size(128, 20);
            this.tb_codProdus.TabIndex = 0;
            // 
            // tb_numeProdus
            // 
            this.tb_numeProdus.Location = new System.Drawing.Point(58, 107);
            this.tb_numeProdus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_numeProdus.Name = "tb_numeProdus";
            this.tb_numeProdus.Size = new System.Drawing.Size(128, 20);
            this.tb_numeProdus.TabIndex = 1;
            // 
            // tb_greutate
            // 
            this.tb_greutate.Location = new System.Drawing.Point(58, 228);
            this.tb_greutate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_greutate.Name = "tb_greutate";
            this.tb_greutate.Size = new System.Drawing.Size(128, 20);
            this.tb_greutate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "COD PRODUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "NUME PRODUS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "TIP PRODUS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "GREUTATE";
            // 
            // cb_tipProdus
            // 
            this.cb_tipProdus.FormattingEnabled = true;
            this.cb_tipProdus.Items.AddRange(new object[] {
            "Motor",
            "Caroserie",
            "Electric",
            "Transmisie"});
            this.cb_tipProdus.Location = new System.Drawing.Point(58, 167);
            this.cb_tipProdus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_tipProdus.Name = "cb_tipProdus";
            this.cb_tipProdus.Size = new System.Drawing.Size(128, 21);
            this.cb_tipProdus.TabIndex = 8;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.ForeColor = System.Drawing.Color.White;
            this.btnAdauga.Location = new System.Drawing.Point(61, 283);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(124, 52);
            this.btnAdauga.TabIndex = 9;
            this.btnAdauga.Text = "ADAUGA";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // FormaAdaugareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(249, 368);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.cb_tipProdus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_greutate);
            this.Controls.Add(this.tb_numeProdus);
            this.Controls.Add(this.tb_codProdus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaAdaugareProdus";
            this.Text = "Adauga Produs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_codProdus;
        private System.Windows.Forms.TextBox tb_numeProdus;
        private System.Windows.Forms.TextBox tb_greutate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_tipProdus;
        private System.Windows.Forms.Button btnAdauga;
    }
}