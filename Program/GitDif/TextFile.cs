using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GitDif
{
    class TextFiles
    {
        public static string FirstFileName;
        public static string SecondFileName;
        public TextFiles(string[] f_name) //Class constructor - setting the file names to class-dependent properties/"names"
        {
            FirstFileName = f_name[1];
            SecondFileName = f_name[2];
        }
        private List<string> FirstContentsList() // All of the first text file's contents (strings) into an string list
        {
            return new List<string>(File.ReadAllLines(FirstFileName.ToString()));
        }
        private List<string> SecondContentsList() // All of the second text file's contents (strings) into an string list
        {
            return new List<string>(File.ReadAllLines(SecondFileName.ToString()));
        }
        public List<char> FirstIndividualCharacters() // Splitting first text file's contents (strings) into individual characters and storing in new list(char) 
        {
            List<char> Temp_List = new List<char>();
            List<string> Temp_First_Contents = FirstContentsList();
            foreach(string str in Temp_First_Contents)
            {
                str.Split();
                foreach(char chars in str)
                {
                    Temp_List.Add(chars);
                }
            }
            return Temp_List;
        }
        public List<char> SecondIndividualCharacters() // Splitting second text file's contents (strings) into individual characters and storing in new list(char) 
        {
            List<char> Temp_List = new List<char>();
            List<string> Temp_Second_Contents = SecondContentsList();
            foreach (string str in Temp_Second_Contents)
            {
                str.Split();
                foreach (char chars in str)
                {
                    Temp_List.Add(chars);
                }
            }
            return Temp_List;
        }
    }
}
