
namespace M01A08D
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl01 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Location = new System.Drawing.Point(63, 51);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(137, 20);
            this.lbl01.TabIndex = 0;
            this.lbl01.Text = "Digite um número: ";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(206, 134);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(147, 91);
            this.btn.TabIndex = 1;
            this.btn.Text = "Ok";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(206, 48);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(147, 27);
            this.txtNum.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(63, 258);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 20);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 304);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lbl01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblMsg;
    }
}

