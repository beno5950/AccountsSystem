# Database Setup Instructions

This document explains how to execute the SQL script file `AccDBScript.sql` to create and configure the database on the client machine.

---

## Prerequisites

- Microsoft SQL Server installed (any supported edition, e.g., Express, Developer, Standard).
- SQL Server Management Studio (SSMS) or any other SQL query tool.
- Access rights to create databases on the SQL Server instance.

---

## Steps to Execute the SQL Script

1. **Copy the Script File**  
   Copy the file `AccDBScript.sql` to a convenient location on the client machine.

2. **Open SQL Server Management Studio (SSMS)**  
   Launch SSMS and connect to the target SQL Server instance.

3. **Open the SQL Script**  
   - In SSMS, go to `File` → `Open` → `File...`  
   - Navigate to the location of `AccDBScript.sql` and open it.

4. **Review the Script (Optional)**  
   Review the script content to understand the database schema and settings.

5. **Execute the Script**  
   - Click the `Execute` button (or press F5) to run the script.  
   - Wait for the execution to complete successfully.  
   - Confirm there are no errors reported in the Messages pane.

6. **Verify Database Creation**  
   - In SSMS Object Explorer, refresh the database list.  
   - Confirm that the new database has been created as specified in the script.

---

## Troubleshooting

- **Permission Issues**: Make sure the SQL Server login you are using has permission to create databases.  
- **Errors During Execution**: Check the error messages for details and resolve issues accordingly.  
- **SQL Server Service Running**: Ensure the SQL Server service is running.

---

## Notes

- The script file defines the entire database structure including tables, relationships, and initial data if any.  
- Do not rename or modify the script file unless necessary.  
- Keep a backup of the script file for future use.
