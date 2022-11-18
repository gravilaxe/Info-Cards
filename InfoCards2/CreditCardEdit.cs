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
    public partial class CreditCardEdit : Form
    {
        //Private strings storing card details
        private string _cardNumber;
        private string _validMonth;
        private string _validYear;
        private string _expiresMonth;
        private string _expiresYear;
        private string _nameOnCard;
        private string _securityCode;
        private string _cardNickname;
        public CreditCardEdit()
        {
            InitializeComponent();
        }
        //Save button method to store data
        private void Save_Button_Click(object sender, EventArgs e)
        {
            //Check if any of the textboxes are blank, return an error message if any are left blank, otherwise save the infocard
            if (Card_Number_Textbox.Text != "" && Valid_FromMonth_Textbox.Text != "" && Valid_FromYear_Textbox.Text != "" && Expires_EndMonth_TextBox.Text != "" && Expires_EndYear_Textbox.Text != "" && Card_Name_TextBox.Text != "" && Security_Code_TextBox.Text != "" && Nickname_Textbox.Text != "")
            {
                CardNumberText = Card_Number_Textbox.Text;
                ValidMonthText = Valid_FromMonth_Textbox.Text;
                ValidYearText = Valid_FromYear_Textbox.Text;
                ExpiresMonthText = Expires_EndMonth_TextBox.Text;
                ExpiresYearText = Expires_EndYear_Textbox.Text;
                NameOnCardText = Card_Name_TextBox.Text;
                SecurityCodeText = Security_Code_TextBox.Text;
                CardNicknameText = Nickname_Textbox.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        //On loading of CreditCardEdit, set the text boxes values to be that stored in infocards.txt, if there is no data will be blank e.g a new card
        private void EditCard_Load(object sender, EventArgs e)
        {
            this.Text = "Edit Card Details";
            this.Card_Number_Textbox.Text = CardNumberText;
            this.Valid_FromMonth_Textbox.Text = ValidMonthText;
            this.Valid_FromYear_Textbox.Text = ValidYearText;
            this.Expires_EndMonth_TextBox.Text = ExpiresMonthText;
            this.Expires_EndYear_Textbox.Text = ExpiresYearText;
            this.Card_Name_TextBox.Text = NameOnCardText;
            this.Security_Code_TextBox.Text = SecurityCodeText;
            this.Nickname_Textbox.Text = CardNicknameText;
        }
        //Method to dispose of the form if the cancel button is clicked
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        //Constructors gathering private strings to store and display data from text boxes
        public string CardNumberText
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }
        public string ValidMonthText
        {
            get { return _validMonth; }
            set { _validMonth = value; }
        }
        public string ValidYearText
        {
            get { return _validYear; }
            set { _validYear = value; }
        }
        public string ExpiresMonthText
        {
            get { return _expiresMonth; }
            set { _expiresMonth = value; }
        }
        public string ExpiresYearText
        {
            get { return _expiresYear; }
            set { _expiresYear = value; }
        }
        public string NameOnCardText
        {
            get { return _nameOnCard; }
            set { _nameOnCard = value; }
        }
        public string SecurityCodeText
        {
            get { return _securityCode; }
            set { _securityCode = value; }
        }
        public string CardNicknameText
        {
            get { return _cardNickname; }
            set { _cardNickname = value; }
        }
    }
}
