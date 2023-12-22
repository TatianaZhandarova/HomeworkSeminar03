int[] array = Numbers(10);

//int -123124 + 1231231  числа без запятых
//float -1231312.0  + 123123.412 числа с плавающей точкой
//bool true false 

//string "sdfsdfsf";  строки
PrintArray(array);
Console.WriteLine();
int sum = NeedElement(array);

if (sum == 0) {
    Console.WriteLine("Отсутсвуют элементы массива, значение которых [20,90]");
} else {
    Console.WriteLine(sum);
}

// i - колличество элементов в массиве
int[] Numbers (int i){
    int[] numbers = new int[i];
    int length = numbers.Length;
    int index = 0;
    while(index<length)
    {
        numbers[index] = new Random().Next(1, 100);
        index++;
    }
    return numbers;
    
}

void PrintArray(int[] csdfsdfsdfkjsdbfjhsbdfol )
{
    int count = csdfsdfsdfkjsdbfjhsbdfol.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(csdfsdfsdfkjsdbfjhsbdfol[position]);
        position++;
    }
}

int NeedElement (int[] arr){
    int index = 0;
    int sum = 0;
    while (index < arr.Length){
        if (19 < arr[index] & arr[index] < 91){
            sum = sum +1;
        
       }
       
    index++;
    }
    return sum;
}

// while (index < array.Length){
//     if(19<array[index] & array[index]>91){
//         count = count + 1;
//     }
// index++;    
// }
// Console.WriteLine(count);
