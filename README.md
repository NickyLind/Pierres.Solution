# _Pierre's Sweet and Savory Treats_

#### _This application showcases many-to-many database relationships and authentications using Entity's Identity_

#### By _**Nick Lindau**_

## Technologies Used

* _.NET5.0_
* _C#_
* _Visual Studio Code_
* _ASP NET Core MVC_
* _MySql_
* _MySql Workbench_
* _Entity Framework_
* _Bootstrap_
* _CSS_
* _ASP.NET Razor_
* _Identity_

## Description

_Pierre is back! He wants you to create a new application to market his sweet and savory treats. This time, he would like you to build an application with user authentication and a many-to-many relationship. Here are the features he wants in the application:_
```
 * The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.

* There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.

* A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.
```

## Setup/Installation Requirements
To run this application you will need the following:
* A code editor. [Visual Studio Code](https://code.visualstudio.com/) is what I use.
* [ASP.NET Core](https://dotnet.microsoft.com/download)
* [MySQL and MySQL Workbench](https://www.mysql.com/)

### 1) Cloning the Project:
* Find the respository [Here](https://github.com/NickyLind/Pierres.Solution)
* Select the green <span style="color:green">'Code'</span> button above the repository and copy the HHTPS link
* In your terminal, find the directory you want to place the <span style="color:red">Pierres.solution</span> directory in
* In your terminal, use the git command `$git clone https://github.com/NickyLind/Pierres.Solution`
* Open in Visual Studio Code or another editor

### 2) Setup a Database for the project:
* Create a file in the root directory of the project (`Pierres`), and name it `appsettings.json`.
* In the `appsettings.json` file you will need to add the following code
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=nick_lindau;uid=[USERIDHERE];pwd=[USERPASSWORDHERE];"
  }
}
```
* Replace the [USERIDHERE] & [USERPASSWORDHERE] with the username and password associated with your local MySQL server.
* Navigate to the `Pierres` Directory in the terminal
* If you have ran one of my projects before and titled the related database `nick_lindau` you will have to run the command `dotnet ef database drop` to remove the previous database
* Once you are sure you have no previous database schema named `nick_lindau` you will need to run the command `dotnet ef database update` to create a database using all the classes from this application.
* You can verify this was created correctly by refreshing the list of schemas in the MySQL Workbench and the schema titled `nick_lindau` should be there

### 3) Running the project:

* Once the project is successfully cloned and the database is connected to can now run the project
* Navigate to the `Pierres` directory and build the project with the command `dotnet build` to ensure there are no compiling errors
* Once the project is succesfully built you may run the command `dotnet run` and navigate to Http://localport:5000 in your browser to access the applications

## Known Bugs

* _Feel free to email me if you find any bugs_


## License

_[MIT](https://choosealicense.com/licenses/mit/)_
 _Copyright (c) Nick Lindau 03/26/2021_

## Contact Information

_Nick Lindau @ <nicholaithegreat@gmail.com>_
