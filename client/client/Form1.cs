using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using Dll;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 obj = new Class1(); // переменная, которая представляет удаленный доступ
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2;
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);

                switch (comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(num1 + num2);
                        break;

                    case "-":
                        textBox3.Text = Convert.ToString(num1 - num2);
                        break;

                    case "*":
                        textBox3.Text = Convert.ToString(num1 * num2);
                        break;

                    case "/":
                        textBox3.Text = Convert.ToString(num1 / num2);
                        break;
                }
                HttpChannel ch = new HttpChannel(); // номер порта не нужен
                ChannelServices.RegisterChannel(new TcpClientChannel());


                obj = (Class1)Activator.GetObject( typeof(Class1), "tcp://localhost:3128/Hello");

                textBox3.Text = obj.cal(num1, num2).ToString();
            }

            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Server Not Available");
            }
        }
    }
}

 /*
                double num1 = Convert.ToInt32(textBox1.Text);
                double num2 = Convert.ToInt32(textBox2.Text);

                obj.cal(num1, num2).ToString("+");
                obj.cal(num1, num2).ToString("-");
                obj.cal(num1, num2).ToString("*");
                obj.cal(num1, num2).ToString("/");

                switch (comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(num1 + num2);
                        break;
                }

                switch (comboBox1.Text)
                {
                    case "-":
                        textBox3.Text = Convert.ToString(num1 - num2);
                        break;
                }

                switch (comboBox1.Text)
                {
                    case "*":
                        textBox3.Text = Convert.ToString(num1 * num2);
                        break;
                }

                
                switch (comboBox1.Text)
                {
                    case "/":
                        
                        textBox3.Text = Convert.ToString(num1 / num2);
                        
                       /* obj.cal(num1, num2).ToString("/");
                        break;
                }

               

                ChannelServices.RegisterChannel(new TcpClientChannel());

                obj = (Class1)Activator.GetObject(typeof(Class1), "tcp://localhost:3128/Hello");
                textBox3.Text = obj.cal(num1, num2).ToString();
            }
        catch (System.Net.Sockets.SocketException)
             {
                MessageBox.Show("Server Not Available");
             }

        }
    }
}

/*
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    Class1 obj = new Class1();
    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            double num1, num2;

            num1 = Convert.ToDouble(textBox1.Text);
            num1 = Convert.ToDouble(textBox1.Text);


            ChannelServices.RegisterChannel(new TcpClientChannel());

            obj = (Class1)Activator.GetObject(typeof(Class1), "tcp://localhost:3128/Hello");

            textBox3.Text = obj.cal(num1, num2).ToString();

        }
        catch (System.Net.Sockets.SocketException)
        {
            MessageBox.Show("Server Not Available");
        }

    }
}
*/

/*
     public Form1()
{
InitializeComponent();
}
Class1 obj = new Class1();
private void button1_Click(object sender, EventArgs e)
{
try
{
    double num1 = Convert.ToInt32(textBox1.Text);
    double num2 = Convert.ToInt32(textBox2.Text);


    ChannelServices.RegisterChannel(new TcpClientChannel());

    obj = (Class1)Activator.GetObject(typeof(Class1), "tcp://localhost:3128/Hello");

    textBox3.Text = obj.cal(num1, num2).ToString();

}
catch (System.Net.Sockets.SocketException)
{
    MessageBox.Show("Server Not Available");
}

}
}
*/
  