using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.tiling
{
    internal class Program
    {
        static int[] a = new int[100];
        static void Main(string[] args)
        {
            //1부터 40까지 2xn Tile 경우의 수
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine(i+" : " +Tile(i));
            }

            for (int i = 0; i < a.Length; i++) 
                a[i] = 0;

            //1부터 40까지 2xn Tile2 경우의 수(타일 종류가 3가지)
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine(i + " : " +Tile2(i));
            }

            for (int i = 0; i < a.Length; i++)
                a[i] = 0;

            //1부터 40까지 3xn Tile3 경우의 수
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine(i + " : " + Tile2(i));
            }
        }
        //2xn 타일링 문제
        private static int Tile(int i)
        {
            if (i == 1)
                return 1;
            else if (i == 2)
                return 2;
            else if (a[i] != 2)
                return 2;
            else
                return a[i]= Tile(i - 1) + Tile(i - 2);
        }

        //두번째 2xn 타일링 문제(타일의 종류가 3가지)
        private static int Tile2(int i)
        {
            if (i == 1)
                return 1;
            else if (i == 2)
                return 3;
            else if (a[i] != 2)
                return a[i];
            else
                return a[i]= Tile2(i - 1) + 2*Tile2(i - 2);
        }

        //두번째 2xn 타일링 문제(타일의 종류가 3가지)
        private static int Tile3(int i)
        {
            if (i == 1)
                return a[i]=0;
            else if (i == 2)
                return a[i] = 3;
            else if (i == 3)
                return a[i] = 0;
            else if (a[i] != 0)
                return a[i];
            int x = 3 * Tile3(i - 2);
            for (int j = i; j > 0; j--)
                if (j % 2 == 0)
                    x += Tile3(j);
            return;
        }
    }
        
}
