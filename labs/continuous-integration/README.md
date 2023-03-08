# Continuous Integration

The process of building code every time it is pushed to the shared Git repository is called _Continuous Integration (CI)_. It's an important healthcheck for the project, to make sure the application is in a good state. If the CI build is broken, that means the application can't run. It's a serious situation - the team needs to stop pushing any more changes until the build is fixed.

In this lab you'll set up a CI build in GitHub and see how it gives everyone clear visibility on the state of the code.

## Reference

- [What is Continuous Integration?](https://www.atlassian.com/continuous-delivery/continuous-integration) - Atlassian

- [Understanding GitHub Actions](https://docs.github.com/en/actions/learn-github-actions/understanding-github-actions) - GitHub

- [Continuous Integration and Continuous Delivery](https://app.pluralsight.com/library/courses/devops-foundations-continuous-integration-continuous-delivery/table-of-contents) - Pluralsight

## A small .NET application

We'll use a simple application for this lab, which just prints a few lines of text to the screen. It's written in C# so it needs the .NET runtime . 

There isn't much code, but the application also uses someone else's code in a _library package_. Most languages have the ability to bring in other code so developers don't have to write everything from scratch - often these are [open-source](https://www.freecodecamp.org/news/what-is-open-source-software-explained-in-plain-english/) libraries which are in public GitHub repos.

To run the program we need .NET installed and we need to download the library package.

Open the VS Code terminal:

```
# switch to the folder with the code in it:
cd labs/continuous-integration/src/HelloWorld

# run this to download library packages:
dotnet restore --packages pkg
```
 
In the VS Code Explorer window you'll see there's a new folder called `labs/continuous-integration/src/HelloWorld/pkg` with lots of stuff in it. This is the third party library which is publicly available to use for free, and now you have a copy which the application can use.

```
# this compiles the application
dotnet build
```

More new folders in `labs/continuous-integration/src/HelloWorld` :) The actual _binary_ which contains the compiled code is in the folder `bin/Debug/net6.0/HelloWorld.exe`

```
# this is an easy way to try the app:
dotnet run
```

This workflow is very similar in all applications - most languages follow the same pattern:

- download libraries
- build the source code
- run the app to test it

## The build pipeline

We want that build workflow to run every time a change is pushed to the SCM server, so we know that change works and hasn't broken anything. There are lots of CI systems which can do that, and GitHub has it's own CI engine (called GitHub Actions) you can use for free.

Every system has it's own way of describing the build process you want ot run, this is how to do it in GitHub:

- [dotnet-hello-world-build.yaml](/.github/workflows/dotnet-hello-world-build.yaml) - the GitHub Actions workflow

This is written in YAML (Yet Another Markup Language) which is a common format for modelling processes and configuration.

If you scan through it you'll see some things which are familiar from the build we just ran on our machines:

- the _working directory_ sets the folder where the commands will run (like we ran the `cd` command)
- there are the same `dotnet` commands - restore, build and run

This process won't run on your machine though, it runs in a temporary environment owned by GitHub, hosted on their own servers.

You created a fork of the lab repo in [branching & merging](/labs/branching-merging/README.md). Open your fork in the browser - `https://github.com/<your-github-id>/dev`

Browse to the Actions tab. You'll see a message like this:

![](/img/continuous-integration/enable-workflows.png)

Click the big green button to enable Actions, and in the next screen select the one called _.NET Hello World build_ from the list on the left. Builds are part of a repo. There may be lots of builds in the original `courselabs` repo, but you've only just enabled them in your fork so you won't have any builds:

![](/img/continuous-integration/no-builds-yet.png)


## Running the build

This build pipeline is triggered when you push changes. We'll push a change and see what happens:

```
# make sure you have the latest version of the code
git checkout main

git pull
```

Now open the file [labs/continuous-integration/src/HelloWorld/Program.cs](/labs/continuous-integration/src/HelloWorld/Program.cs) and make a small change so it prints something else instead of "Hello  World!" (you can safely change anything inside the quote marks on line 9).

You can run `dotnet run` to test your changes.

Now commit and push your update to your own fork on GitHub:

```
git add --all

git commit -m 'Updated app message'

git push fork main
```

Open the Actions page again in GitHub, refresh and you should see the build running:

![](/img/continuous-integration/new-build.png)

You can click on the running workflow to see the progress. Then click the _build_ box and you can see the output of each stage of the build - expand some of the boxes and the logs should look familiar from when you built the app in VS Code.

The build should complete successfully and show a green tick. This is good. The CI build should always be green.

## Lab

There's another feature in this app, try running this in your VS Code terminal:

```
dotnet run 23
```

Can you see from the code what is happening when you add the `23` to the run command?

Open [labs/continuous-integration/src/HelloWorld/Program.cs](/labs/continuous-integration/src/HelloWorld/Program.cs) and make a change:

- find line 13
- find where it says `args[0]`
- replace that with `args[1]`

Don't worry about the details, but this change means the app builds OK but will fail when you run it.

Run `dotnet run 23` again and you'll see an error. You push the change to your GitHub fork (with the `git add` ... `git commit` ... `git push` commands you ran earlier). The action will run again in GitHub - does the build fail this time?
