using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class MobileData
    {
        public static IList<Career> Mobile { get; private set; }

        static MobileData()
        {
            Mobile = new List<Career>();

            Mobile.Add(new Career
            {
                Name = "Java - Programming Language",
                Details = "Java is a programming language and computing platform first released by Sun Microsystems in 1995. There are lots of applications and websites that will not work unless you have Java installed, and more are created every day. Java is fast, secure, and reliable. From laptops to datacenters, game consoles to scientific supercomputers, cell phones to the Internet, Java is everywhere! (Java)",
                ImageUrl = "https://ih1.redbubble.net/image.418233732.0994/flat,1000x1000,075,f.u1.jpg"
            });

            Mobile.Add(new Career
            {
                Name = "JavaScript - Programming Language",
                Details = "It’s impossible to be a software developer these days without using JavaScript in some way. According to Stack Overflow's 2019 Developer Survey, JavaScript is the most popular language among developers for the seventh year in a row. Nearly 70 percent of survey respondents reported that they had used JavaScript in the past year.",
                ImageUrl = "https://b.kisscc0.com/20180815/zlq/kisscc0-computer-icons-logo-brand-javascript-angle-js-5b741783856f77.0690615715343348515466.png"
            });

            Mobile.Add(new Career
            {
                Name = "Object C/C# - Programming Language",
                Details = "C# uses a syntax that’s similar to other C-derived languages such as C++, so it’s easy to pick up if you’re coming from another language in the C family. C# is not only the go-to for Microsoft app development, but it’s also the language mobile developers use to build cross-platform apps on the Xamarin platform. (FullStack Academy)",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/C_Sharp_logo.svg/1200px-C_Sharp_logo.svg.png"
            });

            Mobile.Add(new Career
            {
                Name = "Switf - Programming Language",
                Details = "If you’re interested in Apple products and mobile app development, Swift is a good place to start. First announced by Apple in 2014, Swift is a relatively new programming language used to develop iOS and macOS applications. Swift has been optimized for performance and built from the ground up to match the realities of modern iOS development. (FullStackAcademy)",
                ImageUrl = "https://learning.naukri.com/articles/wp-content/uploads/sites/11/2020/01/swift-og.png"
            });
        }
    }
}