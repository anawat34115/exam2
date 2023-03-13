
/*จงเขียนโปรแกรมภาษา C# สำหรับสั่งอาหารออนไลน์ โดยมีรายละเอียดดังนี้
//2.1 ให้รับค่าจากผู้ใช้เป็นจำนวนเต็มตั้งแต่ 1 ถึง 7 แทนวันในสัปดาห์ (Day of Week) โดยที่เลข 1 แทนวันจันทร์, เลข 2 แทนวันอังคาร, เลข 3 แทนวันพุธ, เลข 4 แทนวันพฤหัสบดี, เลข 5 แทนวันศุกร์, เลข 6 แทนวันเสาร์ และเลข 7 แทนวันอาทิตย์ (ให้ถือว่าผู้ใช้กรอกข้อมูลนำเข้าตามเงื่อนไขเสมอ)
2.2 จากนั้นให้รับค่าจากผู้ใช้เป็นจำนวนเต็มตั้งแต่ 8 ถึง 18 แทนเวลาของวัน (Time of Day) โดยแทนเวลา 8.00 น. ถึง 18.00 น. (ให้ถือว่าผู้ใช้กรอกข้อมูลนำเข้าตามเงื่อนไขเสมอ)
2.3 จากนั้นให้รับค่าจากผู้ใช้เป็นข้อความ คือ เมนูอาหารที่ต้องการจะสั่ง โดยรายการอาหารประกอบด้วย
	2.3.1 “Breakfast Set”	สั่งได้ 5 ชุดต่อวัน
	2.3.2 “Weekend Set”	สั่งได้ 2 ชุดต่อวัน
	2.3.3 “Coffee”		สั่งได้ 3 ชุดต่อวัน
เมื่อผู้ใช้กรอกเมนูอาหารเข้ามาตรงกับเมนูที่มีในรายการอาหาร ให้ลดจำนวนของเมนูอาหารนั้น ๆ ลง 1 ชุด
2.4 ให้ทำซ้ำข้อ 5.3 ไปเรื่อย ๆ จนกว่าผู้ใช้จะกรอกข้อความว่า “End” จึงจะสิ้นสุดการทำงานของโปรแกรม
2.5 ทุกครั้งที่ผู้ใช้กรอกเมนูอาหารเข้ามา ต้องตรวจสอบว่าเมนูอาหารดังกล่าวสามารถสั่งได้หรือไม่ โดยมีเงื่อนไขดังนี้
2.5.1 หากเมนูอาหารดังกล่าว ไม่มีในรายการอาหารที่โจทย์กำหนด ให้แสดงผลว่า “Please enter a valid menu” แล้วให้ผู้ใช้กรอกเมนูอาหารใหม่
2.5.2 หากเมนูอาหารดังกล่าวหมด (มีจำนวนเหลือ 0 ชุด) ให้แสดงผลว่า “Sorry your order is out of stock” แล้วให้ผู้ใช้กรอกเมนูอาหารใหม่
2.5.3 หากผู้ใช้สั่ง “Breakfast Set” ในเวลา (Time of Day) เกิน 11.00 น. หรือสั่ง “Weekend Set” ในวัน (Day of Week) จันทร์ถึงศุกร์ ให้แสดงผลว่า “Sorry your order is not available” แล้วให้ผู้ใช้กรอกเมนูอาหารใหม่*/



using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
        int BreakfastSets = 5;
        int maxWeekendSets = 2;
        int maxCoffeeSets = 3;
            Console.WriteLine("Please enter a number between 1 and 7: ");

            int dayOfWeek = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a 8.00 - 18.00: ");
            int times = int.Parse(Console.ReadLine());

            
        Console.Write("Menu option (Breakfast Set,Weekend Set,Coffee): ");
        string input = Console.ReadLine();

              switch (input)
            {
                case "Breakfast Set":
                    if (BreakfastSets > 0)
                    {
                        Console.WriteLine("Order successful!");
                        BreakfastSets--;
                    }
                    else
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    break;
                case "Weekend Set":
                    if (dayOfWeek > 11)
                    {
                        Console.WriteLine("Order successful!");
                        maxWeekendSets--;
                    }
                    else if(dayOfWeek<5){
                        Console.WriteLine("Sorry your order is not available");
                    }
                    else
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    break;
                case "Coffee":
                    if (maxCoffeeSets > 0)
                    {
                        Console.WriteLine("Order successful!");
                        maxCoffeeSets--;
                    }
                    else
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    break;
                    case "End":
                    {
                        Console.WriteLine();
                    }
                    break;
               default:
                    Console.WriteLine("Please enter a valid menu.");
                    break;
            }

        }
        
}}