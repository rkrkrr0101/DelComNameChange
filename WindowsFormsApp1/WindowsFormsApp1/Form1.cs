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
        class compo
        {
            public string compotype;
            public string name;
            public int namenum;
            public int left;
            public int leftinc;
            public int top;
            public int topinc;
            public int Width;
            public int Height;
            public string text;
            public int taporder;
            public Boolean txtcapchecker;

            public compo( string makecompotype,string makename,int makenamenum,int makeleft,int makeleftinc,int maketop,int maketopinc,int makewidth,int makeheight,string maketext,int maketaporder,Boolean makechecker )
            {
                compotype = makecompotype;
                name = makename;
                namenum = makenamenum;
                left = makeleft;
                leftinc = makeleftinc;
                top = maketop;
                topinc = maketopinc;
                Width = makewidth;
                Height = makeheight;
                text = maketext;
                taporder = maketaporder;
                txtcapchecker = makechecker;

            }
            public void inc()
            {
                namenum++;
                left = left + leftinc;
                top = top + topinc;
                if (txtcapchecker==true)
                {
                    taporder++;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Path = pathBox.Text + filenameBox.Text;
            string [] ReadData = File.ReadAllLines(@Path);
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
            compo compodata = new compo(CompoBox.Text,nameBox.Text, Int32.Parse(incnameBox.Text), Int32.Parse(leftbox.Text), Int32.Parse(incleftBox.Text), Int32.Parse(topBox.Text), Int32.Parse(inctopBox.Text), Int32.Parse(widthbox.Text), Int32.Parse(heightBox.Text), textcapBox.Text, Int32.Parse(taporderBox.Text), textcapcheck.Checked);
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
                   int rowcount = i;
                    //컴포삽입
                    for (int j = 0; j < Int32.Parse(numBox.Text); j++)
                    {


                        WriteData.Insert(rowcount, "object " + compodata.name +compodata.namenum+ ":  " + compodata.compotype);
                        rowcount++;
                        WriteData.Insert(rowcount, "Left = " + compodata.left);
                        rowcount++;
                        WriteData.Insert(rowcount, "Top = " + compodata.top);
                        rowcount++;
                        WriteData.Insert(rowcount, "Width = " + compodata.Width);
                        rowcount++;
                        WriteData.Insert(rowcount, "Height = " + compodata.Height);
                        rowcount++;
                        if (!compodata.txtcapchecker)
                        {
                            WriteData.Insert(rowcount, "Caption = " + "'" + compodata.text + "'");
                            rowcount++;
                        }
                        else
                        {
                            WriteData.Insert(rowcount, "Text = " + "'" + compodata.text + "'");
                            rowcount++;
                            WriteData.Insert(rowcount, "TapOrder = " + compodata.taporder);
                            rowcount++;
                        }
                        WriteData.Insert(rowcount, "end");
                        rowcount++;
                        compodata.inc();
                    }


                    break;
                }



            }
            string[] writedatastr = WriteData.ToArray();
            string abc = string.Join("\n", WriteData);
            taporderBox.Text = abc;
            button1.Text = findindex.ToString();
            button2.Text = ReadData.Length.ToString();

            StreamWriter sw = new StreamWriter(pathBox.Text + "abc.txt", false);

            foreach (string writeline in writedatastr)
            {
                sw.WriteLine(writeline);
            }
            sw.Flush();
            sw.Close();
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
