// Регистрозависимость
Console.WriteLine("Hello");
// Console.writeline("Hello"); // error

// однострочный комментарий
/*
многострочный комментарий
*/

// переменные
//int countStudentGroup;
// константы
//const int maxStudentGroup = 10;

// литералы
/*
var n = 10; // 10 - int
var b1 = 0b01101; // 0b01101 - binary int
var h1 = 0x1A7F; // 0x1A7F - hex int
var ln = 123L; // 123L


var x = 0.5; // 10.5 - double
var y = 0.5F; // 0.5F - float
var z = 0.5M; // 0.5M - decimal
var e = 123.78e-2; // 


var ch1 = '#';
var ch2 = '\x78'; // ASCII char
var ch3 = '\u0050'; // Unicode char

var s = "Hello"; // string

Console.WriteLine(s);
*/
//double x;
//Double.TryParse(Console.ReadLine(), out x);

//int n = Convert.ToInt32(Console.ReadLine());

// арфиметические операции
/*
 
+, -, *, /, %, ++, --

*/

// операции сравнения
/*

>, <, >=, <=, !=, == 

*/

// логические операции
/*

&&, &
||, |
!,
^

*/

int n = 10;
if(n < 0 && ++n < 20)
    Console.WriteLine("Hello");
Console.WriteLine(n);

// побитовые операции
/*

&, |, ^, ~, <<, >>

*/

// операции присваивания
/*

=, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=

*/

// условные конструкции
/*
if(true)
{

}

if(false)
{

}
else
{

}

if (false)
{

}
else if(true)
{

}
else
{

}

int nn = (true) ? 10 : 20;

switch(nn)
{
    case 1: Console.WriteLine("Hello 1"); break;
    case 2: Console.WriteLine("Hello 2"); goto case 4;
    case 3: Console.WriteLine("Hello 3"); break;
    case 4: Console.WriteLine("Hello 4"); break;
    default:
        break;
}
*/

// циклы
/*
while(n > 0)
{

}

do
{

}while(n > 0);

for(int i = 0; i < n; i++)
{

}

foreach(int i in n)
{

}
*/

// массивы
/*
int[] ints = new int[n];
Array ints2 = new int[n];

int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
int[] arr2 = new int[] { 1, 2, 3 };
int[] arr3 = { 1, 2, 3, 4, 5, 6 };

for(int i = 0; i < arr3.Length; i++)
    Console.WriteLine(arr3[i]);

for (int i = 0; i < arr3.Length; i++)
    Console.WriteLine(arr3[arr3.Length - i - 1]);


Console.WriteLine(arr3[^1]); // arr3[^1] === arr3[arr3.Length - 1]
for (int i = 1; i <= arr3.Length; i++)
    Console.WriteLine(arr3[^i]);

foreach (int item in arr3)
    Console.WriteLine(item);
*/
/*
int[,] matrix = new int[5, 6];
int[,,] cube = new int[3, 4, 5];

int rows = matrix.GetUpperBound(0) + 1;
int cols = matrix.GetUpperBound(1) + 1;

Console.WriteLine(rows);
Console.WriteLine(cols);

for (int i = 0; i < rows; i++)
    for (int j = 0; j < cols; j++)
        matrix[i, j] = i + j + 1;

int[][] zmatr = new int[3][];
for (int i = 0; i < zmatr.Length; i++)
    zmatr[i] = new int[i + 1];
*/

int a = 10;
byte b = 20;
byte c = (byte)(b + 20);

float x = 10.5F;
double y = 20.4;

y = x;
x = (float)y;

a = (int)x;
x = a;

a = 345;


byte b3 = (byte)a;
Console.WriteLine(b3);


