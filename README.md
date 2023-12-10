# IEPCompanion

## Contributors

- [Genesis Scott](github.com/witherScript) 
- [Aaron Brown](github.com/aaronvbrown)
- [Mike C](github.com/mikerophonic)
- [Julien Lenaz](github.com/julienfullstack)
- [Israel Padilla](github.com/izzy503)

## Overview
This is a web application for teachers that uses Entity Framework to relate and persist data to form Individual Education Plans. The backend employs authentication and authorization to enable full CRUD functionality for signed in users.

### Technologies Used
- C#/.NET
- Entity Framework
- Pomelo
- Microsoft Identity
- MySQL
- Linq
- Role Based Access Control


## Complete Setup/Installation Instructions
1. Clone the repository to your local machine.

```bash
$ git clone [https://github.com/aaronvbrown/IEPCompanion.Solution](https://github.com/aaronvbrown/IEPCompanion.Solution)
```
2. Navigate to the project directory.

```bash
$ cd IEPCompanion.Solution
```
3. Touch a file in IEPCompanion.Solution/IEPCompanion called appsettings.json and add the following code, replacing the uid and pwd values with your own username and password for MySQL.
$ touch appsettings.json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=Genesis_Scott;uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
  }
}
4. Run "git checkout "Modefc" to checkout the final production branch.
5. Run the command ```dotnet restore``` to install necessary packages.
6. Run the command ```dotnet build``` to compile the application.
7. Run ```dotnet ef database update``` to replicate current schema migrations
8. Run ```dotnet run``` to start the server and application.
9. Visit localhost:5000 in your browser to access the application.
Follow on-screen prompts.

## Known Bugs

- Role Based Access Control is phased out in the final version of the project

## License Information
The project is licensed under the ISC license.

