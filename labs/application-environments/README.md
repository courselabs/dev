

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


