using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class SystemsData
    {
        public static IList<Career> Systems { get; private set; }

        static SystemsData()
        {
            Systems = new List<Career>();

            Systems.Add(new Career
            {
                Name = "Go - Programming Language",
                Details = "One of the core languages favored by Google, Go is the little language that could. As a low-level language, Go is ideal for engineers who want to enter the field of systems programming. It encompasses much of the same functionality of C and C++ without the difficult syntax and steep learning curve. It’s the perfect language for building web servers, data pipelines, and even machine-learning packages. (FullStackAcademy)",
                ImageUrl = "https://www.kindpng.com/picc/m/599-5995612_golang-logo-hd-png-download.png"
            });

            Systems.Add(new Career
            {
                Name = "Rust - Programming Language",
                Details = "One of the core languages favored by Google, Go is the little language that could. As a low-level language, Go is ideal for engineers who want to enter the field of systems programming. It encompasses much of the same functionality of C and C++ without the difficult syntax and steep learning curve. It’s the perfect language for building web servers, data pipelines, and even machine-learning packages. (FullStack Academy)",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d5/Rust_programming_language_black_logo.svg/1200px-Rust_programming_language_black_logo.svg.png"
            });
        }
    }
}