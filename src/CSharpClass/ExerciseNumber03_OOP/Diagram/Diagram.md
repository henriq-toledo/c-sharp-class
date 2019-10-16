# Class Diagram

abstract class Person \
+String FistName get \
-String FirstName set \
+String LastName get \
-String LastName set \
+String FullName get \
+virtual String GetInformation() \
#void Person(String FirstName, string LastName)

abstract class Employee : Person \
+String CompanyName get \
-String CompanyName set \
#void Employee(String firstName, string lastName, string companyName) \
+String GetInformation()

class DatabaseAdministrator : Employee \
-List::String _databases \
+void AddDatabase(String databaseName) \
+void RemoveDatabase(String databaseName) \
+String GetInformation() \
+void DatabaseAdministrator(String firstName, string lastName, string companyName)

class Support : Employee \
-List::String _programs \
+void AddProgram(String program) \
+void RemoveProgram(String program) \
+String GetInformation() \
+void Support(String firstName, string lastName, string companyName)

<ins>class EmployeesList<ins> \
<ins>#List::Employee Employees</ins>
