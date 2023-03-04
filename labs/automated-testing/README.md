

## Exploratory testing

```
cd labs/automated-testing/src

dotnet run --project Calculator.App
```

Try with subtraction:

```
dotnet run --project Calculator.App 10 - 2
```

And this should work:

```
dotnet run --project Calculator.App 10 + 2
```

What other sort of tests could you run?

- negative numbers
- very large numbers
- decimals
- etc.

You'd build up a big list of tests, and you'd need to run them every time a change was made, to make sure an update didn't break the app.

## Unit testing

Unit tests are small pieces of code which test other pieces of code;



- [](labs/automated-testing/src/Calculator.App.Tests/Services/AdditionServiceTests.cs)

These tests can be executed by the runtime:

```
dotnet test
```

Output:

```
Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     4, Skipped:     0, Total:     4, Duration: 1 ms
```

## Test coverage

It's difficult to test every line of code, so some scenarios can be missed. 

If a user or a team member finds a bug when they're using the app, it's good practice for developers to write an automated test to reproduce the bug.

There's something wrong with the calculator app and the number 17 - try this:

```
dotnet run --project Calculator.App 2 + 17
```

Can you write a test to reproduce that? You'll need to copy an existing test, give it a new name and change the conditions. Your should include the expected bevahior, so when you run the test it should fail.

When you make your changes and run `dotnet test` you'll see something like this:

```
[xUnit.net 00:00:00.21]     Calculator.App.Tests.AdditionServiceTests.SimpleIntegers_Bug17 [FAIL]
  Failed Calculator.App.Tests.AdditionServiceTests.SimpleIntegers_Bug17 [< 1 ms]
  Error Message:
   Assert.Equal() Failure
Expected: 19
Actual:   36
  Stack Trace:
     at Calculator.App.Tests.AdditionServiceTests.SimpleIntegers_Bug17() in /Users/elton/scm/github/courselabs/dev/labs/automated-testing/src/Calculator.App.Tests/Services/AdditionServiceTests.cs:line 57

Failed!  - Failed:     1, Passed:     4, Skipped:     0, Total:     5, Duration: 7 ms
```

In a real project, that would be part of the build pipeline. When you pushed your changes the build would break - which is a good thing in this case, because it gives visibility into the problem.

## Lab

can you fix the issue with number 17?

- [AdditionService](labs/automated-testing/src/Calculator.App/Services/AdditionService.cs)