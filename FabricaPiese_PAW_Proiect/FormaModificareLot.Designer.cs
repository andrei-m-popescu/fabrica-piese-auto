namespace FabricaPiese_PAW_Proiect
{
    partial class FormaModificareLot
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
            this.tb_numarLot = new System.Windows.Forms.TextBox();
            this.tb_cantitate = new System.Windows.Forms.TextBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMAR LOT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CANTITATE NOUA";
            // 
            // tb_numarLot
            // 
            this.tb_numarLot.Location = new System.Drawing.Point(403, 33);
            this.tb_numarLot.Name = "tb_numarLot";
            this.tb_numarLot.Size = new System.Drawing.Size(100, 20);
            this.tb_numarLot.TabIndex = 2;
            // 
            // tb_cantitate
            // 
            this.tb_cantitate.Location = new System.Drawing.Point(403, 79);
            this.tb_cantitate.Name = "tb_cantitate";
            this.tb_cantitate.Size = new System.Drawing.Size(100, 20);
            this.tb_cantitate.TabIndex = 3;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(299, 128);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 4;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // FormaModificareLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.tb_cantitate);
            this.Controls.Add(this.tb_numarLot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaModificareLot";
            this.Text = "FormaModificareLot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_numarLot;
        private System.Windows.Forms.TextBox tb_cantitate;
        private System.Windows.Forms.Button btnModifica;
    }
}