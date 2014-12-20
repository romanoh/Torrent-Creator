﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torrent_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Find your file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdlg.FileName;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new AboutBox1().ShowDialog();
    
        }

        private void button2_Click(object sender, EventArgs e);
        class WriteTextFile
{
    static void Main()
    {

        // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
        // You can modify the path if necessary. 

        // Example #1: Write an array of strings to a file. 
        // Create a string array that consists of three lines. 
        string[] lines = { "First line", "Second line", "Third line" };
        // WriteAllLines creates a file, writes a collection of strings to the file, 
        // and then closes the file.
        System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);


        // Example #2: Write one string to a text file. 
        string text = "A class is the most powerful data type in C#. Like a structure, " +
                       "a class defines the data and behavior of the data type. ";
        // WriteAllText creates a file, writes the specified string to the file, 
        // and then closes the file.
        System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);

        // Example #3: Write only some strings in an array to a file. 
        // The using statement automatically closes the stream and calls  
        // IDisposable.Dispose on the stream object. 
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
        {
            foreach (string line in lines)
            {
                // If the line doesn't contain the word 'Second', write the line to the file. 
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
            }
        }

        // Example #4: Append new text to an existing file. 
        // The using statement automatically closes the stream and calls  
        // IDisposable.Dispose on the stream object. 
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt", true))
        {
            file.WriteLine("Fourth line");
        }
    }
}
 //Output (to WriteLines.txt): 
 //   First line 
 //   Second line 
 //   Third line 

 //Output (to WriteText.txt): 
 //   A class is the most powerful data type in C#. Like a structure, a class defines the data and behavior of the data type. 

 //Output to WriteLines2.txt after Example #3: 
 //   First line 
 //   Third line 

 //Output to WriteLines2.txt after Example #4: 
 //   First line 
 //   Third line 
 //   Fourth line
    }
}
