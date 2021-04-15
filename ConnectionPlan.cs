using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDMS
{
    class ConnectionPlan
    {
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
            if (data > 25000)
            {
                throw new Exception("Warning# Data cant be more than 25000 GB per Month");
            }
            this.data = data;
        }

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
            return getPlan();
        }



        public static ConnectionPlan getPlanByName(string planName)
        {
            if (!planName.Equals(" ") && Regex.IsMatch(planName, "[a-zA-Z]"))
            {
                switch (planName.ToLower())
                {
                    case "platinum":
                        PREMIUM = new ConnectionPlan("PREMIUM", 500, 500, 1500, 269);
                        return PREMIUM;
                    case "gold":
                        STANDARD = new ConnectionPlan("STANDARD", 60, 100, 500, 169);
                        return STANDARD;
                    case "silver":
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
