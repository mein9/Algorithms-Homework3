namespace Homework3.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BubbleSort_UnsortedArray_ArrayShouldBeSortedDesc()
        {
            Student[] students = {
                new Student("Matt", 3.8),
                new Student("Rich", 2.6),
                new Student("Adam", 3.2),
                new Student("Alexei", 3.7),
                new Student("Stella", 4.0)
            };
            Program.BubbleSort(students);
            Assert.AreEqual(4.0, students[0].gpa);
            Assert.AreEqual(2.6, students[students.Length - 1].gpa);
        }

        [TestMethod()]
        public void BubbleSort_EmptyArray_ShouldReturnEmptyArray()
        {
            Student[] students = { };
            Program.BubbleSort(students);
            Assert.AreEqual(0, students.Length);
        }

        [TestMethod()]
        public void BubbleSort_SortedArray_ArrayShouldBeSortedDesc()
        {
            Student[] students = {
                new Student("Stella", 4.0),
                new Student("Matt", 3.8),
                new Student("Alexei", 3.7),
                new Student("Adam", 3.2),
                new Student("Rich", 2.6)
            };
            Program.BubbleSort(students);
            Assert.AreEqual(4.0, students[0].gpa);
            Assert.AreEqual(2.6, students[students.Length - 1].gpa);
        }

        [TestMethod()]
        public void SelectionSort_UnsortedArray_ArrayShouldBeSortedDesc()
        {
            Student[] students = {
                new Student("Matt", 3.8),
                new Student("Rich", 2.6),
                new Student("Adam", 3.2),
                new Student("Alexei", 3.7),
                new Student("Stella", 4.0)
            };
            Program.SelectionSort(students);
            Assert.AreEqual(4.0, students[0].gpa);
            Assert.AreEqual(2.6, students[students.Length - 1].gpa);
        }

        [TestMethod()]
        public void SelectionSort_EmptyArray_ShouldReturnEmptyArray()
        {
            Student[] students = { };
            Program.SelectionSort(students);
            Assert.AreEqual(0, students.Length);
        }

        [TestMethod()]
        public void InsertionSort_UnsortedArray_ArrayShouldBeSortedDesc()
        {
            Student[] students = {
                new Student("Matt", 3.8),
                new Student("Rich", 2.6),
                new Student("Adam", 3.2),
                new Student("Alexei", 3.7),
                new Student("Stella", 4.0)
            };
            Program.InsertionSort(students);
            Assert.AreEqual(4.0, students[0].gpa);
            Assert.AreEqual(2.6, students[students.Length - 1].gpa);
        }

        [TestMethod()]
        public void InsertionSort_EmptyArray_ShouldReturnEmptyArray()
        {
            Student[] students = { };
            Program.InsertionSort(students);
            Assert.AreEqual(0, students.Length);
        }
    }
}