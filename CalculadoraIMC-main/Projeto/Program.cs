using System.Collections.Generic;
namespace Projeto
{
    class Program
    {   
        static void Main()
        {
            Methods methods = new Methods();
            Boolean v = true;

            do
            {
                try
                {
                    Console.Clear();
                    int myInt;
                    Console.Write("Digite o seu nome: ");
                    string name = Console.ReadLine();
                    bool isNumerical = int.TryParse(name, out myInt);
                    if(isNumerical == true)
                    {
                        Console.WriteLine("Formato de nome invalido.");
                        break;
                    }
                    Console.Write("Digite o seu peso: ");
                    double pes = double.Parse(Console.ReadLine());
                    Console.Write("Digite a sua altura: ");
                    double alt = double.Parse(Console.ReadLine());
                    Calculator u = new Calculator(pes, alt);

                    double result = u.resultImc(); 
                    string status = u.statusImc(result);
                    methods.addUser(name, pes, alt, result, status);
                
                    Console.Clear();
                    methods.listUser();
            
                    v = false;
                }
                catch(System.NullReferenceException excepition)
                {
                    Console.WriteLine($"Erro de Referencia nula. {excepition.StackTrace}");
                }
                catch(System.FormatException excepition){
                    Console.WriteLine($"Dados inseridos Incorretamente. {excepition.StackTrace}");
                }
                catch(Exception excepition)
                {   
                    Console.WriteLine($"Erro. {excepition.StackTrace}");
                }
                    
            }while(v == true);

            while(v != true)
            {   
                Console.WriteLine("Pressione Enter para calcular novamente");
                Console.WriteLine("Digite 'exit' para finalizar o console");
                Console.WriteLine("Digite 'limpar' para limpar os resultados anteriores e calcular novamente");            
                Console.WriteLine("Digite 'ver' para visualizar resultados anteriores e calcular novamente ");
                string op = Console.ReadLine();
                
                if(op == "")
                {   
                    try
                    {
                        Console.Clear();
                        int myInt;
                        Console.Write("Digite o seu nome: ");
                        string name = Console.ReadLine();
                        bool isNumerical = int.TryParse(name, out myInt);
                        if(isNumerical == true)
                        {
                            Console.WriteLine("Formato de nome invalido.");
                            break;
                        }

                        Console.Write("Digite o seu peso: ");
                        double pes = double.Parse(Console.ReadLine());
                        Console.Write("Digite a sua altura: ");
                        double alt = double.Parse(Console.ReadLine());

                        Calculator u = new Calculator(pes, alt);
                        double result = u.resultImc(); 
                        string status = u.statusImc(result);
                        methods.addUser(name, pes, alt, result, status);
                    
                        Console.Clear();
                        methods.listUser();
                    }
                    catch(System.NullReferenceException excepition)
                    {
                        Console.WriteLine($"Erro de Referencia nula. {excepition.StackTrace}");
                    }
                    catch(System.FormatException excepition){
                        Console.WriteLine($"Dados inseridos Incorretamente. {excepition.StackTrace}");
                    }
                    catch(Exception excepition)
                    {   
                        Console.WriteLine($"Erro. {excepition.StackTrace}");
                    }
                }
                else if(op == "exit")
                {   
                    Console.Clear();
                    break;
                }
                else if(op == "limpar")
                {
                    methods.removeUser();
                    try
                    {
                        Console.Clear();
                        int myInt;
                        Console.Write("Digite o seu nome: ");
                        string name = Console.ReadLine();
                        bool isNumerical = int.TryParse(name, out myInt);
                        if(isNumerical == true){
                            Console.WriteLine("Formato de nome invalido.");
                            break;
                        }

                        Console.Write("Digite o seu peso: ");
                        double pes = double.Parse(Console.ReadLine());
                        Console.Write("Digite a sua altura: ");
                        double alt = double.Parse(Console.ReadLine());
                        
                        Calculator u = new Calculator(pes, alt);
                        double result = u.resultImc(); 
                        string status = u.statusImc(result);
                        methods.addUser(name, pes, alt, result, status);
                    
                        Console.Clear();
                        methods.listUser();
                    }
                    catch(System.NullReferenceException excepition)
                    {
                        Console.WriteLine($"Erro de Referencia nula. {excepition.StackTrace}");
                    }
                    catch(System.FormatException excepition){
                        Console.WriteLine($"Dados inseridos Incorretamente. {excepition.StackTrace}");
                    }
                    catch(Exception excepition)
                    {   
                        Console.WriteLine($"Erro. {excepition.StackTrace}");
                    }
                }
                else if(op == "ver")
                {   
                    Console.Clear();
                    methods.listUser();
                }
                else
                {   
                    Console.Clear();
                    Console.WriteLine("Opção invalida, digite novamente a opção desejada");
                }
            }
        }
    }
}