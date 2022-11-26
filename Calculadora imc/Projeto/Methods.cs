namespace Projeto
{
    public class Methods
    {
        private List<User> user = new List<User>();
        
        public void list(){
            Console.WriteLine("Nome\t|\tPeso\t|\tAltura\t|\tIMC\t|\tSTATUS\t");
            Console.WriteLine(("").PadRight(60, '-'));
            if(user.Count > 1){
                for(int i=0; i < user.Count; i++){
                    Console.WriteLine($"\t{user.ElementAt(i).name}"+$"\t{user.ElementAt(i).pes,8:c}"+
                    $"\t{user.ElementAt(i).alt,8:c}"+$"\t{user.ElementAt(i).result,8:c}"+$"\t{user.ElementAt(i).status,8:c}");
                }
            }else{
                Console.WriteLine("Não existe pessoa cadastrada!");
            }
        }
        public void addUser(string name, double pes, double alt, double result, string status){
            user.Add(new User(name, pes, alt, result, status));
        }
        

    }

}