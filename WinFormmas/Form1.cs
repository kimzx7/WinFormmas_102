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
            MessageBox.Show("�Թ�յ�͹�Ѻ���������ӹǳ BMI", "������ӹǳ");
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            // Input �Ѻ��� TextBox
            string name = txtName.Text.Trim(); // ��Ҫ�ͧ��ҧ�͡�ҡ����

            if (string.IsNullOrWhiteSpace(name))  // ��Ǩ�ͺ��Ҫ��������ҧ
            {
                lblResult.Text = "��سҡ�͡����!";
                lblResult.ForeColor = Color.Red;
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0) // ��Ǩ�ͺ����
            {
                lblResult.Text = "��سҡ�͡�������������١��ͧ!";
                lblResult.ForeColor = Color.Red;
                return;
            }

            try
            {
                double height = ParseInput(txtHeight.Text, "�����٧");
                double weight = ParseInput(txtWeight.Text, "���˹ѡ");

                // �ӹǳ BMI
                double bmi = CalculateBMI(height, weight);

                // ��Ǩ�ͺʶҹ� BMI
                string status = GetBMIStatus(bmi);

                // �ʴ����Ѿ��� Label
                lblResult.Text = $"��� BMI �ͧ�س {name}: {bmi:F2}\nʶҹ�: {status}";
                lblResult.ForeColor = Color.Green;
            }
            catch
            {
                lblResult.Text = "�Դ��ͼԴ��Ҵ㹡�äӹǳ!";
                lblResult.ForeColor = Color.Red;
            }
        }

        private double ParseInput(string input, string fieldName)
        {
            if (!double.TryParse(input, out double result) || result <= 0)
            {
                throw new Exception($"��͡������ {fieldName} ���١��ͧ�����դ�ҵ�ӡ���������ҡѺ 0");
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
                return "���";
            else if (bmi < 24.9)
                return "����ǹ";
            else if (bmi < 29.9)
                return "���˹ѡ�Թ";
            else
                return "��ǹ";
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
            lblResult.Text = ""; // �������ͤ���� Label
            txtName.Focus();
        }

        // ��Ǩ�ͺ��ШѴ��� TextBox
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

        // �ѧ��ѹ�Ѵ�������� TextBox ��ҧ
        private void HandleEmptyInput(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "0"; // ��駤����������� 0
                textBox.SelectionStart = textBox.Text.Length; // ����͹��������价������ش
            }
        }

        private void InputDataValid(TextBox name, TextBox age)
        {
            name.ForeColor = name.Text.Length != 0 ? Color.DarkGreen : Color.Black;
            age.ForeColor = Convert.ToInt32(age.Text) > 0 ? Color.DarkGreen : Color.Black;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // �ѻവ��õ�Ǩ�ͺ����
            InputDataValid(txtName, txtAge);
        }
    }
}
