using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorkRemake
{
    public class Matrix
    {


        private int[,] matr;
        public int QuantityStrings { get; private set; } //длина строчек
        public int QuantityColumns { get; private set; } //длина колонок

        public bool IsSymmetric
        {
            get
            {
                if (QuantityColumns!=QuantityStrings)
                {
                    return false;
                }
                for (int i = 0; i < QuantityStrings; i++)
                {
                    for (int j = 0; j < QuantityStrings; j++)
                    {
                        if (matr[i,j] != matr[j,i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        public int[,] Matr
        {
            get
            {
                return matr;
            }
            private set
            {
                for (int i = 0; i < value.GetLength(0); i++)
                {
                    for (int j = 0; j < value.GetLength(1); j++)
                    {
                        matr[i, j] = value[i, j];
                    }
                }
            }
        }
        public Matrix(int m, int n)
        {
            QuantityStrings = m;
            QuantityColumns = n;
            int[,] matr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i,j] = 0;
                }
            }
            this.matr = matr;
        }
        public Matrix() : this(1, 1)
        {
        }


        public Matrix(string filename)
        {
            string s;
            int k = 0;
            int k2 = 0;
            StreamReader str = new StreamReader(filename);
            if ((s = str.ReadLine()) != null) // k длина строк
            {
                string[] s1 = s.Split(',', StringSplitOptions.RemoveEmptyEntries);
                k = s1.Length;
            }
            while ((s = str.ReadLine()) != null) //k2 длинна столбцов
            {
                k2++;
            }

            int[,] ans = new int[k, k2];
            k = 0;
            while ((s = str.ReadLine()) != null)
            {
                string[] s1 = s.Split(',', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < s1.Length; i++)
                {
                    k++;
                }
            }


        }



        public Matrix(int[,] matr)
        {
            QuantityStrings = matr.GetLength(0);
            QuantityColumns = matr.GetLength(1);
            int[,] matrProm = new int[QuantityStrings, QuantityColumns];
            for (int i = 0; i < QuantityStrings; i++)
            {
                for (int j = 0; j < QuantityColumns; j++)
                {
                    matrProm[i,j] = matr[i,j];
                }
            }
            this.matr = matrProm;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < QuantityStrings; i++)
            {
                for (int j = 0; j < QuantityColumns; j++)
                {
                    str.Append($"{matr[i, j]}");
                }
                str.AppendLine();
            }
            return str.ToString();
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.QuantityStrings != m2.QuantityStrings || m1.QuantityColumns != m2.QuantityColumns)
            {
                throw new ArgumentException("Для сложения матрицы должны быть однолго размера");
            }
            int[,] matr = new int[m1.QuantityStrings,m1.QuantityColumns];
            int[,] matr1 = m1.Matr;
            int[,] matr2 = m2.Matr;
            for (int i = 0; i < m1.QuantityStrings; i++)
            {
                for (int j = 0; j < m1.QuantityColumns; j++)
                {
                    matr[i, j] = matr1[i, j] + matr2[i, j];
                }
            }
            return new Matrix(matr);
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.QuantityStrings != m2.QuantityStrings || m1.QuantityColumns != m2.QuantityColumns)
            {
                throw new ArgumentException("Для вычитания матрицы должны быть однолго размера");
            }
            int[,] matr = new int[m1.QuantityStrings, m1.QuantityColumns];
            int[,] matr1 = m1.Matr;
            int[,] matr2 = m2.Matr;
            for (int i = 0; i < m1.QuantityStrings; i++)
            {
                for (int j = 0; j < m1.QuantityColumns; j++)
                {
                    matr[i, j] = matr1[i, j] - matr2[i, j];
                }
            }
            return new Matrix(matr);
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.QuantityStrings != m2.QuantityColumns)
            {
                throw new ArgumentException("неподходящие размеры матриц");
            }
            int[,] matr = new int[m2.QuantityColumns, m1.QuantityStrings];
            int[,] matr1 = m1.Matr;
            int[,] matr2 = m2.Matr;
            for (int i = 0; i < m1.QuantityColumns; i++)
            {
                for (int j = 0; j < m1.QuantityStrings; j++)
                {
                    for (int k = 0; k < m2.QuantityColumns; k++)
                    {
                        matr[i, j] += matr1[i, k] * matr2[k, i];
                    }
                }
            }
            return new Matrix(matr);
        }

        public Matrix Transponir(Matrix matr)
        {
            int[,] m = new int[matr.QuantityStrings, matr.QuantityColumns];
            int[,] mMain = matr.Matr;
            for (int i = 0; i < matr.QuantityStrings; i++)
            {
                for (int j = 0; j < matr.QuantityColumns; j++)
                {
                    m[i, j] = mMain[j, j];
                }
            }
            return new Matrix(m);
        }



    }
}
