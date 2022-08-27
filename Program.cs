// int CutNumber () {
//     int num = new Random ().Next (100, 1000);
//     Console.WriteLine ("Number is " +num);
//     int dec = num/100;
//     int ed = num % 10;
//     int result = dec*10 + ed;
//     return result;
// }
// int number = CutNumber ();
// Console.WriteLine ("Cut numbre is " +number);

int Factorial (int num) {
    int current = 1;
    int fact = 1;
    while (current<=num) {
        fact *= current;
        current++;
        }
    return fact;
}

int result = Factorial(5) * Factorial(3);
Console.WriteLine("Your result is " +result);
