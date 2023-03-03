

## A Small .NET Application

- [Program file](labs\continuous-integration\src\HelloWorld\Program.cs)

Simple program which uses the .NET runtime, and has a dependency on a third-party package called Humanizer.

Open the VS Code terminal:

```
# switch to the folder with the code in it:
cd labs\continuous-integration\src\HelloWorld

# restore downloads all the dependencies:
dotnet restore --packages pkg
```
 
You'll see there's a new folder called `pkg` with lots of stuff in it. This is someone else's code which is publicly available to use, and now I have a copy which my code can use.

```
# build compiles the application
dotnet build
```

More new folders :) The actual _binary_ which contains the compiled code is in labs\continuous-integration\src\HelloWorld\bin\Debug\net6.0\HelloWorld.exe

```
# this is an easy way to try the app:
dotnet run
```


## The Build Pipeline


- [build script](.github\workflows\dotnet-hello-world-build.yaml)

This is written in YAML (Yet Another Markup Language) which is a common format for modelling processes and configuration.

If you scan through it you'll see some things which are familiar from the build we just ran on our machines:

- the _working directory_ sets the folder where the commands will run
- there are the same `dotnet` commands - restore, build and run

This process doesn't run on your machine though, it runs on GitHub using their own machines.

Open your fork of the repo - https://github.com/<your-github-id>/dev

Browse to the Actions tab, you'll see a warning like this:

![](TODO)

Click the big green button to enable Actions, and select the one called _.NET Hello World build_. There are no builds yet.


## Running the build

This pipeline is triggered when you push changes. We'll make a small change and see what happens:

```
# make sure you have the latest version of the code
git checkout main
git pull
```

Now open the file [labs\continuous-integration\src\HelloWorld\Program.cs](labs\continuous-integration\src\HelloWorld\Program.cs) and make a small change so it prints something else instead of "Hello  World!".

You can run `dotnet run` to test your changes.

Now commit and push your update:

```
git add --all

git commit -m 'Updated app message'

git push fork main
```

Open the Actions page again in GitHub and you should see the build running.

