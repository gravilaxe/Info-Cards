using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CreditCardDisplay : Form
    {
        //Private string variables to store credit card details
        private string _cardNumber;
        private string _validMonth;
        private string _validYear;
        private string _expiresMonth;
        private string _expiresYear;
        private string _nameOnCard;
        private string _securityCode;
        private string _cardNickname;
        public CreditCardDisplay()
        {
            InitializeComponent();
        }
        //On loading of the display form, sets the labels of CreditCardDisplay to the constructors, aswell as the title for the form
        private void CreditCardDisplay_Load(object sender, EventArgs e)
        {
            this.Text = "Credit Card Data";
            this.Card_Number.Text = CardNumber;
            this.Valid_Month.Text = ValidMonth;
            this.Valid_Year.Text = ValidYear;
            this.Expires_Month.Text = ExpiresMonth;
            this.Expires_Year.Text = ExpiresYear;
            this.Name_On_Card.Text = NameOnCard;
            this.Security_Code.Text = SecurityCode;
            this.Card_Nickname.Text = CardNickname;
        }
        //Constructors gathering private strings to display data
        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }
        public string ValidMonth
        {
            get { return _validMonth; }
            set { _validMonth = value; }
        }
        public string ValidYear
        {
            get { return _validYear; }
            set { _validYear = value; }
        }
        public string ExpiresMonth
        {
            get { return _expiresMonth; }
            set { _expiresMonth = value; }
        }
        public string ExpiresYear
        {
            get { return _expiresYear; }
            set { _expiresYear = value; }
        }
        public string NameOnCard
        {
            get { return _nameOnCard; }
            set { _nameOnCard = value; }
        }
        public string SecurityCode
        {
            get { return _securityCode; }
            set { _securityCode = value; }
        }
        public string CardNickname
        {
            get { return _cardNickname; }
            set { _cardNickname = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
