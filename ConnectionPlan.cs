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
        private string name, ipAdd;
        private int data;
        private double downSpeed, upSpeed, monthlyChanrges;

        public ConnectionPlan()
        {
            name = "NewPlan_";
        }

        public ConnectionPlan(string name, string ipAdd, double upSpeed, double downSpeed, int data, double monthlyCharges)
        {
            setName(name);
            setIpAdd(ipAdd);
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
        public void setIpAdd(string ipAdd)
        {
            if (!Regex.IsMatch(ipAdd, "^[0-9.]*$"))
            {
                throw new ArgumentException("Warning# Invalid Ip Address");
            }

            string[] ipParts = ipAdd.Split('.');
            foreach (string part in ipParts)
            {
                int num = Convert.ToInt32(part);
                if (num > 255 || num < 0 || ipParts.Length > 4 || ipParts.Length < 4)
                {
                    throw new ArgumentException("Warning# Ip Address should have 4 parts with 0-255 value each part");
                }
            }

            this.ipAdd = ipAdd;
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
        public string getIpAdd()
        {
            return ipAdd;
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



        public static ConnectionPlan getPlanByName(string planName, string ipAdd)
        {
            if (!planName.Equals(" ") && Regex.IsMatch(planName, "[a-zA-Z]"))
            {
                switch (planName.ToLower())
                {
                    case "platinum":
                        ConnectionPlan PLATINUM = new ConnectionPlan("Platinum", ipAdd, 500, 800, 25000, 200);
                        return PLATINUM;
                    case "gold":
                        ConnectionPlan GOLD = new ConnectionPlan("Gold", ipAdd, 300, 500, 5000, 100);
                        return GOLD;
                    case "silver":
                        ConnectionPlan SILVER = new ConnectionPlan("Silver", ipAdd, 100, 200, 1000, 80);
                        return SILVER;
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
