# 1. User Stories and Epics

_User Stories_ are the unit of work in Scrum (and other agile approaches). They're intended to be a concise description of a desired feature - something which anyone in the team can read and understand. They're usually written in a fixed format: _As a **persona**... I want to **goal**... So that **value**_. Sticking to the formula forces the team to think  in terms of the user and the value they're getting from the system. User Stories are small pieces of work, so they are often grouped together in _Epics_. The epic describes an overall goal or a common feature area.

In this lab we'll use Jira to create Epics and Stories and see how to navigate them in the UI.

## Reference

- [Using the Scrum template in Jira](https://www.atlassian.com/software/jira/templates/scrum)

- [Epics and the Product Backlog](https://www.scrum.org/resources/blog/what-are-epics-and-features)

- [Epics in Jira](https://www.atlassian.com/agile/project-management/epics)


## Create a Jira Account

You'll have your own corporate Jira login for managing real projects. We'll leave that Jira alone - you can create a separate Jira account just for you. That will let you explore the features safely.

Browse to https://id.atlassian.com/signup to create a new account:

- you can use your personal email account
- or log in eith another identity provider
- your corporate email account may be linked to another Jira, so don't use that

You'll be sent a verification email, so you'll need access to the email account. Open your verification email, click the link and choose a password.

In the next page (after all the verification steps) open _Jira Software_:

![](/img/epics-stories/add-jira.png)

Now click the _Get it free_ link (or you can browse to https://www.atlassian.com/software/jira/free).

You don't need to choose any other products, just click _Next_ and then you'll get to another setup screen:

![](/img/epics-stories/create-site.png)

You need to choose a unique name for your Jira site, then click _Agree_.

You'll be asked a few more questions, then your Jira site will be created. When you finally get to the welcome page:

![](/img/epics-stories/skip-setup.png)

Click on _Skip_ to continue.

## Create a new Scrum Project

Projects are the overall grouping mechanism in Jira - everything belongs to a project. 

In the new project screen you can choose between different types of projects using templates. Click _More templates_ and choose the Scrum template:

![](/img/epics-stories/scrum-template.png)

Give your project a name and click _Create_. You'll be asked if you want to connect to other tools - click _Skip_ to get past that.

When your project is ready, you can start creating stories.

> If you're new to Jira, click the _Take the tour_ link and you'll be shown the main parts of the screen.

## Create Stories and Epics

Jira calls all types of work _issues_ and the type of issue in Scrum can be an epic, a story or a bug.

Your project opens in the _Backlog_ tab (on the left menu). This is the product backlog - a list of prioritized stories which the team will work through in sprints.

There's nothing there yet. Click the blue _Create_ button at the top of the screen:

- create a new Epic
- call it 'Registration and login'

You don't need much information for an Epic, but if you want to you can add a full description, set dates and select a color for display.

Save the epic and you'll see there's still nothing showing in the _Backlog_. Only stories are listed here. Switch to the _Roadmap_ tab to see Epics.

Open your Epic and click _Add a child issue_. Now create a story under the epic:

 - for registered users to login
 - you can enter just the summary from this screen
 - open the issue to add more detail
 - use the standard _As a... I want to... So that..._ format in the description
 - there are more fields you don't need to set now - when would the estimate get added?

Browse to the _Backlog_ once you have your story and you'll see it in the list.

Add another story:

- for registering a new user
- use the standard _As a... I want to... So that..._ format in the description
- be sure to link the story to your epic

Issues are usually linked in Jira, so a story issue may have lots of _task_ issues, which may have _bug_ issues, and they would all ultimately link to the parent epic issue. Navigating Jira effectively just takes practice :)

## Lab

Jira has a nice feature to create a project with sample data so you have something to explore. From the top menu click _Your work... Boards... View all boards_:

![](/img/epics-stories/all-boards.png)
 
From here click _Create board_ and you can select _Create a Scrum board with sample data_. Do that and have a look around your new project. Can you see how Jira issues map to the Scrum concepts?

Scrum is a lightweight framework, but for some teams even Scrum has too much admin - they just want a list of work to get through, without breaking it down into sprints. Jira supports another type of agile project called _Kanban_. If you have time you can create a Kanban board with sample data. Can you see how it's different from the Scrum board?
