using System.Globalization;
void DuplicateZeros(int[] arr)
{
    for(int i=0; i < arr.Length - 1;i++ )
    {
        if (arr[i] == 0) {
            
            for(int j = arr.Length -1; j > i+1; j-- )
            {
                arr[j] = arr[j-1];
            }
            arr[i + 1] = 0;
            i++;
        }
    }

    Console.WriteLine(arr);
}
int[] array = { 1, 2, 0, 3, 4, 5 , 0, 0, 0, 0};
DuplicateZeros(array);
