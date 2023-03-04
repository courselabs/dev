

## Exploratory testing

```
cd labs/automated-testing/src/Calculator.App

dotnet run
```

Try with subtraction:

```
dotnet run 10 - 2
```

And this should work:

```
dotnet run 10 + 2
```

What other sort of tests could you run?

- negative numbers
- very large numbers
- decimals
- etc.

You'd build up a big list of tests, and you'd need to run them every time a change was made, to make sure an update didn't break the app.

## Unit testing

Unit tests are small pieces of code which test other pieces of code;

- [AdditionService](labs/automated-testing/src/Calculator.App/Services/AdditionService.cs)

