namespace SimpleBankInterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcomeLabel = new Label();
            accountActive = new ComboBox();
            accountLabel = new Label();
            accountBalance = new Label();
            balanceLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            errorLabel = new Label();
            withdrawButton = new Button();
            depositButton = new Button();
            currency = new ComboBox();
            amountTextBox = new TextBox();
            amountLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(21, 24);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(205, 28);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, John Smith!";
            // 
            // accountActive
            // 
            accountActive.DropDownStyle = ComboBoxStyle.DropDownList;
            accountActive.Font = new Font("Segoe UI", 12F);
            accountActive.Location = new Point(514, 24);
            accountActive.Name = "accountActive";
            accountActive.Size = new Size(151, 36);
            accountActive.TabIndex = 1;
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Font = new Font("Segoe UI", 12F);
            accountLabel.Location = new Point(428, 37);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(93, 28);
            accountLabel.TabIndex = 2;
            accountLabel.Text = "Account: ";
            // 
            // accountBalance
            // 
            accountBalance.AutoSize = true;
            accountBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            accountBalance.Location = new Point(385, 71);
            accountBalance.Name = "accountBalance";
            accountBalance.Size = new Size(85, 28);
            accountBalance.TabIndex = 4;
            accountBalance.Text = "balance";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balanceLabel.Location = new Point(230, 71);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(82, 28);
            balanceLabel.TabIndex = 5;
            balanceLabel.Text = "Balance:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(welcomeLabel);
            panel1.Controls.Add(accountBalance);
            panel1.Controls.Add(accountActive);
            panel1.Controls.Add(balanceLabel);
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(698, 117);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(errorLabel);
            panel2.Controls.Add(withdrawButton);
            panel2.Controls.Add(depositButton);
            panel2.Controls.Add(currency);
            panel2.Controls.Add(amountTextBox);
            panel2.Controls.Add(amountLabel);
            panel2.Font = new Font("Segoe UI", 12F);
            panel2.Location = new Point(12, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(698, 219);
            panel2.TabIndex = 7;
            // 
            // errorLabel
            // 
            errorLabel.FlatStyle = FlatStyle.Flat;
            errorLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.IndianRed;
            errorLabel.Location = new Point(21, 177);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(655, 28);
            errorLabel.TabIndex = 8;
            errorLabel.Text = "error";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.Visible = false;
            // 
            // withdrawButton
            // 
            withdrawButton.BackColor = Color.LightCoral;
            withdrawButton.Location = new Point(190, 118);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(140, 42);
            withdrawButton.TabIndex = 7;
            withdrawButton.Text = "WITHDRAW";
            withdrawButton.UseVisualStyleBackColor = false;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.LightGreen;
            depositButton.Location = new Point(385, 118);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(140, 42);
            depositButton.TabIndex = 6;
            depositButton.Text = "DEPOSIT";
            depositButton.UseVisualStyleBackColor = false;
            depositButton.Click += depositButton_Click;
            // 
            // currency
            // 
            currency.DropDownStyle = ComboBoxStyle.DropDownList;
            currency.FormattingEnabled = true;
            currency.Location = new Point(514, 44);
            currency.Name = "currency";
            currency.Size = new Size(151, 36);
            currency.TabIndex = 5;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(280, 44);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(228, 34);
            amountTextBox.TabIndex = 4;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 12F);
            amountLabel.Location = new Point(134, 47);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(92, 28);
            amountLabel.TabIndex = 3;
            amountLabel.Text = "Amount: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(722, 396);
            Controls.Add(panel2);
            Controls.Add(accountLabel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Simple Bank Interface";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private ComboBox accountActive;
        private Label accountLabel;
        private Label accountBalance;
        private Label balanceLabel;
        private Panel panel1;
        private Panel panel2;
        private Label amountLabel;
        private Button depositButton;
        private ComboBox currency;
        private TextBox amountTextBox;
        private Button withdrawButton;
        private Label errorLabel;
    }
}
