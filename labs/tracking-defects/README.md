# Tracking defects

One problem teams often have is using separate tools for different jobs, and needing to link them together. We've using Jira for product management and GitHub for source code. Both tools let you log defects to manage things that need fixing - which should you use?

In this lab you'll see how defect tracking works in different tools so you can see how they compare.

## Reference

- [About GitHub Issues](https://docs.github.com/en/issues/tracking-your-work-with-issues/about-issues) - GitHub

- [Bug tracking in Jira](https://www.atlassian.com/software/jira/features/bug-tracking) - Atlassian

- [Software Testing and Quality Assurance: The Big Picture](https://app.pluralsight.com/library/courses/software-testing-quality-assurance-big-picture/table-of-contents) - Pluralsight

## Defect tracking with GitHub issues

GitHub uses _issues_ to track problems with the app in a repository - not to be confused with Jira issues which are used in planning.

In a public project, any GitHub user can create an issue:

- https://github.com/courselabs/dev/issues - these are the issues for the course materials. There may be a few things in there which I need to get to; you can add your own if you find anything wrong.

Anyone can see these issues and decide they want to help out (by forking the repo, making their changes and creating a Pull Request). Busy projects like Kubernetes might have thousands of issues:

![](/img/tracking-defects/kubernetes.png)

Open your own fork of the repo in GitHub. Do you see the _Issues_ tab?

> Forks would usually not have a separate list of issues; those would be tracked on the parent repo. 

Issues are an optional feature - under the _Settings_ tab you can scroll down to _Features_ and enable issues in your fork.

Create a new issue in your own fork:

- enter anything in the comment and title fields
- you can upload files here, which you would use for screenshots or reports
- you can use fancy formatting to make the issue more clear

There are some special features too - try the `@` key and you'll see a popup with your username. You can tag a user on the project to make sure they get notifications.

Click _Submit new issue_ and your issue will load. You can add some more comments, assign a user, add labels and even create a branch.

You can close the issue here, and closed issues can be reopened.

## Linking issues in GitHub

Your first issue will be number 1 (you'll see `#1` next to the issue title). Issue numbers can be used as references.

Create a second issue:

- use anything for the title
- in the comments make a reference to issue #1
- save the issue

Navigation between issues helps with tracking. Anything with comments can link to issues by the issue number. That's very helpful for commits or PRs - it maintains an audit trail in SCM linking the issue with the fix.

Open a file in the GitHub UI (any file in your repo will do) and click to edit it with the pen icon:

![](/img/tracking-defects/edit-in-github.png)

Scroll down to commit your changes, and you can reference an issue in the commit message:

![](/img/tracking-defects/issue-in-commit.png)

Open your issue list again and you might see that the issue you referenced in your commit is gone. The default view only shows open issues. If you write something like `this fixes #2` then GitHub closes the issue when you makge your commit.

> The same feature is available for PRs - you can reference an issue in the comments, and when the PR is merged the issue will be closed.

It's good to have this clear link between bugs and commits, but if you're using Jira for your Product Backlog it means you have a separate system to manage your defect workload.

## Defect tracking with Jira

Jira uses the _bug_ issue type to track defects. Bugs can be child issues of a story, or they can be independent of other issues.

Open your Jira instance and navigate to the Scrum project you created in the [Epics and Stories lab](/labs/epics-stories/README.md). In the _Backlog_ view click the _Create issue_ link at the bottom of the product backlog:

- click the issue type icon and change it to _Bug_
- add a description

![](/img/tracking-defects/create-jira-issue.png)

This is a standalone bug, not related to a story. It could be a problem with an environment which doesn't relate to a specific feature, but typically bugs will be problems with new features the team is working on.

Open one of the stories in your Sprint Backlog by clicking on the title. In the story window click the link icon, and then click _Link issue_:

![](/img/tracking-defects/jira-link-issue.png)

Linking an issue in Jira means you're establishing some kind of relationship between them. You can say that this story is blocked by the bug:

![](/img/tracking-defects/jira-link-bug.png)

Click the _Link_ button, then go ahead and drag the bug into the Sprint Backlog so we can work the fix. You'll be asked to confirm if you really want to to that. 

> Remember in Scrum the scope for the Sprint is fixed in the planning session and the team commits to it. A new bug alters the scope so Jira makes you aware of that.

The big advantage with defect tracking in Jira is that the rest of your planning is there. You don't have the link between issues and code, but you do have the link to stories and you get safegaurds around scope change.

## Lab

You can get the best of both worlds if Jira knows about your GitHub repo. Open the project settings in Jira and open the _Toolchain_ tab. Click on the _Add_ button and select _Add code repository_. 

Can you connect your Jira project to your GitHub fork? **There are several steps and lots of authorization to connect GitHub and Jira**. What extra integration do you get when you're connected?