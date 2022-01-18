using System;

namespace My1stProjet
{
    public class PatientAddimission
    {

        public ModeOFSickness ModeOFSickness {get; set;}
         public bool PatientAddimissionStatus = false;
         public PatientAddimission(ModeOFSickness modeOFSickness)
         {
             ModeOFSickness = modeOFSickness;
         }
        public static void PatientAddimision()        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("<<<<>>>>>>><<>>>><> welcome to city Hospital Addmission Portal <<<<>>>>>>><>>>>");
            Console.WriteLine("kindly Provide the neccessary information for your Addmission");
            Console.WriteLine("enter your Registration number");
            string RegNum = Console.ReadLine();
            Patient p3 = Patient.CheckPatientRegNum(RegNum);
            if (p3 != null)
            {
                Console.WriteLine("please kindly choose your mode of sickness");
                Console.WriteLine("\t1 for minor Case");
                Console.WriteLine("\t2 for Normal Case");
                Console.WriteLine("\t3 for critical case");
                Console.WriteLine("\t4 for very critical case"); 
                var sick =  int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkCyan;

                switch (sick)
                {
                    case 1:
                    Console.WriteLine("okay\n you cant be addmited <>>><><><<<<<>>\n Get the prescribe drug at the pharmacy store");
                    break;
                    case 2:
                    Console.WriteLine("okay<>>><><><<<<<>>\n Get the prescribe drug at the pharmacy store\n and come back next week"); 
                    break;
                    case 3:
                    Console.WriteLine("you have been addmitted to our hospital");
                    p3.PatientAddimissionStatus = true;
                    Console.WriteLine($"Congrats<><><><><>< \n your Addmission number is {Patient.GenerateAddmissionNumber()}your bed number is {Patient.GenerateSeatNumber()}");
                    break;
                    case 4:
                    Console.WriteLine("you have been addmitted to our hospital");
                   p3.PatientAddimissionStatus = true;
                    Console.WriteLine($"Congratulations<><><><<><>< \n you have been Admitted to City Hospital \nyour Addmission number is  {Patient.GenerateAddmissionNumber()} and your bed number is {Patient.GenerateSeatNumber()}");
                    break;

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("invalid Registration Number............kindly go back to the menu and register");
            }
        }    
    }
}