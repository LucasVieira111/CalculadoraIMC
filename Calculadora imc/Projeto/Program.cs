using System.Collections.Generic;
namespace Projeto{
    class program
    {   
        static void Main()
        {
            Methods methods = new Methods();
           
            Console.Write("Digite o seu nome: ");
            string name = Console.ReadLine();
            Console.Write("Digite o seu peso: ");
            double pes = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            double alt = double.Parse(Console.ReadLine());
                
            Calculator u = new Calculator(pes, alt);
            double result = u.resultImc(); 
            string status = u.statusImc(result);
            methods.addUser(name, pes, alt, result, status);
            //Console.ReadKey();

            Boolean v = true; 
            while(v != false)
            {   
                //Console.Clear();
                Console.WriteLine("Pressione Enter para calcular novamente");
                Console.WriteLine("Digite 'exit' para finalizar o console");
                Console.WriteLine("Digite 'limpar' para limpar os resultados anteriores e calcular novamente");            
                Console.WriteLine("Digite 'ver' para visualizar resultados anteriores e calcular novamente ");
                string op = Console.ReadLine();
                
                if(op == "")
                {
                    Console.Clear();
                    Console.Write("Digite o seu nome: ");
                    string name1 = Console.ReadLine();
                    Console.Write("Digite o seu peso: ");
                    double pes1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite a sua altura: ");
                    double alt1 = double.Parse(Console.ReadLine());
                    
                    Calculator u1 = new Calculator(pes, alt);
                    double result1 = u.resultImc(); 
                    string status1 = u.statusImc(result);

                    methods.addUser(name1, pes1, alt1, result1, status1);
                    Console.ReadKey();
                }
                else if(op == "exit")
                {   
                    Console.Clear();
                    break;
                }
                else if(op == "limpar")
                {
                    
                }
                else if(op == "ver")
                {   
                    Console.Clear();
                    methods.list();
                    break;

                }
                else
                {
                    Console.WriteLine("Opção invalida, digite novamente a opção desejada");
                    Console.ReadKey();
                }

            }
        }
    }


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
            return imc;
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