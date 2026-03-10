public class Program
{
    static int SeqSearch(int[] arr, int value)
    {
        int i = 0;
        while(arr[i]!=value)
            i++;
        return i;
    }
    static int RecuSearch(int[] arr, int from, int value)
    {
        if(arr[from]==value)
            return from;
        else
            return RecuSearch(arr, from+1, value);
    }
    static int RecuSearch2(Array arr, int value)
    {
        int from = arr.GetLowerBound(0);
        if((int)arr.GetValue(from)==value)
            return from;
        else{
            Array newarr = Array.CreateInstance(
                    typeof(int),
                    new int[]{arr.Length-1},
                    new int[]{from+1}
            );
            for(int i=newarr.GetLowerBound(0); 
                            i<=newarr.GetUpperBound(0); i++)
                newarr.SetValue(arr.GetValue(i), i);
            return RecuSearch2(newarr, value);
        }
    }
    /* Xây dựng RecuSearch3 cải tiến từ RecuSearch2 với vị
       trí đánh dấu ở giữa */
    static int RecuSearch3(Array arr, int value)
    {
        return 0;
    }
    static void Main(string[] args)
    {
        int[] a = {4, 1, 9, 6};
        int val = 9;
        int index1 = SeqSearch(a, val);
        Console.WriteLine($"SeqSearch: {index1}");
        int index2 = RecuSearch(a, 0, val);
        Console.WriteLine($"SeqSearch: {index2}");

        Array ar = Array.CreateInstance(typeof(int), 4);
        ar.SetValue(3, 0); ar.SetValue(7, 1);
        ar.SetValue(4, 2); ar.SetValue(6, 3);
        int v = 4;
        int index3 = RecuSearch2(ar, v);
        Console.WriteLine($"RecuSearch2: {index3}");
    }
}