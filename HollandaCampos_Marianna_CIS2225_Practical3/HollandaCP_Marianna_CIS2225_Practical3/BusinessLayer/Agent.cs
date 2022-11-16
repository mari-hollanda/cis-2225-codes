using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: Dec 04, 2021 
 * Class: CIS-2225
 * Description: Practical 3 - Agent Class
 */
namespace HollandaCP_Marianna_CIS2225_Practical3.BusinessLayer
{
    class Agent
    {
        //private attributes
        private string firstName;
        private string lastName;
        private string email;
        private double salesAmount;
        private double commissionRate;
        private double commissionEarned;
        private double agentCommissionRate = 0;

        //getters and setters
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public double SalesAmount { get => salesAmount; set => salesAmount = value; }
        public double CommissionRate { get => commissionRate; set => commissionRate = value; }
        public double CommissionEarned { get => commissionEarned; set => commissionEarned = value; }
        public double AgentCommissionRate { get => agentCommissionRate; set => agentCommissionRate = value; }

        public virtual void Calculate()
        {
            if (salesAmount < 1000)
            {
                commissionRate = 0.02;
            }
            else if (salesAmount >= 1000 && salesAmount <= 5000)
            {
                commissionRate = 0.04;
            }
            else
            {
                commissionRate = 0.06;
            }

            commissionEarned = salesAmount * commissionRate;

        }
    }
}