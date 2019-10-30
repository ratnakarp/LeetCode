using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroMatrix
{
    public static class ZeroMatrix
    {

        public static void UpdateZeros()
        {
            int rows = 3;
            int cols = 3;
            bool zeroFound = false;
            int kRow = 0;
            int kCol = 0;

            int[,] arr = new int[,] { { 1,2,3},{ 2,0,1},{ 1, 2, 1 } };
            
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    if(arr[i,j] == 0)
                    {
                        kRow = i;
                        kCol = j;
                        zeroFound = true;
                        break;
                    }
                }
                if (zeroFound)
                {
                    break;
                }
            }

            for(int i=0;i<rows;i++)
            {
                    arr[i, kCol] = 0;
            }
            for(int j=0;j<cols;j++)
            {
                arr[kRow, j] = 0;
            }


            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.Write(Environment.NewLine);
            }

        }
    }
}
