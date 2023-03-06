# Dev Setup

There are some tools you'll need installed to work along with the practical sessions.

If you have a lab environment provided for you then it will be already configured, but you should check that everything is installed.

We'll be looking at some apps written in [Node.js](https://nodejs.org/en/) and [.NET](https://dotnet.microsoft.com/en-us/download).

We'll also use [Git](https://git-scm.com) to download the lab content, so you'll need a client on your machine to talk to GitHub.


## Node.js

Open a command line (on Windows click the Windows icon and search for _PowerShell_). Then type (or copy and paste):

```
node --version
```

You should see something like this in the output:

```
v18.14.2
```

The exact version doesn't matter, but if you see an error you need to [install NodeJS](https://nodejs.org/en/).

## .NET 6

In your command line enter:

```
dotnet --list-sdks
```
You should see something like this in the output:

```
6.0.201 [C:\Program Files\dotnet\sdk]
```

The version and location doesn't matter, but if you see an error you need to [install .NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download).

## Git


In your command line enter:

```
git --version
```
You should see something like this in the output:

```
git version 2.31.1.windows.1
```

The version doesn't matter, but if you see an error you need to [install Git](https://git-scm.com/downloads).


## Download the course materials

We'll explain all about Git during the course. For now we need to download all the course materials so you can work through them.

In your terminal enter these commands:

```
cd ~/Documents

git clone https://github.com/courselabs/dev
```

This will _clone_ the content, downloading a copy you can use into your _Documents_ folder, in a subfolder called _dev_.

When the command completes, check you have everything:

```
cd dev

ls
```

You should see a list of files and folders including names like _labs_ and _setup_.

> Now you're good to go 🚀