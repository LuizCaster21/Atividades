﻿using System;
using System.IO;

namespace Course
{
    class Program
    {
        public static void Main (string[ ] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines (sourcePath);
                
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
            }
        }
    }
}