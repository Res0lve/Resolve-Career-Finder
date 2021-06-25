using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class DesktopData
    {
        public static IList<Career> Desktop { get; private set; }

        static DesktopData()
        {
            Desktop = new List<Career>();

            Desktop.Add(new Career
            {
                Name = "Go - Programming Language",
                Details = "One of the core languages favored by Google, Go is the little language that could. As a low-level language, Go is ideal for engineers who want to enter the field of systems programming. It encompasses much of the same functionality of C and C++ without the difficult syntax and steep learning curve. It’s the perfect language for building web servers, data pipelines, and even machine-learning packages. (FullStackAcademy)",
                ImageUrl = "https://www.kindpng.com/picc/m/599-5995612_golang-logo-hd-png-download.png"
            });

            Desktop.Add(new Career
            {
                Name = "Python - Programming Language",
                Details = "Python is perhaps the most user-friendly programming language of any on this list. It’s often said that Python’s syntax is clear, intuitive, and almost English-like, which, like Java, makes it a popular choice for beginners.  Python has a variety of applications that make it a versatile, powerful option when choosing the best programming language for your use case. (FullStackAcademy)",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/600px-Python-logo-notext.svg.png"
            });

            Desktop.Add(new Career
            {
                Name = "Scala - Programming Language",
                Details = "If you’re familiar with Java—a classic programming language in its own right—it’s worth checking out its modern cousin, Scala. Scala combines the best features of Java (such as its Object Oriented Structure and its lightning-fast JVM runtime environment) with a modern twist. (FullStackAcademy)",
                ImageUrl = "https://dwglogo.com/wp-content/uploads/2017/09/1300px-Scala_logo.png"
            });

            Desktop.Add(new Career
            {
                Name = "TypeScript - Programming Language (Gaming)",
                Details = "TypeScript provides highly productive development tools for JavaScript IDEs and practices, like static checking. TypeScript makes code easier to read and understand. With TypeScript, we can make a huge improvement over plain JavaScript. (Dzone)",
                ImageUrl = "https://seeklogo.com/images/T/typescript-logo-B29A3F462D-seeklogo.com.png"
            });

            Desktop.Add(new Career
            {
                Name = "Unity - Programming Platform (Gaming)",
                Details = "In Unity you can use scripts to develop pretty much every part of a game or other real-time interactive content. Unity supports scripting in C# and there are two main ways to architect your C# scripts in Unity: object-oriented design, which is the traditional and most widely used approach, and data-oriented design, which is now possible in Unity, for specific use cases, via our new high-performance multithreaded Data-Oriented Technology Stack (DOTS). (Unity)",
                ImageUrl = "https://deeziner.co.uk/blog/wp-content/uploads/2015/12/unity3d-atc.png"
            });
        }
    }
}
