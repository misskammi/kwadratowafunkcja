namespace kwadratowafunkcja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
			int vara = int.Parse(box1.Text);
			int varb = int.Parse(box2.Text);
			int varc = int.Parse(box3.Text);
			double delta = (Math.Pow(varb, 2)) - (4 * vara * varc);
			Delta.Text = "Delta:" + Convert.ToString(delta);
			if (delta < 0)
			{
				x1.Text = "brak x1";
				x2.Text = "brak x2";
				ukryty.Text = "Delta mniejsza od 0";
			}
			if (delta == 0)
			{
				double xfirst = ((-1) * varb) / (vara * 2);
				xfirst = Math.Round(xfirst, 1);
				x1.Text = "x: " + Convert.ToString(xfirst);
				x2.Text = "";
				ukryty.Text = "Delta równa 0";
			}
			if (delta > 0)
			{
				double pdelta = Math.Sqrt(delta);
				double xfirst = ((-1) * varb - pdelta) / (vara * 2);
				double xsecond = ((-1) * varb + pdelta) / (vara * 2);
				xfirst = Math.Round(xfirst, 1);
				xsecond = Math.Round(xsecond, 1);
				x1.Text = "x1: " + Convert.ToString(xfirst);
				x2.Text = "x2: " + Convert.ToString(xsecond);
				ukryty.Text = "Delta wieksza od 0";

			}
		}
    }
}