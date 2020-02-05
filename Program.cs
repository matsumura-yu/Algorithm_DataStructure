using System;

namespace AlgoData
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {4, 3, 2, 10, 0};
            Trace(A);
            InsertionSort(A.Length,A);
            Trace(A);

        }

        // 配列を全て1行で表示する
        public static void Trace(int[] A){
            for(int i=0; i < A.Length; ++i){
                if(i > 0) Console.Write(" ");
                Console.Write(A[i]);
            }
            Console.WriteLine("");
        }

        // 入力の1行目に数列の個数
        // 2行目に数列
        // 数列を挿入ソートする
        public static void InsertionSort(int N, int[] A){
            for(int i = 1; i < N; ++i){
                int v = A[i];
                int j = i - 1;
                while(j >= 0 && A[j] > v){
                    A[j + 1] = A[j];
                    j--;
                }
                A[j+1] = v;
            }
        }
    }
}
