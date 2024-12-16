# StrykerUnitTestingDemo
## Before you start

Before you give this demo please read this through and read through the code base. Also have a look at .net stryker [here](https://stryker-mutator.io/docs/stryker-net/getting-started/).

This is just an outline so please edit as is suitable for your situation and audience.

## Introduction

Introduce yourself and what you are going to talk about.


**"Hi, I'm here to show you about stryker a tool to improve unit tests."**


## The problem

We are going to show a fizzbuzz application that has bad tests and take them through a somwhat contrived example of a bug making it's way to production due to how weak the tests are.

### Introduction to the problem

Fist introduce the what you are going to do.

**"Before we go into what styker is and how it works I'm first going to show how it can help you. I am paart of the FizzBuzz org, helping provide FizzBuzz at scale for our customers. As a new developer I am helping to rewite our core product, the FizzBuzz Generator"**

Go over the FIzzBuzz code showing the code and that it has tests. Explain fizzbuzz if needed

### The first fix

**"This code has been writen and passed up to as a senior developer in PR, I have notice an issue and in code coverage and have come to check**

Show the code coverage if you are able, Visual Stuido Live Unit test can be a good way of doing it. Fix the error with Fizz not being correct and add an extra test to cover the untested line.

```cs
        public string GetFizzBuzz(int number)
        {
            if (number % 15 == 0) return "FizzBuzz";
            else if (number % 3 == 0)  return "Fizz";
            else  if (number % 5 == 0)  return "Buzz";
            else return $"{number}";
        }
```

```cs
        
        [TestMethod]
        public void TestFizz()
        {
            var expected = "Fizz";
            var result = _fizzBuzzGenerator.GetFizzBuzz(3);
            Assert.AreEqual(expected, result);
        }
```

```cs
        
        [TestMethod]
        public void TestNumber()
        {
            var expected = "Fizz";
            var result = _fizzBuzzGenerator.GetFizzBuzz(11);
            Assert.AreEqual(expected, result);
        }
```

Show the console app ruinning to show it is working.

### The problem

Next rename the FizzBuzz namespace using a renaming tool but accidentally change the fizzbuzz string.
In VS code this can be done with right click -> change all occurrences -> "FizzBuzOrg"
In Visual Studio this can be done with right click ->  rename -> "FizzBuzzOrg" and don't untick the options.

```cs
namespace FizzBuzzOrg
{
    public class FizzBuzzGenerator
    {
        public string GetFizzBuzz(int number)
        {
            if (number % 15 == 0) return "FizzBuzzOrg";
            else if (number % 3 == 0)  return "Buzz";
            else  if (number % 5 == 0)  return "Buzz";
            else return $"{number}";
        }
    }
}
```

If you want to make it less obvious how you are breaking it you can extract the strings to a constant file first. This better shows how easy it is to add in errors when you don't have a good unit test suit.

### The Outcome

Now show the broken code by running the demo console app.

**"This bug was deployed to production as it was not caught by any of our tests, it has caused our customers to not get their needed fizzbuzzes causing us great reputational and financial damage."**

# The solution 

**"How could we have prevented this"**

Revert your git repo to before the changes you made.

**"Styker could have helped ensure a good unit test suite in order to mitigate this problem"**

Install stryker by running the following commands. Explain it is a dotnet tool that will do mutation testing.

The steps below were broadly taken from here - https://stryker-mutator.io/docs/stryker-net/getting-started/

```
dotnet new tool-manifest
dotnet tool install dotnet-stryker
dotnet tool restore

```
Now run it with this command.

```
dotnet stryker -o --mutation-level "advanced"
```
While it run explain that it will be making changes to your code, running the covering tests and then seeing if any fail. Explain that this will help test the effectiveness of the tests not just the coverage.

When the report comes up show them the FizzBuzzGenerator and how stryker has highlight all these different parts of the code which are not effectively covered by unit tests.

# Where to use

Go through when this can be useful.
While Styker (it is also available in other languages) can be useful in a any .net development that needs quality it is especially useful in areas when you are unsure if you will get a good unit test suit and what to check that pragmatically.

This includes: 
- helping more junior developers to write better unit tests and understand why what they are writing is good.
- In teams that for whatever reason are having issues with unit test quality and need to improve.
- In legacy solution where you want to know what bits are safer to refactor due to the presence of effective unit tests.

Go over that this can be run locally or in a pipeline and that you can set thresholds.

# Does have issues

Make sure to cover that Styker has issues.

1. It will not pick up everything. For example, it did not test the mutation below.
```cs
public string GetFizzBuzz(int number)
{
    if (number % 15 == 0) return "FizzBuzz";
    else if (number % 3 == 0)  return "Buzz";
    else  if (number - 5 == 0)  return "Buzz";
    else return $"{number}";
}
```

2. It takes time to run and so for very large projects this can be an issue.
3. Like all software it can break or have bugs and so if it is introduced into your process there will be a cost associated with understanding and maintaining it's integration.
4. It is under a reasonably permissive license but you should always check to ensure you are using it with the terms. https://github.com/stryker-mutator/stryker-net/blob/master/LICENSE 

