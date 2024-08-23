 namespace bai2
{
    partial class MainForm
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.rdDo = new System.Windows.Forms.RadioButton();
            this.btnToMau = new System.Windows.Forms.Button();
            this.txtHopMau = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.rdNu);
            groupBox1.Controls.Add(this.rdNam);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new System.Drawing.Point(222, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(324, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn giới tính:";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(26, 70);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(47, 24);
            this.rdNu.TabIndex = 0;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(26, 38);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(60, 24);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.btnToMau);
            groupBox2.Controls.Add(this.rdXanh);
            groupBox2.Controls.Add(this.rdDo);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new System.Drawing.Point(222, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(324, 182);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn Màu:";
            // 
            // rdXanh
            // 
            this.rdXanh.AutoSize = true;
            this.rdXanh.Location = new System.Drawing.Point(26, 70);
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.Size = new System.Drawing.Size(100, 24);
            this.rdXanh.TabIndex = 0;
            this.rdXanh.TabStop = true;
            this.rdXanh.Text = "Màu Xanh";
            this.rdXanh.UseVisualStyleBackColor = true;
            // 
            // rdDo
            // 
            this.rdDo.AutoSize = true;
            this.rdDo.Checked = true;
            this.rdDo.Location = new System.Drawing.Point(26, 38);
            this.rdDo.Name = "rdDo";
            this.rdDo.Size = new System.Drawing.Size(83, 24);
            this.rdDo.TabIndex = 0;
            this.rdDo.TabStop = true;
            this.rdDo.Text = "Màu Đỏ";
            this.rdDo.UseVisualStyleBackColor = true;
            // 
            // btnToMau
            // 
            this.btnToMau.Location = new System.Drawing.Point(191, 51);
            this.btnToMau.Name = "btnToMau";
            this.btnToMau.Size = new System.Drawing.Size(82, 33);
            this.btnToMau.TabIndex = 1;
            this.btnToMau.Text = "Tô màu";
            this.btnToMau.UseVisualStyleBackColor = true;
            this.btnToMau.Click += new System.EventHandler(this.btnToMau_Click);
            // 
            // txtHopMau
            // 
            this.txtHopMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHopMau.Location = new System.Drawing.Point(602, 312);
            this.txtHopMau.Multiline = true;
            this.txtHopMau.Name = "txtHopMau";
            this.txtHopMau.ReadOnly = true;
            this.txtHopMau.Size = new System.Drawing.Size(280, 100);
            this.txtHopMau.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 568);
            this.Controls.Add(this.txtHopMau);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Name = "MainForm";
            this.Text = "bài tập 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdXanh;
        private System.Windows.Forms.RadioButton rdDo;
        private System.Windows.Forms.Button btnToMau;
        private System.Windows.Forms.TextBox txtHopMau;
    }
}

