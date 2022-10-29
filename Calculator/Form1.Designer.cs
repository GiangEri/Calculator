namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btcong = new System.Windows.Forms.Button();
            this.bttru = new System.Windows.Forms.Button();
            this.btnhan = new System.Windows.Forms.Button();
            this.btchia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TOÁN ĐƠN GIẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(5, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsoA
            // 
            this.txtsoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoA.Location = new System.Drawing.Point(239, 100);
            this.txtsoA.Name = "txtsoA";
            this.txtsoA.Size = new System.Drawing.Size(264, 36);
            this.txtsoA.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(5, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số thứ hai:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsoB
            // 
            this.txtsoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoB.Location = new System.Drawing.Point(239, 151);
            this.txtsoB.Name = "txtsoB";
            this.txtsoB.Size = new System.Drawing.Size(264, 36);
            this.txtsoB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(5, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtketqua
            // 
            this.txtketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtketqua.Location = new System.Drawing.Point(239, 205);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(264, 36);
            this.txtketqua.TabIndex = 2;
            // 
            // btcong
            // 
            this.btcong.ForeColor = System.Drawing.Color.Blue;
            this.btcong.Location = new System.Drawing.Point(65, 312);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(71, 33);
            this.btcong.TabIndex = 3;
            this.btcong.Text = "+";
            this.btcong.UseVisualStyleBackColor = true;
            this.btcong.Click += new System.EventHandler(this.btcong_Click);
            // 
            // bttru
            // 
            this.bttru.ForeColor = System.Drawing.Color.Blue;
            this.bttru.Location = new System.Drawing.Point(208, 312);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(71, 33);
            this.bttru.TabIndex = 3;
            this.bttru.Text = "-";
            this.bttru.UseVisualStyleBackColor = true;
            // 
            // btnhan
            // 
            this.btnhan.ForeColor = System.Drawing.Color.Blue;
            this.btnhan.Location = new System.Drawing.Point(330, 312);
            this.btnhan.Name = "btnhan";
            this.btnhan.Size = new System.Drawing.Size(71, 33);
            this.btnhan.TabIndex = 3;
            this.btnhan.Text = "*";
            this.btnhan.UseVisualStyleBackColor = true;
            // 
            // btchia
            // 
            this.btchia.ForeColor = System.Drawing.Color.Blue;
            this.btchia.Location = new System.Drawing.Point(455, 312);
            this.btchia.Name = "btchia";
            this.btchia.Size = new System.Drawing.Size(71, 33);
            this.btchia.TabIndex = 3;
            this.btchia.Text = "/";
            this.btchia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 375);
            this.Controls.Add(this.btchia);
            this.Controls.Add(this.btnhan);
            this.Controls.Add(this.bttru);
            this.Controls.Add(this.btcong);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsoB);
            this.Controls.Add(this.txtsoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Button bttru;
        private System.Windows.Forms.Button btnhan;
        private System.Windows.Forms.Button btchia;
    }
}

