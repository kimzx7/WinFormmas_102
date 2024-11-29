namespace WinFormmas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtAge = new TextBox();
            txtName = new TextBox();
            btnBMI = new Button();
            lblResult = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Honeydew;
            label1.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 22);
            label1.Name = "label1";
            label1.Size = new Size(228, 42);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวณค่า BMi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 247);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 1;
            label2.Text = "น้ำหนัก(kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 202);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 2;
            label3.Text = "ส่วนสูง(cm)";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(157, 202);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(157, 247);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 126);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 5;
            label4.Text = "ชื่อ-นามสกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(54, 162);
            label5.Name = "label5";
            label5.Size = new Size(39, 23);
            label5.TabIndex = 6;
            label5.Text = "อายุ";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(157, 166);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 2;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.HighlightText;
            txtName.Location = new Point(158, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnBMI
            // 
            btnBMI.Location = new Point(613, 126);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(120, 71);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "ค่า BMI";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.ControlLight;
            lblResult.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(56, 326);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(677, 218);
            lblResult.TabIndex = 10;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(613, 224);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 71);
            btnClear.TabIndex = 6;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(797, 580);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(btnBMI);
            Controls.Add(txtName);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label label4;
        private Label label5;
        private TextBox txtAge;
        private TextBox txtName;
        private Button btnBMI;
        private Label lblResult;
        private Button btnClear;
    }
}
