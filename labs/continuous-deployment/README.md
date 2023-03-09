# Continuous Deployment

There's a lot to do here. Developers often need to pick up something that's new to them - new tools, new languages, new services. This will give you a feel for that and it will show you what Continuous Deployment looks like. Don't worry if you don't get through all the steps - we'll walk through it together.

In this lab we'll create a service in the cloud to run a web application, and set up Continuous Deployment to releases updates to the app in an automated way.

---
**This lab is optional - you need a credit card to sign up to the cloud. You won't be charged, but if you'd prefer not to follow along it's fine, you can watch me instead.** 

---

## Test the web app locally

We'll start by running the web app on your dev machine so you can see how it looks.

Open a terminal window in VS Code and run these commands to build the application:

```
cd labs/continuous-deployment/src/HelloWorldWeb

dotnet restore

dotnet build
```

These are the same commands we used in the [Continuous Integration lab](/labs/continuous-integration/README.md) but this is a different application. It's a .NET app so we use the same commands to work with it, but this is a web application.

Run this to start the web app:

```
dotnet run --urls=http://localhost:5000/
```

You'll see some logs in the terminal, and you won't be able to enter any more commands. The app is listening for network connections.

> Check out the app by browsing to http://localhost:5000/

You'll see a simple page with the date and time. Refresh and the time will update - this is coming from the web server, which happens to be your local development environment:

![](/img/continuous-deployment/web-local.png)

Like most web apps, this uses a mixture of technologies - in this case some HTML and some C#. If you're interested in the code, this is how that page is written:

- [Index.cshtml](/labs/continuous-deployment/src/HelloWorldWeb/Pages/Index.cshtml) - the angle-brackets is the HTML and the @-sign is the C#

Some applications are too big and complex to run on a developer's machine, so they may only be able to run part of it. Larger apps are broken into components, so the dev may only run a few of the components locally.

Now we know how it looks, we can go and deploy it to the cloud!

You can end the web server in the terminal with `Ctrl-C`.

## Create free Azure account

Cloud computing just means renting computers and storage. You never actually see the hardware - that's in secret datacentres with thousands and thousands of machines. Instead you work with cloud services using tools from the provider.

There are three main clouds (in this order of popularity):

- Amazon Web Services (AWS)
- Microsoft Azure
- Google Cloud

We'll use Azure because it's one of the easier services to start with, and it integrates nicely with GitHub to deploy your code.

Sign up for a free Azure account here: https://azure.microsoft.com/en-gb/free/

- you'll need an email account you can access
- and a cell phone for verification
- you'll also need a credit card **but you won't be charged**

When the sign up process is done click _Go to the Azure Portal_ or follow this link: https://portal.azure.com

From the icons in the top right, click the console icon (which looks a bir like `>_` ):

![](/img/continuous-deployment/azure-shell-icon.png)

This launches a terminal inside the browser called _Cloud Shell_. It's just like using the terminal in VS Code, except it's running inside a cloud environment which has a few more tools installed.

There are two confirmation screens:

- Select _PowerShell_ in the first
- Click _Create Storage_ in the second

Now the bottom of the Portal window will have the terminal session:

![](/img/continuous-deployment/azure-shell.png)

You can use the terminal in Azure to create a cloud service which will run the web application.

## Create the Azure resources

Copy and paste this into the cloud shell window:

```
az group create -n labs-cd -l eastus

az appservice plan create -g labs-cd -n app-plan-01 --is-linux --sku S1 --number-of-workers 2
```

This creates a service to host a web application; it will take a while.

Now create the web application - you'll be asked to give it a name, which will become the URL so it needs to be unique - something like `labs-cd-` plus your initials.

```
# make sure you use an app name of your own
az webapp create -g labs-cd --plan app-plan-01 --runtime dotnetcore:6.0 -n your-own-unique-app-name
```

> If you choose a name which has been taken by someone else in the world, you'll see an error message. Just try the command again with a different name.

When the app service is created you can link your GitHub repo to the web application. There are a couple more commands to do that. 

First this will tell the app service where to find the project source code (like when we run `cd` commands locally):

```
az webapp config appsettings set --settings PROJECT='labs/continuous-deployment/src/HelloWorldWeb/HelloWorldWeb.csproj' -g labs-cd -n your-own-unique-app-name
```

And now this will link the app to the GitHub repo for the class. Make sure you use your own app name, and the URL to your own GitHub fork - so you can push changes later and see the deployment working:

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