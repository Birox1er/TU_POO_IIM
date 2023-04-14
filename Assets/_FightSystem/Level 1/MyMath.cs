using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_GC_A2_Partiel_POO.Level_1
{
    public class MyMath
    {
        // Interdictions :
        // classe Math & MathF
        public static int Abs(int input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }

        // Interdictions :
        // classe Math & MathF
        public static int Clamp(int input, int min, int max)
        {
            if (input < min)
            {
                return min;
            }
            else if (input > max)
            {
                return max;
            }
            else
            {
                return input;
            }
        }

        // Interdictions :
        // classe Math & MathF
        public static int Floor(float input)
        {
            return (int)input;
        }

        // Interdictions :
        // classe Math & MathF
        public static int Ceil(float input)
        {
            if (input % 1 == 0)
            {
                return (int)input;
            }
            else
            {
                return (int)input + 1;
            }
        }

        // Interdictions :
        // classe Math & MathF
        public static int Round(float input)
        {
            if (input % 1 >= 0.5)
            {
                return (int)input + 1;
            }
            else
            {
                return (int)input;
            }
        }

        // Interdictions :
        // classe Math & MathF
        // LINQ & Enumerable
        public static float CalculateAverage(int[] input)
        {
            if (input.Length == 0)
            {
                throw new ArgumentException();
            }
            else if (input == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                float sum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    sum += input[i];
                }
                return sum / input.Length;
            }
        }
        

        
    }
}


