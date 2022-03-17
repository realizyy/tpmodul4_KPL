namespace tpmodul4_1302204035;

public class DataGeneric<T>
{
    private List<T> data;
    public DataGeneric()
    {
        data = new List<T>();
    }
    
    public void Add(T item)
    {
        data.Add(item);
        System.Console.WriteLine("Data yang tersimpan adalah : " + item);
    }

    public void PrintData()
    {
        foreach (T item in data)
        {
            System.Console.WriteLine("Nim : " + item);
        }
    }
    
    /*public T PrintData(int index)
    {
        return data[index];
    }*/
}