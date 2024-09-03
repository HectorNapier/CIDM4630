What is the output of the following code?

public interface IUser{
    bool Login(string input_username,string input_password);
}

public interface IFaculty{
    void PrintWelcome();
    void PrintWarning();
}


class Instructor:IUser, IFaculty{
    string username = "alice";
    string password = "alice123";
    public bool Login(string input_username,string input_password){
        if((username == input_username) && (password == input_password)){
            return true;
        }
        else{
            return false;
        }
    }
    public void PrintWelcome(){
        Console.WriteLine("Welcome: "+username);
    }
    public void PrintWarning(){
        Console.WriteLine("Login Failed! Try again");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Instructor ins1 = new Instructor();
        bool login_result = ins1.Login("alice","alice");
        if(login_result == true){
            ins1.PrintWelcome();
        }else{
            ins1.PrintWarning();
        }
    }
}


