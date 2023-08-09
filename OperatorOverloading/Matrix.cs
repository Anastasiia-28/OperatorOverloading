namespace OperatorOverloading
{
    public class Matrix
    {
        private int dimension;
        private int[,] matrix;

        public int Dimension
        {
            get { return dimension; }
            set { if (value > 0) dimension = value; }
        }

        public Matrix(int dimension)
        {
            this.dimension = dimension;
            matrix = new int[this.dimension, this.dimension];
        }

        public int this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }

        public void CompleteMatrix()
        {
            Random random = new Random();

            for (int i = 0; i < this.dimension; i++)
                for (int j = 0; j < this.dimension; j++)
                    matrix[i, j] = random.Next(1, 20);
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        public static Matrix MultiplicationByNumber(Matrix matrix, int number)
        {
            Matrix resultMatrix = new Matrix(matrix.Dimension);
            for (int i = 0; i < matrix.Dimension; i++)
                for (int j = 0; j < matrix.Dimension; j++)
                    resultMatrix[i, j] = matrix[i, j] * number;

            return resultMatrix;
        }

        public static Matrix MatrixMultiplication(Matrix matrix1, Matrix matrix2)
        {

            Matrix resultMatrix = new Matrix(matrix1.Dimension);
            for (int i = 0; i < matrix1.Dimension; i++)
                for (int j = 0; j < matrix2.Dimension; j++)
                    for (int k = 0; k < matrix2.Dimension; k++)
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];

            return resultMatrix;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            return Matrix.MatrixMultiplication(matrix1, matrix2);
        }

        public static Matrix operator *(Matrix matrix1, int matrix2)
        {
            return Matrix.MultiplicationByNumber(matrix1, matrix2);
        }

        public static Matrix MatrixSubtraction(Matrix matrix1, Matrix matrix2)
        {
            Matrix resultMatrix = new Matrix(matrix1.Dimension);
            for (int i = 0; i < matrix1.Dimension; i++)
                for (int j = 0; j < matrix2.Dimension; j++)
                    resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];

            return resultMatrix;
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            for (int i = 0; i < matrix1.Dimension; i++)
                for (int j = 0; j < matrix1.Dimension; j++)
                    if (matrix1.matrix[i, j] != matrix2.matrix[i, j])
                        return true;

            return false;
        }

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            return !(matrix1 != matrix2);
        }

        public override bool Equals(object obj)
        {
            try
            {
                return (bool)(this == (Matrix)obj);
            }
            catch
            {
                return false;
            }
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            return Matrix.MatrixSubtraction(matrix1, matrix2);
        }

        public static Matrix MatrixAddition(Matrix matrix1, Matrix matrix2)
        {
            Matrix resultMatrix = new Matrix(matrix1.Dimension);
            for (int i = 0; i < matrix1.Dimension; i++)
                for (int j = 0; j < matrix2.Dimension; j++)
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];

            return resultMatrix;
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            return Matrix.MatrixAddition(matrix1, matrix2);
        }
    }

}
