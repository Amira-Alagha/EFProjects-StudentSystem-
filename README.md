# Student System

## 📌 Project Overview

The **Student System** is a learning management system developed using **C# and Entity Framework Core**. It manages students, courses, learning resources, and homework submissions while demonstrating database relationships and Code First development.

The project focuses on applying object-oriented programming concepts and working with relational databases through Entity Framework Core.

## 🚀 Technologies Used

- **C#**
- **.NET**
- **Entity Framework Core (EF Core)**
- **SQL Server**
- **LINQ**
- **Code First Approach**
- **Entity Framework Core Migrations**

## ✨ Features

- **Student Management:** Represent and manage student information.
- **Course Management:** Organize courses and their related data.
- **Student Enrollment:** Handle the many-to-many relationship between students and courses.
- **Learning Resources:** Manage resources associated with learning content.
- **Homework Submissions:** Represent homework submissions and their related information.
- **Entity Relationships:** Configure relationships using foreign keys and navigation properties.
- **Data Seeding:** Initialize the database with predefined data.
- **Enum Support:** Use enumerations to represent predefined values, such as resource content types.
- **Database Management:** Create and update the database schema using EF Core migrations.

## 🏗️ Data Model

The project includes the following main entities:

| Entity | Description |
|---|---|
| `Student` | Represents students in the system. |
| `Course` | Represents courses available in the system. |
| `StudentCourse` | Join entity that connects students and courses. |
| `Resource` | Represents learning resources and their content information. |
| `HomeworkSubmission` | Represents homework submissions associated with students and learning activities. |

### Entity Relationships

- **Student ↔ Course:** Many-to-many relationship implemented through `StudentCourse`.
- **StudentCourse:** Uses a composite primary key consisting of `StudentId` and `CourseId`.
- **Resource:** Stores resource information, including content references and content types.
- **HomeworkSubmission:** Represents homework submission data and its configured entity relationships.

## 🗄️ Database Approach

The project follows the **Code First** approach with Entity Framework Core.

1. Define entities as C# classes.
2. Configure primary keys, foreign keys, and relationships.
3. Configure the database context using `DbContext`.
4. Create and apply migrations to generate or update the database schema.
5. Seed initial data when configured.

## 💡 Concepts Practiced

- Object-Oriented Programming (OOP)
- Entity Framework Core
- Code First workflow
- Database relationships
- Primary keys and composite keys
- Foreign keys and navigation properties
- LINQ fundamentals
- Enumerations
- Data seeding
- Database migrations
- SQL Server integration

## ⚙️ Getting Started

### Prerequisites

Make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/sql/ssms/download-sql-server-management-studio-ssms)
- [Entity Framework Core Tools](https://learn.microsoft.com/ef/core/cli/dotnet)

### Installation

1. Clone the repository:

   ```bash
   git clone <https://github.com/Amira-Alagha/EFProjects-StudentSystem->
   ```

2. Navigate to the project directory:

   ```bash
   cd <project1>
   ```

3. Configure your SQL Server connection string in the application's database configuration.

4. Restore the project dependencies:

   ```bash
   dotnet restore
   ```

5. Apply the Entity Framework Core migrations:

   ```bash
   dotnet ef database update
   ```

6. Run the project:

   ```bash
   dotnet run
   ```

> **Note:** Run EF Core commands from the appropriate project directory. If your solution separates the data project from the startup project, specify the relevant project options.

## 🎯 Project Goal

This project demonstrates practical skills in C#, Entity Framework Core, and relational database design. It serves as a foundation for building more advanced data-driven applications using .NET.

## 👩‍💻 Author

**Amira Aalagha**

