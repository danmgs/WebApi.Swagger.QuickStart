# WEB API SWAGGER QUICKSTART [![Build Status](https://travis-ci.org/danmgs/WebApi.Swagger.QuickStart.svg?branch=master)](https://travis-ci.org/danmgs/WebApi.Swagger.QuickStart)

A RESTFUL .NET Core application that exposes web api endpoints by leveraging Swagger.

Use Postman client to test available web api endpoints:
<br />

## Available api endpoints


| Web Method   | API Endpoint URL              | Description                                                      | Example
| :----------: | ----------------------------- | ---------------------------------------------------------------- | -----------------------------
| GET          | /api/orders/                  | get all orders                                                   | /api/orders/
| GET          | /api/orders/id                | search an order given an id                                      | /api/orders/1

## How to run the web api :

Go to binaries directory, open windows cmd console and type :

```
dotnet WebApi.Swagger.QuickStart.dll
```

Then access webapi endpoints with urls : 
```
http://localhost:5000/swagger
http://localhost:5000/api/orders
http://localhost:5000/api/orders/1

```

![alt capture1](https://github.com/danmgs/WebApi.Swagger.QuickStart/blob/master/img/api_endpoints.PNG)

### Useful Links

#### Swagger

https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-2.1&tabs=visual-studio%2Cvisual-studio-xml