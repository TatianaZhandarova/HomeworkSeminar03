double [] array = FillArray(10);
PrintArray(array);
Console.WriteLine();
double diff = MaxMinDiff(array);
Console.WriteLine($"diff = {diff}");

double [] FillArray(int count){
    double[] numbers = new double[count];
    int index = 0;
    while(index<numbers.Length){
        numbers[index] = new Random().NextDouble()*100;
        index++;
    }
    return numbers;
}

void PrintArray(double[] col )
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

double MaxMinDiff(double [] arr){
    double diff;
    double max = 0;
    double min = 0;
    for(int i = 0; i<arr.Length; i++){
        for(int j = 0; j<arr.Length-1; j++){
            if(arr[j]>arr[j+1]){
                double temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }
        }
    }
    //Array.Sort(array);
    min = arr[0];
    max = arr[arr.Length-1];
    diff = max-min;
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"max = {max}");
    return diff;
}