namespace Gazi.KazanMyo.OyunFrmApp
{
    partial class frmOyun
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
            this.components = new System.ComponentModel.Container();
            this.pnlGosterge = new System.Windows.Forms.Panel();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.tmrButton = new System.Windows.Forms.Timer(this.components);
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.pnlGosterge.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGosterge
            // 
            this.pnlGosterge.BackColor = System.Drawing.Color.Salmon;
            this.pnlGosterge.Controls.Add(this.lblSure);
            this.pnlGosterge.Controls.Add(this.lblSkor);
            this.pnlGosterge.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGosterge.Location = new System.Drawing.Point(583, 0);
            this.pnlGosterge.Name = "pnlGosterge";
            this.pnlGosterge.Size = new System.Drawing.Size(130, 435);
            this.pnlGosterge.TabIndex = 0;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(21, 71);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(37, 13);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "SÜRE";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(21, 30);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(37, 13);
            this.lblSkor.TabIndex = 0;
            this.lblSkor.Text = "SKOR";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(411, 135);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 435);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pnlGosterge);
            this.Name = "frmOyun";
            this.Text = "frmOyun";
            this.Load += new System.EventHandler(this.frmOyun_Load);
            this.pnlGosterge.ResumeLayout(false);
            this.pnlGosterge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGosterge;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Timer tmrButton;
        private System.Windows.Forms.Timer tmrSure;
    }
}

