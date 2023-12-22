int [] array = NewNumber(10);
PrintArray(array);
Console.WriteLine();
int sum = NeedNumber(array);

if(sum == 0){
    Console.WriteLine("Отсутсвуют четные числа");
} else{
    Console.WriteLine(sum);
}

int [] NewNumber(int i){
    int [] array = new int [i];
    int index = 0;
    while (index<array.Length){
        array [index] = new Random().Next(1, 100);
        index++;
    }
    return array;
}
void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int NeedNumber(int[] count){
    int sum = 0;
    int index = 0;
    while (index < count.Length){
        if(count[index]%2==0){
            sum = sum+1;
        }
    index++;
    }
    return sum;
}