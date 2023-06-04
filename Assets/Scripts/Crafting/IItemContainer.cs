public interface IItemContainer
{
    int ItemCount(Item item);
    bool ContainsItem(Item item);
    void Remove(Item item);
    void Add(Item item);
}
