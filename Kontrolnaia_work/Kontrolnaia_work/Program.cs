
void printMatrix(int[,] mas)
{
    int n = mas.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{mas[i,j]} ");
        }
        Console.WriteLine();
    }
}


int[,] Ex1(int n)
{
    int[,] mas = new int[n, n];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mas[i, j] = random.Next(-100,100);
        }
    }
    return mas;
}
int[,] arr1 = Ex1(6);
//printMatrix(arr1);
string file = @"C:\Users\salav\source\repos\Practica_iitiis\Kontrolnaia_work\text.txt";

void WriteMartixInFile(int[,] matix,string file)
{
    StreamWriter sr = new StreamWriter(file);
    int n = matix.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sr.Write($"{matix[i,j]}, ");
        }
        sr.WriteLine();
    }
    
    sr.Close();
}
//WriteMartixInFile(arr1,file);

int[,] ReadMatrixFromFile()
{
     
    StreamReader sw = new StreamReader(@"C:\Users\salav\source\repos\Practica_iitiis\Kontrolnaia_work\text.txt");
    string line = sw.ReadLine();
    string[] str;
    int k = 0;
    int[,] a0 = new int[,] { {0} } ;
    if (line != null)
    {
        str = line.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        int len1 = str.Length;
        int[,] ans = new int[len1, len1];


        while (line != null)
        {

            str = line.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                ans[k, i] = int.Parse(str[i]);
            }
            k++;
        }
        sw.Close();
        return ans;
    }
    sw.Close();
    return a0;

}
//int[,] matr = ReadMatrixFromFile();
//printMatrix(matr);


//функция проверяет число простое или нет
bool ProstoeDigits_or_not(int n)
{
    if (n==2)
    {
        return true;
    }
    for (int i = 2; i < (int)Math.Sqrt(n)+1; i++)
    {
        if (n%i==0)
        {
            return false;
        }
    }
    return true;
}



int[,] ex1_1(int n)
{
    int[,] ans = new int[n, n];
    Random r = new Random();
    int k;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            while (true)
            {
                k = r.Next(2, 1000001);
                if (ProstoeDigits_or_not(k))
                {
                    ans[i, j] = k;
                    break;
                }
            }
            
        }
    }
    return ans;
}
int[,] prost = ex1_1(3);
printMatrix(prost);

int[] poisk_min(int[,] matr)
{
    int n = matr.GetLength(0);
    int min = 999999999;
    int a, b;
    int[] ans = new int[2];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (min > matr[i,j])
            {
                min = matr[i, j];
                ans[0] = i;
                ans[1] = j;
            }
        }
    }
    return ans;
}
//int[] k = poisk_min(prost);
//Console.WriteLine($"{k[0]} {k[1]}");

int[] poisk_max(int[,] matr)
{
    int n = matr.GetLength(0);
    int max = -999999999;
    int a, b;
    int[] ans = new int[2];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (max < matr[i, j])
            {
                max = matr[i, j];
                ans[0] = i;
                ans[1] = j;
            }
        }
    }
    return ans;
}

//int[] k = poisk_max(prost);
//Console.WriteLine($"{k[0]} {k[1]}");
int[,] ex1_2(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int[] minn = poisk_min(matrix);
    int[] max = poisk_max(matrix);
    int[] t = new int[n];
    for (int i = 0; i < n; i++)
    {
        t[i] = matrix[minn[0], i];
    }
    for (int i = 0; i < n; i++)
    {
        matrix[minn[0], i] = matrix[max[0],i];
    }
    for (int i = 0; i < n; i++)
    {
        matrix[max[0], i] = t[i];
    }
    return matrix;

}
//int[,] k = ex1_2(prost);
//Console.WriteLine();
//printMatrix(k);

