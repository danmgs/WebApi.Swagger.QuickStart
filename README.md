# WEB API SWAGGER QUICKSTART (2018)

A RESTFUL .NET Core application that exposes web api endpoints by leveraging Swagger.

Use Postman client to test available web api endpoints:
<br />

## Available api endpoints


| Web Method   | API Endpoint URL              | Description                                                      | Example
| :----------: | ----------------------------- | ---------------------------------------------------------------- | -----------------------------
| GET          | /api/orders/                  | get all orders                                                   | /api/orders/
| GET          | /api/orders/id                | search an order given an id                                      | /api/orders/1
| POST         | /api/orders                   | add a new order to storage                                       | /api/orders with order parameters
| PUT          | /api/orders                   | modify an existing order in storage                              | /api/orders with order parameters
| DELETE       | /api/orders/id                | delete an existing order with given id                           | /api/order/1

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