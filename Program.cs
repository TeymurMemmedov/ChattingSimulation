// Creating user1
Users user1=new Users();
user1.Name="Ceyhun";

// Creating user2
Users user2=new Users(); 
user2.Name="Teymur";

// Creating user3
Users user3=new Users();
user3.Name="Tural";

// All users in system and special friend list for current user
List<Users> UserList = new List<Users>(){user1,user2,user3};
int yekunNumber=0;
Console.WriteLine("----------------------------------------------------\n");
while(yekunNumber<5)
{
    List<Users> Dostlar =new List<Users>();
    List<Users> CurrentUserList=new List<Users>();

    Console.Write("Sistemde hansi userdir?:");
    string CurrentUserName=Console.ReadLine();
    Users CurrentUser;
    
    
    foreach (Users User in UserList)
    {
        if (CurrentUserName!=User.Name)
        { 
            Dostlar.Add(User);
        }
        else{
            CurrentUserList.Add(User);
        }
       


}   Console.WriteLine("----------------------------------------------------\n");
    Console.WriteLine("Mesaj ata bileceyin dostlarin:");
    int number=0;
    foreach (Users User in Dostlar)
    {
        Console.WriteLine((number+1)+":"+User.Name);
        number=number+1;
    }
    Console.WriteLine("----------------------------------------------------\n");
    while(true){
    Console.Write("Icra etmek istediyin emeliyyati sec:\n1-Mesaj gondermek\n2-Inboxa baxmaq\nSecimin:");
        string choice=Console.ReadLine();
        Console.WriteLine("----------------------------------------------------\n");
        if (choice=="1")
        {
            Console.Write("Mesaj yazmaq istediyiniz userin adini qeyd edin: ");
            string contactName=Console.ReadLine();
            Users contact;
            Console.Write("Mesajin metnini daxil edin: ");
            string textOfMessage=Console.ReadLine();
            Console.WriteLine("----------------------------------------------------\n");
            
            foreach (Users UsersItem in Dostlar)
            {
                if(contactName==UsersItem.Name){
                    CurrentUser=CurrentUserList[0];
                    contact=UsersItem;
                    textOfMessage=CurrentUser.Name+" adli kontaktdan gelen mesaj:"+textOfMessage;
                    CurrentUser.SendMessage(textOfMessage,contact);
                    
                }
                
            }
        }
         else if (choice=="2")
        {   
            Console.WriteLine("----------------------------------------------------\n");
             CurrentUser=CurrentUserList[0];
             Users.ShowInbox(CurrentUser);
             
             Console.WriteLine("----------------------------------------------------\n");
        }
        Console.WriteLine("Ne etmek isteyirsen?\n1-Emeliyyatlara davam etmek\n2-Yox,islerim bitdi!");
        string choice2=Console.ReadLine();
        if (choice2=="1")
        {
            continue;
        }
        else if(choice2=="2"){
            break;
        }
        
        
    }
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("----------------------------------------------------\n");
       
    
    Console.Write("Icra etmek istediyin emeliyyati sec:\n1-Programdan cixmaq\n2-User deyismek\nSecimin:");
    string secim2=Console.ReadLine();
    Console.WriteLine("----------------------------------------------------\n");
    if (secim2=="1")
    {
        break;
    }
    else if(secim2=="2")
    {
        continue;
    }

}




 
 


    







// // user 1 send message to user 2
// user1.SendMessage("Salam, bu gün axsamki konserte geleceksen?",user2);
// Console.WriteLine("--------------------------------------------");
// // ser2 check te inbox and see message
// Users.ShowInbox(user2);
// Console.WriteLine("--------------------------------------------");
// // user 2 send answer message
// user2.SendMessage("Xeyr bu gun ozumu yaxsi hiss etmirem", user1);
// Console.WriteLine("---------------------------------------------");
// // user 1 check inbox see answer
// Users.ShowInbox(user1);
// Console.WriteLine("---------------------------------------------");
// // user 1 send message to user 2
// user1.SendMessage("Yaxsi, onda gelen defe gederik, ozune yaxsi bax",user2);
// Console.WriteLine("---------------------------------------------");
// // user 2 check inbox
// Users.ShowInbox(user2);
// Console.WriteLine("---------------------------------------------");

// // user3 check the inbox but nobody messaged to him
// Users.ShowInbox(user3);
// Console.WriteLine("----------------------------------------------");



