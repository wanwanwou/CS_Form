using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_form
{
    public partial class Form1 : Form
    {
        TestLabel _TestLabel;

        testtextbox _textBox;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                testbutton testButton = new testbutton(this,i,(i% 5) * 100, (i / 5) * 100, 100, 100);
                Controls.Add(testButton);
            }

            TestLabel testLabel =
                new TestLabel("ラベルです", 10, 300, 100, 500);
            Controls.Add((testLabel));

            _textBox = new testtextbox("テキストボックス",200,300,100,500);   
            Controls.Add((_textBox));



            //Label label=new Label ();
            //label.Location = new Point(30,400);
            //label.Text = "ラベルでごわす";
            //Controls.Add(label);


            //testbutton testButton2 = new testbutton(50,50,50,70);
            //Controls.Add(testButton2);
            //testbutton testButton3 = new testbutton(100, 100, 50,90);
            //Controls.Add(testButton3);
            //testbutton testButton4 = new testbutton(150, 150, 50, 110);
            //Controls.Add(testButton4);
            //testbutton testButton5 = new testbutton(200, 200, 50, 130);
            //Controls.Add(testButton5);
            //testbutton testButton6 = new testbutton(250, 250, 50, 150);
            //Controls.Add(testButton6);
            //testbutton testButton7 = new testbutton(300, 300, 50, 170);
            //Controls.Add(testButton7);
            //testbutton testButton8 = new testbutton(350, 350, 50, 190);
            //Controls.Add(testButton8);
            //testbutton testButton9 = new testbutton(400, 400, 50, 210);
            //Controls.Add(testButton9);
            //testbutton testButton10 = new testbutton(450, 450, 50, 230);
            //Controls.Add(testButton10);
        }
        /// <summary>
        /// ラベルの文字を更新する
        /// </summary>
        /// <param name="str"></param>
        private void LabelTextUpdate(string str)
        {
            _TestLabel.TextUpdate(str);
        }

        
    }
}
