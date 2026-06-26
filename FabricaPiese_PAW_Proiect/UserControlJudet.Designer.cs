using System.Drawing;
using System.Windows.Forms;
using System;

namespace FabricaPiese_PAW_Proiect
{
    partial class UserControlJudet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbJudet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteaza un judet:";
            // 
            // cbJudet
            // 
            this.cbJudet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJudet.FormattingEnabled = true;
            this.cbJudet.Location = new System.Drawing.Point(97, 195);
            this.cbJudet.Name = "cbJudet";
            this.cbJudet.Size = new System.Drawing.Size(193, 24);
            this.cbJudet.TabIndex = 1;
            // 
            // UserControlJudet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbJudet);
            this.Controls.Add(this.label1);
            this.Name = "UserControlJudet";
            this.Size = new System.Drawing.Size(409, 393);
            this.Load += new System.EventHandler(this.UserControlJudet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComboBox cbJudet;
    }
}
