namespace Projeto
{
    public class Methods
    {
        private List<User> user = new List<User>();
        
        public void listUser()
        {
            if(user.Count > 0)
            {
                Console.WriteLine("{0,-15} {1,-10} {2,-10} {3,-10} {4,-10}", "Nome", "Peso","Altura","IMC","STATUS");
                Console.WriteLine(("").PadRight(80, '-'));
                
                for(int i=0; i < user.Count; i++)
                {
                    Console.WriteLine("{0,-15} {1,-10} {2,-10:F} {3,-10} {4,-10}", user.ElementAt(i).Name, user.ElementAt(i).Pes, user.ElementAt(i).Alt,user.ElementAt(i).Result,user.ElementAt(i).Status);
                    Console.WriteLine(("").PadRight(80, '-'));
                }
            }else{
                Console.WriteLine("Não existe pessoas cadastrada!");
            }
        }
        public void addUser(string name, double pes, double alt, double result, string status)
        {
            user.Add(new User(name, pes, alt, result, status));
        }
        public void removeUser()
        {
            user.Clear();
        }
    }
}