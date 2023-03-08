# Pull Requests

Pushing changes to the main branch kicks off a build pipeline which could be set up to deploy to production. The pipeline can have lots of safeguards but teams usually like to have a manual review process. GitHub and other Git systems let you protect the main branch, so the only way to merge changes from a feature branch is using a Pull Request (PR).

In this lab you'll create your own PR and review someone else's PR so you can experience the workflow.

## Reference


## Pair up and create a PR!

For this lab you'll need someone to pair up with, so you can see how the pull request workflow goes.

Browse to your partner's fork - edit a file(any file will do):

![](edit).

Scroll to the bottom and click Propose Changes:

![](propose)


GitHub checks your changes can be merged without a conflict - now you can select _Create pull request_:

![](create-pr)

When you're both done, browse back to your own fork.


## Review the PR

Open the Pull requests view and then open the PR your partner sent in.

Click on the _Files changed_ tab and select _Review changes_:

![](review)

You can add a comment, request changes or approve.

When you've added your review, open the _Pull requests_ link at the top of the GitHub window:

![](PRS)

These are your own PRs which you've created. From here you can see your partner's feedback on your proposed changes.

You can add comments, make more changes or close the PR - which means your changes won't get merged.


## Merge the PR

If you're happy after the review you can merge the PR:

![](merge)

This brings your partner's changes into your fork - it's a special form of merge and commit.

Check the Actions tab after you merge, what's happening with the build?

## Lab

GitHub doesn't give you a nice visualization of the branch and merge history, although if you browse around the Insights tab, you can see something similar.

Can you work through the history in your fork to see which commits came from the original courselabs repo, which are yours and which are from the PR you merged?