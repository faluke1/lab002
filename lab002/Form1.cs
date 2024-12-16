using System.Xml.Linq;

namespace lab002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("���ʴ�!", "!!!Welcome Text!!!",
          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            // ��Ǩ�ͺ��ҷ���͹� TextBox
            if (double.TryParse(txtRadius.Text, out double radius))
            {
                // ���¡�� Method Ẻ return ���ͤӹǳ��鹷��ǧ���
                double area = calculate(radius);

                // �ʴ����Ѿ��� Label
                lblResult.Text = area.ToString("0.00");
            }
            else
            {
                MessageBox.Show("������", "����");
                txtRadius.Focus(); // ��� cursor ����� TextBox
                txtRadius.Select(); // ������͡��ͤ���� TextBox
            }
        }

        // Method Ẻ return ����Ѻ�ӹǳ��鹷��ǧ���
        private double calculate(double radius)
        {
            return Math.PI * Math.Pow(radius, 2); // �׹��Ҿ�鹷��ǧ���
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            SAM(txtHeight.Text, txtWidth.Text);
        }
        void SAM(string Sung, string Yaw)
        {
            double THeight = 0;
            double TBase = 0;
            if (double.TryParse(Sung, out THeight) == false)
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            if (double.TryParse(Yaw, out TBase) == false)
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }
            double TriArea = 0.5 * TBase * THeight;
            lblResult.Text = TriArea.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();
        }


        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double HexW = 0;
            if (double.TryParse(txtHexagonWidth.Text, out HexW) == false)
            {
                MessageBox.Show("Please input only number.", " !!! Error !!! ");
                return;
            }

            //lblResult.Text = HexArea.ToString("0.00");
            double faukeshop = Toat(HexW);
            lblResult.Text = faukeshop.ToString("0.00");

            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        double Toat(double yawtant)
        {
            return (3 * Math.Sqrt(3) * Math.Pow(yawtant, 2)) / 2;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to close me?", "The Program",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearForm();
        }
        private void clearForm()
        {
            txtRadius.Text = "";
            txtHeight.Text = "";
            txtWidth.Text = "";
            txtHexagonWidth.Text = "";
            lblResult.Text = "";

            //txtName.TextAlign = HorizontalAlignment.Left; // �Ѵ�Դ����
            //txtAge.TextAlign = HorizontalAlignment.Right; // �Ѵ�Դ���
            //txtHeight.TextAlign = HorizontalAlignment.Right; // �Ѵ�Դ���
            //txtWeight.TextAlign = HorizontalAlignment.Right; // �Ѵ�Դ���
            //txtName.Focus(); // ⿡�ʷ�����
        }
    }
}
