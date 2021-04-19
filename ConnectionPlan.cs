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
    public class ConnectionPlan
    {
        //creating instance variables for internet plan selection
        private string name;
        private int data;
        private double downSpeed, upSpeed, monthlyChanrges;
        static ConnectionPlan BASIC,STANDARD,PREMIUM;

        public ConnectionPlan()
        {

        }

        public ConnectionPlan(string name, double upSpeed, double downSpeed, int data, double monthlyCharges)
        {
            setName(name);
            setUpSpeed(upSpeed);
            setDownSpeed(downSpeed);
            setData(data);
            setMonthlyCharges(monthlyCharges);
        }
        public void setName(string name)
        {
            //checking if the name section is filled
            if (name.Equals(""))
            {
                throw new ArgumentNullException("Warning# Name cannot be empty");
            }
            if (!Regex.IsMatch(name, "^[a-zA-Z0-9_]*$"))
            {
                throw new ArgumentException("Warning# Invalid characters used in name");
            }

            this.name = name;
        }
        public void setMonthlyCharges(double charges)
        {
            //checking charges amount
            if (!Regex.IsMatch(charges.ToString(), "^[0-9]*$"))
            {
                throw new ArgumentException("Warning# Invalid amount entered");
            }
            this.monthlyChanrges = charges;
        }
        
        public void setUpSpeed(double upSpeed)
        {
            this.upSpeed = upSpeed;
        }
        public void setDownSpeed(double downSpeed)
        {
            this.downSpeed = downSpeed;
        }
        public void setData(int data)
        {
            //checking the data amount by gigabyte
            if (data > 25000)
            {
                throw new Exception("Warning# Data cant be more than 25000 GB per Month");
            }
            this.data = data;
        }
        //applying getters and setters for variables

        public string getPlan()
        {
            return name + " Plan | $ " + monthlyChanrges + "/- per month ";
        }
        public string getName()
        {
            return name;
        }
        public double getCharges()
        {
            return monthlyChanrges;
        }
        
        public int getData()
        {
            return data;
        }
        public double getUpSpeed()
        {
            return upSpeed;
        }
        public double getDownSpeed()
        {
            return downSpeed;
        }

        public override string ToString()
        {
            return getName();
        }

        //selection of the data plan chosen by the user

        public static ConnectionPlan getPlanByName(string planName)
        {
            if (!planName.Equals(" ") && Regex.IsMatch(planName, "[a-zA-Z]"))
            {
                switch (planName.ToLower())
                {
                    case "premium":
                        PREMIUM = new ConnectionPlan("PREMIUM", 500, 500, 1500, 269);
                        return PREMIUM;
                    case "standard":
                        STANDARD = new ConnectionPlan("STANDARD", 60, 100, 500, 169);
                        return STANDARD;
                    case "basic":
                        BASIC = new ConnectionPlan("BASIC", 20, 50, 500, 80);
                        return BASIC;
                    default:
                        throw new ArgumentException("Warning# invaid plan name");
                }

            }
            ConnectionPlan INVALID_PLAN = new ConnectionPlan();
            INVALID_PLAN.setName("_Invalid_Plan_");
            return INVALID_PLAN;
        }
    }
}
