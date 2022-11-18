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
    public partial class AddressCardDisplay : Form
    {
        //Private string variables to store address details
        private string _houseNumber;
        private string _addressLineOne;
        private string _addressLineTwo;
        private string _postcode;
        private string _county;
        private string _city;
        private string _country;
        private string _addressNickname;
        public AddressCardDisplay()
        {
            InitializeComponent();
        }
        //On loading of the display form, sets the labels of AddressCardDisplay to the constructors, aswell as the title for the form
        private void AddressCardDisplay_Load(object sender, EventArgs e)
        {
            this.Text = "Address Details";
            this.House_Number.Text = HouseNumber;
            this.Address_One.Text = AddressLineOne;
            this.Address_Two.Text = AddressLineTwo;
            this.Postcode.Text = PostcodeAddress;
            this.County.Text = CountyAddress;
            this.City.Text = CityAddress;
            this.Country.Text = CountryAddress;
            this.Address_Nickname.Text = AddressNickname;
        }
        //Constructors gathering private strings to display data
        public string HouseNumber
        {
            get { return _houseNumber; }
            set { _houseNumber = value; }
        }
        public string AddressLineOne
        {
            get { return _addressLineOne; }
            set { _addressLineOne = value; }
        }
        public string AddressLineTwo
        {
            get { return _addressLineTwo; }
            set { _addressLineTwo = value; }
        }
        public string PostcodeAddress
        {
            get { return _postcode; }
            set { _postcode = value; }
        }
        public string CountyAddress
        {
            get { return _county; }
            set { _county = value; }
        }
        public string CityAddress
        {
            get { return _city; }
            set { _city  = value; }
        }
        public string CountryAddress
        {
            get { return _country; }
            set { _country = value; }
        }
        public string AddressNickname
        {
            get { return _addressNickname; }
            set { _addressNickname = value; }
        }
    }
}

