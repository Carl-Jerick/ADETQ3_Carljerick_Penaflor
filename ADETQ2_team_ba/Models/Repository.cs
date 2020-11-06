using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enrollment.Models
{
    public static class Repository
    {
        private static List<admission> enrolled = new List<admission>();

        public static IEnumerable<admission> Students => enrolled;

        public static void Addenrolled(admission enroll)
        {
            enrolled.Add(enroll);
        }

    }
}
