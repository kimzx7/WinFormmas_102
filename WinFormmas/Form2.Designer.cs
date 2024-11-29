namespace WinFormmas
{
    partial class Form2
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
            button1 = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Location = new Point(510, 177);
            button1.Name = "button1";
            button1.Size = new Size(177, 95);
            button1.TabIndex = 0;
            button1.Text = "GO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.InactiveCaption;
            txtResult.Location = new Point(30, 27);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(368, 455);
            txtResult.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(774, 497);
            Controls.Add(txtResult);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtResult;
    }
}