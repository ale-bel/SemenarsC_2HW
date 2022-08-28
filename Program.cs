//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// int ThreeDigit (int num ){
 
//         int result = (num/100) % 10;
//         return result;
// }

// Console.Write ("Enter the three digit number: ");
// int num = Convert.ToInt32 (Console.ReadLine ());

// ThreeDigit (num);
// Console.WriteLine ("Result: " + result);

// int [] array = new int [3];
// int N = array Length;
// int find = 1;
// int index = 0;
// while index = 0;

// Console.Write ("Enter the three digit number: ");
// int [] array = Convert.ToInt32 (Console.ReadLine ());

// {
//     if (array [index] == find) 
//     {
// Console.WriteLine (index);
// break;

//     }

//     index++;
// }


// Console.WriteLine("Element in second index : " + numbers[1]);


Console.Write("Enter the three digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("The second number -> "+stringNumber[1]);
