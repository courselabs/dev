# Pull Requests

Pushing changes to the main branch kicks off a build pipeline which could be configured to deploy to production. The pipeline can have lots of automated safeguards but teams usually like to have a manual review process. GitHub and other Git systems let you protect the main branch, so the only way to merge changes from a feature branch is using a Pull Request (PR).

In this lab you'll create your own PR and review someone else's PR so you can experience the workflow.

## Reference

- [Pull Requests tutorial](https://www.atlassian.com/git/tutorials/making-a-pull-request) - Atlassian

- [About Pull Requests](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/about-pull-requests) - GitHub

- [GitHub Pull Requests from Start to Finish](https://app.pluralsight.com/library/courses/github-pull-requests-from-start-finish/table-of-contents) - Pluralsight

## Pair up and create a PR!

For this lab you'll need someone to pair up with, so you can see how the pull request workflow goes:

- find your partner
- share the URLs for each other's GitHub forks
- something like https://github.com/sixeyed/dev

> Your partner won't have permission to push changes to your fork. The only way they can change code in your repo is with a Pull Request which you need to approve.

Open your partner's fork in GitHub. You can make simple changes direct from the GitHub website, you don't need to download the code onto your machine. 

Navigate through the file list in the _Code_ view and open a file (any file will do) - then click the pencil icon to edit it:

![](/img/pull-requests/edit-file.png)

Make any change you like, then scroll to the bottom and click _Propose Changes_:

![](/img/pull-requests/propose-changes.png)


GitHub checks your changes can be merged without a conflict. Now you can select _Create pull request_:

![](/img/pull-requests/create-pr.png)

When you're done, wait for your partner to create their PR for your branch. You'll get an email when there's a new PR to review - you should get one soon :)

## Review the PR

Your email from GitHub will have a lot of technical information, including the user ID of the person requesting the change, and the list of files they changed. The link at the top of the email will open the PR in GitHub:

![](/img/pull-requests/github-email.png)

> You can also browse to the Pull Requests tab in your repo on GitHub; it shows the list of all open PRs.

Open the PR your partner sent in. You can add comments to the PR, or you can drill down into the files that were changed and add notes to specific lines.

Click on the _Files changed_ tab and select _Review changes_:

![](/img/pull-requests/create-review.png)

You can add a comment, request changes or approve. This is usually a repeated cycle:

- the reviewer has some feedback that needs a change
- developer makes the change on their machine and pushes to the branch
- GitHub updates the PR to show there are changes
- reviewer looks again

The developer and the reviewer might be sat next to each other in the office or they might be in different countries with different timezones. Recording all the feedback in the PR creates an audit trail of what was done, when and by whom.

When you've added your review, open the _Pull requests_ link at the very top of the GitHub window:

![](/img/pull-requests/topbar-pr.png)

These are your own PRs which you've created - they could be for multiple repos. From here you can see your partner's feedback on your proposed changes.

You can add comments, make more changes or close the PR - which means your changes won't get merged.

## Complete the PR

Back in your own repo, find the PR your partner sent in.

If you're happy after the review you can merge the PR, which means your partner's changes will be merged into your own fork:

![](/img/pull-requests/merge-pr.png)

This brings your partner's changes into your fork - it's a special form of merge and commit.

If you do merge the PR, check the Actions tab in your repo; what's happening with the build?

Or if you don't want their updates, you can close the PR with a comment:

![](/img/pull-requests/close-pr.png)


## Lab

GitHub doesn't give you a nice visualization of the branch and merge history, although if you browse around the Insights tab, you can see something similar.

Can you work through the history in your fork to see which commits came from the original courselabs repo, which are yours and which are from the PR you merged?