namespace Hashtable
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new Hashtable<string>(40);

            hashTable.Add("Martin");
            hashTable.Add("Roma");
            hashTable.Add("Jack");
            Console.WriteLine(hashTable.Search("Martin"));
            hashTable.Remove("Martin");
            Console.WriteLine(hashTable.Search("Martin"));
        }
    }
}