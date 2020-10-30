# _National Parks API_

#### _An API app for state and national parks, 10/30/20_

#### By _**Ben Stoller**_

## Description

An API application that lets a user access a database of national and state parks. Here is a sample JSON respone and what the properties the Parks model has: 
```
{
        "parkId": 1,
        "parkName": "YellowStone",
        "parkDescription": "OLD FAITHFULL YALL",
        "parkLocation": "Wyoming, Montana, Idaha",
        "dateEstablished": "March 1, 1872",
        "parkArea": 2219790.71,
        "annualVisitors": 4020288
}
```
## API Documentation 

### Using Swagger Documentation 
To explore the National Parks API utilizing Nswag, start the project with "dotnet run" and navigate to the following URL in your browser: "http://localhost:5000/swagger"

### Using the JSON Web Token (JWT)
In order to be authorized to use the POST, PUT, DELETE functionality of the API, you will need to authenticate yourself through Postman.
* Open Postman and create a POST request using the URL: `http://localhost:5000/api/users/authenticate`
* Add the following to the request as JSON raw data in the Body tab:
```
{
    "UserName": "ParksAdmin",
    "Password": "epicodus"
}
```
* The token will be generated in the response. Copy and paste it as the Token paramenter in the Authorization tab.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https://localhost:5000/api/recipe/131
```

#### Sample JSON Response
```
{
    "Id": 131,
    "Name": "Spiced Cold Brew",
    "Ingredient": "Cinnamon, Nutmeg, Cayenne",
    "Recipe Text: "Coffee is the answer to all solutions in the known universe as proven by leading scientists.",
}
```

..........................................................................................

### Coffee Beans
Access information on coffee beans from around the world.

#### HTTP Request
```
GET /api/bean
POST /api/bean
GET /api/bean/{id}
PUT /api/bean/{id}
DELETE /api/bean/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.
| origin | string | none | false | Return any bean from a specific country or region of origin. |
| flavor | string | none | false | Return bean matches with a specific flavor profile. |

#### Example Query
```
https://localhost:5000/api/bean/?origin=brazil&flavor=robust
```

#### Sample JSON Response
```
{
    "Id": 114,
    "Name": "Café Saboroso",
    "Origin": "Brazil",
    "Flavor: "Sweet, Cherry, Robust"
}
```

..........................................................................................

### Beverages
Access information about popular coffee beverages.

#### HTTP Request
```
GET /api/beverage
POST /api/beverage
GET /api/beverage/{id}
PUT /api/beverage/{id}
DELETE /api/beverage/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.
| temp | string | none | false | Return beverage matches with a specific served temperature. |
| topping | string | none | false | Return beverage matches with a specific topping. |
| year | int | none | false | Return beverage matches with a specific year of invention. |

#### Example Query
```
https://localhost:5000/api/beverage/?name=latte&temp=iced&year=1840
```

#### Sample JSON Response
```
{
    "Id": 33,
    "Name": "Iced Latte",
    "Temp": "Iced",
    "Topping: "Wipped Cream",
    "Year": 1840
}
```

..........................................................................................





## Setup/Installation Requirements

* Download or Clone project from Github repository.
* Open a terminal within NationlParks folder within the main project directory.
* Use command: 'dotnet restore' to install.
* After installation, type in 'dotnet build'.
* Use command 'dotnet ef database update' to scaffold the database for the project.
* Run the program with 'dotnet run' in the terminal.
* If you don't have it already, create an "appsettings.json" file in the "ben_stoller" directory and Insert the code below with your user name and password for   MySQL:



## Known Bugs



## Support and contact details

https://github.com/StollerSystem

## Technologies Used

C#/.NET, Entity Framework Core, MySql, Nswag, 

### License

*{Determine the license under which this application can be used.  See below for more details on licensing.}*

Copyright (c) 2016 **_{List of contributors or company name}_**

