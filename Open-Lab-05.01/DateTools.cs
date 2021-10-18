using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            var storocie = Century(year / 100) + 1;
            return storocie;
        }
    }
}
