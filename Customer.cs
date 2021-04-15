using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDMS
{
    class Customer
    {
        private string firstName, lastName, email, streetAdd1, streetAdd2, city, province;
        private int countryCode;
        private long phoneNumber;
        private ConnectionPlan plan;


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
            this.email = email;

        }
        public void setStreetAdd1(string streetAdd)
        {
            if (streetAdd.Equals(""))
            {
                throw new ArgumentNullException("Warning# street address cannot be empty");
            }
            this.streetAdd1 = streetAdd;
        }
        public void setStreetAdd2(string streetAdd)
        {
            if (streetAdd.Equals(""))
            {
                this.streetAdd2 = " ";
            }
            this.streetAdd2 = streetAdd;
        }
        public void setCity(string city)
        {
            if (city.Equals(""))
            {
                throw new ArgumentNullException("Warning# city cannot be empty");
            }
            this.city = city;
        }
        public void setProvince(string province)
        {
            if (province.Equals(""))
            {
                throw new ArgumentNullException("Warning# province cannot be empty");
            }
            this.province = province;
        }
        public void setCountryCode(int countryCode)
        {
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
            this.phoneNumber = phNum;
        }
        public void setConnectionPlan(string planName)
        {
            this.plan = ConnectionPlan.getPlanByName(planName);
        }


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
            return email;
        }
        public string getStreetAdd1()
        {
            return streetAdd1;
        }
        public string getStreetAdd2()
        {
            return streetAdd2;
        }
        public string getCity()
        {
            return city;
        }
        public string getProvince()
        {
            return province;
        }
        public int getCountryCode()
        {
            return countryCode;
        }
        public long getPhoneNumber()
        {
            return phoneNumber;
        }
        public ConnectionPlan getConnectionPlan()
        {
            return plan;
        }


    }
}

