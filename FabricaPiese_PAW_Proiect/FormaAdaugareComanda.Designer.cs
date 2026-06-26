namespace FabricaPiese_PAW_Proiect
{
    partial class FormaAdaugareComanda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_numarComanda = new System.Windows.Forms.TextBox();
            this.tb_numeClient = new System.Windows.Forms.TextBox();
            this.tb_idProdus = new System.Windows.Forms.TextBox();
            this.tb_cantitate = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMAR COMANDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUME CLIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID PRODUS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CANTITATE";
            // 
            // tb_numarComanda
            // 
            this.tb_numarComanda.Location = new System.Drawing.Point(270, 30);
            this.tb_numarComanda.Name = "tb_numarComanda";
            this.tb_numarComanda.Size = new System.Drawing.Size(100, 20);
            this.tb_numarComanda.TabIndex = 4;
            // 
            // tb_numeClient
            // 
            this.tb_numeClient.Location = new System.Drawing.Point(270, 98);
            this.tb_numeClient.Name = "tb_numeClient";
            this.tb_numeClient.Size = new System.Drawing.Size(100, 20);
            this.tb_numeClient.TabIndex = 5;
            // 
            // tb_idProdus
            // 
            this.tb_idProdus.Location = new System.Drawing.Point(270, 151);
            this.tb_idProdus.Name = "tb_idProdus";
            this.tb_idProdus.Size = new System.Drawing.Size(100, 20);
            this.tb_idProdus.TabIndex = 6;
            // 
            // tb_cantitate
            // 
            this.tb_cantitate.Location = new System.Drawing.Point(270, 213);
            this.tb_cantitate.Name = "tb_cantitate";
            this.tb_cantitate.Size = new System.Drawing.Size(100, 20);
            this.tb_cantitate.TabIndex = 7;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(110, 288);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "ADAUGA";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // FormaAdaugareComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tb_cantitate);
            this.Controls.Add(this.tb_idProdus);
            this.Controls.Add(this.tb_numeClient);
            this.Controls.Add(this.tb_numarComanda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaAdaugareComanda";
            this.Text = "FormaAdaugareComanda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_numarComanda;
        private System.Windows.Forms.TextBox tb_numeClient;
        private System.Windows.Forms.TextBox tb_idProdus;
        private System.Windows.Forms.TextBox tb_cantitate;
        private System.Windows.Forms.Button btnAdauga;
    }
}