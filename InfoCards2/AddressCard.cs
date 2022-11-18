using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    class AddressCard : IInfoCard
    {
        //Private string variables to store Address Details
        private string _category = "Address Details";
        private string _houseNumber;
        private string _addressLineOne;
        private string _addressLineTwo;
        private string _postcode;
        private string _county;
        private string _city;
        private string _country;
        private string _cardNickname;
        AddressCardDisplay displayData;
        //Closes the current form through the displayData Method        
        public void CloseDisplay()
        {
            displayData.Close();
        }
        //Opens the AddressCardDisplay form, setting the labels to data stored in infocards.txt
        public void DisplayData(Panel displayPanel)
        {
            displayData = new AddressCardDisplay
            {
                HouseNumber = _houseNumber,
                AddressLineOne = _addressLineOne,
                AddressLineTwo = _addressLineTwo,
                PostcodeAddress = _postcode,
                CountyAddress = _county,
                CityAddress = _city,
                CountryAddress = _country,
                AddressNickname = _cardNickname
            };
            displayData.Show();
        }
        public bool EditData()
        {
            //Opens the AddressCardEdit form, setting the textboxes to data stored in infocards.txt, if no info is stored remains blank
            AddressCardEdit editCard = new AddressCardEdit
            {
                HouseNumberText = _houseNumber,
                AddressLineOneText = _addressLineOne,
                AddressLineTwoText = _addressLineTwo,
                PostcodeText = _postcode,
                CountyText = _county,
                CityText = _city,
                CountryText = _country,
                CardNicknameText = _cardNickname,
            };
            //Checks if the form has been returned as ok, saving data if so
            if (editCard.ShowDialog() == DialogResult.OK)
            {
                _houseNumber = editCard.HouseNumberText;
                _addressLineOne = editCard.AddressLineOneText;
                _addressLineTwo = editCard.AddressLineTwoText;
                _postcode = editCard.PostcodeText;
                _county = editCard.CountyText;
                _city = editCard.CityText;
                _country = editCard.CountryText;
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
            data = (_category + '|' + _houseNumber + '|' + _addressLineOne + '|' + _addressLineTwo + '|' + _postcode + '|' + _county + '|' + _city + '|' + _country + '|' + _cardNickname);
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
        public string TempHouseNumber
        {
            get { return _houseNumber; }
            set { _houseNumber = value; }
        }
        public string TempAddressLineOne
        {
            get { return _addressLineOne; }
            set { _addressLineOne = value; }
        }
        public string TempAddressLineTwo
        {
            get { return _addressLineTwo; }
            set { _addressLineTwo = value; }
        }
        public string TempPostcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }
        public string TempCounty
        {
            get { return _county; }
            set { _county = value; }
        }
        public string TempCity
        {
            get { return _city; }
            set { _city = value; }
        }
        public string TempCountry
        {
            get { return _country; }
            set { _country = value; }
        }
        public string TempNickname
        {
            get { return _cardNickname; }
            set { _cardNickname = value; }
        }
    }
}

