using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public static class LibraryAlgorithm
    {
        public static double CalculateLateRiskScore(DateOnly borrowDate, DateOnly? returnDate, int pageCount)
        {
            DateOnly endDate = returnDate ?? DateOnly.FromDateTime(DateTime.Today);

            int borrowedDays = endDate.DayNumber - borrowDate.DayNumber;

            int allowedDays = 14;

            int daysLate = Math.Max(0, borrowedDays - allowedDays);

            double score = Math.Log(daysLate + 1) * Math.Sqrt(pageCount) * 1.15;

            return Math.Round(score, 2);
        }
    }
}
