using System;

namespace My1stProjet
{
    public class DischargePAtient
    {

        public static void DischargePatient()
        {
            Console.WriteLine("<<<<<<<>>>>>>>><><><><>welcome to City Hospital Discharge DAshboard><><><><><<><><><><><><<>");
            Console.WriteLine("Only doctor can Approve discharge\n Are you Doctor if yes \npress 1 if no \n press 2");
            var answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("kindly enter your doctor ID");
                var Response = Console.ReadLine();
                Doctor D1 = Doctor.CheckDoctorID(Response);
                if (D1 != null)
                {
                    Console.WriteLine("Congratulations||||||<><><><<><><><\n Discharge Confirmed");
                    Console.WriteLine("thanks for comming To city Hospital \n your health matters to us");
                }
                else
                {
                    Console.WriteLine("invalid ID\n retype your ID<<<<<<<<<<<<<<<<<<<");
                }
            }
            else
            {
                Console.WriteLine("your are not a doctor only doctor can discharge patientn\n thanks<<<>>>>>>>>>>");
            }


        }
    }
}