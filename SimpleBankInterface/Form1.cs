namespace SimpleBankInterface
{
    public partial class Form1 : Form
    {
        private decimal balance;
        private decimal maxBalance;
        public Form1()
        {
            InitializeComponent();

            // Initial balance, maxLimit (for real life scenario) and account number (hardcoded)
            balance = 1000.00m;
            maxBalance = 300000000000.00m; // Limit set to 300 Billion
            accountActive.Items.AddRange(new string[] { "1234" });
            accountActive.SelectedIndex = 0;

            accountBalance.Text = $"${balance.ToString("N2")} CAD";

            // Setup currency dropdown
            currency.Items.AddRange(new string[] { "CAD", "USD", "MXN", "EURO" });
            currency.SelectedIndex = 0; // Default to CAD
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                processTransaction(true);
            }
            catch
            {
                raiseToast("Something went wrong. Your balance stayed unaffected");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                processTransaction(false);
            }
            catch
            {
                raiseToast("Something went wrong. Your balance stayed unaffected");
            }
        }

        private void processTransaction(bool isDeposit)
        {   
            // Track existing balance to revert transaction if error occurs
            decimal existingBalance = balance;

            try
            {
                decimal amount;

                // Parse into decimal type to ensure numeric input
                if (decimal.TryParse(amountTextBox.Text, out amount) && amount > 0)
                {
                    // Ensure SelectedItem is not null before using it
                    var selectedCurrency = currency.SelectedItem as string;
                    if (selectedCurrency == null)
                    {
                        raiseToast("Please select a currency.");
                        amountTextBox.Text = "";
                        currency.SelectedIndex = 0;
                        return;
                    }

                    // Round to 2 decimal places and convert amount to CAD
                    amount = Math.Round(amount, 2);
                    decimal convertedAmount = convertToCAD(amount, selectedCurrency);

                    // Add to account if Deposit, else subtract from account if Withdraw
                    if (isDeposit)
                    {
                        if (balance + convertedAmount <= maxBalance)
                        {
                            balance += convertedAmount;
                        }
                        else
                        {
                            raiseToast("Amount exceeds max balance limit.");
                        }

                    }
                    else
                    {
                        if (convertedAmount <= balance)
                        {
                            balance -= convertedAmount;
                        }
                        else
                        {
                            raiseToast("Not enough balance.");
                        }
                    }
                    
                    // Update Frontend
                    accountBalance.Text = $"${balance.ToString("N2")} CAD";
                    amountTextBox.Text = "";
                    currency.SelectedIndex = 0;
                }
                else
                {   
                    // Raise Error
                    raiseToast("Please enter a valid amount.");
                    amountTextBox.Text = "";
                    currency.SelectedIndex = 0;
                }
            }
            catch
            {   
                // Raise Error
                raiseToast($"An error occurred during transaction. Balance was reverted.");
                accountBalance.Text = $"${existingBalance.ToString("N2")} CAD";
                amountTextBox.Text = "";
                currency.SelectedIndex = 0;
            }
        }

        private decimal convertToCAD(decimal amount, string currency)
        {   
            // Convert selected currency to CAD 
            // No try catch block as exception would be caught by outer function
            
            // Default case
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

        private void raiseToast(string message, int durationMilliseconds = 3000)
        {   
            // Raise error on the frontend side for 3 seconds
            errorLabel.Text = message;
            errorLabel.Visible = true;
            var timer = new System.Windows.Forms.Timer { Interval = durationMilliseconds };
            timer.Tick += (sender, e) =>
            {
                errorLabel.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }
    }
}
