namespace BubbleSort
{

    internal class Program
    {
        static void Main(string[] args)

        {
            //Erstellen Sie ein int Array mit den Werten 4, 33, 7, 1, 23, 12 in genau dieser Reihenfolge.
            //Schreiben Sie dann einen Bubblesort um die Zahlen aufsteigend, von der kleinsten bis zur größten Zahl, zu sortieren. 
            //Lassen Sie sich zur Kontrolle dann das sortierte Array ausgeben. 
            //Keine verwendung der .Sort() Methode oder ähnlichen Methoden sind zulässig!

             int[] array = { 4, 33, 7, 1, 23, 12 };
             int temporary;

             for (int j = 0; j <= array.Length - 2; j++)
             {
                 for (int i = 0; i <= array.Length - 2; i++)
                 {
                     if (array[i] > array[i + 1])
                     {
                         temporary = array[i + 1];
                         array[i + 1] = array[i];
                         array[i] = temporary;
                     }
                 }
             }

             Console.WriteLine("aufsteigend:");
             foreach (int n in array)
             {
                 Console.Write($"{n} ");
             }
             Console.ReadLine();

            
            /*Console.Clear();
            string[] array = { "Apple", "Samsung", "Nokia", "Siemens", "Motorola" };
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
            {
                Console.WriteLine(array[array.Length -2]);

            }*/
        }
    }
}
    

