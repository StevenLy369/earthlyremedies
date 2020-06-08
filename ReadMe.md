# _Earthly Remedies_

#### _Epicodus Project June 8, 2020_

#### By _**Julia Seidman & DJ Zevenbergen**_


## Description

_A project to introduce practices for building an API in C#/.Net Core 2.2.0._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Install MySQL on your computer.
3. Open the downloaded directory in a text editor of your choice. (VSCode, Atom, etc.)
4. In your terminal, navigate to the project directory and run the commands dotnet restore and dotnet build to download dependencies and build the configuration.
5. Currently, the mySQL database is set up with an appsettings.json file that was not uploaded to Github.  Once you have saved the SQL database on your computer, create an appsettings.json file in the project root directory, and update it with your MySQL installation information in this format:
  ```{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=YOUR PORT NUMBER HERE;database=DATABASE NAME AS YOU SAVED IT;uid=YOUR USER ID HERE;pwd=YOUR PASSWORD HERE;"
  }
}```
6. To run MySQL migrations and create a database in your MySQL installation, enter the following command in your terminal: ```dotnet ef database update```.
7. To launch the application in your browser, from the project directory in your terminal, enter ```dotnet run``` and open a browser page at localhost:5000.
8. For demo purposes, user accounts may be created with a mockup email and a single-character password, or you may use the account "pete@pete.com" with password "p".


## Known Bugs

There are no known bugs at the time of this update.

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue] here on GitHub._

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MySQL
* Identity
* MSBuild
* Git and GitHub

### User Story

* As a user, I want to be able GET remedies related to a specific ailment
* As a user, I want to be able to POST natural remedies for a specific ailment.
* As a user, I want to see a list of all ailments.
* As a user, I want to be able to tag remedies with specific ingredients.
* As a user, I want to see all uses for a particular ingredient.
* As a user, I want to be able to PUT and DELETE remedies that I have created.
* As a user, I want to be able to look up remedies.
<!-- * As a user, I want to be able to post ratings for remedies.  
* As a user, I want to see the best Remedies by rating. -->

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |



### License
This software is licensed under the MIT license.

Copyright (c) 2020 **_Julia Seidman & DJ Zevenbergen_**