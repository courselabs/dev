# Sprints and Releases

Scrum delivers work in _sprints_ - fixed periods (usually 2 or 4 weeks) with a defined goal and a definite outcome. A successful sprint produces software which could be released (Scrum calls it a _potentially shippable increment_). It may not actually get deployed, because it might not make sense to deliver some features without others. Scrum doesn't have the concept of _releases_ but Jira does because teams often want to see when a feature is planned for release.

In this lab we'll build a Sprint Backlog and see how it relates to a release.

## Reference

- [Story points](https://confluence.atlassian.com/jirasoftwareserver0905/estimate-in-story-points-1207174843.html) - for estimation

- [Release planning with Epics](https://www.scrumdistrict.com/planning-releases-sprints-in-scrum-a-beginners-guide/) - this is not pure Scrum :)

- [Release versions in Jira](https://support.atlassian.com/jira-software-cloud/docs/configure-versions-in-a-scrum-project/)

## Create the Sprint

Open the Scrum Board you created in Jira - the one you used for the Epic on user registration and login.

In the _Backlog_ tab you should see your two stories. There is also a Sprint, which Jira creates by default. In advance of the planning meeting the team will create the next Sprint in Jira, ready to be filled with the Sprint Backlog.

Fill in the details for the Sprint:

- set duration to _2 weeks_
- set the start date to next Monday
- enter the Sprint Goal _User registration_

The Sprint Goal is a short description of the overall goal of the Sprint.

## Plan the work

The Scrum team works from the Product Backlog in the Sprint Planning session. The Backlog is prioritized but the stories probably don't have estimates. 

Estimation happens in the planning meeting so the team agrees how much effort is needed for the top X stories, and then they know how many of the stories can be done in the Sprint.

- add estimates to the stories in the backlog
- estimation is usually in "points" which is an approximate measure of complexity
- points are a deliberately vague, sometimes teams use a fixed scale - e.g. 1, 3, 8, 20 or 40 

> Story points are one of the hardest concepts for people new to Scrum, and one of the most intuitive for people experienced in Scrum :) If you're new to story points, this is a great read: [Practical Fibonacci: A Beginner's Guide to Relative Sizing](https://www.scrum.org/resources/blog/practical-fibonacci-beginners-guide-relative-sizing) (scrum.org)

In Jira you populate the Sprint Backlog by dragging stories into the Sprint:

- add stories to your sprint
- write some new stories if you want a more representative view

![](/img/sprints-releases/sprint-backlog.png)

How many story points the team can complete in a Sprint starts off as guesswork and becomes more refined over time. The team may commit to 13 points in the first Sprint and complete it easily; in Sprint 2 they commit to 40 points and fail; by Sprint 3 they have an idea they can complete 20-30 points.


## Start the sprint

Click _Start Sprint_ and Jira will change the dates for the Sprint and make it the active Sprint.

Now you'll be in the _Board_ tab which shows all the stories for the Sprint in _swimlanes_ which are used to track progress:

- stories are allocated to the team member working on them
- you can move status by dragging the stories horizontally
- the lanes are very simple: To-do, In-progress and Done
- Done means Done - stories in here are finished, tested and ready to release

![](/img/sprints-releases/board.png)

The daily standup is driven from the board (co-located teams like to have a physical whiteboard with post-it notes for each story). Each team member answers three questions: 

- what they did yesterday
- what they're doing today
- whether they have any blockers stopping their work



Scrum lays down strict rules and it's common for teams to adopt just some of the practices, or to mangle them to fit the company's processes or preferences.

## Plan a release

Releases aren't part of Scrum and they're not in the Jira project template - but you can add them:

- open _Project Settings_
- select _Features_
- scroll down to _Releases_ and tick the slider 

Back in the project you'll see _Releases_ listed in the left menu. Select that and create a new version:

- call it `v1`
- give it a release date

Open up your _v1_ version and click _Add issues_. 

> You can add individual stories or whole epics. Which do you think is better?

Releases might span several sprints. In our example we have stories for user registration and user login. There's no point releasing one feature without the other, so we may plan a release with both - so if the stories are done in different sprints, we wouldn't release them independently.

Open the _Roadmap_ tab and you'll see where your version is planned, and how it relates to sprints and epics:

![](/img/sprints-releases/roadmap.png)

## Lab

Jira lets you customize pretty much everything. Can you find your project settings and edit the board to add a new status - _In testing_ - so the team can see when a story has been built and is with the testers.

This is not as simple as you might think, but the built-in help in Jira is good so you should hopefully be able to work through it.