📌 Overview

Student Portal is a simple ASP.NET Core MVC web application developed to manage Students and Courses.
The project demonstrates MVC architecture, interfaces, dependency injection, and Razor views.

🚀 Features

Add new Students

View all Students

View Student details

Add new Courses

View all Courses

View Course details

Clean Bootstrap UI

MVC Architecture

Dependency Injection

Service Layer Implementation

🏗️ Project Structure
StudentPortal
│
├── Controllers
│   ├── StudentController.cs
│   └── CourseController.cs
│
├── Models
│   ├── Student.cs
│   └── Course.cs
│
├── Interfaces
│   ├── IStudentService.cs
│   └── ICourseService.cs
│
├── Services
│   ├── StudentService.cs
│   └── CourseService.cs
│
├── Views
│   ├── Student
│   └── Course
│
└── Program.cs

🧠 Technologies Used

ASP.NET Core MVC

C#

Razor Pages

Bootstrap 5

.NET 8 / .NET 9

🔗 Endpoints
Student Endpoints

/Student/Index

/Student/Details/{id}

/Student/Create

Course Endpoints

/Course/Index

/Course/Details/{id}

/Course/Create

⚙️ How to Run

Clone the repository:

git clone https://github.com/YOUR_USERNAME/StudentPortal.git


Navigate to project folder:

cd StudentPortal


Run the project:

dotnet run


Open browser:

http://localhost:5158/

👨‍💻 Author

Fady Adel
Faculty of Computer Science
Graduation Year: 2026

📚 Academic Purpose

This project was developed as part of a .NET MVC assignment to demonstrate:

Models

Controllers

Views

Interfaces

Dependency Injection