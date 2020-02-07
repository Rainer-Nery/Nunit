using System;

namespace NUnitCalcTest.CalcLib
{
    public class Calculator
    {
        public float floatImc(float peso, float altura)
        {
            

            float imc ;


            imc = (peso / (altura * altura));


            return imc;
        }

        public double doubleImc(double peso, double altura)
        {


            double imc;


            imc = (peso / (altura * altura));


            return Math.Round(imc, 2);
        }
    }


  
    
}
