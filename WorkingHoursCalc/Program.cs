using System;

namespace WorkingHoursCalc
{
   class Program
   {
      public static string CalculateTAT(DateTime? receive, DateTime? reply)
      {
         DateTime[] bankHolidays = new DateTime[]
         {
                new DateTime(2021, 1, 01),
                new DateTime(2021, 1, 18),
                new DateTime(2021, 2, 15),
                new DateTime(2021, 5, 31),
                new DateTime(2021, 6, 19),
                new DateTime(2021, 7, 04),
                new DateTime(2021, 9, 06),
                new DateTime(2021, 10, 11),
                new DateTime(2021, 11, 11),
                new DateTime(2021, 11, 25),
                new DateTime(2021, 12, 25),
         };

         receive = receive ?? default(DateTime);
         reply = reply ?? default(DateTime);

         string result = "";

         TimeSpan totalHours = TimeSpan.Zero;
         TimeSpan fullDay = new TimeSpan(08, 00, 00);
         TimeSpan start = new TimeSpan(08, 30, 00);
         TimeSpan end = new TimeSpan(16, 30, 00);

         if (receive.Value.Date == reply.Value.Date)
         {
            if (receive.Value.TimeOfDay < start)
            {
               totalHours = (reply.Value.TimeOfDay - start);
               return ((int)totalHours.TotalHours + ":" + totalHours.Minutes.ToString("D2"));
            }
            else if (receive.Value.TimeOfDay >= start && reply.Value.TimeOfDay <= end)
            {
               totalHours = (reply.Value.TimeOfDay - receive.Value.TimeOfDay);
               return ((int)totalHours.TotalHours + ":" + totalHours.Minutes.ToString("D2"));
            }
         }


         for (DateTime date = receive.Value; date.Date <= reply.Value.Date; date = date.AddDays(1))
         {
            if ((int)date.DayOfWeek >= 1 && (int)date.DayOfWeek <= 5)
            {
               totalHours = totalHours + fullDay;
            }
         }

         foreach (DateTime bankHoliday in bankHolidays)
         {
            DateTime bh = bankHoliday.Date;
            if (receive <= bh && bh <= reply)
            {
               totalHours = totalHours - fullDay;
            }
         }

         if (receive.Value.TimeOfDay < start)
         {
            totalHours = totalHours - (end - reply.Value.TimeOfDay);
         }
         else if (receive.Value.TimeOfDay > start && receive.Value.TimeOfDay < end)
         {
            totalHours = totalHours - (receive.Value.TimeOfDay - start) - (end - reply.Value.TimeOfDay);
         }
         else if (receive.Value.TimeOfDay > end)
         {
            totalHours = totalHours - fullDay - (end - reply.Value.TimeOfDay);
         }

         result = ((int)totalHours.TotalHours + ":" + totalHours.Minutes.ToString("D2"));

         return result;
      }
      static void Main(string[] args)
      {
         DateTime receive = new DateTime(2021, 07, 20);
         DateTime reply = new DateTime(2021, 07, 28);

         string test = CalculateTAT(receive, reply);

         Console.WriteLine(test);
      }
   }
}
