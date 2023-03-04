

## Test the web app locally

```
cd labs/continuous-deployment/src/HelloWorldWeb

dotnet restore

dotnet build
```

```
dotnet run --urls=http://localhost:5000/
```

> Browse to http://localhost:5000/

You'll see a simple page with the date and time. Refresh and the time will update - this is coming from the web server, which happens to be your local machine.

Code here:

- [](labs/continuous-deployment/src/HelloWorldWeb/Pages/Index.cshtml) - mix of HTML and C#

## Create free Azure account

https://azure.microsoft.com/en-gb/free/


- you'll need an email account you can access
- and a cell phone for verification
- you'll need a credit card **but you won't be charged**

When it's done click _Go to the Azure Portal_

From the icons in the top right, click the consolee icon:

![]console

This launches a terminal inside the browser called _Cloud Shell_. There are two confirmation screens:

- Select _Bash_ in the first
- Click _Create Storage_ in the second

Now we can use the command line to create a cloud service to run an application.

## Create the Azure resources

Copy and paste this into the cloud shell window:

```
az group create -n labs-cd -l eastus

az appservice plan create -g labs-cd -n app-plan-01 --is-linux --sku S1 --number-of-workers 2
```

This creates a service which can host a web application; it will take a while.

Now create the web application - you'll be asked to give it a name, which will become the URL so it needs to be unique - something like `labs-cd-` plus your initials.

**Replace `<app-name>` with your own app name**

```
az webapp create -g labs-cd --plan app-plan-01 --runtime dotnetcore:6.0 -n <app-name>
```

Now you can link your GitHub repo to the web application:

```
az webapp config appsettings set --settings PROJECT='/labs/continuous-deployment/src/HelloWorldWeb/HelloWorldWeb.csproj' -g labs-cd -n <app-name>
```

```
az webapp deployment source config -g labs-appservice-cicd --manual-integration --branch main -n <app-name> --repo-url <github-fork-url>
```

> You can always find your cloud service again from this link: [Azure App Services](https://portal.azure.com/#view/HubsExtension/BrowseResource/resourceType/Microsoft.Web%2Fsites)



