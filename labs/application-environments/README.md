

## Pre-reqs

CD lab

## Create a deployment slot

Open the list of app services:

- https://portal.azure.com/#view/HubsExtension/BrowseResource/resourceType/Microsoft.Web%2Fsites

Browse to your web app.

Click _Deployment slots_ from the left nav.

You'll see one slot which is your production app. This is deployed from the _main_ branch.

Add a new slot:

- name _staging_
- clone settings - select your original web app from the list
- click _Add_

This effectively creates a copy of your app, which can be deployed from a different branch.

A _staging_ environment is one where changes are published so they can be checked before you go live.

Click on the staging slot name, and the Azure UI will load the configuration for that slot.

> Each slot has a different URL, and it can run a different version or a different setup of the app

Open the URL for the staging slot. There's nothing there :) New slots start empty, they would usually be deployed from a different branch.

## Deploy to the staging slot

Open the _Deployment center_ link from the left menu. For your staging slot it should show you there is no source configured:

![](staging deployment)

Set up the staging slot so it deploys the same code as the main app:

- Choose _External git_ as the source
- Enter your GitHub repository URL (https://github.com/<your-github-id>/dev.git)
- Set the branch to be `main`
- Click _Save_

The deployment will start. Under the _Logs_ view you can check the status.

It will take a while, but when the app is deployed you can browse to the the URL for your staging slot  - it looks the same as the main application :) 


## Change the app configuration

We can change the config for the staging slot to show how it can be different from the production slot.

Open the App Service page for the staging slot in the Azure Portal, click the _Configuration_ item from the left menu bar.

Most apps have dozens of configuration settings. This one has none at the moment.

Click on the _New application setting_ link and add a new item:

- Name: `EnvironmentName`
- Value: `staging`
- Deployment slot setting: checked

It should look like this:

![](slot config)

**Click _Save_**. The UI will ask you to confirm, and then it will restart the app in the staging slot.

Browse to your staging slot deployment again (you can find the link on the _Overview_ page, listed under _Default domain_.

Once the deployment has finished, it should look like this:

![staging]

## Lab

Apps typically have multiple environments - you'll probably test new features using one environment, and check bug fixes in another.

See what the app does if you use a different value for the `EnvironmentName` config setting. You could create another slot for that (you'd need to configure the _External git_ deployment settings again), or just change the value in the staging slot.
