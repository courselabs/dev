
Open the terminal in VS Code (menu _Terminal...New Terminal_)

```
cd ~

ls
```

> This is your home directory; the listing will show Documents etc.


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

- add a new file & commit changes
- delete the original file & commit changes
- list all the commits with `git log`
- can you roll back to the very first commit?


