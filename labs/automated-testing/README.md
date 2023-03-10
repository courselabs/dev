# Automated Testing

Most programming languages support automated testing. You write code for your features and then you write some more code which runs the feature and checks it does what it should. This is a valuable way of checking your app works - and the tests become part of the CI build so they'll also tell you if some future changes break something.

In this lab we'll see how unit tests work, and how they add confidence to the CI build.

## Reference

- [Automated testing for continuous delivery](https://www.atlassian.com/continuous-delivery/software-testing/automated-testing) - Atlassian

- [End-to-end testing tutorial](https://www.freecodecamp.org/news/end-to-end-testing-tutorial/) - Free Code Camp

- [Unit testing fundamentals](https://app.pluralsight.com/library/courses/unit-testing-fundamentals/table-of-contents) - Pluralsight

## Exploratory testing

We have a nice simple app for this lab - it's a calculator which can add two numbers. This is a .NET application, and the .NET runtime has good support for unit testing.

Before we get to automated testing, we'll do some _exploratory testing_. This is where users try the application in different ways, to make sure it works. It's unstructured and not repeatable, but it's a good way to see how the app works.

Open a terminal window in VS Code, switch to the app directory and run the app:

```
cd labs/automated-testing/src

dotnet run --project Calculator.App
```

You'll see a message telling you that you need to give it some numbers when you run it. This could be part of the acceptance criteria for the story, something like:

- _Given_ I don't supply any numbers
- _When_ I run the calculator app
- _Then_ I see a message asking for numbers

We can pass instructions to the app in the command line - everything afer the app name _Calculator.App_ gets sent into the application.

Run this to see if the app can do subtraction:

```
dotnet run --project Calculator.App 10 - 2
```

You'll see another message. This could be defined in another Gherkin spec - your user story should cover all the scenarios, so you know what happens if the feature doesn't get used the way it should.

Finally try it the way it's meant to be used, for addition:

```
dotnet run --project Calculator.App 10 + 2
```

That's 3 test cases already for this simple feature. What other sort of tests could you run?

- negative numbers
- very large numbers
- decimals
- etc.

You'd build up a big list of tests, and you'd need to run them every time a change was made, to make sure an update didn't break the app. Doing that manually isn't feasible, so we want to encapsulate those test cases in code which we can run automatically.

## Unit testing

Unit tests are small pieces of code which test other pieces of code. That may sound silly - if a developer writes bad code which doesn't work properly, who's to say they won't write a bad test too? They might, but tests would form part of the PR so they'd get reviewed.

Test cases are usually easier to review than complex code changes. Here are some unit tests written in C# for the calculator app:

- [AdditionServiceTests.cs](/labs/automated-testing/src/Calculator.App.Tests/Services/AdditionServiceTests.cs) - four tests executing different scenarios

You don't need to have been writing C# since 2002 to get some idea of what those tests are doing, but some of the terminology might be new:

- _Fact_ is used to denote a single test - ideally that should be a specific scenario, with just one expected outcome

- _AdditionService_ is the component in the calculator app which does the addition wqrk. The tests use that internal component rather than running the whole app

- _expected_ and _actual_ are variables used to capture the expected result from the code and the actual result that happens in the test

- _Assert_ is used to make sure the actual result is the same as the expected result

You run these tests using a different .NET command:

```
dotnet test
```

You'll see a lot of logs in the output, and at the end you'll see the results of the tests:

```
Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     4, Skipped:     0, Total:     4, Duration: 1 ms
```

This tells us there were 4 tests and they all passed. 

## Test coverage

It's difficult to test every line of code, so some scenarios might be missed even if you have a big test suite. 

If a user or a team member finds a bug when they're using the app, it's good practice for developers to write an automated test to reproduce the bug. That test should fail when they run it - and they'll know they fixed the bug when the test passes.

There's something wrong with the calculator app and the number 17 - try this:

```
dotnet run --project Calculator.App 2 + 17
```

The app runs without an error, but the answer isn't correct. 

Can you write a test to reproduce that? You can copy one of the existing tests in the file:

- open the file [labs/automated-testing/src/Calculator.App.Tests/Services/AdditionServiceTests.cs](/labs/automated-testing/src/Calculator.App.Tests/Services/AdditionServiceTests.cs)

- copy one of the existing tests - everything from the `[Fact]` line to the closing brace `}` (e.g. you can copy lines 9 to 16 and paste them after line 49)

- change the name of the test (e.g. from `SimpleIntegers` to `Number17`)

- change the conditions so the `Operate` call is adding 2 and 17 and the expected answer is 19.

The app doesn't meet the expected behavior in the new test, so when you run the test suite it should fail:

```
dotnet test
```

Now you'll see red error lines in the output, something like this:

```
[xUnit.net 00:00:00.21]     Calculator.App.Tests.AdditionServiceTests.Number17 [FAIL]
  Failed Calculator.App.Tests.AdditionServiceTests.Number17 [< 1 ms]
  Error Message:
   Assert.Equal() Failure
Expected: 19
Actual:   36
  Stack Trace:
     at Calculator.App.Tests.AdditionServiceTests.Number17() in /Users/elton/scm/github/courselabs/dev/labs/automated-testing/src/Calculator.App.Tests/Services/AdditionServiceTests.cs:line 57

Failed!  - Failed:     1, Passed:     4, Skipped:     0, Total:     5, Duration: 7 ms
```

In a real project, that would be part of the build pipeline. When you pushed your changes the build would break - which is a good thing in this case, because it gives visibility into the problem.

## Lab

There is a GitHub Actions pipeline for this lab called _.NET Calculator build_. 

You can push the new test to your fork:

```
git add --all

git commit -m 'Added failing test'

git push fork main
```

Browse to the _Actions_ tab in GitHub for your repo and you should see that the build fails.

Can you fix the issue with number 17? It's in the code file [labs/automated-testing/src/Calculator.App/Services/AdditionService.cs/AdditionService.cs](/labs/automated-testing/src/Calculator.App/Services/AdditionService.cs). You can run `dotnet test` to check - the tests will all pass if you fix it, and then you can push the changes to your fork and fix the build.