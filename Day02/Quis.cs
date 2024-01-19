using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day02
{
    internal class Quis
    {
        public static void SoalSatu(int n)
        {
            string[,] matrix = new string[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        matrix[i, j] = j.ToString();
                    }

                    if (i > 0 && i != n - 1)
                    {
                        matrix[i, j] = " ";
                    }

                    if (j == 0)
                    {
                        matrix[i, j] = i.ToString();
                    }

                    if(i > 0 && j == n-1)
                    {
                        matrix[i, j] = (n + i - 1).ToString();
                    }

                    if(i == n-1)
                    {
                        matrix[i, j] = (n + j - 1).ToString();
                    }

                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void SoalDua(int length)
        {
            int n = length + 1;
            int[,] matrix = new int[n, n];
            List<int> bot = new List<int>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        matrix[i, j] = j;
                    }

                    if (i > 0 && i != n - 1)
                    {
                        matrix[i, j] = j + i;
                    }

                    if (j == 0)
                    {
                        matrix[i, j] = i;
                    }

                    if (j == n - 1)
                    {
                        matrix[i, j] = count;
                    }

                    if (i == length && j == length)
                    {
                        matrix[i, j] = length * (length -1);
                    }

                    count += matrix[i, j];
                }
                bot.Add(matrix[i, n - 1]);

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //bawah
                    if (i == n - 1)
                    {
                        matrix[i, j] = bot[j];
                    }

                }

            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void SoalTiga(int n)
        {
            string[,] matrix = new string[n, n];

            int counter = 3 * (n-1) -1;
            int counterTwo = counter + 3;
            int counterThree = counterTwo + (3 * n - 1) + 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //miring
                    if(i + j == n - 1)
                    {
                        if(j == n/2)
                        {
                            matrix[i, j] = "3";
                        }
                        else
                        {
                            matrix[i, j] = counter.ToString();
                            counter -= 3;
                        }
                    } else if(j == n-1)
                    {
                        if(i == 1)
                        {
                            matrix[i, j] = ((int)Math.Pow(3.0, 2.0)).ToString();
                        }
                        else if (i == n-2)
                        {
                            matrix[i, j] = ((int)Math.Pow(3.0, 3.0)).ToString();
                        }
                        else
                        {
                            matrix[i, j] = counterTwo.ToString();
                            counterTwo += 3;
                        }
                    } else if(i == n-1)
                    {
                        if(j == n/2)
                        {
                            matrix[i, j] = ((int)Math.Pow(3.0, 4.0)).ToString();
                        } else
                        {
                            matrix[i, j] = counterThree.ToString();
                            counterThree -= 3;
                        }
                    }
                    else
                    {
                        matrix[i, j] = "  ";
                    }
                }

            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

        }
        public static void SoalEmpat(int n)
        {
            string[,] matrix = new string[n, n];
    
            int counter = 2;
            int counterTwo = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == 0)
                    {
                        
                        //latering
                        if(j == 3)
                        {
                            matrix[i, j] = "3 ";
                        } else
                        {
                            matrix[i, j] = counter.ToString() + " ";
                            counter += 3;
                        }
                    }
                    else if(i != 0 && j == n-1)
                    {
                        if(i == 1 || i == n -2)
                        {
                            matrix[i, j] = "3 ";
                        }
                        else
                        {
                            matrix[i, j] = counter.ToString();
                            counter += 3;
                        }
                    } else if(i == n-1)
                    {

                        if (j == 0)
                        {
                            counter = counter + (3 * (n - 2));
                        }

                        if (j == 3)
                        {
                            matrix[i, j] = "3 ";
                        }
                        else
                        {
                            matrix[i, j] = counter.ToString() + " ";
                            counter -= 3;
                        }
                    }
                    else
                    {
                        matrix[i, j] = "   ";
                    }
                }
            }

            counterTwo = Int32.Parse(matrix[n - 1, 0]) + (3 * (n-4));

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0 && j != n - 1 && i > 0 & i < n - 1)
                    {
                        if (i == 1 || i == n - 2)
                        {
                            matrix[i, j] = "3 ";
                        }
                        else
                        {
                            matrix[i, j] = counterTwo.ToString() + " ";
                            counterTwo -= 3;
                        }
                    }
                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void SoalLima(int l, int r)
        {
            string[,] matrix = new string[l, r];
            matrix[0, 0] = "A";
            matrix[0, 1] = "B";
            matrix[0, 2] = "A";
            matrix[0, 3] = "C";
            matrix[0, 4] = "C";
            matrix[0, 5] = "D";
            matrix[0, 6] = "E";
            matrix[0, 7] = "E";
            matrix[0, 8] = "A";
            matrix[0, 9] = "D";

            matrix[1, 0] = "D";
            matrix[1, 1] = "B";
            matrix[1, 2] = "A";
            matrix[1, 3] = "B";
            matrix[1, 4] = "C";
            matrix[1, 5] = "A";
            matrix[1, 6] = "E";
            matrix[1, 7] = "E";
            matrix[1, 8] = "A";
            matrix[1, 9] = "D";

            matrix[2, 0] = "E";
            matrix[2, 1] = "D";
            matrix[2, 2] = "D";
            matrix[2, 3] = "A";
            matrix[2, 4] = "C";
            matrix[2, 5] = "B";
            matrix[2, 6] = "E";
            matrix[2, 7] = "E";
            matrix[2, 8] = "A";
            matrix[2, 9] = "D";

            matrix[3, 0] = "C";
            matrix[3, 1] = "B";
            matrix[3, 2] = "A";
            matrix[3, 3] = "E";
            matrix[3, 4] = "D";
            matrix[3, 5] = "C";
            matrix[3, 6] = "E";
            matrix[3, 7] = "E";
            matrix[3, 8] = "A";
            matrix[3, 9] = "D";

            matrix[4, 0] = "A";
            matrix[4, 1] = "B";
            matrix[4, 2] = "D";
            matrix[4, 3] = "C";
            matrix[4, 4] = "C";
            matrix[4, 5] = "D";
            matrix[4, 6] = "E";
            matrix[4, 7] = "E";
            matrix[4, 8] = "A";
            matrix[4, 9] = "D";

            matrix[5, 0] = "B";
            matrix[5, 1] = "B";
            matrix[5, 2] = "E";
            matrix[5, 3] = "C";
            matrix[5, 4] = "C";
            matrix[5, 5] = "D";
            matrix[5, 6] = "E";
            matrix[5, 7] = "E";
            matrix[5, 8] = "A";
            matrix[5, 9] = "D";

            matrix[6, 0] = "B";
            matrix[6, 1] = "B";
            matrix[6, 2] = "A";
            matrix[6, 3] = "C";
            matrix[6, 4] = "C";
            matrix[6, 5] = "D";
            matrix[6, 6] = "E";
            matrix[6, 7] = "E";
            matrix[6, 8] = "A";
            matrix[6, 9] = "D";

            matrix[7, 0] = "E";
            matrix[7, 1] = "B";
            matrix[7, 2] = "E";
            matrix[7, 3] = "C";
            matrix[7, 4] = "C";
            matrix[7, 5] = "D";
            matrix[7, 6] = "E";
            matrix[7, 7] = "E";
            matrix[7, 8] = "A";
            matrix[7, 9] = "D";

            matrix[l - 1, 0] = "D";
            matrix[l - 1, 1] = "B";
            matrix[l - 1, 2] = "D";
            matrix[l - 1, 3] = "C";
            matrix[l - 1, 4] = "C";
            matrix[l - 1, 5] = "D";
            matrix[l - 1, 6] = "A";
            matrix[l - 1, 7] = "E";
            matrix[l - 1, 8] = "A";
            matrix[l - 1, 9] = "D";


            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int count = 0;
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == matrix[l - 1, j])
                    {
                        count += 1;
                    }

                    if (j == l)
                    {
                        Console.WriteLine($"Jawaban Siswa {i} yang benar : {count}");
                    }

                }

            }

        }

        public static void SoalLimaBin(int n)
        {
            string[,] matrix = new string[n - 1, n + 1];
            matrix[0, 0] = "A";
            matrix[0, 1] = "B";
            matrix[0, 2] = "A";
            matrix[0, 3] = "C";
            matrix[0, 4] = "C";
            matrix[0, 5] = "D";
            matrix[0, 6] = "E";
            matrix[0, 7] = "E";
            matrix[0, 8] = "A";
            matrix[0, 9] = "D";

            matrix[1, 0] = "D";
            matrix[1, 1] = "B";
            matrix[1, 2] = "A";
            matrix[1, 3] = "B";
            matrix[1, 4] = "C";
            matrix[1, 5] = "A";
            matrix[1, 6] = "E";
            matrix[1, 7] = "E";
            matrix[1, 8] = "A";
            matrix[1, 9] = "D";

            matrix[2, 0] = "E";
            matrix[2, 1] = "D";
            matrix[2, 2] = "D";
            matrix[2, 3] = "A";
            matrix[2, 4] = "C";
            matrix[2, 5] = "B";
            matrix[2, 6] = "E";
            matrix[2, 7] = "E";
            matrix[2, 8] = "A";
            matrix[2, 9] = "D";

            matrix[3, 0] = "C";
            matrix[3, 1] = "B";
            matrix[3, 2] = "A";
            matrix[3, 3] = "E";
            matrix[3, 4] = "D";
            matrix[3, 5] = "C";
            matrix[3, 6] = "E";
            matrix[3, 7] = "E";
            matrix[3, 8] = "A";
            matrix[3, 9] = "D";

            matrix[4, 0] = "A";
            matrix[4, 1] = "B";
            matrix[4, 2] = "D";
            matrix[4, 3] = "C";
            matrix[4, 4] = "C";
            matrix[4, 5] = "D";
            matrix[4, 6] = "E";
            matrix[4, 7] = "E";
            matrix[4, 8] = "A";
            matrix[4, 9] = "D";

            matrix[5, 0] = "B";
            matrix[5, 1] = "B";
            matrix[5, 2] = "E";
            matrix[5, 3] = "C";
            matrix[5, 4] = "C";
            matrix[5, 5] = "D";
            matrix[5, 6] = "E";
            matrix[5, 7] = "E";
            matrix[5, 8] = "A";
            matrix[5, 9] = "D";

            matrix[6, 0] = "B";
            matrix[6, 1] = "B";
            matrix[6, 2] = "A";
            matrix[6, 3] = "C";
            matrix[6, 4] = "C";
            matrix[6, 5] = "D";
            matrix[6, 6] = "E";
            matrix[6, 7] = "E";
            matrix[6, 8] = "A";
            matrix[6, 9] = "D";

            matrix[7, 0] = "E";
            matrix[7, 1] = "B";
            matrix[7, 2] = "E";
            matrix[7, 3] = "C";
            matrix[7, 4] = "C";
            matrix[7, 5] = "D";
            matrix[7, 6] = "E";
            matrix[7, 7] = "E";
            matrix[7, 8] = "A";
            matrix[7, 9] = "D";

            matrix[8, 0] = "D";
            matrix[8, 1] = "B";
            matrix[8, 2] = "D";
            matrix[8, 3] = "C";
            matrix[8, 4] = "C";
            matrix[8, 5] = "D";
            matrix[8, 6] = "A";
            matrix[8, 7] = "E";
            matrix[8, 8] = "A";
            matrix[8, 9] = "D";


            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int count = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == matrix[8, j])
                    {
                        count += 1;
                    }


                    if (j == n - 1)
                    {
                        //matrix[i, j] = count.ToString();
                        Console.WriteLine($"Jawaban Siswa {i} yang benar : {count}");
                    }

                    matrix[8, n] = " ";
                }

            }

        }
    }
}
