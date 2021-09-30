using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApp1
{
    class Result
    {
        string Username;
        int Score, Size;
        public Result(string username, int score, int size)
        {
            Username = username;
            Score = score;
            Size = size;
        }
        public override string ToString()
        {
            return Username + " счет: " + Score + "(" + Size + "x" + Size + ").";

        }
        public class SortByName : IComparer
        {
            int IComparer.Compare(object ob1, object ob2)
            {
                Result res1 = (Result)ob1;
                Result res2 = (Result)ob2;
                return String.Compare(res1.Username, res2.Username);
            }
        }
        public class SortByScore : IComparer
        {
            int IComparer.Compare(object ob1, object ob2)
            {
                Result res1 = (Result)ob1;
                Result res2 = (Result)ob2;
                if (res1.Score < res2.Score) return 1;
                else if (res1.Score > res2.Score) return -1;
                else return 0;
            }
        }
        public class SortBySize: IComparer
        {
            int IComparer.Compare(object ob1, object ob2)
            {
                Result res1 = (Result)ob1;
                Result res2 = (Result)ob2;
                if (res1.Size > res2.Size) return 1;
                else if (res1.Size < res2.Size) return -1;
                else return 0;
            }
        }
    }
}
