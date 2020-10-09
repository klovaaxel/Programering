using Fragesport;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace Fragesport_File
{
    class FileReader
    {
        public void ReadFromFile(List<QuestionCard> QList) 
        {
            FileStream inStream = new FileStream("Questions.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inStream);

            String row = reader.ReadLine();
            while (row != null)
            {
                if (row.StartsWith("T"))
                {
                    row = row.Remove(0, 2);
                    string[] words = row.Split(',');
                    QList.Add(new QuestionText(words[0], words[(words.Length - 1)]));
                }
                else 
                {
                    row = row.Remove(0, 2);
                    string[] words = row.Split(',');
                    List<String> altList = new List<String>();
                    for (int i = 1; i < (words.Length-1); i++) 
                    {
                        altList.Add(words[i]);
                    }
                    QList.Add(new QuestionChoice(words[0], altList, words[(words.Length-1)]));
                }
                row = reader.ReadLine();
            }
            reader.Dispose();
        }
    }
}
