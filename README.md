# Employee Management System

This is a desktop application developed in C# using Windows Forms for managing employee data, including their details, positions, and salaries. The application connects to a SQL Server database to store and retrieve information.

## Features
*   **User Authentication:** Secure login and registration for users.
*   **Dashboard:** Overview of employee statistics (Total, Active, Inactive Employees).
*   **Employee Management:**
    *   Add new employee records with details such as ID, full name, gender, contact number, position, status, and image.
    *   Update existing employee information.
    *   Delete employee records (soft delete, marking as inactive).
    *   View a comprehensive list of all employees.
*   **Salary Management:**
    *   View employee salary details.
    *   Update employee salaries.
*   **Image Handling:** Import and display employee images.
*   **Database Integration:** Stores and retrieves data from a SQL Server database.

## Technologies Used
*   **C#:** The primary programming language for the desktop application.
*   **Windows Forms (WinForms):** For building the graphical user interface.
*   **SQL Server:** Relational database management system for storing application data.
*   **ADO.NET:** For connecting to and interacting with the SQL Server database.

## Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

*   **Visual Studio:** (e.g., Visual Studio 2019 or newer) with .NET desktop development workload installed.
*   **SQL Server:** (e.g., SQL Server Express, Developer Edition)
*   **SQL Server Management Studio (SSMS):** (Optional, but recommended for database management)


### Installation

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/YOUR_USERNAME/Employee-Management-System.git
    cd Employee-Management-System
    ```

2.  **Set up the SQL Server Database:**
    *   Open SQL Server Management Studio (SSMS).
    *   Create a new database named `EMPLOYEE_DB`.
    *   Execute the SQL script (if available, otherwise create the tables manually based on the application's schema):
        *   **USERS Table:**
            ```sql
            CREATE TABLE USERS (
                id INT PRIMARY KEY IDENTITY(1,1),
                USERNAME VARCHAR(MAX),
                PASSWORDS VARCHAR(MAX),
                DATE_REGISTER DATE
            );
            ```
        *   **EMPLOYEES Table:**
            ```sql
            CREATE TABLE EMPLOYEES (
                ID INT PRIMARY KEY IDENTITY(1,1),
                EMPLOYEE_ID VARCHAR(MAX),
                FULL_NAME VARCHAR(MAX),
                GENDER VARCHAR(MAX),
                CONTACT_NUMBER VARCHAR(MAX),
                POSITION VARCHAR(MAX),
                IMAGES VARCHAR(MAX),
                SALARY INT,
                INSERT_DATE DATE,
                UPDATE_DATE DATE,
                DELETE_DATE DATE,
                STATUS VARCHAR(MAX)
            );
            ```
    *   **Update Connection String:**
        *   Open the `App.config` file in the project.
        *   Modify the `connectionString` to match your SQL Server instance:
            ```xml
            <connectionStrings>
                <add name="DefaultConnection" connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=EMPLOYEE_DB;Integrated Security=True" providerName="System.Data.SqlClient" />
            </connectionStrings>
            ```
            Replace `YOUR_SERVER_NAME` with your actual SQL Server instance name (e.g., `DESKTOP-EFCD3D4`).

3.  **Open the project in Visual Studio:**
    *   Open `Employee_Managment_System.sln`.

4.  **Restore NuGet Packages:**
    *   Right-click on the solution in Solution Explorer and select "Restore NuGet Packages".

5.  **Build the Solution:**
    *   Build the project (`Ctrl+Shift+B` or `Build > Build Solution`).

### Running the Application

1.  **Start the application:**
   *   Build the project in Visual Studio (Build > Build Solution).
   *  Run the application (Debug > Start Debugging or press F5).

2.  **Register a new user:**
  *   On the login screen, click the "SIGN UP" button.
  *   Enter a username and password, then click "SIGN UP".
  *    You will be redirected to the login screen.

3.  **Log in:**
    *   Enter your registered username and password.
    *   Click the "Login" button.

    
4.  **Navigate the Application:**
    *   **Dashboard:** View employee statistics.
    *   **Add Employee:** Add new employee details and import their image.
    *   **Salary:** View and update employee salaries.

## Project Structure

*   `Form1.cs`: Login form.
*   `Register_form.cs`: User registration form.
*   `MainForm.cs`: Main application window with navigation to different modules.
*   `Dashboard.cs`: User control for displaying dashboard statistics.
*   `AddEmployee.cs`: User control for adding, updating, and deleting employee records.
*   `Salary.cs`: User control for managing employee salaries.
*   `EmployeeData.cs`: Data model and data access logic for employee information.
*   `SalaryData.cs`: Data model and data access logic for salary information.
*   `Properties/Resources.resx`: Contains application resources like images.
*   `App.config`: Application configuration, including the database connection string.

## Screenshots

*(You can add screenshots of your application here)*

