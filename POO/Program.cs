using System;
using System.Collections.Generic;
using System.Linq;

using Curso.ContentContext;

namespace Curso
{   
    class Program 
    {
          static void Main(string[] args)
        {
                 var articles = new List<Article>();
                 articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
                 articles.Add(new Article("Artigo sobre C#", "csharp"));
                 articles.Add(new Article("Artigo sobre .NET", "dotnet"));
                 
                 foreach (var article in articles)
                 {
                    Console.WriteLine(article.Id);
                    Console.WriteLine(article.Title);
                    Console.WriteLine(article.Url);
                 }
                 var courses = new List<Course>();
                 var courseOOP = new Course("Fundamentos OOP", " fundamento-oop");
                 var courseCsharp = new Course("Fundamentos C#", " fundamento-csharp");
                 var courseAspNet = new Course("Fundamentos ASP.NET", " fundamento-aspnet");
                courses.Add(courseOOP);
                courses.Add(courseCsharp);
                courses.Add(courseAspNet);
                

                var careers = new List<Career>();
                var careerDotnet = new Career("Especialista .Net", "especialista-dotnet");
                var careerItem2 = new CareerItem(2, "Aprenda OOP,","", courseOOP);
                var careerItem = new CareerItem(1, "Comece por aqui,","", courseCsharp);
                var careerItem3 = new CareerItem(3, "Aprenda .NET,","", courseAspNet);
                careerDotnet.Items.Add(careerItem);
                careerDotnet.Items.Add(careerItem3);
                careerDotnet.Items.Add(careerItem2);
                careers.Add(careerDotnet);
                foreach(var career in careers)
                {
                    Console.WriteLine(career.Title);
                    foreach (var item in career.Items.OrderBy( x => x.Ordem))
                    {
                        Console.WriteLine($"{item.Ordem} - {item.Title}");
                        Console.WriteLine(value: item.Course.Title);
                        Console.WriteLine(item.Course.Level);


                    }
                }    
        }
    }
}