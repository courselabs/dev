# Sharing code with Git and GitHub

Git is the most popular Source Code Management (SCM) system. It takes a bit of getting used to, but once you know a few commands it is fast and powerful. Developers each have their own copy of the application code, and they share it through a central place - GitHub is the choice for lots of teams.

In this lab you'll get started with some Git commands and see how to interact with GitHub.

## Reference

- [Git home page](https://git-scm.com) - docs and free book

- [Git tutorial](https://www.w3schools.com/git/default.asp) - W3 Schools

- [Git: The Big Picture](https://app.pluralsight.com/library/courses/git-big-picture/table-of-contents) - Pluralsight

## Create some content

We'll start with a blank slate. Open a terminal window (you can use VS Code or a separate PowerShell window for this). 

Developers often use the command line instead of windows, because it's usually much quicker and it's easy to repeat something you've done before. Tools like Git are built for the command line.

Create a new folder for our content:

```
mkdir -p ~/Documents/new-project

cd ~/Documents/new-project
```

Write some text in a new file:

```
echo 'first line' > readme.txt
```

In the terminal you can read the file with this command:

```
cat readme.txt
```

> You can open Windows Explorer or the Mac Finder and browse to your Documents folder. You'll see the text file in there which you can open with Notepad or TextEdit. The command line is just another way to work with your machine.

And add some more text with another command:

```
echo 'second line' >> readme.txt
```

Look at the file again - the new text is there, but you can't see when it got added or by whom. Normal file systems are not _versioned_ so there's just the current copy of the file and you can't go back to see previous versions.

## Turn the folder into a Git repo

A Git **repository** (or "repo") is a folder of content with a database which does record all the versions of all the files. You can turn any folder into a Git repo by initialising the database with a Git command:

```
git init
```

The output says you have a new empty repository. Git can tell you if there are changes in the folder which haven't been saved in the database:

```
git status
```

You'll see your text file is listed as _untracked_. This means it hasn't been saved in Git. Changes aren't automatically saved, you need to explicitly tell Git when you want to do that.

Git is all about recording the history of changes, so it needs to know who you are. If this is the first time you've used Git on your machine, you need to set a user name and email address - you can just use fake entries for now:

```
git config --global user.name "username"
git config --global user.email email@domain.com
```

To save changes first you _add_ all the changed files:

```
git add --all
```

Then you _commit_ your changes, which saves them to the database with a timestamp and the message you add:

```
git commit -m 'My first git commit! Go me!'
```

Now Git can track changes for you. Try adding some more text:

```
echo 'third line' >> readme.txt
```

The file is different from the version you saved in the last commit, and Git knows that:

```
git status
```

Git is such a popular tool that lots of other apps can work with it. VS Code has very good Git support. Open a new VS Code window and load your repo:

- in Code click _File...New Window_
- in the new window click _File...Open Folder_
- then browse to _Documents_ and select the _new-project_ folder

You can see the text file listed, and you can look at the contents. 

Now click on _View...Source Control_. Open the file again - what do you see?

## Cloning a GitHub repo


Local Git repos are for work in progress. You share your completed work by pushing commits to a Git server - and you download work from the rest of the team by pulling their commits from the same Git server.

GitHub is a great place to share code. It's a standard Git server you can push and pull with and it also has a very rich web UI. Have a look at the repo for the source materials in your browser at https://github.com/courselabs/dev.git - it will look like this:

![GitHub repo for the class materials](/img/git-github/class-repo.png)

Browse around:

- click on _commits_
- open a commit - you can see the changes that were made
- every commit has a unique id (like [0395e03490acc0a180191dc9ce83bcde5f4ba755](https://github.com/courselabs/dev/commit/0395e03490acc0a180191dc9ce83bcde5f4ba755)) - but you can refer to them by a short version (0395e03)

There are also _Issues_ which you can use to track problems or suggestions:

- this is a public repo so anyone can add an issue
- but you need to create a GitHub account to add one :)

You can download a copy of the repo by **cloning** it. That downloads the current contents and all the history onto your machine.

This is what you did right at the beginning in the setup instructions:

```
# you don't need to do this again :)
git clone https://github.com/courselabs/dev.git
```

Open the VS Code window where you have the course materials loaded. Open any file from the explorer and you'll see the current contents. Click on the _Timeline_ view in the bottom-left window and you can see what Git knows about the file:

- the history of the file's changes
- including commits made in the git repo
- click on one entry and you can see what changed 

## Lab

Back in your own _new-project_ window, try some more change tracking with Git:

- create a new file called _readme2.txt_, then add and commit the changes
- delete the original file _readme.txt_, then add and commit the changes
- list all the commits with `git log`
- can you load the very first commit, so you see the original _readme.txt_ file?
- what has happened to the new _readme2.txt_ file?