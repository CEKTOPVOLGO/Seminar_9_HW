Console.Clear();
int num = TaskNumber("Введите номер задачи: 64 или 66 или 68: ", "Ошибка ввода!");
if (num == 64) FirstTask();
else if (num == 66) SecondTask();
else ThirdTask();


void FirstTask()
{
int N = UserNumber("Введите первое число N: ", "Ошибка ввода!");
int M = UserNumber("Введите второе число M: ", "Ошибка ввода!");
Console.Write("M -> N = \"" + Numbers(N, M) + "\"");
}

void SecondTask()
{
int N = UserNumber("Введите первое число M: ", "Ошибка ввода!");
int M = UserNumber("Введите второе число N: ", "Ошибка ввода!");
Console.WriteLine("Сумма M и N = " + SumRecur(N, M));
}

void ThirdTask()
{
int N = UserNumber("Введите первое число :", "Ошибка ввода!");
int M = UserNumber("Введите второе число :", "Ошибка ввода!");
Console.WriteLine($"N = {N}, M = {M} -> A(N, M) = {Akkerman(N, M)}");
}

int Akkerman(int N, int M)
{
  if (N == 0)
    return M + 1;
  else
    if ((N != 0) && (M == 0))
      return Akkerman(N - 1, 1);
    else
      return Akkerman(N - 1, Akkerman(N, M - 1));
}

int SumRecur(int N, int M)
{
    if (N == M) return M;
    else
    {
        return N + SumRecur(N + 1, M);
    }
}  

string Numbers(int start, int end)
{    
    if(start == end) return start.ToString();
    else return end + " " + Numbers(start, end - 1);
}

int TaskNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect && (userNumber == 64 || userNumber == 66 || userNumber == 68))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int UserNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
