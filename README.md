Basic CRUD Application Using C# and Windows Forms
Overview:
This project is a basic CRUD (Create, Read, Update, Delete) application developed using C# with Windows Forms as the user interface. It allows users to manage records in a database by performing the four basic operations on data: adding new records, retrieving/displaying records, updating existing records, and deleting records.
demonstration video: https://youtu.be/rPOWbF0CORo?si=7f9SXlHSDJ0Ys0sg

Key Features :
Insert: Add new records to the database through an input form.
Search: Display existing records in a table or list.
Update: Modify details of existing records.
Delete: Remove records from the system.
Tools and Technologies :

Programming Language: C#
User Interface: Windows Forms (WinForms)
Database: Microsoft SQL Server
IDE: Visual Studio
Project Workflow:
1. User Interface (Windows Forms)
Main Form: Contains buttons for Create, Edit, Read, Update, Delete, and Refresh operations, along with a DataGridView to display records.
Add/Edit Form: A separate form to enter or modify record details.
Message Boxes: Used for confirming actions such as deletion or record creation.
2. Database Operations
Insert: Add a new record by submitting a form.
Search: Fetch and display records from the database in the DataGridView.
Update: Edit an existing record by selecting it and submitting the modified data.
Delete: Remove a record by selecting it and confirming deletion.
Technical Steps:
1. Database Setup
Open the .sql file located in folder.
Copy the queries from the .sql file and execute them in your new database to set up the schema and initial data.
Use Ctrl+F to search for connectionString within the project files.
private readonly string connectionString = "Data Source=LAPTOP-4128Q006\SQLEXPRESS;Initial Catalog=crudform;Integrated Security=True;Encrypt=False;Trusted_Connection=True;";
- Update this to:
```csharp
private readonly string connectionString = "Data Source=LAPTOP-4128Q006\SQLEXPRESS;Initial Catalog=crudform;Integrated Security=True;Encrypt=False;Trusted_Connection=True;";
Database Schema:




2. Form Design
DataGridView: Displays records from the database.
Textboxes: Input fields for adding/editing records.
Buttons: Implement buttons for Insert, search, Update, Delete operations. 
3. C# Code Implementation
Sample Add New Operation:
 {
     SqlConnection con = new SqlConnection("Data Source=LAPTOP-4128Q006\\SQLEXPRESS;Initial Catalog=crudform;Integrated Security=True;Encrypt=False");
     con.Open();
     SqlCommand cmd = new SqlCommand("update ttt set name =@name,age=@age where id =@id", con);
     cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
     cmd.Parameters.AddWithValue("@name", textBox2.Text);
     cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
     cmd.ExecuteNonQuery();
     con.Close();
     MessageBox.Show("succesfully updated");

 }
 
 {
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-4128Q006\\SQLEXPRESS;Initial Catalog=crudform;Integrated Security=True;Encrypt=False");
    con.Open();
    SqlCommand cmd = new SqlCommand("delete ttt where id =@id",con);
    cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
    cmd.Parameters.AddWithValue("@name", textBox2.Text);
    cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
    cmd.ExecuteNonQuery();
    con.Close();
    MessageBox.Show("succesfully deleted");

}

4. Event Handling
Implement event handlers for each button (e.g., Create, Update, Delete).
When a button is clicked, the corresponding CRUD operation will be executed (e.g., creating a new record or deleting an existing one).
User Flow
When the application is opened, existing records are displayed in the DataGridView.
Users can:
Add new records by clicking the "Add" button and submitting the form.
Update existing records by selecting a row and clicking the "Edit" button.
Delete records by selecting a row and confirming deletion.
Search the displayed data to reflect the latest updates from the database.
Challenges and Considerations
Data Validation: Ensure proper input validation for fields.
Error Handling: Implement error handling for database connection failures or invalid inputs.
Further Enhancements
Search Functionality: Added a search bar to filter records.
How to Run the Project:

Clone the Repository: Clone this repository to your local machine.
git clone https://github.com/arunimasa/crud.git
Set Up the Database: Configure your SQL Server or SQLite database and update the connection according to the script.sql file.
Build the Project: Open the project basic_crud_app.csproj in Visual Studio and build the solution.
Run the Application: Once built, run the application and manage records through the Windows Forms interface.
