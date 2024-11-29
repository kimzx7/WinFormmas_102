using System;
using System.Drawing; // สำหรับการจัดการสี
using System.Windows.Forms;

namespace WinFormmas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // สร้างสามเหลี่ยมและแสดงใน txtResult
            txtResult.Text = Triangle2("*", 5);

            // เปลี่ยนสีของข้อความใน txtResult
            txtResult.ForeColor = Color.Olive; // กำหนดสีฟ้า
        }

        // ฟังก์ชันสำหรับสร้างสามเหลี่ยมด้วย '*'
        string Triangle(int size)
        {
            string txt_result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += "*";
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }

        // ฟังก์ชันสำหรับสร้างสามเหลี่ยมด้วยตัวอักษรที่กำหนด
        string Triangle2(string letter, int size)
        {
            string txt_result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += letter;
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }
    }
}
