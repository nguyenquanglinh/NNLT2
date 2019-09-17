using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Matrix
    {
        public Matrix() { }
        public Matrix(int m, int n) : this()
        {
            this.Arr = new int[m, n];
        }
        public void Access()
        {
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write("nhap gia tri ma tran thu [{0};{1}]: ", i, j);
                    Arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static Matrix operator +(Matrix a, int x)
        {
            for (int i = 0; i < a.Arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.Arr.GetLength(1); j++)
                {
                    a.Arr[i, j] = a.Arr[i, j] + x;
                }
            }
            return a;
        }
        public static Matrix operator *(Matrix a, int x)
        {
            for (int i = 0; i < a.Arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.Arr.GetLength(1); j++)
                {
                    a.Arr[i, j] = a.Arr[i, j] * x;
                }
            }
            return a;
        }
        public static Matrix operator -(Matrix a, int x)
        {
            for (int i = 0; i < a.Arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.Arr.GetLength(1); j++)
                {
                    a.Arr[i, j] = a.Arr[i, j] - x;
                }
            }
            return a;
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            var result = new Matrix();
            if (a.Arr.GetLength(0) != b.Arr.GetLength(0) || a.Arr.GetLength(1) != b.Arr.GetLength(1))
            {
                Console.WriteLine("2 ma tran khac do dai nen khong cong duoc");
            }
            else
            {
                for (int i = 0; i < a.Arr.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Arr.GetLength(1); j++)
                    {
                        result.Arr[i, j] = a.Arr[i, j] + b.Arr[i, j];
                    }
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            var result = new Matrix(a.Arr.GetLength(0), b.Arr.GetLength(1));
            if (a.Arr.GetLength(1) != b.Arr.GetLength(0))
                Console.WriteLine("2 ma tran khac do dai nen khong nhan duoc");
            else
            {
                for (int i = 0; i < a.Arr.GetLength(0); i++)
                {
                    for (int j = 0; j < b.Arr.GetLength(1); j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < a.Arr.GetLength(1); k++)
                            sum += a.Arr[i, k] * b.Arr[k, j];
                        result.Arr[i, j] = sum;
                    }
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            var result = new Matrix();
            if (a.Arr.GetLength(0) != b.Arr.GetLength(0) || a.Arr.GetLength(1) != b.Arr.GetLength(1))
            {
                Console.WriteLine("2 ma tran khac do dai nen khong tru duoc");
            }
            else
            {
                for (int i = 0; i < a.Arr.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Arr.GetLength(1); j++)
                    {
                        result.Arr[i, j] = a.Arr[i, j] - b.Arr[i, j];
                    }
                }
            }
            return result;
        }

        public int[,] Arr { get; private set; }

    }
}
