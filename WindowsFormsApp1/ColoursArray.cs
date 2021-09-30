using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    class ColorsArray
    {
        int[,] Colors;
        Random rnd = new Random();
        int size;
        public ColorsArray (int size)
        {
            Colors = new int[size, size];
            this.size = size;
            for (int i=0; i<size; i++)
                for (int j=0; j<size; j++)
                {
                    Colors[i, j] = rnd.Next(1, 6);
                }
        }
        public bool FindLines()
        {
            int lines = 0;
            for (int i=0; i<size; i++)
            {
                for (int j=0; j<size-2; j++)
                {
                    if (CheckTwoRight(i, j))
                        lines++;
                }
            }
            if (lines > 0)
                return true;
            else
            {
                for (int j = 0; j < size; j++)
                {
                    for (int i = 0; i < size-2; i++)
                    {
                        if (CheckTwoDown(i, j))
                            lines++;
                    }
                }
                if (lines > 0)
                    return true;
                else return false;
            }
        }
        //public void DeleteLines()
        //{
        //    for (int i = 0; i < size; i++)
        //    {
        //        for (int j = 0; j < size - 2; j++)
        //        {
        //            if (CheckTwoRight(i, j))
        //            {
        //                if (i == 0)
        //                {
        //                    _Boom(i, j);
        //                    _Boom(i, j + 1);
        //                    _Boom(i, j + 2);
        //                    Wait();
        //                    Colors[i, j] = rnd.Next(1, 6);
        //                    Colors[i, j + 1] = rnd.Next(1, 6);
        //                    Colors[i, j + 2] = rnd.Next(1, 6);
        //                    return;
        //                }
        //                else
        //                {
        //                    int str = i;
        //                    _Boom(str, j);
        //                    _Boom(str, j + 1);
        //                    _Boom(str, j + 2);
        //                    Wait();
        //                    do
        //                    {                               
        //                        Colors[str, j] = Colors[str - 1, j];
        //                        Colors[str, j + 1] = Colors[str - 1, j + 1];
        //                        Colors[str, j + 2] = Colors[str - 1, j + 2];
        //                        str--;
        //                    } while (str > 0);                           
        //                    Colors[0, j] = rnd.Next(1, 6);
        //                    Colors[0, j + 1] = rnd.Next(1, 6);
        //                    Colors[0, j + 2] = rnd.Next(1, 6);
        //                    return;
        //                }
        //            }
        //        }
        //    }
        //    for (int j = 0; j < size; j++)
        //    {
        //        for (int i = 0; i < size - 2; i++)
        //        {
        //            if (CheckTwoDown(i, j))
        //            {
        //                if (i == 0)
        //                {
        //                    _Boom(i, j);
        //                    _Boom(i+1, j);
        //                    _Boom(i + 2, j);
        //                    Wait();
        //                    Colors[i, j] = rnd.Next(1, 6);
        //                    Colors[i + 1, j] = rnd.Next(1, 6);
        //                    Colors[i + 2, j] = rnd.Next(1, 6);
        //                    return;
        //                }
        //                else
        //                {
        //                    int columns = i;
        //                    _Boom(i, j);
        //                    _Boom(i + 1, j);
        //                    _Boom(i + 2, j);
        //                    Wait();
        //                    do
        //                    {
        //                        Colors[columns + 2, j] = Colors[columns - 1, j];
        //                        columns--;
        //                    } while (columns-1 >= 0);
        //                    Colors[0, j] = rnd.Next(1, 6);
        //                    Colors[1, j] = rnd.Next(1, 6);
        //                    Colors[2, j] = rnd.Next(1, 6);
        //                    return;
        //                }
        //            }

        //        }
        //    }
        //}
        public void DeleteLines()
        {
            int j1, count, i1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 2; j++)
                {
                    int line = CheckRight(i, j);
                    if (line>2)
                    {
                        if (i == 0)
                        {
                            j1 = j;
                            count = 0;
                            do
                            {
                                _Boom(i, j1);
                                _ChangeScore();
                                count++;
                                j1++;
                            } while (count < line);
                            Wait();
                            j1 = j;
                            count = 0;
                            do
                            {
                                Colors[i, j1] = rnd.Next(1, 6);
                                j1++;
                                count++;
                            } while (count < line);
                            return;
                        }
                        else
                        {
                            int str = i;
                            j1 = j;
                            count = 0;
                            do
                            {
                                _Boom(str, j1);
                                _ChangeScore();
                                j1++;
                                count++;
                            } while (count < line);
                            Wait();
                            
                            do
                            {
                                j1 = j;
                                count = 0;
                                do
                                {
                                    Colors[str, j1] = Colors[str - 1, j1];
                                    j1++;
                                    count++;
                                }
                                while (count < line);
                                str--;
                            } while (str > 0);
                            j1 = j;
                            count = 0;
                            do
                            {
                                Colors[0, j1] = rnd.Next(1, 6);
                                j1++;
                                count++;
                            } while (count < line);                     
                            return;
                        }
                    }
                }
            }
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size - 2; i++)
                {
                    int line = CheckDown(i, j);
                    if (line > 2) 
                    {
                        if (i == 0)
                        {
                            i1 = i;
                            count = 0;
                            do
                            {
                                _Boom(i1, j);
                                _ChangeScore();
                                i1++;
                                count++;
                            } while (count < line);
                            Wait();
                            i1 = i;
                            count = 0;
                            do
                            {
                                Colors[i1, j] = rnd.Next(1, 6);
                                i1++;
                                count++;
                            } while (count < line);
                            return;
                        }
                        else
                        {
                            int columns = i;
                            i1 = i;
                            count = 0;
                            do
                            {
                                _Boom(i1, j);
                                _ChangeScore();
                                i1++;
                                count++;
                            } while (count < line);
                            Wait();
                            do
                            {
                                Colors[columns+(line - 1), j] = Colors[columns - 1, j];
                                columns--;
                            } while (columns - 1 >= 0);
                            i1 = 0;
                            do
                            {
                                Colors[i1, j] = rnd.Next(1, 6);
                                i1++;
                            } while (i1 < line);
                            
                            return;
                        }
                    }

                }
            }
        }
        public bool IsItAMatch(int i1, int j1, int i2, int j2)
        {
            int a =Colors[i1, j1];
            Colors[i1, j1] = Colors[i2, j2];
            Colors[i2, j2] = a;
            if (FindLines())
                return true;
            else
            {
                a = Colors[i1, j1];
                Colors[i1, j1] = Colors[i2, j2];
                Colors[i2, j2] = a;
                return false;
            }
        }
        public static void _Boom(int i, int j)
        {
            for(int a=0; a<Application.OpenForms.Count; a++)
                if (Application.OpenForms[a] is Form1)
                {
                    (Application.OpenForms[a] as Form1).ChangeButton(i, j);
                    break;
                }
        }
        public static void _ChangeScore()
        {
            for (int a = 0; a < Application.OpenForms.Count; a++)
                if (Application.OpenForms[a] is Form1)
                {
                    (Application.OpenForms[a] as Form1).ChangeScore();
                    break;
                }
        }
        public bool IsThereAMove()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if ((i < size - 1) && (j < size - 1))
                    {
                        ChangeTwoButtons(i, j, i, j + 1);
                        if (FindLines())
                        {
                            ChangeTwoButtons(i, j, i, j + 1);
                            return true;
                        }
                        else
                        {
                            ChangeTwoButtons(i, j, i, j + 1);
                            ChangeTwoButtons(i, j, i + 1, j);
                            if (FindLines())
                            {
                                ChangeTwoButtons(i, j, i + 1, j);
                                return true;
                            } else ChangeTwoButtons(i, j, i + 1, j);

                        }
                    }
                    else if ((i < size - 1) && (j == size - 1))
                    {
                        ChangeTwoButtons(i, j, i + 1, j);
                        if (FindLines())
                        {
                            ChangeTwoButtons(i, j, i + 1, j);
                            return true;
                        }
                        else ChangeTwoButtons(i, j, i + 1, j);
                    }
                    else if ((i == size - 1) && (j < size - 1))
                    {
                        ChangeTwoButtons(i, j, i, j + 1);
                        if (FindLines())
                        {
                            ChangeTwoButtons(i, j, i, j + 1);
                            return true;
                        }
                        else ChangeTwoButtons(i, j, i, j + 1);
                    }
                }
            return false;

        }
        public void ChangeTwoButtons(int i1, int j1, int i2, int j2)
        {
            int color = Colors[i1, j1];
            Colors[i1, j1] = Colors[i2, j2];
            Colors[i2, j2] = color;
        }
        
        public bool CheckTwoDown(int i, int j)
        {
            if ((Colors[i + 2, j] == Colors[i, j]) && (Colors[i + 1, j] == Colors[i, j]))
                return true;
            else return false;
        }
        public bool CheckTwoRight(int i, int j)
        {
            if ((Colors[i, j+2] == Colors[i, j]) && (Colors[i, j+1] == Colors[i, j]))
                return true;
            else return false;
        }
        public int CheckDown(int i, int j)
        {
            int line = 0;
            for (int a = i; a < size - 1; a++)
            {
                if (Colors[a, j] == Colors[a + 1, j])
                    line++;
                else break;
            }
            return line + 1;
        }
        public int CheckRight(int i, int j)
        {
            int count = 0;
            for (int a = j; a < size-1; a++ )
            {
                if (Colors[i, a] == Colors[i, a+1])
                    count++;
                else break;
            }
            return count + 1;
        }
        public void Wait()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < 500)
                Application.DoEvents();
        }
        public void DeleteFirstLines()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 2; j++)
                {
                    if (CheckTwoRight(i, j))
                    {
                        if (i == 0)
                        {
                            Colors[i, j] = rnd.Next(1, 6);
                            Colors[i, j + 1] = rnd.Next(1, 6);
                            Colors[i, j + 2] = rnd.Next(1, 6);
                        }
                        else
                        {
                            int str = i;                           
                            do
                            {
                                Colors[str, j] = Colors[str - 1, j];
                                Colors[str, j + 1] = Colors[str - 1, j + 1];
                                Colors[str, j + 2] = Colors[str - 1, j + 2];
                                str--;
                            } while (str > 0);
                            Colors[0, j] = rnd.Next(1, 6);
                            Colors[0, j + 1] = rnd.Next(1, 6);
                            Colors[0, j + 2] = rnd.Next(1, 6);
                        }
                    }
                }
            }
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size - 2; i++)
                {
                    if (CheckTwoDown(i, j))
                    {
                        if (i == 0)
                        {                           
                            Colors[i, j] = rnd.Next(1, 6);
                            Colors[i + 1, j] = rnd.Next(1, 6);
                            Colors[i + 2, j] = rnd.Next(1, 6);
                        }
                        else
                        {
                            int columns = i;
                            do
                            {
                                Colors[columns + 2, j] = Colors[columns - 1, j];
                                columns--;
                            } while (columns - 1 >= 0);
                            Colors[0, j] = rnd.Next(1, 6);
                            Colors[1, j] = rnd.Next(1, 6);
                            Colors[2, j] = rnd.Next(1, 6);
                        }
                    }

                }
            }
        }

        public int this[int index1,int index2 ]
        {
            get
            {
                if ((index1 <= size-1)&&(index2<=size-1))
                    return Colors[index1,index2];
                else
                {
                    return 0;
                }
            }
            set
            {
                if ((index1 <= size-1) && (index2 <= size-1))
                    Colors[index1, index2] = value;
            }
        }
    }
}
