using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string [] ReadData = File.ReadAllLines(@"C:\Unit1.dfm");
            List<String> WriteData = ReadData.ToList();
            int findindex = 0;
            

            foreach(String dataline in ReadData)
            {
               if ( dataline.IndexOf("object " + parnamebox.Text + ":")!=-1)
                {
                    break;
                }
                findindex++;
            }
            //findindex다음부터 obj+1 end-1스택돌려서 0될때 컴포삽입
            int stackcount = 0;
            for (int i = findindex; i < ReadData.Length; i++)
            {
               if(ReadData[i].IndexOf("object") != -1)
                {
                    stackcount++;
                }
                if (ReadData[i].IndexOf("end") != -1)
                {
                    stackcount--;
                }
                //오브젝트는 안되는데 엔드는 전체일치로 바꿀수는있음 나중에 겹치는거 많이나오면 교체
                if (stackcount == 0)
                {
                    //컴포삽입
                    WriteData.Insert(i,"abcd");


                    break;
                }



            }
            string[] writedatastr = WriteData.ToArray();
            string abc = string.Join("\n", WriteData);
            textBox1.Text = abc;
            button1.Text = findindex.ToString();
            button2.Text = ReadData.Length.ToString();

            /* string ReadData = File.ReadAllText(@"C:\Unit1.dfm");
             int findindex = ReadData.IndexOf("object "+ parnamebox.Text+":");
             button1.Text = findindex.ToString();
             ReadData=ReadData.Insert(findindex, "abcd");
             textBox1.Text = ReadData;    */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qw = "abcd1234";
            qw=qw.Insert(0, "wwww");
            button1.Text = qw;
        }
    }
}
