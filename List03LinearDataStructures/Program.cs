// See https://aka.ms/new-console-template for more information


// ============================================================
// EXERCISE 1 - ARRAYS
// ============================================================
int[] numbers;
Random rand = new Random();
numbers = new int[10];
//creating random numbers between 10 and 90
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(10, 91);
}

//a
bool found = false;
foreach (int number in numbers)
{
    if (number == 50)
    {
        Console.WriteLine("Found 50!");
        found = true;
        break;
    }
}
if (!found)
{
    Console.WriteLine("50 not found.");
}

//b
int count50 = 0;
foreach (int number in numbers)
    if (number == 50)
        count50++;
Console.WriteLine($"50 appears {count50} times.");


//c
float average = 0.0f;
foreach (int number in numbers)
    average += number;
average /= numbers.Length;
Console.WriteLine($"Average: {average}");

//d
int min, max;
min = max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
    if (numbers[i] < min)
        min = numbers[i];
    else if (numbers[i] > max)
        max = numbers[i];

//e
long sum, product;
sum = 0;
product = 1;
foreach (int number in numbers)
{
    sum += number;
    product *= number;
}

//f
for (int i = numbers.Length - 1; i >= 0; i--)
    Console.Write(numbers[i] + " ");

//g
int[] reverseNumbers = new int[numbers.Length];
for (int i = 0, j = numbers.Length - 1; i < numbers.Length; i++, j--)
    reverseNumbers[i] = numbers[j];

//h
int evenCount = 0, oddCount = 0;
foreach (int number in numbers)
    if (number % 2 == 0)
        evenCount++;
    else
        oddCount++;
int[] evenNumbers = new int[evenCount];
int[] oddNumbers = new int[oddCount];
evenCount = oddCount = 0;
foreach (int number in numbers)
    if (number % 2 == 0)
        evenNumbers[evenCount++] = number;
    else
        oddNumbers[oddCount++] = number;

int fernando = 10;
Console.WriteLine(fernando++); // prints 10     
Console.WriteLine(++fernando); // prints 12 
Console.WriteLine(--fernando); // prints 11

// ============================================================
// EXERCISE 2 - VALUES * INDEX
// ============================================================
Console.Write("\nenter how many integers (n > 0): ");
int n = int.Parse(Console.ReadLine());
int[] values = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"value {i + 1}: ");
    values[i] = int.Parse(Console.ReadLine());
}
Console.Write("result: ");
for (int i = 0; i < n; i++)
    Console.Write(values[i] * i + " ");
Console.WriteLine();
// ============================================================
// EXERCISE 3 - DICE THROWS
// ============================================================
Console.Write("\nenter number of throws: ");
int throwsN = int.Parse(Console.ReadLine());
int[] throwsCount = new int[6];
for (int i = 0; i < throwsN; i++)
{
    int face = rand.Next(1, 7);
    throwsCount[face - 1]++;
}

Console.WriteLine($"number of throws: {throwsN}");
for (int i = 0; i < 6; i++)
{
    double percent = (double)throwsCount[i] / throwsN * 100;
    Console.WriteLine($"face {i + 1}: {throwsCount[i]} ({percent:F2}%)");
}
// ============================================================
// EXERCISE 4 - MATRIX 4x4
// ============================================================
int[,] matrix = new int[4, 4];
Console.WriteLine("\nenter 16 integers (4x4 matrix):");
for (int i = 0; i < 4; i++)
    for (int j = 0; j < 4; j++)
        matrix[i, j] = int.Parse(Console.ReadLine());

int totalSum = 0;
for (int i = 0; i < 4; i++)
    for (int j = 0; j < 4; j++)
        totalSum += matrix[i, j];
Console.WriteLine($"total sum: {totalSum}");

int sumSecondRow = 0;
for (int j = 0; j < 4; j++)
    sumSecondRow += matrix[1, j];
Console.WriteLine($"sum of 2nd row: {sumSecondRow}");

int sumThirdColumn = 0;
for (int i = 0; i < 4; i++)
    sumThirdColumn += matrix[i, 2];
Console.WriteLine($"sum of 3rd column: {sumThirdColumn}");

Console.Write("main diagonal: ");
for (int i = 0; i < 4; i++)
    Console.Write(matrix[i, i] + " ");
Console.WriteLine();

Console.Write("decondary diagonal: ");
for (int i = 0; i < 4; i++)
    Console.Write(matrix[i, 3 - i] + " ");
Console.WriteLine();

// ============================================================
// EXERCISE 5 - MAGIC SQUARE
// ============================================================
Console.Write("\nenter size n for square matrix: ");
int size = int.Parse(Console.ReadLine());
int[,] square = new int[size, size];

Console.WriteLine($"enter {size * size} integers:");
for (int i = 0; i < size; i++)
    for (int j = 0; j < size; j++)
        square[i, j] = int.Parse(Console.ReadLine());

bool isMagic = true;
int sumDiag1 = 0, sumDiag2 = 0;
int refSum = 0;

for (int j = 0; j < size; j++)
    refSum += square[0, j];

// check rows
for (int i = 0; i < size; i++)
{
    int sumRow = 0;
    for (int j = 0; j < size; j++)
        sumRow += square[i, j];
    if (sumRow != refSum)
        isMagic = false;
}

// check columns
for (int j = 0; j < size; j++)
{
    int sumCol = 0;
    for (int i = 0; i < size; i++)
        sumCol += square[i, j];
    if (sumCol != refSum)
        isMagic = false;
}

// check diagonals
for (int i = 0; i < size; i++)
{
    sumDiag1 += square[i, i];
    sumDiag2 += square[i, size - 1 - i];
}

if (sumDiag1 != refSum || sumDiag2 != refSum)
    isMagic = false;

if (isMagic)
    Console.WriteLine("magic square!");
else
    Console.WriteLine("not a magic square.");
// ============================================================
// LIST
// ============================================================
List<int> list = new List<int>();
int option;
do
{
    Console.WriteLine("\n=== LIST MENU ===");
    Console.WriteLine("1) Add number");
    Console.WriteLine("2) Remove number");
    Console.WriteLine("3) Remove by position");
    Console.WriteLine("4) Print list");
    Console.WriteLine("5) Print reversed");
    Console.WriteLine("6) Count elements");
    Console.WriteLine("7) Clear list");
    Console.WriteLine("8) Exit");
    Console.Write("Option: ");
    if (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }
    switch (option)
    {
        case 1:
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                list.Add(num);
            }
            break;
        case 3:
            Console.Write("Enter position: ");
            if (int.TryParse(Console.ReadLine(), out int pos) && pos >= 0 && pos < list.Count)
            {
                list.RemoveAt(pos);
                Console.WriteLine("Element removed.");
            }
            else
            {
                Console.WriteLine("Invalid position.");
            }
            break;
        case 4:
            Console.WriteLine("List: " + string.Join(" ", list));
            break;
        case 5:
            Console.WriteLine("Reversed: " + string.Join(" ", list.AsEnumerable().Reverse()));
            break;
        case 6:
            Console.WriteLine($"List has {list.Count} elements.");
            break;
        case 7:
            list.Clear();
            Console.WriteLine("List cleared.");
            break;
        case 8:
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
} while (option != 8);

// ============================================================
// STACK
// ============================================================
Stack<int> stack = new Stack<int>();
int option;
do
{
    Console.WriteLine("\n=== STACK MENU ===");
    Console.WriteLine("1) Push");
    Console.WriteLine("2) Pop");
    Console.WriteLine("3) Peek");
    Console.WriteLine("4) Count");
    Console.WriteLine("5) Clear");
    Console.WriteLine("6) Exit");
    Console.Write("Option: ");
    if (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }
    switch (option)
    {
        case 1:
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                stack.Push(num);
                Console.WriteLine("Number pushed.");
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
            break;
        case 2:
            if (stack.Count > 0)
                Console.WriteLine($"Popped: {stack.Pop()}");
            else
                Console.WriteLine("Stack is empty.");
            break;
        case 3:
            if (stack.Count > 0)
                Console.WriteLine($"Top: {stack.Peek()}");
            else
                Console.WriteLine("Stack is empty.");
            break;
        case 4:
            Console.WriteLine($"Stack has {stack.Count} elements.");
            break;
        case 5:
            stack.Clear();
            Console.WriteLine("Stack cleared.");
            break;
        case 6:
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
} while (option != 6);


// ============================================================
// QUEUE
// ============================================================
Queue<string> queue = new Queue<string>();
int option;
do
{
    Console.WriteLine("\n=== QUEUE MENU ===");
    Console.WriteLine("1) Enqueue");
    Console.WriteLine("2) Dequeue");
    Console.WriteLine("3) Peek");
    Console.WriteLine("4) Print all");
    Console.WriteLine("5) Count");
    Console.WriteLine("6) Clear");
    Console.WriteLine("7) Exit");
    Console.Write("Option: ");
    if (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }
    switch (option)
    {
        case 1:
            Console.Write("Enter string: ");
            queue.Enqueue(Console.ReadLine());
            Console.WriteLine("String enqueued.");
            break;
        case 2:
            if (queue.Count > 0)
                Console.WriteLine($"dequeued: {queue.Dequeue()}");
            if (queue.Count > 0)
                Console.WriteLine($"dequeued: {queue.Dequeue()}");
            else
                Console.WriteLine("Queue is empty.");
            break;
        case 3:
            if (queue.Count > 0)
                Console.WriteLine($"front: {queue.Peek()}");
            else
                Console.WriteLine("queue is empty.");
            break;
        case 4:
            Console.WriteLine("queue contents: " + string.Join(" ", queue));
            break;
        case 5:
            Console.WriteLine($"queue has {queue.Count} elements.");
            break;
        case 6:
            queue.Clear();
            Console.WriteLine("queue cleared.");
            break;
        case 7:
            break;
        default:
            Console.WriteLine("invalid option.");
            break;
    }
} while (option != 7);

