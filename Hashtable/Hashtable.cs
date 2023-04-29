namespace Hashtable
{
    public class Hashtable<T>
    {
        private Item<T>[] items;

        public Hashtable(int size)
        {
            items = new Item<T>[size];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }

        public void Add(T item)
        {
            var key = GetHash(item);
            items[key].Nodes.Add(item);
        }

        public void Remove(T item)
        {
            var key = GetHash(item);
            if (items[key].Nodes != null)
                items[key].Nodes.Remove(item);
            return;
        }
        public bool Search(T item)
        {
            var key = GetHash(item);
            return items[key].Nodes.Contains(item);

        }
        private int GetHash(T item)
        {
            return Math.Abs(item.GetHashCode() % items.Length);
        }
    }
}
