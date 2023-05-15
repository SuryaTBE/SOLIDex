#region
//For this Code Under Single Responsibility Principle
//using System.ComponentModel.DataAnnotations;
//using System.Net.Mail;

//public class UserService
//{
//    public void Register(string email, string password)
//    {
//        if (!ValidateEmail(email))
//            throw new ValidationException("Email is not an email");
//        var user = new User(email, password);//Consider this is in db

//        SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
//    }
//    public virtual bool ValidateEmail(string email)
//    {
//        return email.Contains("@");
//    }
//    public bool SendEmail(MailMessage message)
//    {
//        _smtpClient.Send(message);
//    }
#endregion
//For our purpose,I didnot use db as it is for reference only.
public class UserService
{
    EmailService emailService=new EmailService();
    public void register(string username, string password,string email)
    {
        if(emailService.ValidEmail(email))
        {
            emailService.SendMail(email,username,"Welcome to SOLID priciples!....");
            Console.WriteLine("User Added...\nCheck Your Mail Inbox...");
        }
        else
        {
            Console.WriteLine("Validation Exception");
        }
    }
}
public class EmailService
{
    public bool ValidEmail(string email)
    {
        return email.Contains("@");
    }
    public void SendMail(string email,string username, string subject)
    {
        Console.WriteLine("To:  {0} \nHi {1},\n\t{2}", email, username, subject);
    }
}

