

## Reference

- [git-flow](https://nvie.com/posts/a-successful-git-branching-model/) - a branching model for complex  projects

- [GitHub Flow](https://guides.github.com/introduction/flow/https://guides.github.com/introduction/flow/) - a simpler branching model

## Forking a repository

You can make changes to a local repo but you can only push those changes to GitHub if you have permission.

Sign up for a GitHub account: 

- https://github.com/signup

When you have signed in with your account, you can fork the class repo - this means taking a copy of it into your own account:

- https://github.com/courselabs/dev/fork

Leave all the default values and click _Create Fork_.

> Make a note of the URL of your fork in the browser window, it will contain your GitHub username. 

My username is `sixeyed` so my fork URL is: https://github.com/sixeyed/dev. Yours will be different.

Open the VS Code terminal and add your fork as a remote - this tells Git there is a new location where you can push changes:

```
cd ~/Documents/dev

# make sure you use your real URL!
git remote add fork <your-github-fork url>
```

## Pushing changes

Make a change to a file - anything will do - and commit the change. You can do that in VS Code using the _View...Source Code_ window, or in the terminal:

```
git add --all

git commit -m 'Added new file'
```

The changes are saved in your local copy of the repo. That isn't automatically synced to GitHub, so if your machine died your changes would be lost.

Try pushing to the _origin_ - which is the original copy of the code in the courselabs/dev repo:

```
# this will fail
git push origin main
```

> You'll get an error, because your account doesn't have access to write to the courselabs repo.

But you have your own fork, so you can push to that:

```
git push fork main
```

Now your changes are stored in GitHub so they could be available [forever](https://archiveprogram.github.com/arctic-vault/) :)

Open your fork again in the browser and refresh the page. You'll see a banner saying _This branch is 1 commit ahead of courselabs:main_.

Your fork is a separate repo, but GitHub knows it is linked to the original repo, and there are options to send your changes back to the source - with an approval step so the owner can decide if they want to take them.

## Branching

In a team project you'll all be sharing code in the same repo, but you need to make sure your changes are isolated. Often developers create a _branch_ for every item they work on. A branch is lightweight copy of the code, which can be shared without affecting the main codebase.

Create a new branch:

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

> You'll see in the output that git links your local branch to the remote branch in the fork.

Open your browser and refresh the fork in GitHub. You'll see a new sign saying there's a new branch.

Click the _Compare and pull request_ button and you can see the changes you made (you don't need to complete the Pull Request).

## Merging

This branch is separate from the `main` branch, but Git knows they're related. You can merge branches to bring the changes you've been working on back into the main codebase:

First switch back to main and check the last commit:

```
git checkout main

git log -n 1
```

Now merge in your branch changes:

```
git merge my-new-feature
```

You'll see some commit IDs and the list of files you changed. Check the log again and you'll see your branch changes are in the main branch now:

```
git log -n 1
```


## Lab

- push the changes from main to your fork
- create a pull request from your fork to the original repo
- open the PR list in the original repo: https://github.com/courselabs/dev/pulls
- can you see why PRs are useful?