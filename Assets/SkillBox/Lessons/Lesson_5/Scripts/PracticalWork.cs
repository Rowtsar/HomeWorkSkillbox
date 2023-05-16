using System;
using System.Linq;
using UnityEngine;

public class PracticalWork : MonoBehaviour
{
    /// <summary>
    /// Метод обработки события OnClick кнопки "Сумма четных чисел заданного диапазона"
    /// </summary>
    public void OnSumEvenNumbersInRange()
    {
        int min = 7;
        int max = 21;
        var want = 98;
        int got = SumEvenNumbersInRange(min, max);
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в диапазоне от {min} до {max} включительно: {got} - {message}");
    }

    private int SumEvenNumbersInRange(int min, int max)
    {
        int sumNumber = 0;
        for(int i = min; i < max; i++)
        {
            if (i % 2 == 0)
                sumNumber += i;
        }  
        return sumNumber;
    }
    /////////////////////////////////////

    public void OnSumEvenNumbersInArray()
    {
        int[] array = { 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
        int want = 214;
        int got = SumEvenNumbersInArray(array);
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Сумма четных чисел в заданном массиве: {got} - {message}");
    }

   
    private int SumEvenNumbersInArray(int[] array)
    {
        int sumNumInArray = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sumNumInArray += array[i];
            }
        }
        return sumNumInArray;
    }


    //////////////////////////////////////

    public void OnFirstOccurrence()
    {
        // Первый тест, число присутсвует в массиве
        int[] array = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        int value = 34;
        int want = 3;
        int got = FirstOccurrence(array, value);
        string message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");

        // Второй тест, число не присутсвует в массиве
        array = new int[] { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68, 55 };
        value = 55;
        want = 10;
        got = FirstOccurrence(array, value);
        message = want == got ? "Результат верный" : $"Результат не верный, ожидается {want}";
        Debug.Log($"Индекс первого вхождения числа {value} в массив: {got} - {message}");
    }


    private int FirstOccurrence(int[] array, int value)
    {
        int indexNum = 0;

        for(int i  = 0 ; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                indexNum = i;
                break;
            }
            else
                indexNum = -1;
        }
        return indexNum;
    }

    ////////////////////////////////////////////////

    public void OnSelectionSort()
    {
        int[] originalArray = { 81, 22, 13, 34, 10, 34, 15, 26, 71, 68 };
        Debug.LogFormat("Исходный массив {0}", "[" + string.Join(",", originalArray) + "]");

        int[] sortedArray = SelectionSort((int[])originalArray.Clone());
        Debug.LogFormat("Результат сортировки {0}", "[" + string.Join(",", sortedArray) + "]");

        int[] expectedArray = { 10, 13, 15, 22, 26, 34, 34, 68, 71, 81 };
        Debug.Log(sortedArray.SequenceEqual(expectedArray) ? "Результат верный" : "Результат не верный");
    }

    private int[] SelectionSort(int[] array)
    {
        int tempBox = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    tempBox = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tempBox;
                }
            }
        }

        Array.Sort(array);

        return array;
    }
}