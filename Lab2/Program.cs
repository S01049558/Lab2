using System;

namespace Lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student A = new Student();
            A.lName = "Modou";
            A.fName = "Jallow";
            A.Age = 38;
            A.EmailAddress = "s01020445@acad.tri-.edu";
            A.socialSecurityNumber = 218986543;

            Student B = new Student();
            B.lName = "Douo";
            B.fName = "Germain";
            B.Age = 37;
            B.EmailAddress = "S01049558@acad.tri-c.edu";
            B.socialSecurityNumber = 217432277;

            Console.WriteLine(A.lName + ", " + A.fName + ", " + A.Age + A.EmailAddress + ", " + A.socialSecurityNumber);
            Console.WriteLine(B.lName + ", " + B.fName + ", " + B.Age + B.EmailAddress + ", " + B.socialSecurityNumber);
            Console.ReadLine();

            
          
        }  
    }
}
