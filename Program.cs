using System;

namespace My1stProjet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello World!");
             Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("welcome to City Hospital <<<<<>>>>>>>><>>>>><><><><><>< <<<>>");
            Console.WriteLine("for patient Registration press 1 \n for doctor Registration press 2 \n For Patient Addmission press 3 \n for patient Discharge press 4");
            int menu = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
                
          //   while (true)
          //   {


                 if (menu == 1)
                 {
                      Patient.Registration();
                 }
                 if (menu == 2)
                 {
                     Doctor.DoctorRegistration();
                 }
                 if (menu == 3)
                 {
                     PatientAddimission.PatientAddimision();
    
                 }
                 if (menu == 4)
                 {
                      DischargePAtient.DischargePatient();
                 }
           //  }   
        }
    }
}
