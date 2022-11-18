using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    class CreditCard : IInfoCard
    {
        //Private strings to store Credit Card information
        private string _category = "Credit Card";
        private string _cardNumber;
        private string _validMonth;
        private string _validYear;
        private string _expiresMonth;
        private string _expiresYear;
        private string _nameOnCard;
        private string _securityCode;
        private string _cardNickname;
        CreditCardDisplay displayData;
        //Closes the form thought the displayData method
        public void CloseDisplay()
        {
            displayData.Close();
        }
        //Opens the CreditCardDisplay form, setting the data stored to data stored in infocards.txt
        public void DisplayData(Panel displayPanel)
        {
            displayData = new CreditCardDisplay
            {
                CardNumber = _cardNumber,
                ValidMonth = _validMonth,
                ValidYear = _validYear,
                ExpiresMonth = _expiresMonth,
                ExpiresYear = _expiresYear,
                NameOnCard = _nameOnCard,
                SecurityCode = _securityCode,
                CardNickname = _cardNickname
            };
            displayData.Show();
        }
        public bool EditData()
        {
            //Opens the CreditCardEdit form, setting the textboxes to data stored in infocards.txt, if no info is stored remains blank
            CreditCardEdit editCard = new CreditCardEdit
            {
                CardNumberText = _cardNumber,
                ValidMonthText = _validMonth,
                ValidYearText = _validYear,
                ExpiresMonthText = _expiresMonth,
                ExpiresYearText = _expiresYear,
                NameOnCardText = _nameOnCard,
                SecurityCodeText = _securityCode,
                CardNicknameText = _cardNickname
            };
            //Checks if the form has been returned as ok, saving data if so
            if (editCard.ShowDialog() == DialogResult.OK)
            {
                _cardNumber = editCard.CardNumberText;
                _validMonth = editCard.ValidMonthText;
                _validYear = editCard.ValidYearText;
                _expiresMonth = editCard.ExpiresMonthText;
                _expiresYear = editCard.ExpiresYearText;
                _nameOnCard = editCard.NameOnCardText;
                _securityCode = editCard.SecurityCodeText;
                _cardNickname = editCard.CardNicknameText;
                return true;
            }
            else
            {
                return false;
            }     
        }
        //Store card data to infocards.txt through the GetDataAsString method
        public string GetDataAsString()
        {
            string data;
            data = (_category + '|' + _cardNumber + '|' + _validMonth + '|' + _validYear + '|' + _expiresMonth + '|' + _expiresYear + '|' + _nameOnCard + '|' + _securityCode + '|' + _cardNickname);
            return data;
        }
        //Constructors gathering private strings to store data from info card
        public string Category
        { 
            get { return _category; }
        }
        public string Name
        {
            get { return _cardNickname; }
            set { _cardNickname = value; }
        }
        public string TempCardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }
        public string TempValidMonth
        {
            get { return _validMonth; }
            set { _validMonth = value; }
        }
        public string TempValidYear
        {
            get { return _validYear; }
            set { _validYear = value; }
        }
        public string TempExpireMonth
        {
            get { return _expiresMonth; }
            set { _expiresMonth = value; }
        }
        public string TempExpireYear
        {
            get { return _expiresYear; }
            set { _expiresYear = value; }
        }
        public string TempNameOnCard
        {
            get { return _nameOnCard; }
            set { _nameOnCard = value; }
        }
        public string TempSecurityCode
        {
            get { return _securityCode; }
            set { _securityCode = value; }
        }
    }
}
