using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            if (year % 100 == 0) //1800
            {
                int new_century = year / 100; //18
                if (new_century.ToString().EndsWith("1") && new_century != 11)
                {
                    return new_century + "st century";
                }
                else if (new_century.ToString().EndsWith("2") && new_century != 12)
                {
                    return new_century + "nd century";
                }
                else if (new_century.ToString().EndsWith("3") && new_century != 13)
                {
                    return new_century + "rd century";
                }
                else
                {
                    return new_century + "th century";
                }
            }
            else
            {
                double new_century = ((year / 100 + 1));//18,89
                var final_century = Math.Floor(new_century);
                if (final_century.ToString().EndsWith("1") && new_century != 11)
                {
                    return new_century + "st century";
                }
                else if (final_century.ToString().EndsWith("2") && final_century != 12)
                {
                    return final_century + "nd century";
                }
                else if (final_century.ToString().EndsWith("3") && final_century != 13)
                {
                    return final_century + "rd century";
                }
                else
                {
                    return final_century + "th century";
                }
            }
        }
    }
}
