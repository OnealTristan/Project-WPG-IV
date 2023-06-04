public interface IItemContainer
{
    int ItemCount(Item item);
    bool ContainsItem(Item item);
    bool Remove(Item item);
    void Add(Item item);
}
