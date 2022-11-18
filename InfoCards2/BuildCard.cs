using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class BuildCard : IInfoCardFactory
    {
        private string _description;
        
        //Constructor for the categories to be supported, and the categories supported
        public string[] CategoriesSupported { get { return _categoriesSupported; } }
        string[] _categoriesSupported = { "Credit Card", "Address Details" };
        //Create info card using CreateInfoCardMethod
        public IInfoCard CreateInfoCard(string initialDetails)
        {
            //Make new instances of CreditCard and AddressCard
            CreditCard cardOne = new CreditCard();
            AddressCard cardTwo = new AddressCard();
            //Create a variable to be split into a string array
            var stringData = initialDetails;
            string[] cardDetails = stringData.Split('|');
            //If the category is a credit card store information from infocard.txt to Temp variables 
            if (cardDetails[0] == "Credit Card")
            {
                cardOne.TempCardNumber = cardDetails[1];
                cardOne.TempValidMonth = cardDetails[2];
                cardOne.TempValidYear = cardDetails[3];
                cardOne.TempExpireMonth = cardDetails[4];
                cardOne.TempExpireYear = cardDetails[5];
                cardOne.TempNameOnCard = cardDetails[6];
                cardOne.TempSecurityCode = cardDetails[7];
                cardOne.Name = cardDetails[8];
                return cardOne;
            }
            else  //If the category is an address card store information from infocard.txt to Temp Variables
            {   
                cardTwo.TempHouseNumber = cardDetails[1];
                cardTwo.TempAddressLineOne = cardDetails[2];
                cardTwo.TempAddressLineTwo = cardDetails[3];
                cardTwo.TempPostcode = cardDetails[4];
                cardTwo.TempCounty = cardDetails[5];
                cardTwo.TempCity = cardDetails[6];
                cardTwo.TempCountry = cardDetails[7];
                cardTwo.TempNickname = cardDetails[8];
                return cardTwo;
            }
        }
        //CreateNewInfoCard method to return creditInfoCard/addressInfoCard
        public IInfoCard CreateNewInfoCard(string category)
        {
            CreditCard creditInfoCard = new CreditCard();
            AddressCard addressInfoCard = new AddressCard();
            //Checks the category of the card, returing creditInfoCard if a credit card is being read, otherwise an addressInfoCard
            if (category == "Credit Card")
            {
                return creditInfoCard;
            }
            else
            {
                return addressInfoCard;
            }
        }
        //GetDescription method to display description of the card when the user attempts to make a new card
        public string GetDescription(string category)
        {
            if (category == "Credit Card")
            {
                _description = "Store Credit Card Information";
            }
            if (category == "Address Details")
            {
                _description = "Store Address Information";
            }
            return _description;
        }
    }
}
