using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class SupportData
    {
        public static IList<Career> Support { get; private set; }

        static SupportData()
        {
            Support = new List<Career>();

            Support.Add(new Career
            {
                Name = "Customer Service Administrator",
                MedianSalary = "$42,662",
                Details = "A customer service administrator holds a supervisory position, handling customer inquiries and overseeing the needs and requirements of the customer service representatives working in their department. This is normally an office-type position that requires equal parts clerical skill and communications savvy. (PayScale)",
                ImageUrl = "https://www.cpdqs.co.uk/wp-content/uploads/2017/10/EE8-OFFICE-ADMIN-AND-CUSTOMER-SERVICE-COURSE.jpg"
            });

            Support.Add(new Career
            {
                Name = "Customer Support Specialist",
                MedianSalary = "$44,885 (PayScale)",
                Details = "Customer support specialists are responsible for diagnosing and troubleshooting customers' problems while maintaining a professional and friendly attitude. They need to collect information from customers on their issues and follow up with them for additional information is needed. Customer support specialists also establish and build good customer relationships by providing high-quality customer service. (PayScale)",
                ImageUrl = "https://images.wisegeek.com/customer-service-woman-on-computer-near-man-in-blue-shirt.jpg"
            });

            Support.Add(new Career
            {
                Name = "Desktop Support Manager",
                MedianSalary = "$75,733 (PayScale)",
                Details = "Desktop support managers are responsible for the smooth operation of a team of workers whose primary function is to help customers resolve issues with their desktop computers. As such, they should have considerable experience with personnel management, as well as comprehensive knowledge of computers and their many possible malfunctions. Generally, desktop support managers are required to have at least a Bachelor's degree in an information technology-related field. (PayScale)",
                ImageUrl = "https://www.thinkhdi.com/education/courses_bu/~/media/HDICorp/Images/Home/Cards/publicTraining.jpg"
            });

            Support.Add(new Career
            {
                Name = "Desktop Support Specialist",
                MedianSalary = "$49,281 (PayScale)",
                Details = "Desktop support specialists are in charge of providing excellent end user experience, which includes resolving potential or actual technical issues. One of their main duties is troubleshooting different software packages, hardware devices, and other peripherals. Additionally, desktop support specialists configure computer systems according to company policies. (PayScale)",
                ImageUrl = "https://images.wisegeek.com/call-center-man-in-front-of-computers.jpg"
            });

            Support.Add(new Career
            {
                Name = "Help Desk Specialist",
                MedianSalary = "$44,895 (PayScale)",
                Details = "A help desk specialist is responsible for maintaining customers' relationships with the company, providing answers to customers' questions and other needs related to technical support. These specialists are responsible for a variety of duties in the company, depending on the products or services for which they provide assistance. But the help desk specialist's main objective is to maintain a high level of customer satisfaction and provide them with any necessary support. (PayScale)",
                ImageUrl = "https://www.ziprecruiter.com/blog/zrs-0005/blog/wp-content/uploads/2020/03/1045241618_Help-Desk-Specialist.jpg"
            });

            Support.Add(new Career
            {
                Name = "Help Desk Technician",
                MedianSalary = "$41,071 (PayScale)",
                Details = "Help desk technicians are needed by virtually every company that produces or uses sophisticated computer equipment. When either customers or colleagues run into technical problems, the help desk technician identifies, troubleshoots, and resolves the issue. They typically field calls or emails from end users who are having trouble with some aspect of a sophisticated system. (PayScale)",
                ImageUrl = "https://2.bp.blogspot.com/-gEG553fNIfw/WM2F90hkoGI/AAAAAAAAAhY/hAEbqg7Uvv4n77l6cfAxQxMAKocrcJSIgCLcB/w1200-h630-p-k-no-nu/it-helpdesk-technician-shutterstock_268148900.jpg"
            });

            Support.Add(new Career
            {
                Name = "IT Applications Support Manager",
                MedianSalary = "$87,012 (PayScale)",
                Details = "The application support manager is responsible for the overall software needs of the company. Software includes network and computer applications. He analyzes networking needs, recommends systems for purchase, purchases the hardware and applications, configures the system, installs the software, tests the system, implements the system to the whole company and maintains system integrity. (GreatSamplerResume)",
                ImageUrl = "https://www.monster.co.uk/advertise-a-job/hr-resources/wp-content/uploads/sites/3/2019/02/c2cc19566efd6626fcc989417cfde932.jpg"
            });

            Support.Add(new Career
            {
                Name = "IT Support Specialist",
                MedianSalary = "$49,897 (PayScale)",
                Details = "The information technology (IT) support specialist is a generalist position devoted to all aspects of computer set-up, installation, troubleshooting, service, upgrades, and maintenance. The position can also include handling how computers connect to each other or the rest of the network; printing, both locally and on the network; and auxiliary devices such as tablets, PDAs, and smartphones. (PayScale)",
                ImageUrl = "https://coda.newjobs.com/api/imagesproxy/ms/niche/images/articles/Computer%20Support%20Specialist.jpg"
            });

            Support.Add(new Career
            {
                Name = "Senior Support Specialist",
                MedianSalary = "$54,473 (PayScale)",
                Details = "Senior Support Specialists provide help and advice to people and organizations using computer software or equipment. Some, called computer network support specialists, support information technology (IT) employees within their organization. (Zippia)",
                ImageUrl = "https://www.goodtherapy.org/blog/blog/wp-content/uploads/2019/07/peer-support-specialist-e1563213855164-300x200.jpg"
            });

            Support.Add(new Career
            {
                Name = "Technical Support Engineer",
                MedianSalary = "$63,777 (PayScale)",
                Details = "Technical support engineers are responsible for answering incoming phone calls and e-mails from customers and addressing their questions and concerns regarding the company's products and services, as well as troubleshooting any technical problems they may have. They also address concerns brought up by other departments within the company, such as operations and sales. (PayScale)",
                ImageUrl = "https://www.thebalancecareers.com/thmb/5GT1SOfZMkRYSAr76kGUh-LpUO4=/300x200/filters:no_upscale():max_bytes(150000):strip_icc():saturation(0.2):brightness(10):contrast(5)/GettyImages-906499516-5bc6570d46e0fb0026d6f1e0.jpg"
            });
        }
    }
}