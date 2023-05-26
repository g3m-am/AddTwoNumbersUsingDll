namespace AddTwoNumbersUsingDll
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int n1, n2;
			n1 = Convert.ToInt32(textBox1.Text);
			n2 = Convert.ToInt32(textBox2.Text);
			SumDll.Class1 obj = new SumDll.Class1();

			textBox3.Text = obj.Sum(n1, n2).ToString();

		}
	}
}