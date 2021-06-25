using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class DatabaseData
    {
        public static IList<Career> Database { get; private set; }

        static DatabaseData()
        {
            Database = new List<Career>();

            Database.Add(new Career
            {
                Name = "Data Center Support Specialist",
                MedianSalary = "$51,333 (PayScale)",
                Details = "Data center support specialist provide help and advice to people and organizations using computer software or equipment. Some, called computer network support specialists, support information technology (IT) employees within their organization. Others, called computer user support specialists, assist non-IT users who are having computer problems. (Zippia)",
                ImageUrl = "https://www.fda.gov/files/cell%20phone%201.jpg"
            });

            Database.Add(new Career
            {
                Name = "Data Quality Manager",
                MedianSalary = "$70,873",
                Details = "They inspect processes and equipment, maintain a data quality checklist, set data quality objectives and also check the efficiency and functionality of these processes. The process of testing is also determined by the quality data manager, and he or she makes modifications if needed. (Ringlead)",
                ImageUrl = "https://www.accessconsultant.com/assets/images/ms-access-database-consultant-banner.jpg"
            });

            Database.Add(new Career
            {
                Name = "Database Administrator (DBA)",
                MedianSalary = "$74,372 (PayScale)",
                Details = "A database administrator (DBA) is an IT professional who ensures that the software used to manage a database is properly maintained to allow rapid access when needed. Because constant access, searches, traffic are likely to have a damaging effect on any company database, the DBA works to maintain the efficiency of the servers.  He or she also will typically work to ensure data security, coordinating with an IT security professional or team in larger companies to help maintain the integrity of sensitive business data. (PayScale)",
                ImageUrl = "https://jobfindjobs.com/wp-content/uploads/2016/01/Database-Administrator_opt-1.jpg"
            });

            Database.Add(new Career
            {
                Name = "Senior Database Administrator (DBA)",
                MedianSalary = "$107,801",
                Details = "Senior database administrators work as team leaders with computer engineering teams in order to create database architecture to accomplish the necessary goals of specialized computer software. Senior database administrators have very clear educational goals: they need a bachelor's degree in computer science or in similar fields. They will also need certification for database administration from an accredited board, such as Oracle. (PayScale)",
                ImageUrl = "https://bloximages.newyork1.vip.townnews.com/kmaland.com/content/tncms/assets/v3/editorial/6/fd/6fd283c8-37fa-11e3-9015-0019bb30f31a/526139b712fc5.image.jpg"
            });

        }
    }
}