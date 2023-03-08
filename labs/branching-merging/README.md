# Branching and Merging

Branching is how developers can work on different features in the same codebase without interfering with each other. Applications usually have a _main_ branch which is used for releases, and developers create _feature branches_ for work-in-progress. Branches can be stored on remote servers (like GitHub), but the work won't be released until the branch is _merged_ into the main branch.

In this lab you'll create your own copy of the project repo in GitHub, which you can use to try branching and merging

## Reference

- [Basic branching and merging in Git](https://git-scm.com/book/en/v2/Git-Branching-Basic-Branching-and-Merging)

- [GitHub Flow](https://guides.github.com/introduction/flow/https://guides.github.com/introduction/flow/) - a simple branching model

- [git-flow](https://nvie.com/posts/a-successful-git-branching-model/) - a branching model for complex  projects

## Forking a repository

You can make changes to a local repo but you can only push those changes to GitHub if you have permission. You don't have permission to push to the `courselabs/dev` repo, but you can create your own copy of that repository in GitHub.

You'll need a GitHub account - if you don't have one, sign up at:

- https://github.com/signup

When you have registered and then signed in with your account, you can fork the class repo - this means taking a copy of it into your own account:

- https://github.com/courselabs/dev/fork

Leave all the default values and click _Create Fork_:

![](/img/branching-merging/create-fork.png)

> Make a note of the URL of your fork in the browser window, it will contain your GitHub username. 

My username is `sixeyed` so my fork URL is: `https://github.com/sixeyed/dev`. **Yours will be different**.

Open the project repo in VS Code and then launch a terminal. Git understands there may be more than one server to use for pushing and pulling changes - it calls them _remotes_. You can add your forked copy of the project as a remote - this tells Git there is a new location where you can push changes:

```
cd ~/Documents/dev

# make sure you use your real URL from the GitHub window!
git remote add fork your-github-fork-url
```

## Pushing changes

Make a change to a file or create a new file - anything will do - and commit the change. You can commit changes in VS Code using the _View...Source Code_ window, or in the terminal:

```
git add --all

git commit -m 'Made some changes'
```

The changes are saved in your local copy of the repo on your machine. That isn't automatically synced to GitHub, so if your machine died your changes would be lost.

Try pushing to the _origin_ - which is the original copy of the code in the `courselabs/dev` repo:

```
# this will pop up a window asking you to authenticate:
git push origin main
```

> Even after you autheticatie, you'll get an error saying `Permission to courselabs/dev.git denied`. That's because your account doesn't have access to write to the courselabs repo.

But you have your own fork which you do have permissions for, so you can push to that:

```
git push fork main
```

Now your changes are stored in GitHub so they could be available [forever](https://archiveprogram.github.com/arctic-vault/) :)

Open your fork again in the browser and refresh the page. You'll see a banner saying _This branch is 1 commit ahead of courselabs:main_. That means GitHub know there are changes in your fork which have happened since you created the copy.

Your fork is a separate repo, but GitHub knows it is linked to the original repo, and there are options to send your changes back to the source - with an approval step so the owner can decide if they want to take them.

## Branching

In a team project you'll all be sharing code in the same repo, but you need to make sure your changes are isolated. Often developers create a _branch_ for every item they work on. A branch is lightweight copy of the code, which can be shared without affecting the main codebase.

Using the terminal window. you can create a new branch with the Git command line:

```
git checkout -b my-new-feature
```

List your branches:

```
git branch
```

> `main` is the original branch and that could be the source used to build and deploy the app

Make some changes to the repo - add or delete files, edit text, remove whole folders - and then commit them:

```
git add --all

git commit -m 'Some changes in my branch'
```

Check the history of your repo:

```
git log -n 3
```

GitHub knows about branches. You can share a new branch by pushing it with a special syntax:

```
git push -u fork my-new-feature
```

> This tells Git to push the `my-new-feature` branch to the forked repository. You'll see in the output that Git links your local branch to the remote branch in the fork.

Open your browser and refresh the fork in GitHub. You'll see a new sign saying there's a new branch.

Click the _Compare and pull request_ button and you can see the changes you made (you don't need to complete the Pull Request - we'll cover that process in a later lab). Here you can see that GitHub is able to compare the content of two branches.

## Merging

This branch is separate from the `main` branch, but Git knows they're related. Branching and merging is a core Git feature, GitHub just makes it easier to visualize changes. You can merge branches to bring the changes you've been working on back into the main codebase.

First switch back to the main branch and check the last commit:

```
git checkout main

git log -n 1
```

The output shows the most recent commit in that branch - it will be one of mine. Now merge in your changes from your branch:

```
git merge my-new-feature
```

You'll see some commit IDs and the list of files you changed. Check the log again and you'll see your branch changes are in the main branch now:

```
git log -n 1
```

> That brings your main branch up to date from the new branch, but these changes are still only on your machine. All changes in Git are local until you push them.

## Lab

Let's send your changes up to GitHub and ask to have them brought into the courselabs repo:

- push the changes from the main branch to your fork
- create a pull request from your fork to the original repo
- open the PR list in the original repo: https://github.com/courselabs/dev/pulls
- can you see why PRs are useful?

I won't be merging your changes (unless you've fixed some typos), and your local content might be a bit mixed up by now. You can reset it back to the original content with these commands:

```
git checkout main

git pull origin main

git reset --hard
```