using System.Text;

int[] ParseStringToIntArray(string? text)
{
    if(text==null)return new int[0];
    int[] preResult=new int[text.Length];
    int count=0;
    StringBuilder numString=new StringBuilder();
    int numInt;
    for(int i=0;i<text.Length;i++)
    {
        if((text[i]>='0'&&text[i]<='9')||(text[i]=='-'&&numString.Length==0))
        {
            numString.Append(text[i]);
        }
        else
        {
            if(Int32.TryParse(numString.ToString(),out numInt))
            {
                preResult[count]=numInt;
                count++;  
            }
            numString.Clear();
        }
    }
    if(Int32.TryParse(numString.ToString(),out numInt))
    {
        preResult[count]=numInt;
        count++;
    }
    int[] result=new int[count];
    Array.Copy(preResult,result,count);
    return result;
}
void PrintArray(int[] array)
{
    if(array.Length==0)return;
    Console.Write("[");
    for(int i=0;i<array.Length-1;i++)
        Console.Write(array[i]+", ");
    Console.Write(array[array.Length-1]+"]");
}
int CountPositive(int[] array)
{
    int count=0;
    for(int i=0;i<array.Length;i++)
        if(array[i]>0)count++;
    return count;
}
Console.WriteLine("Введите массив в свободной форме");
string? input=Console.ReadLine();
int[] array = ParseStringToIntArray(input);
PrintArray(array);
Console.WriteLine(" -> "+CountPositive(array));