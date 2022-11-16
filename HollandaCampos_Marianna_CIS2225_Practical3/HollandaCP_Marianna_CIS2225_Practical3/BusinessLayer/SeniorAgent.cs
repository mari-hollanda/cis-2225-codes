using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: Dec 04, 2021
 * Class: CIS-2225
 * Description: Practical 3 - Senior Agent Class
 */
namespace HollandaCP_Marianna_CIS2225_Practical3.BusinessLayer
{
    class SeniorAgent : Agent
    {
        private double seniorCRate = 0.015;
        private double seniorCEarned;

        public double SeniorCEarned { get => seniorCEarned; set => seniorCEarned = value; }
        public double SeniorCRate { get => seniorCRate; set => seniorCRate = value; }

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

            SeniorCEarned = base.SalesAmount * (base.CommissionRate + seniorCRate);

        }
    }
}

