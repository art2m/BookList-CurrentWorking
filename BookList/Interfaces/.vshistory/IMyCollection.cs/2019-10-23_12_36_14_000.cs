namespace BookList.Interfaces
{
    public interface IMyCollection
    {
        void AddItem(string item);
        void ClearCollection();
        bool ContainsItem(string value);
        string[] GetAllItems();
        string GetItemAt(int index);
        int GetItemIndex(string value);
        int GetItemsCount();
        bool RemoveItem(string value);
        bool RemoveItemAt(int index);
        void SortCollection();
    }
}