
Open the terminal in VS Code:

```
cd ~

ls
```

> This is your home directory; we'll create a new folder for this lab:

```
mkdir new-project

cd new-project

notepad ./readme.txt
```

This will open Notepad with a message about creating a new file - click _OK_

Write some text in the file:

```
version 1
text
```

And save it.

In the terminal you can read the file with a command:

```
cat readme.txt
```

And add some more text with another command:

```
echo ' extra' >> readme.txt
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
echo ' even more' >> readme.txt
```

```
git status
```

Open the new-project folder in VS Code:

- File...New Window
- _Open Folder_
- 


