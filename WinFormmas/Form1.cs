namespace WinFormmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ยินดีต้อนรับสู่โปรแกรมคำนวณ BMI", "โปรแกรมคำนวณ");
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            // Input รับค่า TextBox
            string name = txtName.Text.Trim(); // เอาช่องว่างออกจากชื่อ

            if (string.IsNullOrWhiteSpace(name))  // ตรวจสอบว่าชื่อไม่ว่าง
            {
                lblResult.Text = "กรุณากรอกชื่อ!";
                lblResult.ForeColor = Color.Red;
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0) // ตรวจสอบอายุ
            {
                lblResult.Text = "กรุณากรอกข้อมูลอายุให้ถูกต้อง!";
                lblResult.ForeColor = Color.Red;
                return;
            }

            try
            {
                double height = ParseInput(txtHeight.Text, "ความสูง");
                double weight = ParseInput(txtWeight.Text, "น้ำหนัก");

                // คำนวณ BMI
                double bmi = CalculateBMI(height, weight);

                // ตรวจสอบสถานะ BMI
                string status = GetBMIStatus(bmi);

                // แสดงผลลัพธ์ใน Label
                lblResult.Text = $"ค่า BMI ของคุณ {name}: {bmi:F2}\nสถานะ: {status}";
                lblResult.ForeColor = Color.Green;
            }
            catch
            {
                lblResult.Text = "เกิดข้อผิดพลาดในการคำนวณ!";
                lblResult.ForeColor = Color.Red;
            }
        }

        private double ParseInput(string input, string fieldName)
        {
            if (!double.TryParse(input, out double result) || result <= 0)
            {
                throw new Exception($"กรอกข้อมูล {fieldName} ไม่ถูกต้องหรือมีค่าต่ำกว่าหรือเท่ากับ 0");
            }
            return result;
        }

        private double CalculateBMI(double height, double weight)
        {
            return weight / Math.Pow(height / 100, 2);
        }

        private string GetBMIStatus(double bmi)
        {
            if (bmi < 18.5)
                return "ผอม";
            else if (bmi < 24.9)
                return "สมส่วน";
            else if (bmi < 29.9)
                return "น้ำหนักเกิน";
            else
                return "อ้วน";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            lblResult.Text = ""; // เคลียร์ข้อความใน Label
            txtName.Focus();
        }

        // ตรวจสอบและจัดการ TextBox
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            HandleEmptyInput(txtAge);
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            HandleEmptyInput(txtHeight);
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            HandleEmptyInput(txtWeight);
        }

        // ฟังก์ชันจัดการเมื่อ TextBox ว่าง
        private void HandleEmptyInput(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "0"; // ตั้งค่าเริ่มต้นเป็น 0
                textBox.SelectionStart = textBox.Text.Length; // เลื่อนเคอร์เซอร์ไปที่ท้ายสุด
            }
        }

        private void InputDataValid(TextBox name, TextBox age)
        {
            name.ForeColor = name.Text.Length != 0 ? Color.DarkGreen : Color.Black;
            age.ForeColor = Convert.ToInt32(age.Text) > 0 ? Color.DarkGreen : Color.Black;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // อัปเดตการตรวจสอบชื่อ
            InputDataValid(txtName, txtAge);
        }
    }
}
