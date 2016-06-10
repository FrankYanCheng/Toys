using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayes
{
    /// <summary>
    /// 编辑距离类
    /// </summary>
    class Edit
    {
        //数据字典，单词以及对应的 编辑距离为1的词
     public  Dictionary<string, List<string>> Di_Word_Edit = new Dictionary<string, List<string>>();
        public void  Edit_1(ref List<string> text)

       {
         
            Char[] char_text;
            string alphat = "abcdefghijklmnopqrstuvwxyz";
            char[] alphat_char=alphat.ToCharArray();
            List<string> li_text_2=new List<string>();
            int text_count = text.Count;
            string Later_text; int Lengths=0;
            for(int i=0;i<text_count;i++)
            {
                if (!Di_Word_Edit.Keys.Contains(text[i]))
                {
                 
                    li_text_2 = new List<string>();
                    string Before_text = "";
                    Later_text = text[i];
                    Lengths = Later_text.Count();
                    //split
                    for (int j = 0; j < Lengths; j++)
                    {
                        li_text_2.Add(Before_text);
                        li_text_2.Add(Later_text);
                        Before_text = Before_text + Later_text.Substring(0, 1);
                        Later_text = Later_text.Substring(1, Lengths - j - 1);
                    }

                    li_text_2.Add(text[i]);
                    li_text_2.Add("");

                    //deletes
                    for (int j = 0; j < Lengths; j++)
                    {
                        li_text_2.Add(text[i].Remove(j, 1));
                    }
                    //transport
                    char temps;

                    for (int k = 0; k < Lengths - 1; k++)
                    {
                        char_text = text[i].ToCharArray();
                        StringBuilder texts = new StringBuilder();
                        temps = char_text[k];
                        char_text[k] = char_text[k + 1];
                        char_text[k + 1] = temps;
                        for (int j = 0; j < Lengths; j++)
                        {
                            texts.Append(char_text[j]);

                        }
                        li_text_2.Add(texts.ToString());
                    }
                    //replaces
                    string replaces_temps;
                    for (int j = 0; j < Lengths; j++)
                    {

                        for (int k = 0; k < alphat.Length; k++)
                        {
                            replaces_temps = text[i].Remove(j, 1);
                            li_text_2.Add(replaces_temps.Insert(j, alphat_char[k].ToString()));
                        }
                    }
                    //inserts
                    for (int j = 0; j < Lengths + 1; j++)
                    {

                        for (int k = 0; k < alphat.Length; k++)
                        {

                            li_text_2.Add(text[i].Insert(j, alphat_char[k].ToString()));
                        }
                    }
                    Di_Word_Edit.Add(text[i], li_text_2);

                }
              
            }
          
        }

    }
}
