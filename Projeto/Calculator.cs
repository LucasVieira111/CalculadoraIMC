namespace Projeto
{
    public class Calculator
    {
        private double pes;
        private double alt;

        public Calculator(double pes, double alt)
        {
            this.pes = pes;
            this.alt = alt;
        }

        public double resultImc()
        {
            double imc = (pes / (alt * alt));
            return Math.Round(imc,2);
        }

        public string statusImc(double x)
        {
            if(x < 18.5)
            {
                string status = "Magreza";
                return status;
            }
            else if(x >=18.5 && x <= 24.9)
            {
                string status = "Saudavel";
                return status;
            }
            else if(x >=25.0 && x <= 29.9)
            {
                string status = "Sobrepeso";
                return status;
            }
            else if(x >= 30.0 && x <= 34.9)
            {
                string status = "Obesidade Grau I";
                return status;
            }
            else if(x >= 35.0 && x <= 39.9)
            {
                string status = "Obesidade Grau II (severa)";
                return status;
            }
            else
            {
                string status = "Obesidade Grau III (morbida)";
                return status;
            }   
        }
    }
}