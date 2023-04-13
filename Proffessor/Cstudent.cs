using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor
{
    internal class Cstudent
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public double YearMark { get; set; }
        public double LastExamMark { get; set; }
        public double FinalMark { get; set; }

        public string Grade { get; set; }

        public double CalculateFinal(double yearMark, double lastExamMark)
        {
            FinalMark = (yearMark + lastExamMark) / 2;
            return FinalMark;
        }
        //public string CalcGrade()
        //{
        //    Grade = null;

            //if (FinalMark > 74)
            //{ 
            //    Grade = "A";
            //    return Grade;
            //}
                
            //else if (FinalMark < 75)
            //{
            //    Grade = "B";
            //    return Grade;
            //}
            //else if (FinalMark < 70)
            //{
            //    Grade = "C";
            //    return Grade;
            //}
            //else if (FinalMark < 60)
            //{
            //    Grade = "D";
            //    return Grade;
            //}
            //else if (FinalMark < 50)
            //{
            //    Grade = "F";
            //    return Grade;
            //}
            //return Grade;


            //switch (FinalMark)
            //{
            //    case < 50:
            //        Grade = "F";
            //        break;

            //    case < 60:
            //        Grade = "D";
            //        break;

            //    case < 70:
            //        Grade = "C";
            //        break;

            //    case > 75:
            //        Grade = "B";
            //        break;

            //    case >= 75:
            //        Grade = "A";
            //        break;        
            //}

        //}
    }
}
