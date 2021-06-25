using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class AnalystData
    {
        public static IList<Career> Analyst { get; private set; }

        static AnalystData()
        {
            Analyst = new List<Career>();

            Analyst.Add(new Career
            {
                Name = "Application Support Analyst",
                MedianSalary = "$62,071 (Payscale)",
                Details = "Application support analysts assist users of computer and mobile applications. They must be able to think creatively in order to implement improvements, and they may also be involved in installing new software and making updates. Software must be tested prior to being implemented and then re-tested periodically. (Payscale)",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR6i2Lpvep-CIG8yTHx4hVH3EaR8IsdyLq1Mw&usqp=CAU"
            });

            Analyst.Add(new Career
            {
                Name = "Senior Systems Analyst",
                MedianSalary = "$89,465 (Payscale)",
                Details = "Senior systems analysts are in charge of implementing and analyzing complex systems for their organizations, which includes planning development, testing, and deployment processes for various departments, and they report their progress to informational systems managers.",
                ImageUrl = "https://cdn.computercareers.org/wp-content/uploads/IT-Professionals-career.jpg"
            });

            Analyst.Add(new Career
            {
                Name = "Systems Analyst",
                MedianSalary = "$66,014 (Payscale)",
                Details = "People who wish to work as systems analysts must be able to think outside the box, finding effective solutions for businesses and other clients.  They must be adept at investigating problems and fixing them in the most efficient way possible.  Systems analysts must be knowledgeable in programming languages, operating systems and hardware. (Payscale)",
                ImageUrl = "https://stmedia.stimg.co/ows_151399010624056.jpg?fit=crop&crop=faces"
            });

            Analyst.Add(new Career
            {
                Name = "Systems Designer",
                MedianSalary = "$60,000 (Payscale)",
                Details = "Systems Designers need to have several skills such as the ability to understand and solve any complex problems that may arise while working on a job. They need to have a logical and analytical approach to solving problems. Since they will often work on large teams to develop a system. (Payscale)",
                ImageUrl = "https://www.yellowbrickroad.com/follow/wp-content/uploads/2011/07/system-designer.jpg"
            });
        }
    }
}
