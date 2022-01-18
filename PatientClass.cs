using System;
using System.Collections.Generic;

namespace My1stProjet
{
    public class Patient
    {
        public string Firstname {get; set;}
        public string Lastname {get; set;}
        public Gender  Gender {get;set;}
        public string  Phonenumber {get; set;}
        public int Age {get; set;}
        public string RegistrationNumber {get;}
        public double Temperature {get;set;}
          public ModeOFSickness ModeOFSickness {get; set;}

        public  BloodGroup BloodGroup {get;set;}
       public bool PatientAddimissionStatus = false;
        private static int NumOfReg = 0;
        public static List<Patient> pt1 = new List <Patient>();

        public Patient (string firstname,string lastname, Gender gender, string phonenumber, int age,ModeOFSickness modeOFSickness, double temperature, BloodGroup bloodgroup)
        {
            Firstname = firstname;
            Lastname = lastname;
            Gender = gender;
            Phonenumber = phonenumber;
            Age = age;
            RegistrationNumber =   GenerateRegistrationNumber();
            Temperature = temperature;
            modeOFSickness = ModeOFSickness;
            BloodGroup = bloodgroup;
            NumOfReg++;
             AddToPatient();

        }
           private string GenerateRegistrationNumber()
           {
               Console.ForegroundColor = ConsoleColor.DarkYellow;
            return $"PT{NumOfReg.ToString(/*format*/ "0001")}";
           }
           public void AddToPatient()
           {
               pt1.Add(this);
           }  
           public void PrintPatientDetails()
           {
              Console.ForegroundColor = ConsoleColor.Blue;
             Console.WriteLine("WELCOME ...........TO........CITY.........hOSPITAL<<<<<<<<<>>>>>>>>>>>>>, 15TH TIME BEST HOSPITAL IN WEST AFRICA");Console.ForegroundColor = ConsoleColor.Red;
              Console.Beep();
              Console.ForegroundColor = ConsoleColor.DarkGray;
              Console.WriteLine($"dear {Firstname} {Lastname} Welcome to City Hospital, \n your Registration number is {RegistrationNumber}");
              
              Console.ForegroundColor = ConsoleColor.White;
              
           } 
            //    public static void PrintPatient()
            //    {
            //        for (int i = 1; i <NumOfReg; i++)
            //        {
            //           Console.WriteLine($" \n {pt1[i] . RegistrationNumber} \n {pt1[i]. Firstname} \n {pt1[i]. Lastname}");
            //        }
            //    }

           public static void Registration()
           {
             //  Console.WriteLine("how many patiet wou you like to Register");
             //  int reg = int.Parse(Console.ReadLine());
            //   for (int i = 0; i < reg; i++)
              // {
                    Console.WriteLine("welcome to city Hospital <<<>><<<>>>>>><>> kindly provide the necessary details for your Registration");
                    Console.WriteLine("enter your firstName");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your last name");
                    string name2 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("chose your gender");
                    Console.WriteLine("\t1 for male");
                    Console.WriteLine("\t2  forfemale");
                    Console.WriteLine("\t3 for RatherNotSpecify");
                    var answer =  (Gender)int.Parse(Console.ReadLine()); 
                    Console.WriteLine("enter your phone number");
                    string phone = Console.ReadLine();
                    Console.WriteLine("enter your age");
                    int age = int.Parse(Console.ReadLine());  
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                   Console.WriteLine("please kindly choose your mode of sickness");
                    Console.WriteLine("\t1 for minor Case");
                    Console.WriteLine("\t2 for Normal Case");
                    Console.WriteLine("\t3 for critical case");
                    Console.WriteLine("\t4 for very critical case"); 
                   var sick = (ModeOFSickness)int.Parse(Console.ReadLine());
                  Console.ForegroundColor = ConsoleColor.DarkGray; 
                    Console.WriteLine("chose  your blood group");
                    Console.WriteLine("\t1 for AA");
                    Console.WriteLine("\t2 for AS");
                    Console.WriteLine("\t3 for SS");   
                    var blood =(BloodGroup)int.Parse(Console.ReadLine());
                    Console.WriteLine("enter your temperature");
                    double temp = double.Parse(Console.ReadLine());  

                    Patient ps2 = new Patient(name,name2,answer,phone,age,sick,temp,blood);
                    ps2.PrintPatientDetails();
                       
              //  }
           }
           public static Patient CheckPatientRegNum(string RegNum)
           {
               foreach (var item in pt1)
               {
                   if (item.RegistrationNumber.Equals(RegNum))
                   {
                       return item;
                   }
               }
               return null;
           }
           
           public static string GenerateAddmissionNumber()
           {
               Console.ForegroundColor = ConsoleColor.Gray;
               return $"city PT{Guid.NewGuid().ToString().Substring(0,4)}";
           }

           public static String GenerateSeatNumber()
           {
               Random rmd = new Random();
             return $"CITY{rmd.Next(100,501)}BD";
           }
    }
}