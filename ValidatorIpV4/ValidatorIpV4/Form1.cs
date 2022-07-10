namespace ValidatorIpV4
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

        private void OnCheckButtonClick(object sender, EventArgs e)
        {
            string? IP = IPtextBox.Text;
            if (Validator.ValidateIP(IP) == true)
            {
                resultLabel.Visible = true;
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = "IPv4 is avaible";

            }
            else
            {
                resultLabel.Visible = true;
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = "IPv4 is not avaible";

            }
        }

        private void OnIPtextBoxClick(object sender, EventArgs e)
        {
            resultLabel.Visible = false;

        }
    }
}