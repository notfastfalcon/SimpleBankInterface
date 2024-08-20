# SimpleBankInterface
This is a minimalistic bank user interface programmed in C# using Windows Forms. This bank allows customers to create checking accounts. The checking account balance is always tracked in Canadian currency. Deposits and withdraws can be made in Canadian dollars, US dollars, Mexican Pesos or Euros. The applicable exchange rate is applied when depositing or withdrawing a foreign currency.
Exchange Rates:
$1.00 CAD = $0.50 USD
$1.00 CAD = $10.00 MXN
$1.00 CAD = €0.25 EURO

### Functionality: ###
* Current account balance is displayed
* Initial balance is hard coded to $1000 CAD
* User can make a withdrawal or deposit using the following fields:
    * Amount (numeric input)
    * Currency (dropdown) - static list of currencies: CAD/USD/MXN/EURO. Adding/deleting/renaming of currencies is not available.

### Limitations: ###
* Minimalistic input validation 
* No authorization/authentication functionality
* No database support
* No ability to switch between accounts



