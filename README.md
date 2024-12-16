# StrykerUnitTestingDemo

hi i'm here to show you about stryker. Through a quick demo/exmaple.
First i'm going to give abreif look at the problem stryker aims to solve.

# I'm a developer of the fizz buzz application at fizzbuzz inc.

I have just finished updating our fizzbuzz application and moving it into .net core.
A complete rewrite.

Senior comes along, sees code coverage issue, fixes mistake in not having both fizz and buzz.. 
And renames.

# The issue

Add the tests, fix the issue, show working app. extract constants and rename to cuase error.
Big issue for fizzbuzz org, what could they have done.

# install 

dotnet new tool-manifest
dotnet tool install dotnet-stryker
dotnet tool restore
 dotnet stryker -o --mutation-level "advanced"

 While it installs and runs explain wht it is going to do.
The fact it edits code in complable ways to see if any tests fail.

#Go trhough results to see show that it has highlighted all my issues.

# Where to use

can be usefull anywhere.
Can be intrdocuced into piplines.
Usefull espesially where you think quality can be an issue.

# Does have issues

Takes time
Can break
Not perfect.
