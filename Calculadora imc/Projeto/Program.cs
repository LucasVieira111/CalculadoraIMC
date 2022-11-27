using System.Collections.Generic;
namespace Projeto{
    class program
    {   
        static void Main()
        {
            Methods methods = new Methods();
            Boolean v = true;

            do{
                Console.Clear();
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
                
                Console.Clear();
                methods.list();
            
                v = false;

            }while(v == true);

            while(v != true)
            {   
                Console.WriteLine("Pressione Enter para calcular novamente");
                Console.WriteLine("Digite 'exit' para finalizar o console");
                Console.WriteLine("Digite 'limpar' para limpar os resultados anteriores e calcular novamente");            
                Console.WriteLine("Digite 'ver' para visualizar resultados anteriores e calcular novamente ");
                string op = Console.ReadLine();
                
                if(op == "")
                {   Console.Clear();
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
                    
                    Console.Clear();
                    methods.list();
                }
                else if(op == "exit")
                {   
                    Console.Clear();
                    break;
                }
                else if(op == "limpar")
                {
                    methods.removeUser();
                    Console.Clear();
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
                    
                    Console.Clear();
                    methods.list();
                }
                else if(op == "ver")
                {   
                    Console.Clear();
                    methods.list();
                }
                else
                {   
                    Console.Clear();
                    Console.WriteLine("Opção invalida, digite novamente a opção desejada");
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