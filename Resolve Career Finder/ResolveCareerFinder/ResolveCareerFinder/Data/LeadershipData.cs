using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class LeadershipData
    {
        public static IList<Career> Leadership { get; private set; }

        static LeadershipData()
        {
            Leadership = new List<Career>();

            Leadership.Add(new Career
            {
                Name = "Chief Information Officer (CIO)",
                MedianSalary = "$162,050 (PayScale)",
                Details = "As the top of this organizational pyramid, the chief information officer's job is to make all of the big decisions regarding the organization's information framework. It is the CIO's task to make the final decisions regarding the selection and purchasing of IT equipment. The CIO also decides how to install the equipment, when to upgrade and improve the system, and how to integrate all of this into the rest of the company's operations. (PayScale)",
                ImageUrl = "https://tr3.cbsistatic.com/hub/i/r/2014/09/16/452a80ba-2667-48ce-9b6a-ed2a5e2ec9bc/resize/1200x/63389788bd52b2a182c902383a0948c7/pmp.jpg"
            });

            Leadership.Add(new Career
            {
                Name = "Chief Technology Officer (CTO)",
                MedianSalary = "$161,187 (PayScale)",
                Details = "A chief technology officer is part of an executive team in a company. He or she leads the efforts of the technology development within the company. This is usually the highest position related to technology within a company. Leadership skills are needed, as the CTO will often lead teams of people in the information technology department.  (PayScale)",
                ImageUrl = "https://mallory.com.au/wp-content/uploads/it-manager.jpg"
            });

            Leadership.Add(new Career
            {
                Name = "Director of Technology",
                MedianSalary = "$105,943 (PayScale)",
                Details = "A technology director is responsible for planning, organizing, and directing all operations and personnel in a company's information technology (IT) operations. They are in charge of maintaining a well-maintained technology network, and their team must be able to troubleshoot any technological issues that may arise.  (PayScale)",
                ImageUrl = "https://wdeptford.ss9.sharpschool.com/UserFiles/Servers/Server_3459/Image/Administration/tt.jpg"
            });

            Leadership.Add(new Career
            {
                Name = "IT Director",
                MedianSalary = "$119,886 (PayScale)",
                Details = "Information technology (IT) directors are responsible for managing and directing IT operations for their companies and providing leadership and technical advice to lead their departments. They may also be responsible for developing effective strategies for deploying technology and software, testing hardware devices and applications before introducing them to management, and managing schedules and deployment contracts. (PayScale)",
                ImageUrl = "https://www.masc.sc/SiteCollectionImages/uptown/Wes_in_Server_Room.JPG"
            });

            Leadership.Add(new Career
            {
                Name = "IT Manager",
                MedianSalary = "$88,216 (PayScale)",
                Details = "An information technology (IT) manager supervises their company's computer infrastructure and related areas of concern. He or she may oversee teams that manage network technology, IT security and the software platforms used by the company. The IT manager may help establish data storage infrastructure and access protocols and rules within the company as well.  (PayScale)",
                ImageUrl = "https://www.usnews.com/dims4/USNEWS/ac3ec9d/2147483647/thumbnail/640x420/quality/85/?url=http%3A%2F%2Fmedia.beam.usnews.com%2Fbd%2F80%2F5f37c7a84105b5aff55a875b67f4%2F180919-itoffice-stock.jpg"
            });

            Leadership.Add(new Career
            {
                Name = "Management Information Systems Director",
                MedianSalary = "$102,433 (PayScale)",
                Details = "A director of information systems is generally responsible for the management of the information systems of the business.  This director will usually manage any projects that would be part of the information systems. These projects could include implementation of new software, new equipment installation, or any changes or upgrades in current equipment.  (PayScale)",
                ImageUrl = "https://www.ecpi.edu/sites/default/files/techjuly31.png"
            });

            Leadership.Add(new Career
            {
                Name = "Technical Operations Officer",
                MedianSalary = "$83,758 (PayScale)",
                Details = "A technical operations manager is a leadership position in the technical department of an organization. These individuals are responsible for planning, coordinating, and executing organizational technical processes from start to finish. Technical operations managers are responsible for maintaining the technical goals of the company and address any future potential needs. A technical operations manager is a leadership position in the technical department of an organization. These individuals are responsible for planning, coordinating, and executing organizational technical processes from start to finish. Technical operations managers are responsible for maintaining the technical goals of the company and address any future potential needs. (PayScale)",
                ImageUrl = "https://www.gethppy.com/wp-content/uploads/2014/05/What-does-a-Chief-Happiness-Officer-actually-do-img.jpg"
            });
        }
    }
}