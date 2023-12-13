First see that you have installed dotnet 8.0 sdk and runtime in your system- https://dotnet.microsoft.com/en-us/download/dotnet/8.0

To run the project , run this following commands in different terminals 
1. dotnet run  //the folder location should be InventoryService
2. dotnet run  //the folder location should be OrderService
3. dotnet run  //the folder location should be APIGateway
4. dotnet run  //the folder location should be BlazorInventoryOrderApp

====================================================================================
====================================================================================
To run the project in Kubernetes pods, use the following files in Misc folder:

# Navigate to your project directory
cd /path/to/your/project

# Build the Docker image
docker build -t your-image-name 

# Run the Docker container
docker run -p 8080:80 --name your-container-name your-image-name

needs to be performed for all the 4 projects - BlazorInventoryOrderApp, InventoryService, OrderService, SQLServer

once done, then with the help of Deployment.yaml file of each of the projects (different commands I have added in Readme file inside Misc Folder)
run the command 
kubectl apply -f your-deployment.yaml   