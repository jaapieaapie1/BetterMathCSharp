using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterMath
{
    public static class BetterMath
    {

        //Mins
        public static int Min(params int[] numbers)
        {
            int smallest = numbers[0];

            foreach (int number in numbers)
            {
                if (smallest > number)
                {
                    smallest = number;
                }
            }
            return smallest;
        }

        public static float Min(params float[] numbers)
        {
            float smallest = numbers[0];

            foreach (float number in numbers)
            {
                if (smallest > number)
                {
                    smallest = number;
                }
            }
            return smallest;
        }

        public static double Min(params double[] numbers)
        {
            double smallest = numbers[0];

            foreach (double number in numbers)
            {
                if (smallest > number)
                {
                    smallest = number;
                }
            }
            return smallest;
        }

        public static decimal Min(params decimal[] numbers)
        {
            decimal smallest = numbers[0];

            foreach (decimal number in numbers)
            {
                if (smallest > number)
                {
                    smallest = number;
                }
            }
            return smallest;
        }

        public static long Min(params long[] numbers)
        {
            long smallest = numbers[0];

            foreach (long number in numbers)
            {
                if (smallest > number)
                {
                    smallest = number;
                }
            }
            return smallest;
        }

        public static short Min(params short[] numbers)
        {
            short smallest = numbers[0];

            foreach (short number in numbers)
            {
                if (smallest > number)
                {
                    smallest = number;
                }
            }
            return smallest;
        }




        //Max
        public static int Max(params int[] numbers)
        {
            int biggest = numbers[0];

            foreach (int number in numbers)
            {
                if (biggest < number)
                {
                    biggest = number;
                }
            }
            return biggest;
        }

        public static float Max(params float[] numbers)
        {
            float biggest = numbers[0];

            foreach (float number in numbers)
            {
                if (biggest < number)
                {
                    biggest = number;
                }
            }
            return biggest;
        }

        public static double Max(params double[] numbers)
        {
            double biggest = numbers[0];

            foreach (double number in numbers)
            {
                if (biggest < number)
                {
                    biggest = number;
                }
            }
            return biggest;
        }

        public static decimal Max(params decimal[] numbers)
        {
            decimal biggest = numbers[0];

            foreach (decimal number in numbers)
            {
                if (biggest < number)
                {
                    biggest = number;
                }
            }
            return biggest;
        }

        public static long Max(params long[] numbers)
        {
            long biggest = numbers[0];

            foreach (long number in numbers)
            {
                if (biggest < number)
                {
                    biggest = number;
                }
            }
            return biggest;
        }

        public static short Max(params short[] numbers)
        {
            short biggest = numbers[0];

            foreach (short number in numbers)
            {
                if (biggest < number)
                {
                    biggest = number;
                }
            }
            return biggest;
        }




        //Add
        public static int Add(params int[] numbers)
        {
            int final = 0;
            foreach (int number in numbers)
            {
                final += number;
            }
            return final;
        }

        public static float Add(params float[] numbers)
        {
            float final = 0;
            foreach (float number in numbers)
            {
                final += number;
            }
            return final;
        }

        public static double Add(params double[] numbers)
        {
            double final = 0;
            foreach (double number in numbers)
            {
                final += number;
            }
            return final;
        }

        public static decimal Add(params decimal[] numbers)
        {
            decimal final = 0;
            foreach (decimal number in numbers)
            {
                final += number;
            }
            return final;
        }

        public static long Add(params long[] numbers)
        {
            long final = 0;
            foreach (long number in numbers)
            {
                final += number;
            }
            return final;
        }

        public static short Add(params short[] numbers)
        {
            short final = 0;
            foreach (short number in numbers)
            {
                final += number;
            }
            return final;
        }




        //Minus
        public static int Minus(params int[] numbers)
        {
            int final = 0;
            foreach (int number in numbers)
            {
                final = number;
            }
            return final;
        }

        public static float Minus(params float[] numbers)
        {
            float final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final -= numbers[i];
            }
            return final;
        }

        public static double Minus(params double[] numbers)
        {
            double final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final -= numbers[i];
            }
            return final;
        }

        public static decimal Minus(params decimal[] numbers)
        {
            decimal final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final -= numbers[i];
            }
            return final;
        }

        public static long Minus(params long[] numbers)
        {
            long final = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                final -= numbers[i];
            }
            return final;
        }

        public static short Minus(params short[] numbers)
        {
            short final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final -= numbers[i];
            }
            return final;
        }


        //Times
        public static int Times(params int[] numbers)
        {
            int final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final *= numbers[i];
            }
            return final;
        }

        public static float Times(params float[] numbers)
        {
            float final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final *= numbers[i];
            }
            return final;
        }

        public static double Times(params double[] numbers)
        {
            double final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final *= numbers[i];
            }
            return final;
        }

        public static decimal Times(params decimal[] numbers)
        {
            decimal final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final *= numbers[i];
            }
            return final;
        }

        public static short Times(params short[] numbers)
        {
            short final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final *= numbers[i];
            }
            return final;
        }

        public static long Times(params long[] numbers)
        {
            long final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final *= numbers[i];
            }
            return final;
        }




        // Devide
        public static int Devide(params int[] numbers)
        {
            int final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final /= numbers[i];
            }
            return final;
        }

        public static float Devide(params float[] numbers)
        {
            float final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final /= numbers[i];
            }
            return final;
        }

        public static double Devide(params double[] numbers)
        {
            double final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final /= numbers[i];
            }
            return final;
        }

        public static decimal Devide(params decimal[] numbers)
        {
            decimal final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final /= numbers[i];
            }
            return final;
        }

        public static short Devide(params short[] numbers)
        {
            short final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final /= numbers[i];
            }
            return final;
        }

        public static long Devide(params long[] numbers)
        {
            long final = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                final /= numbers[i];
            }
            return final;
        }
    }
}