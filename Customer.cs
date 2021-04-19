using System;
using System.Text.RegularExpressions;

/*****************************
 * 
 * Author: Manjiner singh
 * Student Number: 200455485 
 * 
 ***************************/

namespace TDMS
{
    public class Customer
    {
        //creating instance variables for customer info
        private string firstName, lastName, email_, streetAdd1_, streetAdd2_, city_, province_;
        private int countryCode;
        private long phoneNumber_;
        private ConnectionPlan plan_;


        public Customer(string fName, string lName, string email, string strAdd1,
            string strAdd2, string city, string province, int ctrCode, long phNum)
        {
            setFirstName(fName);
            setLastName(lName);
            setEmail(email);
            setStreetAdd1(strAdd1);
            setStreetAdd2(strAdd2);
            setCity(city);
            setProvince(province);
            setCountryCode(ctrCode);
            setPhoneNumber(phNum);
        }

        public Customer(string fName, string lName, string email, string strAdd1,
           string city, string province, int ctrCode, long phNum)
        {
            setFirstName(fName);
            setLastName(lName);
            setEmail(email);
            setStreetAdd1(strAdd1);
            setStreetAdd2("");
            setCity(city);
            setProvince(province);
            setCountryCode(ctrCode);
            setPhoneNumber(phNum);
        }

        public void setFirstName(string firstName)
        {
            //checking if first name is entered
            if (firstName.Equals(""))
            {
                throw new ArgumentNullException("Warning# First Name cannot be empty");
            }
            if (!Regex.IsMatch(firstName, "^[a-zA-Z]*$"))
            {
                throw new ArgumentException("Warning# Invalid characters used in First name");
            }
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            //checking if last name is entered
            if (firstName.Equals(""))
            {
                throw new ArgumentNullException("Warning# Last Name cannot be empty");
            }
            if (!Regex.IsMatch(lastName, "^[a-zA-Z]*$"))
            {
                throw new ArgumentException("Warning# Invalid characters used in Last name");
            }
            this.lastName = lastName;
        }
        public void setEmail(string email)
        {
            //checking if email is entered
            if (email.Equals(""))
            {
                throw new ArgumentNullException("Warning# Name cannot be empty");
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new ArgumentException("Warning# Invalid email, please use proper syntax");
            }
            if (!Regex.IsMatch(email, "^[@a-zA-Z.]*$"))
            {
                throw new ArgumentException("Warning# Invalid email, please use proper syntax");
            }
            this.email_ = email;

        }
        public void setStreetAdd1(string streetAdd)
        {
            //checking the two street addresses
            if (streetAdd.Equals(""))
            {
                throw new ArgumentNullException("Warning# street address cannot be empty");
            }
            this.streetAdd1_ = streetAdd;
        }
        public void setStreetAdd2(string streetAdd)
        {
            if (streetAdd.Equals(""))
            {
                this.streetAdd2_ = " ";
            }
            this.streetAdd2_ = streetAdd;
        }
        public void setCity(string city)
        {
            //checking if customer city/town and province is entered
            if (city.Equals(""))
            {
                throw new ArgumentNullException("Warning# city cannot be empty");
            }
            this.city_ = city;
        }
        public void setProvince(string province)
        {
            if (province.Equals(""))
            {
                throw new ArgumentNullException("Warning# province cannot be empty");
            }
            this.province_ = province;
        }
        public void setCountryCode(int countryCode)
        {
            //checking customer phone number including their country code
            if (countryCode.Equals(null))
            {
                throw new ArgumentNullException("Warning# country code cannot be empty");
            }
            this.countryCode = countryCode;
        }
        public void setPhoneNumber(long phNum)
        {
            if (phNum.Equals(null))
            {
                throw new ArgumentNullException("Warning# phone number cannot be empty");
            }
            this.phoneNumber_ = phNum;
        }
        public void setConnectionPlan(string planName)
        {
            this.plan_ = ConnectionPlan.getPlanByName(planName);
        }

        //implementing getters and setters for the customer variables 
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getEmail()
        {
            return email_;
        }
        public string getStreetAdd1()
        {
            return streetAdd1_;
        }
        public string getStreetAdd2()
        {
            return streetAdd2_;
        }
        public string getCity()
        {
            return city_;
        }
        public string getProvince()
        {
            return province_;
        }
        public int getCountryCode()
        {
            return countryCode;
        }
        public long getPhoneNumber()
        {
            return phoneNumber_;
        }
        public ConnectionPlan getConnectionPlan()
        {
            return plan_;
        }


    }
}

