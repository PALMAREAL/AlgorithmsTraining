using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace CsharpTraining
{
    public class Exercises
    {
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
            var length = input.Length;

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
        /// Dada una cadena de string separada por ";" devolver cuántas veces está repetido cada elemento en una lista.
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
        /// Return a List of strings with abc in the end of the string or X caracter string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<string> SplitString(
            string input, 
            char[] separators, 
            string pattern1, 
            string pattern2, 
            int nTimesDigitMax, 
            int nTimesStartMax)
        {
            List<string> formatedList = new List<string>();

            List<string> inputString = input.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            string aux = string.Empty;
            int nTimesDigitAppear = 0;
            int nTimesStartAppear = 0;

            for (int i = 0; i < inputString.Count; i++)
            {
                aux = inputString[i];

                if ((EndsWithAbc(aux) || ContainsX(aux)) &&
                    NoContainsO(aux) ||
                    ContainsKIn3stPosition(aux))
                {
                    formatedList.Add(ToUpperLower(aux));

                    // FUSIONAR IN ONE 
                    if (ContainsDigit(aux))
                        nTimesDigitAppear++;

                    if (nTimesDigitAppear == nTimesDigitMax)
                    {
                        break;
                    }

                    if (ContainsEnd(aux, pattern1))
                    {
                        if (ContainsStart(aux, pattern2))
                            nTimesStartAppear++;

                        if (nTimesStartAppear == nTimesStartMax)
                        {
                            break;
                        }
                    }
                }
            }

            return formatedList;
        }



        private static bool EndsWithAbc(string input)
        {
            return input.EndsWith("abc");
        }

        private static bool ContainsX(string input)
        {
            return input.Contains("X");
        }

        private static bool NoContainsO(string input)
        {
            return !input.Contains("o");
        }

        private static bool ContainsKIn3stPosition(string input)
        {
            return input.Contains("k") && input.IndexOf("k") > 2;
        }

        private static string ToUpperLower(string input)
        {
            string start = (input.Length >= 1)
                ? input.Substring(0, 1).ToUpper()
                : string.Empty;

            string end = (input.Length >= 2)
                ? input.Substring(input.Length - 1).ToLower()
                : string.Empty;

            string middle = (input.Length >= 3)
                ? input.Substring(1, input.Length - 2)
                : string.Empty;

            string finalString = start + middle + end;

            return finalString;
        }

        private static bool ContainsDigit(string input)
        {
            //Option 01
            //return input.Any(char.IsDigit);

            //Option 02
            //var inputWithoutDigit =  input.Except(new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });

            //return !(inputWithoutDigit.Count() == input.Length);

            // Option 03
            foreach (var item in input)
            {
                if (item >= 48 && item <= 57)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool ContainsEnd(string input, string pattern)
        {
            return input.Contains(pattern) &&  
                input.IndexOf(pattern) > 0 && 
                input.IndexOf(pattern) < (input.Length - pattern.Length - 1);
        }

        private static bool ContainsStart(string input, string pattern)
        {
            return input.IndexOf(pattern) == 0;
        }

    }
}