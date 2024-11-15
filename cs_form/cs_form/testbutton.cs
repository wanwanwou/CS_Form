using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace cs_form
{
   
     class testbutton :Button
    {
        Form1  _form1;
        string[] strs =
        {
            "サンプラザ中野君",
            "オジンオズボーン",
            "マリッジスターこうもと",
            "あひるちゃんスポンジクラブ",
            "風穴あけるズ",
            "高橋メリーゴーランド",
            "なすなかにし",
            "ビーグル38能勢",
            "ボアソルチ斎藤",
            "三日月マンハッタン",
        };


        /// <summary>
        /// コンストラクタ
        ///クラスを生成したときに呼び出される
        /// </summary>
        public testbutton(Form1 form,int id ,int x, int y, int width, int height)
        {
            _form1 = form;

            //クリックイベントにクリック関数を登録
            //ボタンをクリックしたときに登録した関数を実行
            Click += OnClick;

            //もじのやつ
            Text = strs[id];

            //ボタンの場所
            Location = new Point(x,y);

            //大きさのやつ
            Size= new Size(width,height);


        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show(Text);
        }
            
    }
}
