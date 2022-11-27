namespace Projeto
{
    public class User
    {
        private String _name;
        private double _pes;
        private double _alt;
        private double _result;
        private string _status;

        public User(string name, double pes, double alt, double result, string status){
            _name = name; 
            _pes = pes; 
            _alt = alt; 
            _result = result; 
            _status = status; 
        }
        public string Name { 
            get { return _name;} 
            set{_name = value;} 
        }
        public double Pes { 
            get {return _pes;}
            set{_pes = value;} } 
        public double Alt { 
            get {return _alt;}
            set{_alt = value;} } 

        public double Result { 
            get {return _result;}
            set{_result = value;} } 
        public string Status { 
            get { return _status;} 
            set{_status = value;} 
        }
    }
}