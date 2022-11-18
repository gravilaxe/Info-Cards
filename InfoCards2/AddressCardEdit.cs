using System;
using System.Windows.Forms;


namespace Assignment
{
    public partial class AddressCardEdit : Form
    {
        //Private strings storing address details
        private string _houseNumber;
        private string _addressLineOne;
        private string _addressLineTwo;
        private string _postcode;
        private string _county;
        private string _city;
        private string _country;
        private string _cardNickname;

        public AddressCardEdit()
        {
            InitializeComponent();
        }
        //On loading of AddressCardEdit, set the text boxes values to be that stored in infocards.txt, if there is no data will be blank e.g new card
        private void AddressCardEdit_Load(object sender, EventArgs e)
        {
            this.Text = "Edit Card Details";
            this.House_Number_Textbox.Text = HouseNumberText;
            this.Address_One_Textbox.Text = AddressLineOneText;
            this.Address_Two_Textbox.Text = AddressLineTwoText;
            this.Postcode_Textbox.Text = PostcodeText;
            this.County_Textbox.Text = CountyText;
            this.City_Textbox.Text = CityText;
            this.Country_Textbox.Text = CountryText;
            this.Nickname_Textbox.Text = CardNicknameText;
        }

        //Save button method to store data
        private void Save_Button_Click_1(object sender, EventArgs e)
        {
            //Check if any of the textboxes are blank, return an error message if any are left blank, otherwise save the infocard
            if (House_Number_Textbox.Text != "" && Address_One_Textbox.Text != "" && Postcode_Textbox.Text != "" && County_Textbox.Text != "" && City_Textbox.Text != "" && Country_Textbox.Text != "" && Nickname_Textbox.Text != "")
            {
                HouseNumberText = House_Number_Textbox.Text;
                AddressLineOneText = Address_One_Textbox.Text;
                AddressLineTwoText = Address_Two_Textbox.Text;
                PostcodeText = Postcode_Textbox.Text;
                CountyText = County_Textbox.Text;
                CityText = City_Textbox.Text;
                CountryText = Country_Textbox.Text;
                CardNicknameText = Nickname_Textbox.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        //Cancel button method to dispose of the form if clicked
        private void Cancel_Button_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        //Constructors gathering private strings to store and display data in text boxes
        public string HouseNumberText
        {
            get { return _houseNumber; }
            set { _houseNumber = value; }
        }
        public string AddressLineOneText
        {
            get { return _addressLineOne; }
            set { _addressLineOne = value; }
        }
        public string AddressLineTwoText
        {
            get { return _addressLineTwo; }
            set { _addressLineTwo = value; }
        }
        public string PostcodeText
        {
            get { return _postcode; }
            set { _postcode = value; }
        }
        public string CountyText
        {
            get { return _county; }
            set { _county = value; }
        }
        public string CityText
        {
            get { return _city; }
            set { _city = value; }
        }
        public string CountryText
        {
            get { return _country; }
            set { _country = value; }
        }
        public string CardNicknameText
        {
            get { return _cardNickname; }
            set { _cardNickname = value; }
        }
    }
}

