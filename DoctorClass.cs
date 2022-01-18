using System;
using System.Collections.Generic;

namespace My1stProjet
{
    public class Doctor
    {
        public string Firstname {get; set;}
        public string Lastname {get; set;}
        public Gender  Gender {get;set;}
        public string  Phonenumber {get; set;}
        public int Age {get; set;}
        public string DoctorID {get;}
        public Doctorspecialization DocctorSpecialization {get; set;}

         public static List<Doctor> D1 = new List <Doctor>();
         public static int TimesofRegistration = 0;


        public Doctor (string firstname, string lastname, Gender gender,string phonenumber, int age, Doctorspecialization doctorspecialization)
        {
            Firstname = firstname;
            Lastname  = lastname;
            Gender = gender;
            Phonenumber = phonenumber;
            Age = age;
            DoctorID =   GenerateDoctorID();
           DocctorSpecialization = doctorspecialization;
           TimesofRegistration++;

        }

          public static Doctor CheckDoctorID(string RegNum)
           {
               foreach (var item in D1)
               {
                   if (item.DoctorID.Equals(RegNum))
                   {
                       return item;
                   }
               }
               return null;
           }

        public string GenerateDoctorID()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Random rmd = new Random();

            return $"DC{rmd.Next(100,501)}";
        }
        public  void StoreDoctorDtails()
        {
            D1.Add(this);
        }

        public void PrintDoctorDetails()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" <<<<<<<<>>>>>>>>>>>>>>> Welcome To City Hospital <<<<<<<<<>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine($"dear doctor {Firstname} {Lastname} your registration ID is {DoctorID}");
        }
    
        public static void DoctorRegistration()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine(" <<<<<<<<>>>>>>>>>>>>>>> Welcome To City Hospital <<<<<<<<<>>>>>>>>>>>>>>>>>>>");
           //  Console.WriteLine("how many doctor would you like to register");
         //   int add = int.Parse(Console.ReadLine());
          //  for (int i =0; i< add; i++)
         //   {
                Console.WriteLine("kindly provide your details for your registration");
                Console.WriteLine("enter your first name");
                string name = Console.ReadLine();
                Console.WriteLine("enter your last name ");
                string name2 = Console.ReadLine();
                Console.WriteLine("chose your gender");
                Console.WriteLine("\t1 for male");  
                Console.WriteLine("\t2 for female");
                 Console.WriteLine("\t3 for Rathernotspecifry");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                var result =  (Gender)int.Parse(Console.ReadLine());  
                Console.WriteLine("enter your phonenumber");
                string phone = Console.ReadLine();
                Console.WriteLine("enter your age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("chose your specialization");
                Console.WriteLine("\t1 for seniorDoctor");
                Console.WriteLine("\t2 for juniorDoctor"); 
                Console.WriteLine("\t3 for ResidentDoctor");
                Console.WriteLine("\t4 for Matron"); 
                Console.ForegroundColor = ConsoleColor.Gray;
                var answer=(Doctorspecialization)int.Parse(Console.ReadLine());  

                Doctor ps3 = new Doctor(name,name2,result,phone,age,answer);
                Console.Beep();
                ps3.PrintDoctorDetails();
           // }     
        }

        // public static void PrintRegisteredDoctor()
        // {
        //     for (int i =0; i<TimesofRegistration; i++)
        //     {
        //            Console.WriteLine($" \n {D1[i] . DoctorID} \n {D1[i]. Firstname} \n {D1[i]. Lastname}");
        //     }
        // }
    }
}