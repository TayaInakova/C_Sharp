// Допустим, пользователь не будет вводить НЕ целые числа.

int[] UserInput()
{
    Console.WriteLine("Ведите числа через запятую:");
    string? userText = Console.ReadLine();
    userText = userText!.Replace(" ", "");
    userText = userText!.Replace(";", "");
    userText = userText!.Replace("/", "");
    string[]? userTextArray = userText.Split(",");
    int[] userNumberArray = new int[userTextArray.Length];
    int size = userTextArray.Length;
    for (int i = 0; i < size; i++)
    {
        userNumberArray[i] = Convert.ToInt32(userTextArray[i]);
    };
    return userNumberArray;
};

int QuantityGreaterThanZero(int[] array)
{
    int count = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
};

void Start()
{
    int quantity = QuantityGreaterThanZero(UserInput());
    Console.WriteLine($"Количество введенных положительных чисел: {quantity}");
}
Start();