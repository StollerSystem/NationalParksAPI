# _National Parks API_

#### _An API app for state and national parks, 10/30/20_

#### By _**Ben Stoller**_

## Description

An API application that lets a user access a database of national and state parks. 
Once you have obtained a bearer token (see below), you can add search parameters to narrow down your query, add (POST) new entries, edit (PUT) entries and delete them. 


## API Documentation 

### Using Swagger Documentation 
To explore the National Parks API utilizing Nswag, start the project with "dotnet run" (see Setup/Installation below) and navigate to the following URL in your browser: "http://localhost:5000/swagger"

### Using the JSON Web Token (JWT)
In order to be authorized to use the POST, PUT, DELETE functionality of the API, you will need to authenticate yourself through Postman.
* Open Postman and create a POST request using the URL: `http://localhost:5000/api/users/authenticate`
* Add the following to the request as JSON raw data in the Body tab:
```
{
    "Username": "ParksAdmin",
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
GET /api/{component}/search
GET /api/{component}/random
GET /api/{component}/{id}
POST /api/{component}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}

```

#### Example Query
```
https://localhost:5000/api/nationalparks/2
```

..........................................................................................

### National Parks
Access information on national parks in the USA.

#### HTTP Request
```
GET /api/nationalparks
GET /api/nationalparks/search
GET /api/nationalparks/random
GET /api/nationalparks/{id}
POST /api/nationalparks
PUT /api/nationalparks/{id}
DELETE /api/nationalparks/{id}

```

#### Parameters for /api/nationalparks/search 
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches that contain name.
| location | string | none | false | Return matches that contain location. |
| date | string | none | false | Return matches that contain date established. |



#### Example Query
```
http://localhost:5000/api/nationalparks/search/?name=yellowstone
```

#### Sample JSON Response
```
 {
      "nationalParkId": 1,
      "nationalParkName": "YellowStone",
      "nationalParkDescription": "test",
      "nationalParkLocation": "Wyoming, Montana, Idaha",
      "dateEstablished": "March 1, 1872",
      "nationalParkArea": 2219790.71,
      "annualVisitors": 4020288
}
```
#### Random Endpoint
```
http://localhost:5000/api/nationalparks/random
```
Returns a random national park from the database.

..........................................................................................

### State Parks
Access information about state parks.

#### HTTP Request
```
GET /api/stateparks
GET /api/stateparks/search
GET /api/stateparks/yearround
GET /api/stateparks/random
GET /api/stateparks/{id}
POST /api/stateparks
PUT /api/stateparks/{id}
DELETE /api/stateparks/{id}

```
### YearRound Endpoint

Will only return state parks that are open year round.

####  Parameters for /api/stateparks/yearround
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches that contain name.
| state | string | none | false | Return matches that contain state. |


#### Example Query
```
http://localhost:5000/api/stateparks/yearround/?state=oregon
```
### Search EndPoint

####  Parameters for /api/stateparks/search
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches that contain name.
| state | string | none | false | Return matches that contain state. |


#### Example Query
```
http://localhost:5000/api/stateparks/search/?state=oregon
```

#### Sample JSON Response
```
{
      "stateParkId": 1,
      "stateParkName": "Goose Lake",
      "stateParkDescription": "test",
      "state": "Oregon",
      "dateEstablished": null
}
```
#### Random Endpoint
```
http://localhost:5000/api/stateparks/random
```
Returns a random state park from the database.

..........................................................................................





## Setup/Installation Requirements

* Download or Clone project from Github repository.
* Open a terminal within NationlParks folder within the main project directory.
* Use command: 'dotnet restore' to install.
* After installation, type in 'dotnet build'.
* Use command 'dotnet ef database update' to scaffold the database for the project.
* Run the program with 'dotnet run' in the terminal.
* If you don't have it already, create an "appsettings.json" file in the "NationalParks" directory and Insert the code below with your user name and password for   MySQL:
```
{
  "AppSettings": {
    "Secret": "THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=ben_stoller_npapi;uid=root;pwd=epicodus;"
  }
}
```

## Known Bugs

None atm

## Support and contact details

https://github.com/StollerSystem

## Technologies Used

C#/.NET, Entity Framework Core, MySql, Nswag, Postman

### License

MIT

Copyright (c) 2020 **Ben Stoller**

