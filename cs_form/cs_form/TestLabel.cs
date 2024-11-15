using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_form
{
    class TestLabel : Label
    {
        /// <summary>
        /// コンストラクタ
        ///クラスを生成したときに呼び出される
        /// </summary>
        public TestLabel(string str, int x, int y, int width, int height)
        {
            //ラベルに文字を表示
            Text += str;

            //ボタンの場所
            Location = new Point(x, y);

            //大きさのやつ
            Size = new Size(width, height);

        }

        public void TextUpdate(string str)
        { 
            Text = str; 
        }
        
    }
}
