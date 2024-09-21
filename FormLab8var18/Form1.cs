namespace FormLab8var18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int n = Convert.ToInt32(textBox1.Text);
            if (IsPerfectSquare(n))
            {
                MessageBox.Show("������ ����� �������� ������ ���������!");
            }
            else MessageBox.Show("������ ����� �� �������� ������ ���������!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������");
            }
        }
        static bool IsPerfectSquare(int n)
        {

            int sqrt = (int)Math.Sqrt(n);
            MessageBox.Show($"������ ����� - ������� ����� {sqrt}");
            return sqrt * sqrt == n;

        }
    }
}
