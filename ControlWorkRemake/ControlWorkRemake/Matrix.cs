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


        public Matrix(string filename,int n)
        {
            int[,] array = new int[n, n];
            QuantityColumns = n;
            QuantityStrings = n;

            using (StreamReader sr = new StreamReader(filename))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    var subs = sr.ReadLine().Trim().Split(' ');
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = int.Parse(subs[j]);
                    }
                }
                matr = array;
            }
        }
    
            
        public void InstallMatrix(string filename)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < QuantityStrings; i++)
            {
                for (int j = 0; j < QuantityColumns; j++)
                {
                    str.Append($"{matr[i, j]} ");
                }
                str.AppendLine();
            }
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(str.ToString());
            sw.Close(); 
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
                    str.Append($"{matr[i, j]} ");
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
            int[,] matr = new int[m2.QuantityStrings, m1.QuantityColumns];
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

        public static Matrix Transponir(Matrix matr)
        {
            int[,] m = new int[matr.QuantityStrings, matr.QuantityColumns];
            int[,] mMain = matr.Matr;
            for (int i = 0; i < matr.QuantityStrings; i++)
            {
                for (int j = 0; j < matr.QuantityColumns; j++)
                {
                    m[i, j] = mMain[j, i];
                }
            }
            return new Matrix(m);
        }



    }
}
