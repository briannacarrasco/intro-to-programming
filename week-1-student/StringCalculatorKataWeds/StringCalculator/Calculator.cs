
using System;
using System.Text.RegularExpressions;

public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers.Length == 0)
        {
            return 0;
        }
        else if (numbers.Length ==1){
            return int.Parse(numbers);
        }
        // else if (length==3){
        // string[] arr = numbers.Split(", ")
        // return int.Parse(arr[0] + int.Parse(arr[1]);
        else {
            int sum = 0;
            // num 6
            // Regex numbersOnly = new Regex("^[0-9]+$");
            char[] delimiters = new char[] { ',', '\n' };
            string[] arr = numbers.Split(delimiters);
            for (int i = 0; i < arr.Length; i++)
            {
                sum += int.Parse(arr[i]);
            }
            return sum;
        }
    }
}
