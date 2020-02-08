using System;

namespace AlgoData
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] A = {4, 3, 2, 10, 0};
            int[] A = {2, 1};
            // Trace(A);
            // InsertionSort(A.Length,A);
            // Trace(A);

            Console.WriteLine("バブルソート");
            Trace(A);
            int result = 0;
            result = BubbleSort(A.Length,A);
            Trace(A);
            Console.WriteLine("転倒数:" + result);

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

        // バブルソート
        // 与えられた数列をソートし、転倒数を返す
        public static int BubbleSort(int N, int[] A){
            int swapNum = 0;
            int tmp = 0;
            // N-1回で配列を確定させる
            for(int i = 0; i < N-1; ++i){
                for(int j = N - 2; j >= i; --j){
                    // 転倒させる
                    if(A[j] > A[j+1]){
                        tmp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = tmp;
                        ++swapNum;
                    }
                }
            }

            return swapNum;
        }
    }
}
