namespace FabricaPiese_PAW_Proiect
{
    partial class FormaAdaugareLot
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_numarLot = new System.Windows.Forms.TextBox();
            this.tb_dataProductie = new System.Windows.Forms.TextBox();
            this.tb_cantitate = new System.Windows.Forms.TextBox();
            this.tb_idProdus = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMAR LOT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATA PRODUCTIE(zz/ll/aaaa)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CANTITATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID PRODUS";
            // 
            // tb_numarLot
            // 
            this.tb_numarLot.Location = new System.Drawing.Point(478, 23);
            this.tb_numarLot.Name = "tb_numarLot";
            this.tb_numarLot.Size = new System.Drawing.Size(100, 20);
            this.tb_numarLot.TabIndex = 5;
            // 
            // tb_dataProductie
            // 
            this.tb_dataProductie.Location = new System.Drawing.Point(478, 63);
            this.tb_dataProductie.Name = "tb_dataProductie";
            this.tb_dataProductie.Size = new System.Drawing.Size(100, 20);
            this.tb_dataProductie.TabIndex = 6;
            // 
            // tb_cantitate
            // 
            this.tb_cantitate.Location = new System.Drawing.Point(478, 105);
            this.tb_cantitate.Name = "tb_cantitate";
            this.tb_cantitate.Size = new System.Drawing.Size(100, 20);
            this.tb_cantitate.TabIndex = 8;
            // 
            // tb_idProdus
            // 
            this.tb_idProdus.Location = new System.Drawing.Point(478, 147);
            this.tb_idProdus.Name = "tb_idProdus";
            this.tb_idProdus.Size = new System.Drawing.Size(100, 20);
            this.tb_idProdus.TabIndex = 9;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(283, 204);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "ADAUGA";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // FormaAdaugareLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tb_idProdus);
            this.Controls.Add(this.tb_cantitate);
            this.Controls.Add(this.tb_dataProductie);
            this.Controls.Add(this.tb_numarLot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaAdaugareLot";
            this.Text = "FormaAdaugareLot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_numarLot;
        private System.Windows.Forms.TextBox tb_dataProductie;
        private System.Windows.Forms.TextBox tb_cantitate;
        private System.Windows.Forms.TextBox tb_idProdus;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label label5;
    }
}