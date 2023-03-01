
Open the terminal in VS Code (menu _Terminal...New Terminal_)

```
cd ~

ls
```

> This is your home directory; the listing will show Documents etc.


## Clone a GitHub repo

Check the repo on GitHub: https://github.com/courselabs/dev.git

Browse around:

- click on _Commits_
- open a commit - you can see the changes that were made
- every commit has a unique id (like [0395e03490acc0a180191dc9ce83bcde5f4ba755](https://github.com/courselabs/dev/commit/0395e03490acc0a180191dc9ce83bcde5f4ba755)) - but you can refer to them by a short version (0395e03)

There are also _Issues_

- this is a public repo so anyone can add an issue
- add one if you like :)

You can download a copy of the repo by **cloning** it. That downloads the current contents and all the history onto your machine.

Run this in the terminal window:

```
git clone https://github.com/courselabs/dev.git
```

Open the folder in VS Code (_File..Open Folder_ then browse to Documents and the folder dev). You can see all the contents in the folder view. 

Open a file and it will load - click on the _TImeline_ view in the bottom-left window:

- you can see the history of the file
- including commits made in the git repo
- click on one entry and you can see what changed 

## Create a new Git repo


Create a new folder for this lab:

```
mkdir -p Documents/new-project

cd Documents/new-project
```

Write some text in the file:

```
echo 'first line' > readme.txt
```

In the terminal you can read the file with a command:

```
cat readme.txt
```

And add some more text with another command:

```
echo 'second line' >> readme.txt
```

Open the file again - the new text is there, but you can't see when it got added or by whom.


```
git init

git status
```

```
git add --all

git commit -m ' My first git commit! Go me!'
```

Now Git is tracking all changes for you. Try adding some more text:


```
echo 'third line' >> readme.txt
```

```
git status
```

Open the new-project folder in VS Code:

- File...New Window
- _Open Folder_
- Browse to Documents then select new-project

Find the text file. Then switch to _View...Source Control_. Open the file again - what do you see?



## Lab

Back in your own new-project window:

- add a new file & commit changes
- delete the original file & commit changes
- list all the commits with `git log`
- can you roll back to the very first commit?


