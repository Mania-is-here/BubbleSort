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

            //Michael

           /* int[] bubbleArray = { 4, 33, 7, 1, 23, 12 };

            Console.WriteLine($" Array vor der sortierung : {string.Join("-", bubbleArray)}");

            for(int elementIndex =0; elementIndex < bubbleArray.Length; elementIndex++)
            {
               // Console.WriteLine = (bubbleArray[elementIndex]);
               for(int sortierSchleife =0; sortierSchleife < bubbleArray.Length; sortierSchleife++)
                {
                    if(bubbleArray[sortierSchleife] > bubbleArray[sortierSchleife+1])
                    {
                        Console.WriteLine("Der Wert von sortierSchleife ist größer");
                        int temp = bubbleArray[sortierSchleife +1];
                        bubbleArray[sortierSchleife +1] = bubbleArray[sortierSchleife];
                        bubbleArray[sortierSchleife] = temp;
                    }
                }
            }
            Console.WriteLine($"Sortiert: {string.Join("-", bubbleArray)}"); */
        }
    }
}
    

