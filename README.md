# PostGrad Office

This repository contains the code and database schema for the "PostGrad Office" web application, designed to manage thesis progress, payments, and other related activities for students, supervisors, admins, and examiners. This project was developed as part of the "Databases I" course at the German University in Cairo.

## Features
- **General Component**:
  - User registration and login (Students, Supervisors, Admins, and Examiners)
  - Telephone number management
- **Student Component**:
  - View and update student profile
  - List all theses and grades (for non-GUCian students)
  - Add and update progress reports for ongoing thesis
  - Add publications and link them to thesis
- **Supervisor Component**:
  - List all students and their thesis progress
  - View all publications of a student
  - Add defenses and assign examiners
  - Evaluate student progress reports
  - Cancel thesis if the evaluation is zero
- **Admin Component**:
  - Manage supervisors and theses
  - Issue thesis payments and installments
  - Update thesis extensions
- **Examiner Component**:
  - Edit personal information
  - List and grade defenses
  - Add comments for defenses
  - Search for thesis by title

## Technologies Used
- Frontend: HTML, CSS
- Backend: ASP.NET, SQL Server
- Database: SQL Server
- Stored Procedures and Functions for data operations

## Installation Instructions  
### Prerequisites
- **Visual Studio**: Ensure that Visual Studio is installed on your machine with support for ASP.NET development.
- **SQL Server**: Ensure that SQL Server is installed and running. The application connects to a database hosted on SQL Server.

### Setup
1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/AndrewSameh30/PostGrad-Office.git
2. Open the project in Visual Studio.
3. Set up the database by running the SQL scripts provided in the `sql-scripts/` directory. These scripts contain the database schema and necessary stored procedures.
4. Configure the database connection string in the `web.config` file to point to your SQL Server instance.
5. Build and run the application in Visual Studio.
   
### Database Setup
1. The database schema is located in the `sql-scripts/` folder.
2. Make sure to execute all SQL scripts to set up the necessary tables, stored procedures, and relationships.

### Running the App
1. Open the project in Visual Studio.
2. Press `Ctrl + F5` to run the application without debugging, or press `F5` to run with debugging.
3. The application will open in your default web browser.

