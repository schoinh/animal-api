# Animal Shelter API

#### _An API for an animal shelter - August 23, 2019_

#### _By **Na Hyung Choi**_

## Description

This API supports full CRUD functionality for an animal shelter database. The database contains a list of all animals at the shelter, with attributes such as species, gender, name, and spayed/neutered status. (For full schema and a sample request body for POST, please refer to the Swagger documentation. Setup instructions for it are below.) 

In addition to basic CRUD methods, the API allows:
* Optional query parameters for species and/or gender
* Pagination of data
* Retrieving a randomly selected animal
* Automatic calculation of an animal's `Age` (in decimal years) when user creates an animal and inputs the `Birthdate`

### **Basic CRUD**
| Endpoint | HTTP Method | Description |
| :------------- | :------------- | :------------- |
| `api/animals` | GET | Return all animals, sorted by intake date (newest first). Optional query parameters: `species`, `gender` |
| `api/animals/{id}` | GET | Returns a specific animal |
| `api/animals` | POST | Creates a new animal |
| `api/animals/{id}` | PUT | Edits a specific animal |
| `api/animals/{id}` | DELETE | Deletes a specific animal |

### **Pagination and Random Animal**
| Endpoint | HTTP Method | Description |
| :------------- | :------------- | :------------- |
| `api/animals/first` | GET | Returns first page of animals (3 animals per page), sorted by intake date (newest first) |
| `api/animals/next` | GET | Returns next page of animals |
| `api/animals/prev` | GET | Returns previous page of animals |
| `api/animals/random` | GET | Returns a random animal |

### **Example Call**
```
http://localhost:5000/api/animals?species=Cat&gender=Male
```

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
7. The API is now up and running. For full documentation on the database and details about using this API, navigate to the Swagger documentation at http://localhost:5001.

## Known Bugs
None at this time.

## Technologies Used
* C# / .NET Core
* ASP.NET Core MVC
* LINQ
* MySQL
* OpenAPI aka Swagger

## Support and contact details

_Please contact Na Hyung with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Na Hyung Choi_**