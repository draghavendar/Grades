using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            LowestGrade = float.MaxValue; 
            HighestGrade = 0f;
        }

        public float LowestGrade;
        public float HighestGrade;
        public float AverageGrade;
    }
}
