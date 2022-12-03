//Подход без функций
/*
int a1 = 15;
int a2 = 251;
int a3 = 39;
int a4 = 12;
int a5 = 223;
int a6 = 33;
int a7 = 113;
int a8 = 23;
int a9 = 333;

int max = a1;
if(a2 > max) max = a2;
if(a3 > max) max = a3;
if(a4 > max) max = a4;
if(a5 > max) max = a5;
if(a6 > max) max = a6;
if(a7 > max) max = a7;
if(a8 > max) max = a8;
if(a9 > max) max = a9;

Console.WriteLine(max);
*/

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int a2 = 2156;
int a3 = 39;
int a4 = 12;
int a5 = 223;
int a6 = 33;
int a7 = 113;
int a8 = 23;
int a9 = 333;

int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);
Console.WriteLine(max);