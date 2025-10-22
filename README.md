# Student Attendance System

## Description
A web-based application designed for teachers to efficiently manage and track student attendance. The system provides a clean interface for recording student information and monitoring attendance records for various courses.

### 🎥 Demo Video

[![Demo Video](https://img.icons8.com/color/96/000000/play--v1.png)](https://drive.google.com/file/d/1pdCYCpeT_vGXoZDYfwCXEcjH7b13rv8K/view?usp=sharing)

## Features
- **Teacher Authentication**: Secure login and sign-up for teachers
- **Student Management**: Add, update, and delete student information including ID, name, roll number, and course details
- **Attendance Tracking**: Record and view student attendance with Present/Absent status for specific dates
- **Data Search & Filtering**: Easily search and filter student lists and attendance records
- **Responsive Interface**: User-friendly web interface for easy navigation

## Tech Stack
- **Frontend**: HTML, CSS, Javascrpit, Bootstrap, ASP.NET Web Forms
- **Backend**: C# with ASP.NET
- **Database**: SQL Server 

## Demo
![System Demo](Screenshot%202025-10-22%20134803.png)

## Installation
1. Ensure you have .NET Framework and Visual Studio installed
2. Clone or download the project files
3. Open the project solution file (.sln) in Visual Studio
4. Build the solution to restore NuGet packages
5. Configure database connection in web.config
6. Run the application (hosted on `https://localhost:4434`)

## Usage

### Teacher Login
1. Navigate to the homepage
2. Click "Teacher Login"
3. Enter credentials (Username: `John`, Password)
4. Access the teacher dashboard

### Student Management
1. Go to "Student Information" section
2. Add new students using the form:
   - Student ID (e.g., A001)
   - Full Name
   - Roll No.
   - Date of Birth
   - Course Teacher
   - Year & Semester (e.g., 1-1)
   - Course No. (e.g., ECE 3110)
3. Use Update/Delete buttons to modify existing records
4. Search students using the search functionality

### Attendance Management
1. Navigate to "Insert Student Attendance" section
2. Select student from dropdown or search
3. Choose attendance date
4. Mark status as Present or Absent
5. View all attendance records in the "Attendance List" table
6. Use pagination and search to navigate records

## Project Structure
- `homepage.aspx` - Main landing page
- Student information management module
- Attendance recording module
- Teacher authentication system


