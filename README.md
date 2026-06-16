# University Management System (C# WinForms)

A university management system developed using C# Windows Forms.  
The system simulates core features of academic systems such as 'behestan.iut.ac.ir', supporting different user roles including students, professors, and staff.

The application allows course registration, academic term management, grading, and reporting.

---

## Features

### Student
- Login with username and password
- Select a major (enum-based predefined list)**
- Register courses during the allowed term registration period**
- Credit limits based on GPA:
  - GPA > 17 → up to 24 credits
  - 12 ≤ GPA ≤ 17 → up to 20 credits
  - GPA < 12 → up to 12 credits
- View enrolled courses for each term
- View academic history
- Edit personal information

### Professor
- Login with username and password
- View courses taught in each term
- View the list of students in each course
- Enter and save student grades
- Edit personal information

### Staff (Administration)
- Create and manage academic terms
- Add, edit, or remove courses
- View and manage students and professors
- Assign professors to courses  
  - Each professor can teach up to 4 courses per term
- Enroll or remove students from courses
- Generate reports:
  - Course report (course name, professor, number of students)
  - Major report (number of students, courses, professors)
- Remove courses with fewer than 10 students
- Restrict students from course registration

### Course
Each course includes:
- Major
- Term
- Number of credits
- Assigned professor
- List of enrolled students

### Term
Each academic term includes:
- Start date
- End date
- Course registration period
- List of offered courses

---

## System Roles

The system contains three main user panels:

- Student Panel
- Professor Panel
- Staff (Admin) Panel

Each role has different permissions and access levels.

---

## Technologies Used

- C#
- .NET
- Windows Forms (WinForms)
- Object-Oriented Programming

---

## Possible Future Improvements

- Course scheduling and time conflict detection
- Database integration (SQL Server)
- Improved reporting and analytics
- Modern UI framework

---
Isfahan University of Technology - Advanced Programming - Course Project