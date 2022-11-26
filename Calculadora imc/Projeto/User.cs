namespace Projeto
{
    public class User
    {
        public User(string name, double pes, double alt, double result, string status){
            this.name = name; 
            this.pes = pes; 
            this.alt = alt; 
            this.result = result; 
            this.status = status; 
        }
        public string name { 
            get { return name;} 
            set{this.name = name;} 
        }
        public double pes { 
            get {return pes;}
            set{this.pes = pes;} } 
        public double alt { 
            get {return alt;}
            set{this.alt = alt;} } 

        public double result { 
            get {return result;}
            set{this.result = result;} } 
        public string status { 
            get { return status;} 
            set{this.status = status;} 
        }
    }
}