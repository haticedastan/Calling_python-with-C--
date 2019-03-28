using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;



using System.Diagnostics;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }


        private void button1_Click(object sender, EventArgs e)
        {

              /* var py = Python.CreateEngine();


               try
               {
                   py.ExecuteFile(@"C:\Users\dstnh\Desktop\denemepython\helloworld.py");

               }
               catch(Exception ex)
               {
                  
               }*/



            System.Diagnostics.Process.Start(@"C:\Users\dstnh\Desktop\denemepython\helloworld.py");

           // System.Diagnostics.Process.Start(@"C:\Python27\python.exe" @"C:\Users\dstnh\Desktop\denemepython\helloworld.py""");




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
