using MyPortfolioMVC.Models;

namespace MyPortfolioMVC.Data
{
    public class ProjectData
    {
        public static List<Project> Projects { get; set; } = new List<Project>();
        public static List<Comment> Comments { get; set; } = new List<Comment>();

        static ProjectData()
        {
            Projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "Fizz, Buzz, and FizzBuzz",
                    Description = "The C# code for generating numbers between 0 to 100 and displaying Fizz for multiples of 3, Buzz for multiples of 5, and FizzBuzz for multiples of both.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/BSIT31E2_Prelim_A1_ArciagaLloydNathaniel.git",
                    ImageUrl = "/images/PrelimAct1.png"
                },

                new Project
                {
                    Id = 2,
                    Title = "Simple Calculator",
                    Description = "This program, written in C#, develops a basic calculator where users can input two numbers and execute operations such as addition, subtraction, multiplication, or division.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/BSIT31E2_Prelim_A2_ArciagaLloydNathaniel.git",
                    ImageUrl = "/images/PrelimAct2.png"
                },

                new Project
                {
                    Id = 3,
                    Title = "Student Management System",
                    Description = "The Student Management System allows you to input the student’s name and three grades for him/her, find his/her average grade, and detect his/her maximum grade in the classroom.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/BSIT31E2_PRELIM_H1_ARCIAGA_LLOYDNATHANIEL.git",
                    ImageUrl = "/images/PrelimH1.png"
                },

                new Project
                {
                    Id = 4,
                    Title = "File Ingestion Engine",
                    Description = "The File Ingestion Engine is designed to efficiently process and import data from various file formats into the system.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/BSIT31E2_PRELIM_H2_Arciaga_LloydNathaniel.git",
                    ImageUrl = "/images/PrelimH2.png"
                },

                new Project
                {
                    Id = 5,
                    Title = "HTTP-Server",
                    Description = "The HTTP-Server project involves creating a simple web server that can handle basic HTTP requests and responses.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/BSIT31E2_Prelim_A3_Arciaga_LloydNathaniel.git",
                    ImageUrl = "/images/PrelimAct3.png"
                },

                new Project
                {
                    Id = 6,
                    Title = "My Portfolio",
                    Description = "A simple portfolio website to showcase my projects and skills.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/IT_ELECTIVE_2_Midterm_A1_Arciaga_LloydNathaniel.git",
                    ImageUrl = "/images/MidtermAct1.png"
                },

                new Project
                {
                    Id = 7,
                    Title = "Login Page with Validation",
                    Description = "A simple hard-coded login page with form validation such as required fields and minimum length requirements.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/IT_ELECTIVE_BSIT_31E2_Arciaga_LloydNathaniel.git",
                    ImageUrl = "/images/MidtermLogin.png"
                },

                new Project
                {
                    Id = 8,
                    Title = "URL Song List",
                    Description = "A simple application for creating and managing a list of URLs for songs.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/IT_ELECTIVE_2_MIDTERM_Q2_Arciaga_LloydNathaniel.git",
                    ImageUrl = "/images/MidtermQ2.png"
                },

                new Project
                {
                    Id = 9,
                    Title = "MVC Authentication",
                    Description = "A simple authentication system implemented in an ASP.NET MVC application.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/IT_ELECTIVE_2_MIDTERM_Q3_Arciaga_LloydNathaniel.git",
                    ImageUrl = "/images/MidtermQ3.png"
                },

                new Project
                {
                    Id = 10,
                    Title = "KMart POS",
                    Description = "A simple point-of-sale system implemented in an ASP.NET MVC application.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Arciaga_LloydNathaniel.git",
                    ImageUrl = "/images/MidtermH1H2H3.png"
                },

                new Project
                {
                    Id = 11,
                    Title = "Package Pickup Monitoring System",
                    Description = "A system for monitoring package pickups implemented in an ASP.NET MVC application.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/IT_ELECTIVE_2_MIDTERM_EXAM_6_Arciaga_LloydNathaniel.git",
                    ImageUrl = "/images/MidtermExam.png"
                },

                new Project
                {
                    Id = 12,
                    Title = "20 Questions and Answers using MVC",
                    Description = "A application for viewing a list of questions and answers using ASP.NET MVC.",
                    GitHubLink = "https://github.com/lloydnathanielarciaga/IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.git",
                    ImageUrl = "/images/PrefinalExam.png"
                },

            };
        }
    }
}
