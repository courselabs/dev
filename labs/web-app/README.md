# A Web Application

Static websites just show the same content to everybody. Dynamic web applications let users do things, and that usually means saving data in a database. Node.js is a popular runtime for web applications and it has lots of support for databases - we'll be using a simple one called Sqlite.

In this lab you'll use source code in the class materials to run a Node.js app and see how the process works.  

## Reference

- [Overview of Node.js](https://nodejs.org/en/about/) - Node.js organization

- [Node.js tutorial](https://www.w3schools.com/nodejs/) - W3 Schools

- [Node.js: The Big Picture](https://app.pluralsight.com/library/courses/nodejs-big-picture/table-of-contents) - Pluralsight

## Explore the code

VS Code is a great tool for developers - it lets you open and edit files, and it also has a terminal window so you can run commands without swapping between applications.

Open the course materials folder in VS Code:

- launch Code
- click _File...Open Folder_
- browse to the download (it will be in _Documents...dev_) if you followed the setup instructions

On the left is the Explorer window which shows you all the files. Click through to open a few files:

- [/labs/web-app/src/index.html](/labs/web-app/src/index.html) - this is the main HTML page for the webite; there's a lot of stuff in here, but it's just the layout of the page. You'll see a reference to _app.js_ - that's where the real work happens

- [/labs/web-app/src/app.js](/labs/web-app/src/app.js) - whoa! This looks like real code! It's in a language called JavaScript. Don't worry about trying to understand it, but you can see that it is very clearly structured and there are some bits which are in plain English.

## Run the app

Plain HTML pages can be opened in the browser, they don't need a separate runtime. This app does need a runtime, which is Node.js. It is the web _server_ you will contact with your browser, which is the _client_:

- it sits and waits for connections from the client
- when it receives a web request it processes it
- which may mean reading or writing data
- and then it sends back the response

All that logic runs on the server - it's the _backend_ of the app. The Node.js app needs to be running the whole time to process any client requests which come in.

Open a terminal window. In VS Code use the menu _Terminal...New terminal_. Run these commands to browse to the application source code folder and list the contents:

```
cd labs/web-app/src/

ls
```

> You should see a list of folders and files, including _index.html_ and _app.js_. If not, you need to make sure you're in the right directory.


Use the Node.js tools to build and run the application:

```
npm install

node server.js
```

You'll see lots of lines of text - these are _logs_ which the application writes so you can see what it's doing. 

In amongst the logs you should see the line `** Server listening on port 8080 **` which means the app is ready and waiting for clients to connect.

## Try the app

Leave the application running in the terminal and try browsing to it at [http://localhost:8080](http://localhost:8080).

- `http` means this is a website address which is not encrypted (encryption uses `https`)
- `localhost` is the address of your local machine
- `8080` is the port, which is the specific network connection the server is listening on

If everything goes well you should see this:

![Local web app running in Node.js](/img/web-app/localhost.png)

Try adding and removing events, you'll see them listed in the page when you make any changes.

Back in the terminal window in VS Code you'll see lots more logs. These are all details developers have decided to record to help them see what's happening and track down any problems.

Stop the application in the terminal by hitting _Ctrl-C_. The Node.js runtime exits and there is no application listening for connections now:

- refresh the browser - what happens?
- start the app again, is the data you added still there?

## Lab

Developers often get thrown into an application that's new to them and asked to make some changes. Sometimes it's easy to find your way through a new app and sometimes it's harder (big apps easily have millions of lines of code). 

Find the file in the `labs/web-app/src` folder which prints the text "Welcome to the Event Calendar!" on the web page. Change the text to say something else. Refresh your browser - does it pick up the changes or do you need to stop and start the application again to see them?

Developers also need to understand all the components of the application. This app uses a database to permanently store data - which is why any events you added are still there when you restart the app.

Can you find where the data is actually stored? What happens if you delete the database file and restart the app?