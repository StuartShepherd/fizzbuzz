/// FizzBuzz. 
/// The FizzBuzz problem is a classic test given in coding interviews.
///
/// The coding test is as follows:
///      Write a program that prints the numbers from 1 to 100. 
///      But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
///      For numbers which are multiples of both three and five print "FizzBuzz".

Console.WriteLine("FizzBuzz");
Console.WriteLine("");

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(FizzBuzz
        .FizzBuzzHelper
        .Get(i));
}

Console.ReadLine();
