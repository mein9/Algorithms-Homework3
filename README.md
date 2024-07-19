# Algorithms Homework3

## Report on Adapting Sorting Algorithms to Sort Students by GPA in Descending Order

### Methodology for Adapting the Algorithms

To adapt the sorting algorithms to sort students by GPA in descending order, 
I modified the comparison conditions within each algorithm. Specifically, 
I changed the conditions to prioritize higher GPA values over lower ones. This involved:

1. **Bubble Sort:**
    - Modified the comparison condition from `arrToSort[j] > arrToSort[j + 1]` to 
    - `arrToSort[j].gpa < arrToSort[j + 1].gpa`.
    
2. **Selection Sort:**
    - Changed the condition to update `minIndex` from `arrToSort[j] < arrToSort[minIndex]`
    - to `arrToSort[j].gpa > arrToSort[minIndex].gpa`.
    
3. **Insertion Sort:**
    - Altered the `while` loop condition from `arrToSort[priorIndex] > temp` to 
    - `arrToSort[priorIndex].gpa < temp.gpa`.

These changes ensured that each algorithm sorted the array in descending order based on the GPA field.

### Challenges Encountered and Strategies Employed

1. **Ensuring Correct Comparisons:**
    - The primary challenge was ensuring that the comparison conditions were accurately modified. 
    - Misinterpreting the logic could result in incorrect sorting. I carefully reviewed the conditions and 
    - tested each algorithm to confirm correctness.
    
2. **Maintaining Code Readability:**
    - Ensuring that the code remained readable and maintainable after modifications was another challenge.
    - I addressed this by adding comments and maintaining consistent naming conventions.
    
3. **Testing and Validation:**
    - Verifying the correctness of the modified algorithms required thorough testing with various input scenarios.
    - I employed sample data and printed the sorted arrays to validate the output.

### Example Outputs

Here are example outputs demonstrating the sorted student list in descending order for each algorithm:

1. **Bubble Sort:**
    - Output: `Stella : 4.0 Matt : 3.8 Alexei : 3.7 Adam : 3.2 Rich : 2.6`
    
2. **Selection Sort:**
    - Output: `Stella : 4.0 Matt : 3.8 Alexei : 3.7 Adam : 3.2 Rich : 2.6`
    
3. **Insertion Sort:**
    - Output: `Stella : 4.0 Matt : 3.8 Alexei : 3.7 Adam : 3.2 Rich : 2.6`

These outputs confirm that each algorithm correctly sorts the students by GPA in descending order, 
demonstrating the successful adaptation of the algorithms. 