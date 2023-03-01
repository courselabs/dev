

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

```