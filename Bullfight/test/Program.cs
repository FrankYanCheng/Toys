using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokers;
namespace test
{
    class Program
    {
     
        static void Main(string[] args)
        {


            Card_Name name = new Card_Name();
            name.Big_Joker = "大王";
            name.Little_Joker = "小王";
            name.Club = "草花";
            name.Diamon = "方块";
            name.Hearts = "红桃";
            name.Peach = "黑桃";
            int numbers = Convert.ToInt32(Console.ReadLine());
        
                BullfightCards card = new BullfightCards(1);
                card.SetRules(name);
                Credit[] credit = new Credit[3];
                List<int>[] player = new List<int>[3];
                int[] BullFight =new int[11];
                int WinTime = 0;
                int LostTime = 0;

                for (int ist = 0; ist < numbers; ist++)
                {
                    for (int i = 0; i < player.Length; i++)
                    {
                        player[i] = new List<int>();
                        credit[i] = new Credit();
                    }
                    card.Shuffle();
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < player.Length; j++)
                        {
                            player[j].Add(card.Play());
                        }
                    }
                    //for (int i = 0; i < player.Length; i++)
                    //{
                    //    foreach (int j in player[i])
                    //    {
                    //        Console.Write(card.IntToString(j) + " ");
                    //    }

                    //    Console.Write("       " + card.ResultPoint(player[i]));
                    //    Console.WriteLine();
                    //    Console.WriteLine("-------------");
                    //}
                    //Console.WriteLine("-------------");
                    for (int l = 1; l < player.Length; l++)
                    {

                        //if (card.IsBankerWin(player[0], player[l], ref credit[0], ref credit[l], 1))
                        //{
                        //    WinTime++;
                        //}
                        //else
                        //{
                        //    LostTime++;
                        //}
                        int index=card.ResultPoint(player[l]);
                      if(index!=-1)
                        {
                            BullFight[index]++;
                          
                        }
                      else
                      {
                          BullFight[0]++;
                      }
                    }
                    int indexs = card.ResultPoint(player[0]);
                    if(indexs!=-1)
                        {
                            BullFight[indexs]++;
                          
                        }
                      else
                      {
                          BullFight[0]++;
                      }
                }
                //Console.WriteLine("游戏局数验证" + numbers);
                //Console.WriteLine("庄家胜率" + (double)WinTime / (LostTime + WinTime));
                //Console.WriteLine("庄家金额" + credit[0].Score);
                for (int i = 0; i < BullFight.Length; i++)
                    Console.WriteLine(i + "牛率" + (double)BullFight[i] / (numbers * (player.Length)));
                Console.WriteLine("-------------");
                Console.ReadKey();
            
        }
    }
}
