
namespace Homework3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a sorting Algorithm:");
            Console.WriteLine("1: Bubble Sort");
            Console.WriteLine("2: Selection Sort");
            Console.WriteLine("3: Insertion Sort");

            string? userSelection = Console.ReadLine();

            Student student1 = new Student("Matt", 3.8);
            Student student2 = new Student("Rich", 2.6);
            Student student3 = new Student("Adam", 3.2);
            Student student4 = new Student("Alexei", 3.7);
            Student student5 = new Student("Stella", 4.0);

            Student[] students = { student1, student2, student3, student4, student5 };

            switch (userSelection)
            {
                case "1":
                    // bubble Sort
                    BubbleSort(students);
                    Console.Write("Bubble Sort: ");
                    PrintArray(students);
                    break;

                case "2":
                    // selection sort
                    SelectionSort(students);
                    Console.Write("Selection Sort: ");
                    PrintArray(students);
                    break;

                case "3":
                    // insertion sort
                    InsertionSort(students);
                    Console.Write("Insertion Sort: ");
                    PrintArray(students);
                    break;

                default:
                    // none match 
                    break;

            }
        }
        public static void PrintArray(Student[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($" {item.name} : {item.gpa} ");
            }
            Console.WriteLine();
        }

        public static int BubbleSort(Student[] arrToSort)
        {
            int totalOuterIterations = 0;
            double temp;
            // Overall O(n^2) runtime


            for (int i = 0; i < arrToSort.Length; i++)
            {
                ++totalOuterIterations;
                int swaps = 0;
                for (int j = 0; j < arrToSort.Length - 1 - i; j++)
                {
                    //swap places if j is greater than j + 1
                    if (arrToSort[j].gpa < arrToSort[j + 1].gpa) //change to > to reverse array
                    {
                        swaps++;
                        temp = arrToSort[j].gpa;
                        arrToSort[j].gpa = arrToSort[j + 1].gpa;
                        arrToSort[j + 1].gpa = temp;
                    }
                }
                if (swaps == 0) break;
            }
            return totalOuterIterations;
        }

        public static void SelectionSort(Student[] arrToSort)
        {
            // minIndex keeps track of smallest index in each iteration
            // temp stores the value being swapped
            int minIndex;
            Student temp;

            for (int i = 0; i < arrToSort.Length - 1; i++) // iterate through unsorted elements O(n)
            {
                minIndex = i; // set minIndex to current index

                for (int j = i + 1; j < arrToSort.Length; j++) // iterate through the remaining elements O(n)
                {
                    // update minIndex if the current element is smaller than the element at minIndex
                    if (arrToSort[j].gpa > arrToSort[minIndex].gpa)
                    {
                        minIndex = j;
                    }
                }

                // swap the elements if minIndex is not the current index
                if (minIndex != i)
                {
                    temp = arrToSort[i];
                    arrToSort[i] = arrToSort[minIndex];
                    arrToSort[minIndex] = temp;
                }
            }

        }

        public static void InsertionSort(Student[] arrToSort)
        {

            for (int i = 1; i < arrToSort.Length; i++)
            {
                Student temp = arrToSort[i];  // store element as it might be overwritten
                int priorIndex = i - 1;  //start comparing with element before the current element

                // if prior element is greater than stored element
                // and we have not reached the end of the array
                while (priorIndex >= 0 && arrToSort[priorIndex].gpa < temp.gpa)
                {
                    arrToSort[priorIndex + 1] = arrToSort[priorIndex];
                    priorIndex--;
                }

                arrToSort[priorIndex + 1] = temp; // sets prior index to saved variable
            }
        }

    }
}
