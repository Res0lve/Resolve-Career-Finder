using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class CloudData
    {
        public static IList<Career> Cloud { get; private set; }

        static CloudData()
        {
            Cloud = new List<Career>();

            Cloud.Add(new Career
            {
                Name = "Cloud Architect",
                MedianSalary = "$107,309 (Glassdoor)",
                Details = "Cloud Architects are Information Technology (IT) experts responsible for the supervision of a company's cloud computing system. This involves working on cloud application designs, cloud approval plans, and systems required to manage cloud storage. (BetterTeam)",
                ImageUrl = "https://cdn1.expresscomputer.in/wp-content/uploads/2016/10/13173645/ThinkstockPhotos-478450750-CLOUD-COMPUTING.jpg"

            });

            Cloud.Add(new Career
            {
                Name = "Cloud Consultant",
                MedianSalary = "$78,579 (Glassdoor)",
                Details = "Cloud consultants start out by examining the typical duties performed by their clients, asking questions and performing other types of research. They then analyze that data to determine which cloud solutions would best meet the client's needs; they make recommendations based on their analysis. Cloud consultants implement the selected cloud systems and may be responsible for customization as well; accordingly, consultants need to be well-versed in both existing cloud products and creating and modifying programming code. (Study)",
                ImageUrl = "https://d12vzecr6ihe4p.cloudfront.net/media/967732/top-cloud-certifications-400x250.jpg"

            });

            Cloud.Add(new Career
            {
                Name = "Cloud Product and Project Manager",
                MedianSalary = "$152,831 (Payscale)",
                Details = "A Cloud Project manager is in charge of ensuring that best practices are followed, goals are met, and projects and related operations of the Cloud team are conducted effectively. (Payscale)",
                ImageUrl = "https://www.tastefulspace.com/wp-content/uploads/2019/04/Cloud-Management-The-Future-of-Professionals.jpeg"

            });

            Cloud.Add(new Career
            {
                Name = "Cloud Services Developer",
                MedianSalary = "$107,309 (Glassdoor)",
                Details = "A cloud service developer designs and develops secure cloud applications, services, and products. This can include everything from back-end, front-end, web application, full-stack, data and application integration, and cloud application deployment. (Upwork)",
                ImageUrl = "https://blogs-images.forbes.com/louiscolumbus/files/2018/11/Where-Cloud-Computing-Jobs-Will-Be-In-2019.jpg"

            });

            Cloud.Add(new Career
            {
                Name = "Cloud Software and Network Engineer",
                MedianSalary = "$72,362 (Glassdoor)",
                Details = "The work of network engineers revolves around their employers' computer network designs and implementations, and they are salaried instead of paid on an hourly basis. They generally work in offices to troubleshoot problems related to their company’s enterprise-wide network, and they must ensure that their systems' security and firewall software is up-to-date.The work of network engineers revolves around their employers' computer network designs and implementations, and they are salaried instead of paid on an hourly basis. They generally work in offices to troubleshoot problems related to their company’s enterprise-wide network, and they must ensure that their systems' security and firewall software is up-to-date. (Payscale)",
                ImageUrl = "https://blog.ercom.com/wp-content/uploads/sites/2/2016/11/cloudsecupro_Web-300x218.jpg"

            });

            Cloud.Add(new Career
            {
                Name = "Cloud Systems Administrator",
                MedianSalary = "$64,892 (Glassdoor)",
                Details = "A Cloud Systems Administrator is responsible for working in a mixed Windows and Unix software environment. The responsibility of the individual is to manage the instances of the cloud infrastructure services and the multiple cloud servers. (FieldEngineer)",
                ImageUrl = "https://www.wgu.edu/content/dam/web-sites/blog-newsroom/blog/images/national/2019/november/what-is-cloud-and-systems-administration.jpg"

            });

            Cloud.Add(new Career
            {
                Name = "Cloud System Engineer",
                MedianSalary = "$85,000 (PayScale)",
                Details = "Cloud engineers are responsible for assessing the existing infrastructure of a business, and researching solutions for moving different functions (like database storage) to a cloud-based system, according to our sister site Tech Pro Research. (TechRepublic)",
                ImageUrl = "https://cdn.techgyd.com/12-Cloud-computing-jobs-with-huge-salary-2.jpg"

            });
        }
    }
}