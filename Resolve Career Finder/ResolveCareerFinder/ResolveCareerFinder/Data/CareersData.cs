using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class CareersData
    {
        public static IList<Career> Careers { get; private set; }

        static CareersData()
        {
            Careers = new List<Career>();

            Careers.Add(new Career
            {
                Name = "Application Developer",
                MedianSalary = "$69,537 (PayScale)",
                Details = "Application developers help companies keep up with the latest technologies and developments on the web. As online technology becomes increasingly important, all types of businesses are seeking application developers--from banks to universities, news channels to hospitals. These applications (or apps) can be used on smartphones, computers, tablets and more. (PayScale)",
                ImageUrl = "https://applaunchhub.com/wp-content/uploads/2019/05/Lets-Talk-About-IT-.jpg"

            });

            Careers.Add(new Career
            {
                Name = "Computer Programmer",
                MedianSalary = "$63,241 (PayScale)",
                Details = "Computer programmers work in a wide range of industries, but generally in offices as salaried employees who code or write computer software and write, design, debug, troubleshoot, and maintain source code related to various computer programs. They also ensure that all source code is written in programming languages that can be understood by the computer so that programs can then be used by end-users. (PayScale)",
                ImageUrl = "https://www.pixelproductionsinc.com/wp-content/uploads/2019/02/A-Beginners-Guide-to-Becoming-a-Computer-Programmer.jpg"

            });

            Careers.Add(new Career
            {
                Name = "Junior Software Engineer",
                MedianSalary = "$60,953 (PayScale)",
                Details = "A junior software engineer designs codes for new software and also modifies current software. They are responsible for correcting defects and debugging software. They also recommend changes to existing software, as well as develop ideas for implementing future software. A junior software engineer must be able to keep up with rapidly changing computer technology. (PayScale)",
                ImageUrl = "https://thedronegirl.com/wp-content/uploads/2019/03/iStock-874016084.jpg"

            });

            Careers.Add(new Career
            {
                Name = "Senior Programmer",
                MedianSalary = "$86,842 (PayScale)",
                Details = "As senior programmer is someone who is experienced enough to have solved many programming challenges. When a problem shows up, a senior programmer will likely have a history of solving that problem vs. a regular or junior programmer who may get worried or afraid about this new problem. (Quora - Aziz)",
                ImageUrl = "https://thumbs.dreamstime.com/b/senior-programmer-working-computer-modern-office-coworkers-background-programmers-working-office-163526034.jpg"

            });

            Careers.Add(new Career
            {
                Name = "Software Developer",
                MedianSalary = "$71,428 (PayScale)",
                Details = "Software developers are the driving creative force behind programs. Software developers are responsible for the entire development process. They are the ones who collaborate with the client to create a theoretical design. They then have computer programmers create the code needed to run the software properly. Computer programmers will test and fix problems together with software developers. Software developers provide project leadership and technical guidance along every stage of the software development life cycle. (SheCanCode)",
                ImageUrl = "https://www.usnews.com/dims4/USNEWS/600fce7/2147483647/crop/2000x1313%2B0%2B0/resize/640x420/quality/85/?url=http%3A%2F%2Fmedia.beam.usnews.com%2Ff9%2Ff1%2Fa6174c87479b8222c09903d7651c%2F190219-softwaredevelopers-stock.jpg"

            });

            Careers.Add(new Career
            {
                Name = "Software Engineer",
                MedianSalary = "$85,690 (PayScale)",
                Details = "Software engineering refers to the application of engineering principles to create software. Software engineers participate in the software development life cycle through connecting the client’s needs with applicable technology solutions. Thus, they systematically develop processes to provide specific functions. In the end, software engineering means using engineering concepts to develop software. (SheCanCode)",
                ImageUrl = "https://www.computersciencedegreehub.com/wp-content/uploads/2020/05/What-is-a-Software-Engineer-1024x683.jpg"

            }); 

            Careers.Add(new Career
            {
                Name = "Web Developer",
                MedianSalary = "$59,597 (PayScale)",
                Details = "Most of the time, web developers work in an office.  Web developers build the backbone of websites. Employers often require candidates to have a bachelor’s degree in computer science, programming, informational technology, or another relevant fields. However, some companies will accept candidates with enough years of experience in lieu of bachelor's degree requirements.  (PayScale)",
                ImageUrl = "https://www.onblastblog.com/wp-content/uploads/2019/09/09aea00fc018749c1c255ddfd594b218.jpeg"

            });
        }
    }
}
