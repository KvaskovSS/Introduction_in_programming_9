// Task 1
// int decimalToBinary(int dec){
//     if(dec == 0){
//         return 0;
//     }else{
//         return dec % 2 + 10 * (decimalToBinary(dec / 2));
//     }
// }

// Task 2
void findNatureSum(int M, int N, int sum){
    if(M > N){
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum += M++;
    findNatureSum(M, N, sum);
}

// Task 1
// Console.WriteLine("Введите десятичное число : ");
// int dec = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(decimalToBinary(dec));

// Task 2
Console.WriteLine("Введите начальное число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число M:");
int N = Convert.ToInt32(Console.ReadLine());

findNatureSum(M, N, 0);