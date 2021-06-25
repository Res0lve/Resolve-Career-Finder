using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class NetworkData
    {
        public static IList<Career> Network { get; private set; }

        static NetworkData()
        {
            Network = new List<Career>();

            Network.Add(new Career
            {
                Name = "Computer and Information Research Scientist",
                MedianSalary = "$115,740 (PayScale)",
                Details = "Computer and information research scientists are responsible for overseeing research efforts and completing information and computer-related reports on behalf of their organizations. They also help complete investigative tasks and process data to gather new information, so organization and close attention to detail are important in this position. (PayScale)",
                ImageUrl = "https://s3-us-east-2.amazonaws.com/maryville/wp-content/uploads/2019/11/19113907/computer-information-research-scientists-1-500x333.jpg"
            });

            Network.Add(new Career
            {
                Name = "Computer and Information Systems Manager",
                MedianSalary = "$83,336 (PayScale)",
                Details = "Information system, or IS, managers, are the head of the information technology (IT) department and must be able to manage a team to ensure that they are functional and productive. They ensure program applications or modifications to those applications run smoothly.  (PayScale)",
                ImageUrl = "https://www.owlguru.com/wp-content/uploads/wpallimport/files/computer-and-information-systems-managers/__(1).jpg"
            });

            Network.Add(new Career
            {
                Name = "Computer Systems Analyst",
                MedianSalary = "$69,172 (PayScale)",
                Details = "Computer systems analysts use computers and related systems to automate functions and integrate them into distributing, manufacturing, sales, and other related functions. These analysts look at what a business unit or organization is attempting to do and then figure out how to use computer technology to streamline and automate those processes to achieve maximum accuracy and efficiency.  (PayScale)",
                ImageUrl = "https://d31u95r9ywbjex.cloudfront.net/sites/default/files/styles/width_320/public/iStock_000007201983XSmall_0.jpg?itok=Qbleg-iR"
            });

            Network.Add(new Career
            {
                Name = "IT Analyst",
                MedianSalary = "$63,493 (PayScale)",
                Details = "An IT analyst, also called a systems analyst, designs and implements information systems that optimize organizational efficiency. The process begins with managers, who provide the IT analyst with a broad objective, like capturing marketing research data. The IT analyst employs modeling, information engineering and cost-based accounting to develop a system that satisfies both management and end-users in the most cost-effective and efficient way possible. (Study)",
                ImageUrl = "https://www.yourfreecareertest.com/wp-content/uploads/2016/07/information_system_manager.jpg"
            });

            Network.Add(new Career
            {
                Name = "IT Coordinator",
                MedianSalary = "$51,789 (PayScale)",
                Details = "An information technology (IT) coordinator is normally the backbone of all computer-related technology within an organization or project. In larger organizations, this coordinator may be assigned to individual projects by an organization; in smaller companies, the IT coordinator may work across multiple projects or departments.  (PayScale)",
                ImageUrl = "https://www.turniton.co.uk/wp-content/uploads/2017/05/it-coordinator01.jpg"
            });

            Network.Add(new Career
            {
                Name = "Network Administrator",
                MedianSalary = "$59,574 (PayScale)",
                Details = "Network administrators are responsible for the upkeep of computer hardware and software systems. They usually focus on the network components within their company. In some cases it is the responsibility of network administrators to design and implement new networks. They are generally in charge of network address assignments, management and implementation of protocols. They also handle the maintenance of networks and file servers. (PayScale)",
                ImageUrl = "https://www.thebalancecareers.com/thmb/VHwZTBOLJ7p2ihY4nPjF0z9wmzs=/4256x2832/filters:fill(auto,1)/it-programmer-473983321-9ba7ff4909604fec8474760ced3c304a.jpg"
            });

            Network.Add(new Career
            {
                Name = "Network Architect",
                MedianSalary = "$120,858 (PayScale)",
                Details = "Network architects are in charge of effectively designing and reviewing network requirements and capabilities for their organization. They are responsible for validating high-level design plans for optimal network implementation. Network architects must be organized individuals that pay strong attention to detail to prevent network issues and incompatibility. They report their progress and escalate issues to the network administrator or supervisor in their department as needed (PayScale)",
                ImageUrl = "https://www.bls.gov/ooh/images/15197.jpg"
            });

            Network.Add(new Career
            {
                Name = "Network Engineer",
                MedianSalary = "$73,985 (PayScale)",
                Details = "The work of network engineers revolves around their employers' computer network designs and implementations, and they are salaried instead of paid on an hourly basis. They generally work in offices to troubleshoot problems related to their company’s enterprise-wide network, and they must ensure that their systems' security and firewall software is up-to-date. (PayScale)",
                ImageUrl = "https://online.norwich.edu/sites/default/files/content/resources/header/what_is_a_network_engineer_-_its_role_in_information_security.jpg"
            });

            Network.Add(new Career
            {
                Name = "Senior Network Architect",
                MedianSalary = "$148,490 (ZipRecruiter)",
                Details = "Senior technical infrastructure architects are often burdened with working for companies who do not adequately understand the value of good technical personnel. Information Technology is often outside the core business of their corporation, and these personnel are faced with shrinking budgets, limited projects, and outdated equipment. Architects are often forced into management promotion tracks which cause them to lose their technical skills. (SmartRecruiter - Fulcrum)",
                ImageUrl = "https://i.ytimg.com/vi/LGbI0lJT-Ds/maxresdefault.jpg"
            });

            Network.Add(new Career
            {
                Name = "Senior Network Engineer",
                MedianSalary = "$100,706 (PayScale)",
                Details = "Senior network engineers design and create computer networks within an organization and ensure that they are working properly. In some cases, they also maintain networks for third-party clients. The network should be balanced so that it works well and data flows easily; when networks are not functioning properly, the network engineer must use problem-solving skills to find a solution. It is also important to back up the systems so they can be easily restored. (PayScale)",
                ImageUrl = "https://ojjme2x5sm337cgpo2mhuny3-wpengine.netdna-ssl.com/wp-content/uploads/2017/05/senior-network-engineer-shutterstock_505337071.jpg"
            });

            Network.Add(new Career
            {
                Name = "Senior Network System Administrator",
                MedianSalary = "$79,134 (PayScale)",
                Details = "Information technology (IT) senior network administrators are responsible for providing system- and network-related solutions for their organization's information-technology assets. They oversee the functioning of networking equipment and follow strict maintenance standards. Their experience in the IT and networking fields is also used to develop new strategies to optimize server operation. (PayScale)",
                ImageUrl = "https://www.computersciencedegreehub.com/wp-content/uploads/2020/06/What-is-a-Systems-Administrator-1024x576.jpg"
            });

            Network.Add(new Career
            {
                Name = "Telecommunications Specialist",
                MedianSalary = "$63,862 (PayScale)",
                Details = "Telecommunications specialists are responsible for troubleshooting, implementing, and providing telecommunications support on behalf of their organization. They are in charge of ensuring the correct functioning of telecommunication devices, as well as providing regular maintenance of said devices. They interact with company staff, communicating technical issues in non-technical language, and serve as administrators for telecommunication channels to minimize downtime. (PayScale)",
                ImageUrl = "https://adoptostaging.blob.core.windows.net/media/telecommunications-specialist-job-description-template-FEKqCY.jpg"
            });
        }
    }
}