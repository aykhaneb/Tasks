using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    internal static class ClassTasks
    {
        internal static string DifferenceTime(string time1, string time2)
        {
            //10:20:00 12:20:00 
            int h1 = int.Parse(time1.Substring(0, 2));
            int m1 = int.Parse(time1.Substring(3, 2));
            int s1 = int.Parse(time1.Substring(6, 2));

            int h2 = int.Parse(time2.Substring(0, 2));
            int m2 = int.Parse(time2.Substring(3, 2));
            int s2 = int.Parse(time2.Substring(6, 2));

            int h3 = h2 - h1;
            int m3 = m2 - m1;
            int s3 = s2 - s1;

            if (h2<h1)
            {
                h3 = 24 - (h1 - h2);
            }
            if(m2<m1)
            {
                m3 = (60 - m1) +m2;
                h2 = h2 - 1;
            }
            if (s2<s1)
            {
                s3 = (60 - s1) +s2;
                m2=m2-1;
            }

            return $"{h3}:{m3}:{s3}";
        }
    }
}
