using System.Runtime.InteropServices;

Console.WriteLine("Введите натуральное число:");
int num = Convert.ToInt32(Console.ReadLine());
string str = num + "";
if(CheckNum(num)){
    int [] array = NeedArray(num);
    PrintArray(array);
}

bool CheckNum(int i){
    if (i>=1 && i<=100000){
        return true;
    }
    return false;
}

int [] NeedArray(int j){
    int[] num = new int[j];
    for(int i = 0; i < num.Length; i++){
        if(j<10){
        num[i]=j;
        } 
        if(j>9){
            num[i] = j%10;//0,0
            j /=10;//50,5   
        }
    }
    return num;
}

void PrintArray(int[] col )
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(col[position]);
        position++;
    }
}