//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// Первый вариант решения через функцию

// int ThreeDigit (int num ){
 
//         int result = (num/100) % 10;
//         return result;
// }

// Console.Write ("Enter the three digit number: ");
// int num = Convert.ToInt32 (Console.ReadLine ());

// ThreeDigit (num);
// Console.WriteLine ("Result: " + result);


// Второй вариант решения через массив

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
// return 0;

//     }

//     index++;
// }

// Console.WriteLine("Element in second index : " + find);


// Третий вариант решения через String
// Console.Write("Enter the three digit number: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("The second number -> "+stringNumber[1]);


// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// Console.Write("Enter number: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// string NumberText = Convert.ToString(Number);
// if (NumberText.Length > 2){
//   Console.WriteLine("the third digit -> " + NumberText[2]);
// }
// else {
//   Console.WriteLine("-> no the third digit");
// }

//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

Console.Write("Номер дня недели: ");
int NumDay = Convert.ToInt32(Console.ReadLine());

void Checking (int NumDayber) {
  if (NumDay == 6 || NumDay == 7) {
  Console.WriteLine("этот день выходной -> да");
  }
  else if (NumDay < 1 || NumDay > 7) {
    Console.WriteLine("ошибка, нет такого дня");
  }
  else Console.WriteLine("этот день выходной -> нет");
}

Checking(NumDay);
