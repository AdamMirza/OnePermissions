# Welcome to OnePermissions

This project is a formatted GUI for Permission control at Microsoft.

**Simplifying the world of certs, keys, and permissions.**

*Built at the OneWeek Hackathon.*

## Setup

In order to build and run the project be sure to have the following frameworks on your machine:

 - .NET Framework v4.7.2
 - Visual Studio 2019
 - Angular 8*
 - Node v10.16.0

\* Packages for Angular will be indicated when trying to build the project.


## Running OnePermissions
First we have to start up the API. Open a command (cmd) prompt (or terminal) and `cd` into the project root.

    cd {{Enter your path here}}\OnePermissions

### .NET API
In that same cmd prompt, run the following to start the API.

    cd .\api\OnePermissions\
    dotnet run

The project will take some time to build, but should run on ports `5000` and `5001` as SSL.

To access the API make a GET call to the following endpoint:

    https://localhost:5001/api/values/{{Enter Your Parameter Here}}

### Angular Frontend
Open a command (cmd) prompt (or terminal) and `cd` into the ui folder.

    cd {{Enter your path here}}\OnePermissions\ui\

Run the following code

    ng serve

This will run the frontend on port `4200`.
Your project should open in your default browser, but if it doesn't, access it by [following this link](https://localhost:4200) or typing `https://localhost:4200` in your favorite browser window.
