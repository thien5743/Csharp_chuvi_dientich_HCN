namespace Csharp_chuvi_dientich_HCN
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbla = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndientich = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.lbltinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chu vi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(70, 106);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(13, 13);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "a";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(205, 106);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(205, 149);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 4;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(70, 152);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(13, 13);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "b";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(205, 196);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 6;
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(70, 199);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(43, 13);
            this.lblkq.TabIndex = 5;
            this.lblkq.Text = "kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tính HCN";
            // 
            // btndientich
            // 
            this.btndientich.AutoEllipsis = true;
            this.btndientich.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btndientich.Location = new System.Drawing.Point(352, 284);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(75, 23);
            this.btndientich.TabIndex = 8;
            this.btndientich.Text = "Diện tích";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(211, 333);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbdientich);
            this.groupBox1.Controls.Add(this.rdbchuvi);
            this.groupBox1.Location = new System.Drawing.Point(536, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 174);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Location = new System.Drawing.Point(106, 42);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(54, 17);
            this.rdbchuvi.TabIndex = 0;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "chu vi";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Location = new System.Drawing.Point(106, 77);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(67, 17);
            this.rdbdientich.TabIndex = 1;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "diện tích";
            this.rdbdientich.UseVisualStyleBackColor = true;
            // 
            // lbltinh
            // 
            this.lbltinh.AutoEllipsis = true;
            this.lbltinh.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbltinh.Location = new System.Drawing.Point(683, 222);
            this.lbltinh.Name = "lbltinh";
            this.lbltinh.Size = new System.Drawing.Size(75, 23);
            this.lbltinh.TabIndex = 11;
            this.lbltinh.Text = "Tính";
            this.lbltinh.UseVisualStyleBackColor = true;
            this.lbltinh.Click += new System.EventHandler(this.lbltinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 405);
            this.Controls.Add(this.lbltinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.Button lbltinh;
    }
}

