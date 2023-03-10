using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Gasolina_Etanol_3._0
{
    public class CalcularRazao
    {
        private double _combustivelA;
        public double CombustivelA
        {
            get { return _combustivelA; }
            set { _combustivelA = value; }
        }


        public double _combustivelB;
        public double CombustivelB
        {
            get { return _combustivelB; }
            set { _combustivelB = value; }
        }
        

        public double Razao
        {
            get
            {
                return CombustivelB / CombustivelA;
            }

            set
            {
                Razao = value;    
            }          
         }

        public double va;

        public double VA
        {
            get { return va; }
            set { va = value; }
        }


        public double economiaG; // Economia Gasolina

        public double EconomiaG /////
        {
            get { return (VA * (Razao - 0.73)); }
            set { economiaG = value; }
        }
       
        public double economiaE; // Economia Etanol

        public double EconomiaE
        {
            get { return (VA * (0.73 - Razao)); } //VA = Valor Abastecimento
            set { economiaE = value; }
        }


        public void exibirDados()
        {
            double ExibirDados = Razao;

            if (Razao >= 0.73)//Gasolina
            {
                Console.WriteLine($"\nO combustivel mais vantajoso é a Gasolina.");
                
                Console.WriteLine($"\nVocê está economizando R${EconomiaG:f2} ");
            }

            else // Etanol
            {
                Console.WriteLine($"\nO combustivel mais vantajoso é o Etanol.");
                Console.WriteLine($"\nVocê está economizando R${EconomiaE:f2} ");
            }


        }

        public string CalcularVantagem()
        {
            if (Razao >= 0.73)//Gasolina
            {
                return "G";
            }
            else // Etanol
            {
                return "E";
            }
        }
    }
}
