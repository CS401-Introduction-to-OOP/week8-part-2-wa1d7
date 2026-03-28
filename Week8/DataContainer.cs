namespace Week8;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();
 
    public void AddItem(T item)
    {
        _items.Add(item);
    }
 
    public long GetTotalSize()
    {
        long total = 0;
        foreach (var item in _items)
        {
            total += item.GetSize();
        }
        return total;
    }
}
