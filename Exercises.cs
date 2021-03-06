﻿using CSharpTraining;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using Xunit.Sdk;

namespace CsharpTraining
{
    public class Exercises
    {
        /// <summary>
        /// Verify if two strings are anagrams
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>
        public static bool AreAnagram(string firstString, string secondString)
        {
            if ((firstString.Length != secondString.Length) ||
                (firstString == secondString))
            {
                return false;
            }

            for (int i = 0; i < firstString.Length; i++)
            {
                if (secondString.Contains(firstString[i]))
                {
                    //secondString = secondString.Replace(firstString[i].ToString(), string.Empty, StringComparison.InvariantCulture);
                    secondString = secondString.Replace(firstString.Substring(i, 1), string.Empty, StringComparison.InvariantCulture);
                }
            }

            return secondString.Trim() == string.Empty;
        }

        /// <summary>
        /// Verify repeteaded chars in string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool AreRepeteadedChars(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Return the sum of all numbers in an array
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int SumAllArrayNumbers(int[] array)
        {
            //int result = array.Sum();
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }

            return result;
        }

        /// <summary>
        /// Return the sum of odd numbers in an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int SumOddNumbers(int[] array)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    result += array[i];
                }
            }

            return result;
        }

        /// <summary>
        /// Return the sum of odd position in an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int SumOddPositions(int[] array)
        {
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result += array[i];
                }
            }

            return result;
        }

        /// <summary>
        /// From a list of words return a list of palindrome
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        //public static List<string> IsPalindromeList(List<string> input)
        //{
        //    List<string> palindromesList = new List<string>();

        //    for (int i = 0; i < input.Count; i++)
        //    {
        //        for (int j = input[i].Length - 1; j >= 0; j--)
        //        {

        //        }
        //    }


        //    return palindromesList;
        //}

        /// <summary>
        /// Suma de los cuadrados de las posiciones pares
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int SumSquaredEvenPositions(int[] array)
        {
            double result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += Math.Pow(array[i], 2);
                }
            }

            return (int)result;
        }

        /// <summary>
        /// Devolver un arreglo con los índices de los números que sean múltiplo de dos.
        /// </summary>
        /// <param name = "array" ></ param >
        /// < returns ></ returns >
        public static int[] IndexOfOddValues(int[] array)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result.Add(i);
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Devolver un arreglo con los índices de los números que sean múltiplo de dos.
        /// </summary>
        /// <param name = "array" ></ param >
        /// < returns ></ returns >
        public static int[] IndexOfOddValues(Data data)
        {
            return IndexOfOddValues(data.Values);
        }

        /// <summary>
        /// Devolver el valor máximos de un arreglo
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int GetMax(int[] values)
        {
            int maxValue = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > maxValue)
                {
                    maxValue = values[i];
                }
            }

            return maxValue;
        }

        /// <summary>
        /// Reverse the string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ReverseString(string input)
        {
            string result = string.Empty;

            List<char> inputChars = input.ToList();

            //for (int i = inputChars.Count - 1; i >= 0; i--)
            //{
            //    result += inputChars[i].ToString();
            //}

            for (int i = 0; i < inputChars.Count; i++)
            {
                result += inputChars[inputChars.Count - 1 - i].ToString();
            }

            return result;
        }

        /// <summary>
        /// Sort ascendent values
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] SortAscValues(int[] input)
        {
            int length = input.Length;

            int[] result = new int[length];

            input.CopyTo(result, 0);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (result[i] < result[j])
                    {
                        Swap(result, i, j);
                    }
                }
            }

            return result;
        }

        private static void Swap(int[] values, int i, int j)
        {
            int aux = values[i];
            values[i] = values[j];
            values[j] = aux;
        }

        /// <summary>
        /// Get the char more repeated
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<Element> GetMostRepeatedCharAndMax(List<string> inputs)
        {
            return inputs.Select(x => GetMostRepeatedChar(x)).ToList();

        }

        /// <summary>
        /// Get the char more repeated
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Element GetMostRepeatedChar(string input)
        {
            char maxChar = ' ';
            int maxCount = 0;
            int tmpCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                tmpCount = input.Count(c => c == input[i]);

                if (tmpCount > maxCount)
                {
                    maxCount = tmpCount;
                    maxChar = input[i];
                }
            }

            return new Element(maxCount, maxChar);
        }

        /// <summary>
        /// Return a List of negative numbers and other with positive numbers where all absolute value bigger than (n).
        /// Implement with object
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static ValueList NegativeAndPositiveValues(List<int> input)
        {
            ValueList result = new ValueList();

            //for (int i = 0; i < input.Count; i++)
            //{
            //    if (input[i] > 0)
            //    {
            //        result.PositiveList.Add(input[i]);
            //    }
            //    else
            //    {
            //        result.NegativeList.Add(input[i]);
            //    }
            //}

            //foreach (var item in input)
            //{
            //    if (item > 0)
            //    {
            //        result.PositiveList.Add(item);
            //    }
            //    else 
            //    {
            //        result.NegativeList.Add(item);
            //    }
            //}

            var inputEnum = input.GetEnumerator();

            while (inputEnum.MoveNext())
            {
                if (inputEnum.Current > 0)
                {
                    result.PositiveList.Add(inputEnum.Current);
                }
                else
                {
                    result.NegativeList.Add(inputEnum.Current);
                }
            }

            return result;
        }

        /// <summary>
        /// Dada una cadena de string separada por "," devolver cuántas veces está repetido cada elemento en una lista.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<Product> NumberOfProductSales(string input)
        {
            List<Product> products = new List<Product>();

            string[] productNames = input.Split(',');

            for (int i = 0; i < productNames.Length; i++)
            {
                if (!products.Any(p => p.Name == productNames[i]))
                {
                    var product = new Product()
                    {
                        Name = productNames[i],
                        Quantity = 1
                    };

                    products.Add(product);
                }
                else
                {
                    Product product = products.FirstOrDefault(p => p.Name == productNames[i]);
                    product.Quantity += 1;
                }
            }

            return products;
        }



        /// <summary>
        /// Return prime numbers from a List<int>
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int> PrimeNumbers(List<int> input, int count)
        {
            List<int> primesNumbers = new List<int>();

            int nPrimes = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (IsNumberPrime(input[i]))
                {
                    primesNumbers.Add(input[i]);

                    nPrimes++;
                    if (nPrimes == count)
                        break;
                }
            }

            return primesNumbers;
        }



        public static List<int> PrimeNumbers(List<int> input, int count, int max)
        {
            List<int> primesNumbers = new List<int>();

            int nPrimes = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (IsNumberPrime(input[i]) && input[i] < max)
                {
                    primesNumbers.Add(input[i]);

                    if (++nPrimes == count)
                        break;

                    // Option 01
                    //if (input[i] < max)
                    //{
                    //    primesNumbers.Add(input[i]);

                    //    if (++nPrimes == count)
                    //        break;
                    //}

                    // Option 02
                    //if (input[i] >= max) continue;

                    //primesNumbers.Add(input[i]);

                    //if (++nPrimes == count)
                    //    break;
                }
            }

            return primesNumbers;
        }

        private static bool IsNumberPrime(int number)
        {
            number = Math.Abs(number);

            for (int i = number - 1; i > 1; i--)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Calculate Max, Min and Average
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Stadistic MaxMinAndAverage(List<int> input)
        {
            int max = input[0];
            int min = input[0];
            double average = 0;
            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > max)
                    max = input[i];

                if (input[i] < min)
                    min = input[i];

                sum += input[i];
            }

            average = (double)sum / input.Count;

            return new Stadistic()
            {
                Max = max,
                Min = min,
                Average = average
            };
        }

        public static Stadistic MaxMinAndAverage(IEnumerator<int> enumerator)
        {
            enumerator.MoveNext();
            int max = enumerator.Current;
            int min = enumerator.Current;
            double average = 0;
            int sum = enumerator.Current;
            int count = 1;

            while (enumerator.MoveNext())
            {
                if (enumerator.Current > max)
                    max = enumerator.Current;

                if (enumerator.Current < min)
                    min = enumerator.Current;

                sum += enumerator.Current;

                count++;
            }

            average = (double)sum / count;

            return new Stadistic()
            {
                Max = max,
                Min = min,
                Average = average
            };
        }

        /// <summary>
        /// Verify if an array of integer contains one element repeated
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool VerifyRepeatedNumbers(int[] input)
        {
            //Option 01
            //for (int i = 0; i < input.Length; i++)
            //{
            //    for (int j = i + 1; j < input.Length; j++)
            //    {
            //        if (input[i] == input[j])
            //        {
            //            return true;
            //        }
            //    }
            //}

            //return false;

            // Option 02

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (listNumbers.Contains(input[i]))
                {
                    return true;
                }
                else
                {
                    listNumbers.Add(input[i]);
                }
            }

            return false;
        }

        /// <summary>
        /// Verify if the string is palindrome
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string input)
        {
            /*Option 01
            var inputReverse = input.Reverse().ToString();

            return (input == inputReverse)
                 */

            // Option 02
            //string inputReverse = string.Empty;

            //for (int i = input.Length - 1; i >= 0; i--)

            //    inputReverse += input[i];

            //return (input == inputReverse);

            // Option 03

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Get factorial of n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public static int Factorial(int n)
        //{
        //    //Option 01

        //    if (n <= 0)
        //        return 0;

        //    int factorial = 1;

        //    for (int i = 1; i <= n; i++)
        //        factorial *= i;

        //    return factorial;
        //}

        public static int Factorial(int n)
        {
            //Option 01 una línea

            return (n == 1)
                ? 1
                : n * Factorial(n - 1);

            //Option 02
            //if (n == 1)
            //    return 1;
            //else
            //    return n * Factorial2(n - 1);

            //int factorial = 1;

            //for (int i = 1; i <= n; i++)
            //    factorial *= i;

            //return factorial;
        }

        /// <summary>
        /// RemoveDuplicateChar from input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RemoveDuplicateChar(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        input = input.Remove(j, 1);
                    }
                }
            }

            return input;
        }

        /// <summary>
        /// Swap min and max from an int Array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] SwapMinAndMax(int[] input)
        {
            //Option 01
            /*
            int[] result = new int[input.Length];

            int max = input.Max();
            int min = input.Min();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == max)
                {
                    input[i] = min;
                    continue;
                }

                if (input[i] == min)
                {
                    input[i] = max;
                    continue;
                }
            }

            return input;
            */
            //Option 02
            int min = input[0];
            int max = input[1];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < min)
                    min = input[i];

                if (input[i] > max)
                    max = input[i];
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == max)
                    input[i] = min;

                else if (input[i] == min)
                    input[i] = max;
            }


            return input;
        }

        /// <summary>
        /// Move the zeros to the end of an Array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] MoveValueToEnd(int[] input, int value)
        {
            ////Option 01
            //List<int> inputList = new List<int>();
            //List<int> number = new List<int>();

            //inputList.AddRange(input);

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == value)
            //    {
            //        number.Add(input[i]);
            //        inputList.Remove(input[i]);
            //    }
            //}

            //inputList.AddRange(number);

            //return inputList.ToArray();


            ////Option 02          

            //List<int> inputList = new List<int>();

            //inputList.AddRange(input);

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == value)
            //    {
            //        inputList.Remove(input[i]);
            //        inputList.Add(value);
            //    }
            //}

            //return inputList.ToArray();

            ////Option 03

            //var arrayValue = Array.FindAll(input, x => x == value);

            //input = input.Except(new int[] { value }).ToArray();

            //int[] result = input.Concat(arrayValue).ToArray();


            //return result;


            ////Option 04

            //int count = 0;

            //int[] result = new int[input.Length];

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] != value)
            //    {
            //        input[count++] = input[i];

            //    }
            //}

            //while (count < input.Length)
            //{
            //    input[count++] = 0;
            //}

            //input.CopyTo(result, 0);

            //return result;

            //Option 05

            int[] result = new int[input.Length];

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != value)
                {
                    result[count++] = input[i];
                }
            }

            return result;
        }

        /// <summary>
        /// Delete an element from Array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] DeleteElement(int[] input, int index)
        {
            int length = input.Length;

            if (input == null
                || index < 0
                || index >= length)
            {
                throw new ArgumentException("The input must be valid");
            }

            int count = 0;

            int[] result = new int[length - 1];

            for (int i = 0; i < length; i++)
            {
                ////Option 01
                if (i != index)
                    result[count++] = input[i];
            }

            return result;
        }

        /// <summary>
        /// Insert an element in Array by index
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int[] AddElementInIndex(int[] input, int index, int element)
        {
            int length = input.Length;

            if (input == null
                || index < 0
                || index >= length)
            {
                throw new ArgumentException("The input must be valid");
            }

            int[] result = new int[length + 1];

            //Option 01
            //for (int i = 0; i < index; i++)
            //    result[i] = input[i];

            //result[index] = element;

            //for (int i = index + 1 ; i <= length; i++)
            //    result[i] = input[i - 1];

            //Option 02

            for (int i = 0; i < length; i++)
            {
                if (i < index)
                    result[i] = input[i];
                else
                    result[i + 1] = input[i];
            }

            result[index] = element;

            return result;
        }

        /// <summary>
        /// Get the number of Upper Case from a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int GetNumberOfUpperCase(string input)
        {
            if (input == null)
                throw new ArgumentException("The input must be valid");

            int count = 0;

            foreach (var item in input)
            {
                if (item >= 65 && item <= 90)
                    count++;
            }

            return count;
        }

        /// <summary>
        /// Sort even and odd numbers in array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] SortEvenAndOddNumbers(int[] input)
        {
            if (input == null)
                throw new ArgumentException("The input must be valid");

            int[] result = new int[input.Length];

            int count = 0;

            int lastIndex = input.Length - 1;

            //Option 01
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                    result[count++] = input[i];
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] % 2 != 0)
                    result[lastIndex--] = input[i];
            }


            return result;
        }

        /// <summary>
        /// Return true if are two numbers continuos and equal
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool AreContinuosAndEquals(int[] input)
        {
            int index = input.Length - 1;

            if (input == null
                || input.Length < 2)
            {
                throw new ArgumentException("The input must be valid");
            }
            else
            {
                //Option 1
                //for (int i = 0; i < input.Length; i++)
                //{
                //    if (i < index && input[i] == input[i + 1])
                //        return true;
                //}

                //Option 2
                for (int i = 0; i < index; i++)
                {
                    if (input[i] == input[i + 1])
                        return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Create a new array with the rightmost digits from other array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] RightMostDigit(int[] input)
        {
            if (input == null)
                throw new ArgumentException("The input must be valid");

            int[] result = new int[input.Length];

            int count = 0;

            foreach (var item in input)
            {
                char rightNumber = item.ToString().Last();
                result[count++] = (int)Char.GetNumericValue(rightNumber);
            }

            return result;
        }

        /// <summary>
        /// Insert an array in the index
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] InsertArray( int[] baseArray, int[] inputArray, int index)
        {
            if ( baseArray == null
                || inputArray == null
                || index < 0
                || index >= baseArray.Length)
            {
                throw new ArgumentException("The inputs must be valid");
            }

            int newArrayLength = baseArray.Length + inputArray.Length;

            int[] newArray = new int[newArrayLength];

            // Option 01
            //for (int i = 0; i < index; i++)
            //    newArray[i] = baseArray[i];

            //for (int i = baseArrayIndex; i >= index; i--)
            //    newArray[newArrayIndex--] = baseArray[i];

            //for (int i = 0; i < inputArray.Length; i++)
            //    newArray[index++] = inputArray[i];


            // Option 02

            //for (int i = 0; i < index; i++)
            //    newArray[i] = baseArray[i];            

            //for (int i = index; i < index + inputArray.Length; i++)
            //    newArray[i] = inputArray[i - index];

            //for (int i = index + inputArray.Length; i < newArray.Length; i++)
            //    newArray[i] = baseArray[i - inputArray.Length];


            // Option 03
            for (int i = 0; i < baseArray.Length + inputArray.Length; i++)
            {
                if (i < index)
                    newArray[i] = baseArray[i];

                else if (i < (index + inputArray.Length))
                    newArray[i] = inputArray[i - index];

                else 
                    newArray[i] = baseArray[i - inputArray.Length];
            }

            return newArray;
        }

        /// <summary>
        /// Displace array n positions 
        /// </summary>
        /// <param name="baseArray"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] DisplaceArray(int[] baseArray, int n)
        {
            if (baseArray == null 
                || n < 0)
                throw new ArgumentException("The inputs must be valid");

            if (n >= baseArray.Length 
                && n % baseArray.Length == 0)
                return baseArray;

            int[] result = new int[baseArray.Length];

            result[0] = baseArray[baseArray.Length - n];

            result[n] = baseArray[0];

            //result[baseArray.Length - n - 1] = baseArray[n];

            result[baseArray.Length - 1] = baseArray[baseArray.Length - n - 1];

            return result;
        }

        /// <summary>
        /// Rotate an array from a pivot
        /// </summary>
        /// <param name="array"></param>
        /// <param name="pivot"></param>
        /// <returns></returns>
        public static string[] RotateByPivot(string[] array, int pivot)
        {
            if (array == null
                || !array.Any()
                || pivot < 0
                || pivot > array.Length - 1)
                throw new ArgumentException("The inputs must be valid");

            if (pivot == array.Length - 1 
                || pivot == 0)
                return array;

            int length = array.Length;

            int lastIndex = length - 1;

            int count = length - pivot;

            string[] result = new string[length];

            for (int i = 0; i < lastIndex - pivot; i++)
                result[i] = array[i + pivot + 1];

            result[lastIndex - pivot] = array[pivot];

            for (int i = 0; i < pivot; i++)
                result[count++] = array[i];

            return result;
        }

        /// <summary>
        /// Rotate an array from a pivot with queue
        /// </summary>
        /// <param name="array"></param>
        /// <param name="pivot"></param>
        /// <returns></returns>
        public static string[] RotateByPivotQueue(string[] array, int pivot)
        {
            if (array == null
                || !array.Any()
                || pivot < 0
                || pivot > array.Length - 1)
                throw new ArgumentException("The inputs must be valid");

            if (pivot == array.Length - 1
                || pivot == 0)
                return array;

            int length = array.Length;

            int count = length - pivot;

            Queue<string> prePivotElements = new Queue<string>(); 

            Queue<string> postPivotElements = new Queue<string>(); 

            string[] result = new string[length];

            for (int i = 0; i < length; i++)
            {
                if (i == pivot) continue;
                if (i < pivot)
                    prePivotElements.Enqueue(array[i]);
                else  
                    postPivotElements.Enqueue(array[i]);
            }

            postPivotElements.CopyTo(result, 0);

            prePivotElements.CopyTo(result, count);

            result[count - 1] = array[pivot];

            return result;
        }
    }
}
