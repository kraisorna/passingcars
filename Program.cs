using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingCars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 1, 0, 1, 1 };
            Solution s = new Solution();
            Console.WriteLine(s.solution(A));
            Console.ReadLine();
        }
    }

    class Solution {
        public int solution(int[] A) {
            int N = A.Length;
            int passing = 0;
            int pairs = 0;
            for (int i = 0; i < N; i++) {
                if (A[i] == 0) passing++;
                else if (passing>0) {
                    pairs += passing;
                    if (pairs > 1000000000) return -1;
                }
            }
            return pairs;
        }
    }
}
