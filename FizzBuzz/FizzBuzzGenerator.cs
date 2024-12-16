namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public string GetFizzBuzz(int number)
        {
            if (number % 15 == 0) return "FizzBuzz";
            else if (number % 3 == 0)  return "Buzz";
            else  if (number % 5 == 0)  return "Buzz";
            else return $"{number}";
        }
    }
}
