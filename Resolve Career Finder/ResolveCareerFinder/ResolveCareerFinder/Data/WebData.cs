using System.Collections.Generic;
using ResolveCareerFinder.Models;

namespace ResolveCareerFinder.Data
{
    public static class WebData
    {
        public static IList<Career> Web { get; private set; }

        static WebData()
        {
            Web = new List<Career>();

            Web.Add(new Career
            {
                Name = "Back-End Web Development",
                Details = "The back end of a website consists of a server, an application, and a database. A back-end developer builds and maintains the technology that powers those components which, together, enable the user-facing side of the website to even exist in the first place. (Udacity)",
                ImageUrl = "https://imageog.flaticon.com/icons/png/512/106/106842.png?size=1200x630f&pad=10,10,10,10&ext=png&bg=FFFFFFFF"
            });

            Web.Add(new Career
            {
                Name = "Front-End Web Development",
                Details = "The front end of a website is the part that users interact with. Everything that you see when you’re navigating around the Internet, from fonts and colors to dropdown menus and sliders. (Udacity)",
                ImageUrl = "https://papercallio-production.s3.amazonaws.com/uploads/event/logo/786/frontend.png"
            });

            Web.Add(new Career
            {
                Name = "Elm - Front-End",
                Details = "One of the youngest languages on our list, what began as a Harvard student’s thesis has now grown to become a point of passion for front-end developers around the world. Elm compiles to JavaScript, making it ideal for building fast-executing UIs with zero errors at runtime. Elm is a functional programming language, allowing developers to create client-side interfaces without the declarative trappings of HTML and CSS. (FullStack Academy)",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQOSy1ncs8NSHwe9LxrfXb-u7YBdzSnaVtLng&usqp=CAU"
            });

            Web.Add(new Career
            {
                Name = "Go - Back-End",
                Details = "One of the core languages favored by Google, Go is the little language that could. As a low-level language, Go is ideal for engineers who want to enter the field of systems programming. It encompasses much of the same functionality of C and C++ without the difficult syntax and steep learning curve. It’s the perfect language for building web servers, data pipelines, and even machine-learning packages. (FullStackAcademy)",
                ImageUrl = "https://www.kindpng.com/picc/m/599-5995612_golang-logo-hd-png-download.png"
            });

            Web.Add(new Career
            {
                Name = "JavaScript - Front and Back End",
                Details = "It’s impossible to be a software developer these days without using JavaScript in some way. According to Stack Overflow's 2019 Developer Survey, JavaScript is the most popular language among developers for the seventh year in a row. Nearly 70 percent of survey respondents reported that they had used JavaScript in the past year.",
                ImageUrl = "https://b.kisscc0.com/20180815/zlq/kisscc0-computer-icons-logo-brand-javascript-angle-js-5b741783856f77.0690615715343348515466.png"
            });

            Web.Add(new Career
            {
                Name = "Python - Back-End",
                Details = "Python is perhaps the most user-friendly programming language of any on this list. It’s often said that Python’s syntax is clear, intuitive, and almost English-like, which, like Java, makes it a popular choice for beginners.  Python has a variety of applications that make it a versatile, powerful option when choosing the best programming language for your use case. (FullStackAcademy)",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/Python-logo-notext.svg/600px-Python-logo-notext.svg.png"
            });

            Web.Add(new Career
            {
                Name = "Ruby - Back-End",
                Details = "Ruby is another scripting language that’s commonly used for web development. In particular, it’s used as the basis for the popular Ruby on Rails web application framework. Beginners often gravitate toward Ruby because it has a reputation for having one of the friendliest and most helpful user communities. (FullStackAcademy)",
                ImageUrl = "https://www.pngitem.com/pimgs/m/12-120179_best-free-ruby-png-ruby-programming-language-logo.png"
            });

            Web.Add(new Career
            {
                Name = "Scala - Back-End",
                Details = "If you’re familiar with Java—a classic programming language in its own right—it’s worth checking out its modern cousin, Scala. Scala combines the best features of Java (such as its Object Oriented Structure and its lightning-fast JVM runtime environment) with a modern twist. (FullStackAcademy)",
                ImageUrl = "https://dwglogo.com/wp-content/uploads/2017/09/1300px-Scala_logo.png"
            });

            Web.Add(new Career
            {
                Name = "TypeScript - Front-End",
                Details = "TypeScript provides highly productive development tools for JavaScript IDEs and practices, like static checking. TypeScript makes code easier to read and understand. With TypeScript, we can make a huge improvement over plain JavaScript. (Dzone)",
                ImageUrl = "https://seeklogo.com/images/T/typescript-logo-B29A3F462D-seeklogo.com.png"
            });
        }
    }
}