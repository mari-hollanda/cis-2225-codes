using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: Dec 04, 2021 
 * Class: CIS-2225
 * Description: Practical 3 - Junior Agent Class
 */
namespace HollandaCP_Marianna_CIS2225_Practical3.BusinessLayer
{
    class JuniorAgent : Agent
    {
        //private attributes
        private double juniorCRate = 0.005;
        private double juniorCEarned;

        //getters and setters
        public double JuniorCRate { get => juniorCRate; set => juniorCRate = value; }
        public double JuniorCEarned { get => juniorCEarned; set => juniorCEarned = value; }

        public override void Calculate()
        {
            if (base.SalesAmount < 1000)
            {
                base.CommissionRate = 0.02;
            }
            else if (SalesAmount >= 1000 && SalesAmount <= 5000)
            {
                base.CommissionRate = 0.04;
            }
            else
            {
                base.CommissionRate = 0.06;
            }

            JuniorCEarned = base.SalesAmount * (base.CommissionRate - JuniorCRate);


        }
    }
}