
There's a lot to do here. Developers often need to pick up something that's new to them - new tools, new languages, new services. This will give you a feel for that and it will show you what Continuous Deployment looks like.

Don't worry if you don't get through all the steps - we'll walk through it together.


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

You'll see a simple page with the date and time. Refresh and the time will update - this is coming from the web server, which happens to be your local machine:

![](web-local)

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
az webapp config appsettings set --settings PROJECT='labs/continuous-deployment/src/HelloWorldWeb/HelloWorldWeb.csproj' -g labs-cd -n <app-name>
```

```
az webapp deployment source config -g labs-appservice-cicd --manual-integration --branch main -n <app-name> --repo-url <github-fork-url>.git
```

_az webapp deployment source config -g labs-cd --manual-integration --branch main -n labs-cd-es --repo-url https://github.com/sixeyed/dev.git_


The build will take a while. This is a different approch where the cloud service takes the source code and it knows how to build and deploy it. You don't need to manage a workflow in this case.

> You can always find your cloud service again from this link: [Azure App Services](https://portal.azure.com/#view/HubsExtension/BrowseResource/resourceType/Microsoft.Web%2Fsites)

Open your App Service in the Overview section there's a default domain which shows your web app name: 

![](app-service)

That's a link - when you click it, you'll open your web application, running in the cloud :)

## Lab

How was that? Lots of new things here - the cloud services, the command line tool to work with the cloud services, and the whole continuous deployment. It's not really continuous though... Make a change to the web page at:

- [labs/continuous-deployment/src/HelloWorldWeb/Pages/Index.cshtml](labs/continuous-deployment/src/HelloWorldWeb/Pages/Index.cshtml)

Any change will do. Then push your changes to your fork:

```
git add --all

git commit -m 'Updated CD lab web app'

git push fork main
```

You'll need to manually start a new deployment from the Azure Portal. Can you trigger that and see your changes get deployed to the live site?