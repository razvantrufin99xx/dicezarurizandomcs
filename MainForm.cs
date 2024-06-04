/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/4/2024
 * Time: 2:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ZaruriRandom
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		Random r2 = new Random();
		Random r1 = new Random();
		int counter = 0;
		public int runA()
		{
			r1.Next(0,100);
			textBox1.Text = r1.ToString();
			
			r1.Next(0,100);
			
			textBox1.Text = r1.ToString();
			r1.Next(0,100);
			
			textBox1.Text = r1.ToString();
			r1.Next(0,100);
			
			textBox1.Text = r1.ToString();
			r1.Next(0,100);
			
			textBox1.Text = r1.ToString();
			r1.Next(0,100);
			
			textBox1.Text = r1.ToString();
			r1.Next(0,100);
			
			textBox1.Text = r1.ToString();
			r1.Next(0,100);
			
			textBox1.Text = r1.ToString();
			r1.Next(0,100);
			
			textBox1.Text = r1.ToString();
			
			r1.Next(0,100);
			textBox2.Text = r2.ToString();
			
			int a = r1.Next(0,100);
			if(a>0 && a<11){a = 1;return a;}
			else if(a>=0 && a<11){a = 2;return a;}
			else if(a>=11 && a<21){a = 3;return a;}
			else if(a>=21 && a<31){a = 4;return a;}
			else if(a>=31 && a<41){a = 5;return a;}
			else if(a>=41 && a<51){a = 6;return a;}
			else if(a>=51 && a<61){a = 1;return a;}
			else if(a>=61 && a<71){a = 2;return a;}
			else if(a>=71 && a<81){a = 3;return a;}
			else if(a>=81 && a<91){a = 4;return a;}
			else if(a>=91 && a<101){a = 5;return a;}
			else if(a>=101 && a<111){a = 6;return a;}
			return a;
			
		}
		public int runB()
		{
			r2.Next(0,100);
			textBox2.Text = r2.ToString();
			r2.Next(0,100);
			textBox2.Text = r2.ToString();
			
			r2.Next(0,100);
			textBox2.Text = r2.ToString();
			
			r2.Next(0,100);
			textBox2.Text = r2.ToString();
			
			r2.Next(0,100);
			textBox2.Text = r2.ToString();
			
			r2.Next(0,100);
			textBox2.Text = r2.ToString();
			
			r2.Next(0,100);
			textBox2.Text = r2.ToString();
			
			r2.Next(0,100);
			textBox2.Text = r2.ToString();
			
			r2.Next(0,100);
			textBox2.Text = r2.ToString();
			
			
			int a = r2.Next(0,100);
			if(a>0 && a<11){a = 6;return a;}
			else if(a>=0 && a<11){a = 5;return a;}
			else if(a>=11 && a<21){a = 4;return a;}
			else if(a>=21 && a<31){a = 3;return a;}
			else if(a>=31 && a<41){a = 2;return a;}
			else if(a>=41 && a<51){a = 1;return a;}
			else if(a>=51 && a<61){a = 6;return a;}
			else if(a>=61 && a<71){a = 5;return a;}
			else if(a>=71 && a<81){a = 4;return a;}
			else if(a>=81 && a<91){a = 3;return a;}
			else if(a>=91 && a<101){a = 2;return a;}
			else if(a>=101 && a<111){a = 1;return a;}
			return a;
			
		}
		public int [] counterA =  {0,0,0,0,0,0};
		public int [] counterB =  {0,0,0,0,0,0};
		public int [] counterT =  {0,0,0,0,0,0};
		public void updateDatasInFormA()
		{
			textBox3.Text = counterA[0].ToString();
			textBox4.Text = counterA[1].ToString();
			textBox5.Text = counterA[2].ToString();
			
			textBox6.Text = counterA[3].ToString();
			textBox7.Text = counterA[4].ToString();
			textBox8.Text = counterA[5].ToString();
		}
		
		public void updateDatasInFormB()
		{
			textBox9.Text = counterB[0].ToString();
			textBox10.Text = counterB[1].ToString();
			textBox11.Text = counterB[2].ToString();
			
			textBox12.Text = counterB[3].ToString();
			textBox13.Text = counterB[4].ToString();
			textBox14.Text = counterB[5].ToString();
		}
		public void updateDatasInFormT()
		{
			textBox15.Text = counterT[0].ToString();
			textBox16.Text = counterT[1].ToString();
			textBox17.Text = counterT[2].ToString();
			
			textBox18.Text = counterT[3].ToString();
			textBox19.Text = counterT[4].ToString();
			textBox20.Text = counterT[5].ToString();
		}
		
		
		public void addIntoCountersA(int x)
		{
			counterA[x-1]++;
		}
		public void addIntoCountersB(int y)
		{
			counterB[y-1]++;
		}
		public void addIntoCountersT(int xy)
		{
			counterT[xy-1]++;
		}
		public void run()
		{
			counter++;
			int x = runA(); 
			addIntoCountersA(x);
			int y = runB();
			addIntoCountersB(y);
			textBox1.Text = x.ToString();
			textBox2.Text = y.ToString();
			addIntoCountersT(x);
			addIntoCountersT(y);
			updateDatasInFormA();
			updateDatasInFormB();
			updateDatasInFormT();
			this.textBox21.Text = counter.ToString();
			this.textBox22.Text = (counter*2).ToString();
		}
		public void runntimes(int n)
		{
		
		for(int kkkk = 0 ; kkkk < n ; kkkk++)
			{
			run();
			Refresh();
			}
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			runntimes(int.Parse(textBox23.Text));
		}
	}
}
