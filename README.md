# Animal Shelter API

#### _An API for an animal shelter - August 23, 2019_

#### _By **Na Hyung Choi**_

## Description



## Setup/Installation Requirements

* This application requires MySQL.

1. Clone this repository:
    ```
    $ git clone https://github.com/schoinh/animal-api.git
    ```
2. Open the database context file (animal-api/Models/Animal_APIContext.cs) and replace `EnvironmentVariables.MySQLKey` with a string containing your MySQL password (ex: `"abcd123"`).

3. Log onto MySQL:
    ```
    $ mysql -u USERNAME -p PASSWORD
    ```
5. Navigate to the project directory (Animal-API). Restore dependencies, update your local database, and run the API:
    ```
    $ dotnet restore
    $ dotnet ef database update
    $ dotnet run
    ```
7. The API is now up and running. For full documentation on using this API, refer to XXXXXXXXX.

## Known Bugs
??????????

## Technologies Used
* C# / .NET Core
* ASP.NET Core MVC
* LINQ
* MySQL
* OpenAPI

## Support and contact details

_Please contact Na Hyung with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Na Hyung Choi_**