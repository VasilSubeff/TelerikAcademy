using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T> where T : struct, IComparable
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public int Rows
        {
            get
            {
                return this.rows;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Rows must be > 0");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cols must be > 0");
                }

                this.cols = value;
            }
        }

        public Matrix(int currentRows, int currentCols)
        {
            this.Rows = currentRows;
            this.Cols = currentCols;
            this.matrix = new T[this.Rows, this.Cols];

        }


        public T this[int Row, int Col]
        {
            get
            {
                return this.matrix[Row, Col];
            }
            set
            {
                if (this.matrix.GetLength(0).CompareTo(Row) < 0 || this.matrix.GetLength(1).CompareTo(Col) < 0)
                {
                    throw new ArgumentOutOfRangeException("The value is out of the matrix range");
                }
                this.matrix[Row, Col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }

            Matrix<T> newMatrix = new Matrix<T>(m1.Rows, m1.Cols);

            for (int row = 0; row < newMatrix.Rows; row++)
            {
                for (int col = 0; col < newMatrix.Cols; col++)
                {
                    //newMatrix[row, col] = (dynamic)m1[row, col] + m2[row, col];

                    var firstMatrixValueToLong = Convert.ToInt64(m1.matrix[row, col]);
                    var secondMatrixValueToLong = Convert.ToInt64(m2.matrix[row, col]);
                    var resultFromAdding = firstMatrixValueToLong + secondMatrixValueToLong;
                    newMatrix.matrix[row, col] = (T)Convert.ChangeType(resultFromAdding, typeof(T));
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }

            Matrix<T> newMatrix = new Matrix<T>(m1.Rows, m1.Cols);

            for (int row = 0; row < newMatrix.Rows; row++)
            {
                for (int col = 0; col < newMatrix.Cols; col++)
                {
                    newMatrix = (dynamic)m1[row, col] - m2[row, col];
                }
            }

            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool nonZeroElements = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        nonZeroElements = false;
                    }
                }
            }

            return nonZeroElements;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool nonZeroElements = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        nonZeroElements = false;
                    }
                }
            }

            return nonZeroElements;
        }
    }
}
