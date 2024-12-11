namespace lab002
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
            groupBox3 = new GroupBox();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnTriangleArea = new Button();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnHexagonArea = new Button();
            txtHexagonWidth = new TextBox();
            label4 = new Label();
            label6 = new Label();
            lblResult = new Label();
            button1 = new Button();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveBorder;
            groupBox3.Controls.Add(btnCircleArea);
            groupBox3.Controls.Add(txtRadius);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(404, 122);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวณพื้นที่วงกลม";
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(219, 42);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(167, 32);
            btnCircleArea.TabIndex = 17;
            btnCircleArea.Text = "คำนวณพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(69, 45);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(99, 27);
            txtRadius.TabIndex = 0;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 48);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "รัศมี";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Cyan;
            groupBox1.Controls.Add(btnTriangleArea);
            groupBox1.Controls.Add(txtWidth);
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 137);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Location = new Point(231, 68);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(155, 34);
            btnTriangleArea.TabIndex = 17;
            btnTriangleArea.Text = "คำนวณพื้นที่สามเหลี่ยม";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(114, 107);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(73, 27);
            txtWidth.TabIndex = 6;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(114, 57);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(73, 27);
            txtHeight.TabIndex = 3;
            txtHeight.TextChanged += txtHeight_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 57);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "ความสูง";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 107);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "ความยาวฐาน";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(btnHexagonArea);
            groupBox2.Controls.Add(txtHexagonWidth);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 326);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(404, 150);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า";
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Location = new Point(218, 54);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(168, 31);
            btnHexagonArea.TabIndex = 17;
            btnHexagonArea.Text = "คำนวณพื้นที่รูปหกเหลี่ยม";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // txtHexagonWidth
            // 
            txtHexagonWidth.Location = new Point(95, 54);
            txtHexagonWidth.Name = "txtHexagonWidth";
            txtHexagonWidth.Size = new Size(73, 27);
            txtHexagonWidth.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 54);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 10;
            label4.Text = "ความยาวฐาน";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(608, 60);
            label6.Name = "label6";
            label6.Size = new Size(151, 43);
            label6.TabIndex = 20;
            label6.Text = "พื้นที่ (ตารางหน่วย)";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(255, 192, 128);
            lblResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(572, 103);
            lblResult.Name = "lblResult";
            lblResult.RightToLeft = RightToLeft.No;
            lblResult.Size = new Size(223, 162);
            lblResult.TabIndex = 19;
            lblResult.Text = "0.00";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(594, 326);
            button1.Name = "button1";
            button1.Size = new Size(182, 74);
            button1.TabIndex = 21;
            button1.Text = "ล้างค่า";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 576);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnTriangleArea;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnHexagonArea;
        private TextBox txtHexagonWidth;
        private Label label4;
        private Label label6;
        private Label lblResult;
        private Button button1;
    }
}
