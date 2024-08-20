namespace SimpleBankInterface
{
    public partial class Form1 : Form
    {
        private decimal balance;
        public Form1()
        {
            InitializeComponent();

            // Initial balance and account number (hardcoded)
            balance = 1000.00m;
            comboBox1.Items.AddRange(new string[] { "1234" });
            comboBox1.SelectedIndex = 0;

            label4.Text = $"${balance} CAD";

            // Setup currency dropdown
            comboBox2.Items.AddRange(new string[] { "CAD", "USD", "MXN", "EURO" });
            comboBox2.SelectedIndex = 0; // Default to CAD
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessTransaction(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessTransaction(false);
        }

        private void ProcessTransaction(bool isDeposit)
        {
            decimal amount;
            if (decimal.TryParse(textBox1.Text, out amount) && amount > 0)
            {
                // Ensure SelectedItem is not null before using it
                var selectedCurrency = comboBox2.SelectedItem as string;
                if (selectedCurrency == null)
                {
                    MessageBox.Show("Please select a currency.");
                    return;
                }

                decimal convertedAmount = ConvertToCAD(amount, selectedCurrency);

                if (isDeposit)
                {
                    balance += convertedAmount;
                }
                else
                {   
                    if (convertedAmount <= balance)
                    {
                        balance -= convertedAmount;
                    }
                    else
                    {
                       MessageBox.Show("Not enough balance.");
                    }
                }

                label4.Text = $"${balance} CAD";
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private decimal ConvertToCAD(decimal amount, string currency)
        {
            decimal conversionRate = 1.0m;

            switch (currency)
            {
                case "USD":
                    conversionRate = 2.0m;
                    break;
                case "MXN":
                    conversionRate = 0.1m;
                    break;
                case "EURO":
                    conversionRate = 4.0m;
                    break;
            }

            return amount * conversionRate;
        }
    }
}
