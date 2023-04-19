namespace EventsWinForms
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnSave.Click += BtnSave_Counter;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtSomething.Text;
            txtSomething.Text = string.Empty;
        }
        private void BtnSave_Counter(object sender, EventArgs e)
        {
            count++;
            lblTimesClicked.Text = count.ToString();
        }
    }
}