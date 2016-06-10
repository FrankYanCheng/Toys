using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Text.RegularExpressions;
namespace Bayes
{
    class Program
    {
        static string path;
        /// <summary>
        /// 单词链表产生方法
        /// </summary>
        /// <param name="li_text"></param>
        static void List_Intialize(ref List<string> li_text)
        {
            string rules = "[a-z]+";
            Regex gt = new Regex(rules, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            MatchCollection ma;
            path = "D:/test.txt";
            ma = gt.Matches(String_Copy());
            foreach (Match t in ma)
            {
                li_text.Add(t.Value.ToLower());
            }

        }
        static void Edit1_Seek(string read_string,Edit edit,Statistics state )
        {
            DateTime t1 = DateTime.Now;
            string temp_word ="Not Found";
            int counts = 0;
            int temps = 0;//记录出现频次，大的替换
            foreach (string word in edit.Di_Word_Edit.Keys)
            {
                counts = 0;
                foreach (string edit_word in edit.Di_Word_Edit[word])
                {
                    if (edit_word == read_string)
                    {
                        counts++;
                    }

                }
                if ((temps < (((double)counts / edit.Di_Word_Edit[word].Count) * state.di_text[word] * state.di_text[word])))
                {
                    temps = counts / edit.Di_Word_Edit[word].Count * state.di_text[word];
                    temp_word = word;
                }

            }
            DateTime t2 = DateTime.Now;
            TimeSpan timer = t2 - t1;

            Console.WriteLine(temp_word + "   Times:   " + timer.TotalSeconds);
        }
        static void Main(string[] args)
        {
            //单词链表
            List<string> li_text = new List<string>();
            List_Intialize(ref li_text);
            Statistics stat = new Statistics(li_text);
            Edit edit = new Edit();
            edit.Edit_1(ref li_text);
            Console.WriteLine("Analysis Down！");
            while (true)
            {
              
                string read_string = Console.ReadLine().ToLower();
                //判断是否在单词文本中
                bool is_right = false;
                foreach (string word in edit.Di_Word_Edit.Keys)
                {
                    if (read_string.Trim() == word)
                    {
                        Console.WriteLine(word);
                        is_right = true;
                        break;
                    }
                }
              
              
                Statistics state = new Statistics(li_text);
              
                //如果不在单词文本中，则在每个单词的编辑距离为1的单词中找
                if (is_right == false)
                {
                    Edit1_Seek(read_string, edit,state);
                   
                }
            }            
        }
        //复制字符串
        static string String_Copy()
        {
           
         
            using(StreamReader  reader=new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
          
            
        }
    }
  
}
