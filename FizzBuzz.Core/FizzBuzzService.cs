namespace FizzBuzz.Core;
public class FizzBuzzService
{
    public string Print(int num)
    {
        if (IsDivisibleByThree(num) && IsDivisibleByFive(num)) {
            return "FizzBuzz";
        }
        else if (IsDivisibleByThree(num)) {
            return "Fizz";
        }
        else if (IsDivisibleByFive(num)) {
            return "Buzz";
        }
        else {
            return num.ToString();
        }
        
    }

    private bool IsDivisibleByThree(int num) {
        return num % 3 == 0;
    }

    private bool IsDivisibleByFive(int num) {
        return num % 5 == 0;
    }
}
