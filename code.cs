using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            int day1, day2, month=0, year1, year2,week,y1,y2,numberofloop,fmonth=0,monthc=0,smonth=0;
            string fmonth2,month1, month2;  
                Console.WriteLine("Enter first date");
                Console.Write("Day1=");
                day1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Month1=");
                month1 = Convert.ToString(Console.ReadLine());
                month1 = month1.ToLower();
                Console.Write("Year1=");
                year1 = Convert.ToInt32(Console.ReadLine());

            while ((((day1 < 1 || day1 > 31) && month1 == "january") || ((day1 < 1 || day1 > 28) && (month1 == "february" &&
                    (year1 % 4 == 1 || year1 % 4 == 2 || year1 % 4 == 3))) ||
                    ((day1 < 1 || day1 > 31) && month1 == "march") || ((day1 < 1 || day1 > 30) && month1 == "april") ||
                    ((day1 < 1 || day1 > 31) && month1 == "may") || ((day1 < 1 || day1 > 30) && month1 == "june") ||
                    ((day1 < 1 || day1 > 31) && month1 == "july") || ((day1 < 1 || day1 > 31) && month1 == "august") ||
                    ((day1 < 1 || day1 > 30) && month1 == "september") || ((day1 < 1 || day1 > 31) && month1 == "october") ||
                    ((day1 < 1 || day1 > 30) && month1 == "november") || ((day1 < 1 || day1 > 31) && month1 == "december") ||
                    ((day1 < 1 || day1 > 29) && (month1 == "february" && year1 % 4 == 0))) || ((day1 < 1 || day1 > 31) &&
                    (month1 != "january" || month1 != "february" || month1 != "march" || month1 != "april" || month1 != "may" ||
                    month1 != "june" || month1 != "july" || month1 != "august" || month1 != "september" || month1 != "october" ||
                    month1 != "november" || month1 != "december")))
                {
                if(((day1 < 1 || day1 > 31) && month1 == "january") || ((day1 < 1 || day1 > 28) && (month1 == "february" &&
                    (year1 % 4 == 1 || year1 % 4 == 2 || year1 % 4 == 3))) ||
                    ((day1 < 1 || day1 > 31) && month1 == "march") || ((day1 < 1 || day1 > 30) && month1 == "april") ||
                    ((day1 < 1 || day1 > 31) && month1 == "may") || ((day1 < 1 || day1 > 30) && month1 == "june") ||
                    ((day1 < 1 || day1 > 31) && month1 == "july") || ((day1 < 1 || day1 > 31) && month1 == "august") ||
                    ((day1 < 1 || day1 > 30) && month1 == "september") || ((day1 < 1 || day1 > 31) && month1 == "october") ||
                    ((day1 < 1 || day1 > 30) && month1 == "november") || ((day1 < 1 || day1 > 31) && month1 == "december") ||
                    ((day1 < 1 || day1 > 29) && (month1 == "february" && year1 % 4 == 0)))
                    {
                    Console.WriteLine("day is wrong");
                    Console.Write("Day1=");
                    day1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month1=");
                    month1 = Convert.ToString(Console.ReadLine());
                    month1 = month1.ToLower();
                    Console.Write("Year1=");
                    year1 = Convert.ToInt32(Console.ReadLine());
                }
                else if((day1 < 1 || day1 > 31) && (month1 != "january" || month1 != "february" || month1 != "march" ||
                    month1 != "april" || month1 != "may" || month1 != "june" || month1 != "july" || month1 != "august" ||
                    month1 != "september" || month1 != "october" || month1 != "november" || month1 != "december"))
                {
                    Console.WriteLine("day and month are wrong");
                    Console.Write("Day1=");
                    day1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month1=");
                    month1 = Convert.ToString(Console.ReadLine());
                    month1 = month1.ToLower();
                    Console.Write("Year1=");
                    year1 = Convert.ToInt32(Console.ReadLine());
                }
                

            }
                 
            Console.WriteLine();
                Console.WriteLine("Enter second date");
                Console.Write("Day2=");
                day2 = Convert.ToInt32(Console.ReadLine());       
                Console.Write("Month2=");
                month2 = Convert.ToString(Console.ReadLine());
                month2 = month2.ToLower();
                Console.Write("Year2=");
                year2 = Convert.ToInt32(Console.ReadLine());
                        
            while ((((day2 < 1 || day2 > 31) && month2 == "january") || ((day2 < 1 || day2 > 28) && (month2 == "february" &&
                (year2 % 4 == 1 || year2 % 4 == 2 || year2 % 4 == 3))) ||
                ((day2 < 1 || day2 > 31) && month2 == "march") || ((day2 < 1 || day2 > 30) && month2 == "april") ||
                ((day2 < 1 || day2 > 31) && month2 == "may") || ((day2 < 1 || day2 > 30) && month2 == "june") ||
                ((day2 < 1 || day2 > 31) && month2 == "july") || ((day2 < 1 || day2 > 31) && month2 == "august") ||
                ((day2 < 1 || day2 > 30) && month2 == "september") || ((day2 < 1 || day2 > 31) && month2 == "october") ||
                ((day2 < 1 || day2 > 30) && month2 == "november") || ((day2 < 1 || day2 > 31) && month2 == "december") ||
                ((day2 < 1 || day2 > 29) && (month2 == "february" && year2 % 4 == 0))) || ((day2 < 1 || day2 > 31) &&
                (month2 != "january" || month2 != "february" || month2 != "march" || month2 != "april" || month2 != "may" ||
                month2 != "june" || month2 != "july" || month2 != "august" || month2 != "september" || month2 != "october" ||
                month2 != "november" || month2 != "december")) || (year1 > year2)) 
            {
                if (((day2 < 1 || day2 > 31) && month2 == "january") || ((day2 < 1 || day2 > 28) && (month2 == "february" &&
                (year2 % 4 == 1 || year2 % 4 == 2 || year2 % 4 == 3))) ||
                ((day2 < 1 || day2 > 31) && month2 == "march") || ((day2 < 1 || day2 > 30) && month2 == "april") ||
                ((day2 < 1 || day2 > 31) && month2 == "may") || ((day2 < 1 || day2 > 30) && month2 == "june") ||
                ((day2 < 1 || day2 > 31) && month2 == "july") || ((day2 < 1 || day2 > 31) && month2 == "august") ||
                ((day2 < 1 || day2 > 30) && month2 == "september") || ((day2 < 1 || day2 > 31) && month2 == "october") ||
                ((day2 < 1 || day2 > 30) && month2 == "november") || ((day2 < 1 || day2 > 31) && month2 == "december") ||
                ((day2 < 1 || day2 > 29) && (month2 == "february" && year2 % 4 == 0)))
                {
                    Console.WriteLine("day is wrong");
                    Console.Write("Day2=");
                    day2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month2=");
                    month2 = Convert.ToString(Console.ReadLine());
                    month2 = month2.ToLower();
                    Console.Write("Year2=");
                    year2 = Convert.ToInt32(Console.ReadLine());
                }
                else if((day2 < 1 || day2 > 31) && (month2 != "january" || month2 != "february" || month2 != "march" || month2 != "april" || month2 != "may" ||
                month2 != "june" || month2 != "july" || month2 != "august" || month2 != "september" || month2 != "october" ||
                month2 != "november" || month2 != "december"))
                {
                    Console.WriteLine("day and month are wrong");
                    Console.Write("Day2=");
                    day2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month2=");
                    month2 = Convert.ToString(Console.ReadLine());
                    month2 = month1.ToLower();
                    Console.Write("Year2=");
                    year2 = Convert.ToInt32(Console.ReadLine());
                }          
                else if(year1 > year2)
                {
                    Console.WriteLine("the first date must be before the second date.");
                    Console.Write("Year2=");
                    year2 = Convert.ToInt32(Console.ReadLine());
                }
               
            }
            Console.WriteLine();
            fmonth2 = month1;
            if (month1 == "january")
            {
                month = 11;
            }
            else if (month1 == "february")
            {
                month = 12;
            }
            else if (month1 == "march")
            {
                month = 1;
            }
            else if (month1 == "april")
            {
                month = 2;
            }
            else if (month1 == "may")
            {
                month = 3;
            }
            else if (month1 == "june")
            {
                month = 4;
            }
            else if (month1 == "july")
            {
                month = 5;
            }
            else if (month1 == "august")
            {
                month = 6;
            }
            else if (month1 == "september")
            {
                month = 7;
            }
            else if (month1 == "october")
            {
                month = 8;
            }
            else if (month1 == "november")
            {
                month = 9;
            }
            else if (month1 == "december")
            {
                month = 10;
            }
            
           
            if(fmonth2=="january")
            {
                fmonth = 1;
            }
            else if (fmonth2 == "february")
            {
                fmonth = 2;
            }
            else if (fmonth2 == "march")
            {
                fmonth = 3;
            }
            else if (fmonth2 == "april")
            {
                fmonth = 4;
            }
            else if (fmonth2 == "may")
            {
                fmonth = 5;
            }
            else if (fmonth2 == "june")
            {
                fmonth = 6;
            }
            else if (fmonth2 == "july")
            {
                fmonth = 7;
            }
            else if (fmonth2 == "august")
            {
                fmonth = 8;
            }
            else if (fmonth2 == "september")
            {
                fmonth = 9;
            }
            else if (fmonth2 == "october")
            {
                fmonth = 10;
            }
            else if (fmonth2 == "november")
            {
                fmonth = 11;
            }
            else if (fmonth2 == "december")
            {
                fmonth = 12;
            }
            
            if (month2 == "january")
            {
                smonth = 1;
            }
            else if (month2 == "february")
            {
                smonth = 2;
            }
            else if (month2 == "march")
            {
                smonth = 3;
            }
            else if (month2 == "april")
            {
                smonth = 4;
            }
            else if (month2 == "may")
            {
                smonth = 5;
            }
            else if (month2 == "june")
            {
                smonth = 6;
            }
            else if (month2 == "july")
            {
                smonth = 7;
            }
            else if (month2 == "august")
            {
                smonth = 8;
            }
            else if (month2 == "september")
            {
                smonth = 9;
            }
            else if (month2 == "october")
            {
                smonth = 10;
            }
            else if (month2 == "november")
            {
                smonth = 11;
            }
            else if (month2 == "december")
            {
                smonth = 12;
            }


            y1 = year1 % 100;
            y2 = year1 / 100;
            week = ((day1 + (((13 * month) - 1) / 5) + y1 + (y1 / 4) + (y2 / 4) - 2 * y2)-1) % 7;
           
            if (week < 0)
            {
                week += 7;
            }
            
            if (month1 == "august" || month1 == "september" || month1 == "october" || month1 == "november" || month1 == "december")
            {
                week += 1;
            }
            numberofloop = ((year2 - year1) * 12) - fmonth + smonth;
            for (int i = fmonth;i <= numberofloop + fmonth;i++)
            {
                if (i % 12 == 1 || i % 12 == 3 || i % 12 == 5 || i % 12 == 7 || i % 12 == 8 || i % 12 == 10 || i % 12 == 0)
                {
                    monthc = 31;
                }
                else if (i % 12 == 4 || i % 12 == 6 || i % 12 == 9 || i % 12 == 11)
                {
                    monthc = 30;
                }
                else if (i % 12 == 2)
                {
                    if (year1 % 4 == 0)
                    {
                        monthc = 29;
                    }
                    else
                    {
                        monthc = 28;
                    }
                }

                if (i % 12 == 1)
                {
                    Console.Write("January");
                }
                else if (i % 12 == 2)
                {
                    Console.Write("February");
                }
                else if (i % 12 == 3)
                {
                    Console.Write("March");
                }
                else if (i % 12 == 4)
                {
                    Console.Write("April");
                }
                else if (i % 12 == 5)
                {
                    Console.Write("May");
                }
                else if (i % 12 == 6)
                {
                    Console.Write("June");
                }
                else if (i % 12 == 7)
                {
                    Console.Write("July");
                }
                else if (i % 12 == 8)
                {
                    Console.Write("August");
                }
                else if (i % 12 == 9)
                {
                    Console.Write("September");
                }
                else if (i % 12 == 10)
                {
                    Console.Write("October");
                }
                else if (i % 12 == 11)
                {
                    Console.Write("November");
                }
                else if (i % 12 == 0)
                {
                    Console.Write("December");
                }
                
                Console.Write(" " + year1 + " - ");
                if (i % 12 == 0 || i % 12 == 1 || i % 12 == 2)
                {
                    Console.WriteLine("Winter");
                }
                else if (i % 12 == 3 || i % 12 == 4 || i % 12 == 5)
                {
                    Console.WriteLine("Spring");
                }
                else if (i % 12 == 6 || i % 12 == 7 || i % 12 == 8)
                {
                    Console.WriteLine("Summer");
                }
                else if (i % 12 == 9 || i % 12 == 10 || i % 12 == 11)
                {
                    Console.WriteLine("Fall");
                }
                Console.WriteLine("Mo Tu We Th Fr Sa Su");  
                
                if (week%7 == 0)
                {
                    Console.Write("                  ");
                }
                else if (week%7 == 1)
                {
                    Console.Write("");
                }
                else if (week%7 == 2)
                {
                    Console.Write("   ");
                }
                else if (week%7 == 3)
                {
                    Console.Write("      ");
                }
                else if (week%7 == 4)
                {
                    Console.Write("         ");
                }
                else if (week%7 == 5)
                {
                    Console.Write("            ");
                }
                else if (week%7 == 6)
                {
                    Console.Write("               ");
                }
                if(i== numberofloop + fmonth)
                {
                    monthc = day2;
                }
                if (i % 12 == 0)
                {
                    year1 += 1;
                }
                for (int j=day1;j<=monthc;j++)
                {
                    if(j>=1 && j<=9)
                    {
                        Console.Write(j + "  ");
                    }
                    if(j>=10)
                    {
                        Console.Write(j + " ");
                    }
                    

                    
                    
                    if (week%7==0)
                    {                       
                        Console.WriteLine();
                    }
                    week += 1;

                }
                day1 = 1;
                Console.WriteLine("\n");

            }
            Console.ReadLine();
                }
            }
            
        }
    

