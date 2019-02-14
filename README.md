# WEB API SWAGGER QUICKSTART [![Build Status](https://travis-ci.org/danmgs/WebApi.Swagger.QuickStart.svg?branch=master)](https://travis-ci.org/danmgs/WebApi.Swagger.QuickStart)

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

![alt api_endpoints](https://github.com/danmgs/WebApi.Swagger.QuickStart/blob/master/img/api_endpoints.PNG)

## Docker Image

A Docker image of this project is available on Docker hub [here](https://hub.docker.com/r/danmgs/webapiswaggerquickstart).

Pull and run image by specifying a port mapping (8080 to reach 80 for example).
```
docker pull danmgs/webapiswaggerquickstart
docker run -p 8080:80 danmgs/webapiswaggerquickstart
```

And access to the swagger API GUI with url :

http://localhost:8080/swagger/index.html

## Kubernetes with minikube

-> Start minikube then apply k8s configuration, from solution root path :

```
kubectl apply -f .\k8s
```
This will create k8s namespace/deployments/services for our docker image to run under Kubernetes.

The image used in configuration is **danmgs/webapiswaggerquickstart:linux-x64**.

-> Check deployments of k8s config under WEB dashboard by typing command :

```
minikube dashboard
```

-> Also, you can check status of deployments/pod/services which was created under namespace by typing command
```
kubectl get all --namespace=swaggerapp
```

![alt k8s_dashboard_overview](https://github.com/danmgs/WebApi.Swagger.QuickStart/blob/master/img/k8s_dashboard_overview.PNG)

-> Browse with url to access the webapi :

```
http:\\< minikube ip >:31516\swagger
```
where
* **31516** is the specified service nodePort 
* **< minikube ip >** is determined by typing command:

```
minikube ip
```


#### Customized configuration

In the file **swagger-api-deployment.yaml**, you can overrides default port (80) exposed by the running container. Configure env variables like so :
```
    spec:
      containers:
      - name: swagger-api-cont
        image: danmgs/webapiswaggerquickstart:linux-x64
        env:
          - name: ASPNETCORE_URLS        
            value: http://+:8080   
```
Under the minikube dashboard, in the pod log, you will then see the port listening:

![alt k8s_dashboard_pod_logs](https://github.com/danmgs/WebApi.Swagger.QuickStart/blob/master/img/k8s_dashboard_pod_logs.PNG)


## Useful Links

### Swagger

https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-2.1&tabs=visual-studio%2Cvisual-studio-xml