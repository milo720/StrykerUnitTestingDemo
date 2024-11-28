using FizzBuzz;

var fizzBuzz = new FizzBuzzGenerator();
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(fizzBuzz.GetFizzBuzz(i));
}
