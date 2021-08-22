using System;
using System.Drawing;
using PFrameWork;

namespace Celluar_Autamata
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] cellmap = new string[172, 41];

            Random random = new Random();
            Random placedisran = new Random();
            Random ranset = new Random();
          
            cellmap[8, 8] = "#";
            cellmap[172 - 8, 8] = "-";
           



            Console.WindowWidth = 172;
            Console.WindowHeight = 41;
            string ss = Console.ReadLine();
            if (ss == "go")
            {
                Console.CursorVisible = false;
                while (true)
                {
                    int cellcout = 0;
                    for (int y = 0; y < 41; y++)
                    {
                        for (int x = 0; x < 172; x++)
                    {
                            try
                            {
                              int rr = random.Next(4);

                                if (rr == 1 && cellmap[x, y] != null && x > 7 && y > 7 && y < 41 - 7 && x < 172 - 7 && cellmap[x,y] != "+" && cellmap[x, y] != " " && cellmap[x, y] != "/")
                                {
                                    cellmap[x + placedisran.Next(6), y + placedisran.Next(6)] = cellmap[x, y];

                                }

                                else if (rr == 2 && cellmap[x, y] != null && x > 7 && y > 7 && y < 41 - 7 && x < 172 - 7 && cellmap[x, y] != "+" && cellmap[x, y] != " " && cellmap[x, y] != "/")
                                {
                                    cellmap[x - placedisran.Next(6), y - placedisran.Next(6)] = cellmap[x, y];

                                }


                              

                                if (cellmap[x,y] == "+" && rr == 1 && x > 7 && y > 7 && y < 41 - 7 && x < 172 - 7)
                                {
                                    cellmap[x - placedisran.Next(6), y - placedisran.Next(2)] = "+";
                                  
                                    cellmap[x, y] = " ";

                                }



                                else if (cellmap[x,y] == "+" && rr == 2 && x > 7 && y > 7 && y < 41 - 7 && x < 172 - 7)
                                {
                                    cellmap[x + placedisran.Next(6), y + placedisran.Next(2)] = cellmap[x, y];
                                   
                                    cellmap[x, y] = " ";
                                }


                               

                                if (cellmap[x,y] == "+" && cellmap[x + 1,y] == "+"|| cellmap[x, y] == "+" && cellmap[x - 1, y] == "+" || cellmap[x, y] == "+" && cellmap[x, y - 1] == "+" || cellmap[x, y] == "+" && cellmap[x, y + 1] == "+")
                                {
                                    cellmap[x + placedisran.Next(6), y + placedisran.Next(6)] = cellmap[x, y];
                                }
                             

                                if (cellmap[x,y] == "#" && cellmap[x + 1,y] == "-" || cellmap[x, y] == "#" && cellmap[x - 1, y] == "-" || cellmap[x, y] == "#" && cellmap[x, y + 1] == "-" || cellmap[x, y] == "#" && cellmap[x, y - 1] == "-")
                                {
                                    cellmap[x, y] = "/";
                                }

                                if (cellmap[x, y] == "-" && cellmap[x + 1, y] == "#" || cellmap[x, y] == "#" && cellmap[x - 1, y] == "-" || cellmap[x, y] == "-" && cellmap[x, y + 1] == "#" || cellmap[x, y] == "-" && cellmap[x, y - 1] == "#")
                                {
                                    cellmap[x, y] = " ";
                                }
                                /*if (cellmap[x, y] != null && cellmap[x, y] != " " && cellmap[x, y + 1] == null && y < 41 - 9 || cellmap[x, y] != null && cellmap[x, y] != " " && cellmap[x, y + 1] == " " && y < 41 - 9)
                                 {
                                     cellmap[x, y + 1] = cellmap[x, y];
                                     cellmap[x, y] = " ";
                                 }*/

                                if (cellmap[x, y] == "#")
                                {
                                    Drawing.draw(ConsoleColor.Red, x, y);
                                    

                                }

                                if (cellmap[x, y] == "+")
                                {
                                    Drawing.draw(ConsoleColor.Green, x, y);
                                    
                                }

                                if (cellmap[x, y] == " ")
                                {
                                    Drawing.draw(ConsoleColor.Black , x, y);
                                }

                                if (cellmap[x, y] == "-")
                                {
                                    Drawing.draw(ConsoleColor.Cyan, x, y);
                                }

                                if (cellmap[x, y] == "/" && ranset.Next(2) != 1)
                                {
                                    Drawing.draw(ConsoleColor.Gray, x, y);
                                }

                                else  if (cellmap[x, y] == "/")
                                {
                                    Drawing.draw(ConsoleColor.DarkGray, x, y);
                                }

                                if (cellmap[x,y] != null && cellmap[x, y] != " ")
                                {
                                    cellcout++;
                                    Console.SetCursorPosition(1,1);
                                    Console.WriteLine("cell count " + cellcout);
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("e");

                            }

                        }

                    }
                }

            
            }
          
           
        }
    }
}
