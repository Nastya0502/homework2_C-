// на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

Console.Write("Введите любое число: ");
double num = Convert.ToDouble(Console.ReadLine());
int num_int = 0;
int num_isp = 0;
double num_last = 0;
int num1 = 0;
int index = 1;
int index2 = 1;
double result = 0;
while (num%1 !=0)
{
    num*=10;
    index2*=10;
}
num_int = Convert.ToInt32(num);
num_isp = num_int;
if (num<10)
{
    Console.WriteLine("Второй цифры нет");
}
else
{
    while (num_isp>99)
    {
        num_isp/=10;
        index*= 10;
    }
    num1 = num_int/index/10;
    num_last = num_int%index;
    result = (num1*index+num_last)/index2;
    Console.WriteLine(result);
}
