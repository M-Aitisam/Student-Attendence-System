using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDal
{
    public class SubjectService
    {
        public List<Subject> GetSubjects()
        {
            return new List<Subject>
            {
                new Subject { SrNo = 1, SubjectName = "F-24-Information Security-6", Total = 22, Atts = 22, Abs = 0, Percent = 100 },
                new Subject { SrNo = 2, SubjectName = "F-24-Industrial Project-I-11", Total = 9, Atts = 8, Abs = 1, Percent = 88.89 },
                new Subject { SrNo = 3, SubjectName = "F-24-Visual Programming-1", Total = 20, Atts = 19, Abs = 1, Percent = 95 },
                new Subject { SrNo = 4, SubjectName = "F-24-Advisory Class-14", Total = 11, Atts = 11, Abs = 0, Percent = 100 },
                new Subject { SrNo = 5, SubjectName = "F-24-Visual Programming Lab-2", Total = 2, Atts = 2, Abs = 0, Percent = 100 },
                new Subject { SrNo = 6, SubjectName = "F-24-Calculus & Analytical Geometry-3", Total = 21, Atts = 21, Abs = 0, Percent = 100 },
                new Subject { SrNo = 7, SubjectName = "F-24-Full Stack Web Development-Frontend Lab-9", Total = 10, Atts = 9, Abs = 1, Percent = 90 },
                new Subject { SrNo = 8, SubjectName = "F-24-Software Engineering-10", Total = 22, Atts = 22, Abs = 0, Percent = 100 },
                new Subject { SrNo = 9, SubjectName = "F-24-Information Security Lab-7", Total = 11, Atts = 10, Abs = 1, Percent = 90.91 },
                new Subject { SrNo = 10, SubjectName = "F-24-Data Structures-4", Total = 22, Atts = 22, Abs = 0, Percent = 100 },
                new Subject { SrNo = 11, SubjectName = "F-24-Data Structures Lab-5", Total = 12, Atts = 12, Abs = 0, Percent = 100 }
            };
        }
    }
}
