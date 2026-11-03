/*
 * Student ID : 1680707666
 * Name       : WEERAPAT PROMPAT
 * Section    : 129A
 * No.        : 8
 * Course     : GI113 Computer Programming (GI)
 */
using UnityEngine;

public class Lab11 : MonoBehaviour
{
    // Step 1: one array that stores 8 numbers (Part B: numbers are changed in the Inspector)
    [SerializeField] int[] numbers = { 12, 7, 30, 4, 19, 25, 9, 18 };

    int sum;
    float average;
    int maximum;
    int minimum;

    void Start()
    {
        // Step 2: print every number
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log("Number " + (i + 1) + ": " + numbers[i]);
        }

        // Step 3: sum and average
        sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        average = (float)sum / numbers.Length;
        Debug.Log("Sum: " + sum);
        Debug.Log("Average: " + average);

        // Step 4: maximum and minimum, both start from the first number
        maximum = numbers[0];
        minimum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }
        Debug.Log("Maximum: " + maximum);
        Debug.Log("Minimum: " + minimum);

        // Step 5: sort, then print again
        System.Array.Sort(numbers);
        foreach (int n in numbers)
        {
            Debug.Log("Sorted: " + n);
        }
    }
}
