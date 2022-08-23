public class Users
{
     
     public string Name;
     
     public string MessageInbox;

     public void SendMessage(string MessageText, Users user){
        
        user.MessageInbox="~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~"+"\n"+user.MessageInbox+"\n"+MessageText+"\n";
     }

    public static void ShowInbox(Users user){
        Console.WriteLine("\t\t\t"+user.Name+ " Inbox"+"\n");
        if (user.MessageInbox==null){
            Console.WriteLine(user.Name+", size heç bir mesaj yazilmayib");
        }
        else{
            Console.WriteLine("\t\t"+user.Name+", yeni bir mesajin var!"+"\n\n"+user.MessageInbox);
            
        }
    }
}