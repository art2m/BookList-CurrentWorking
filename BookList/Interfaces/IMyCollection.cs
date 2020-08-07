namespace BookList.Interfaces
{
    /// <summary>
    /// Defines the <see cref="IMyCollection" />.
    /// </summary>
    public interface IMyCollection
    {
        /// <summary>
        /// The AddItem.
        /// </summary>
        /// <param name="item">The item<see cref="string" />.</param>
        bool AddItem(string item);

        /// <summary>
        /// The ClearCollection.
        /// </summary>
        void ClearCollection();

        /// <summary>
        /// The ContainsItem.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        bool ContainsItem(string value);

        /// <summary>
        /// The GetAllItems.
        /// </summary>
        /// <returns>The <see cref="string[]" />.</returns>
        string[] GetAllItems();

        /// <summary>
        /// The GetItemAt.
        /// </summary>
        /// <param name="index">The index<see cref="int" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        string GetItemAt(int index);

        /// <summary>
        /// The GetItemIndex.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="int" />.</returns>
        int GetItemIndex(string value);

        /// <summary>
        /// The GetItemsCount.
        /// </summary>
        /// <returns>The <see cref="int" />.</returns>
        int GetItemsCount();

        /// <summary>
        /// The RemoveItem.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        bool RemoveItem(string value);

        /// <summary>
        /// The RemoveItemAt.
        /// </summary>
        /// <param name="index">The index<see cref="int" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        bool RemoveItemAt(int index);

        /// <summary>
        /// The SortCollection.
        /// </summary>
        void SortCollection();
    }
}
