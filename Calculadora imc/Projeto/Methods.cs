namespace Projeto
{
    public class Methods
    {
        private List<User> user = new List<User>();
        
        public void list(){
            if(user.Count > 0)
            {
                Console.WriteLine("Nome   | Peso | Altura |  IMC  |  STATUS");
                Console.WriteLine(("").PadRight(50, '-'));
                
                for(int i=0; i < user.Count; i++)
                {
                    Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t", user.ElementAt(i).Name, user.ElementAt(i).Pes, user.ElementAt(i).Alt,user.ElementAt(i).Result,user.ElementAt(i).Status);
                    Console.WriteLine(("").PadRight(50, '-'));
                }
            }else{
                Console.WriteLine("Não existe pessoa cadastrada!");
            }
        }
        public void addUser(string name, double pes, double alt, double result, string status){
            user.Add(new User(name, pes, alt, result, status));
        }
        public void removeUser(){
            user.Clear();
        }
        

    }

}