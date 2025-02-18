namespace TP_1
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Ej1_Click(object sender, EventArgs e)
        {
            this.Hide();
            E1 e1 = new E1();
            e1.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            E2 e2 = new E2();
            e2.ShowDialog();
            this.Show();
        }
    }
}
