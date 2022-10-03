using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace HanshasinkeiTEST
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Trainer trainer;
        Form2 form2;
        static public string t;
        private Color AreaColor; 

        public Form1()
        {
            InitializeComponent();
            StatusLabel.Text = "反射神経テスト";
            form2 = new Form2();
        }

        private void StartTrainingElement_Click(object sender, EventArgs e)   //スタート
        {
            StartTraining();
        }

        private void StopTrainigElement_Click(object sender, EventArgs e)　//停止
        {
            StopTraining();
            trainer.ClearScore();
            AreaBox.Enabled = false; //Areaboxをクリックしない
        }

        private void ExitElement_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AreaClicked(object sender, EventArgs e)　　　//エリア
        {
            if (trainer.GetAreaColor() != Color.Black)
            {
                trainer.StopCounting();
                var time = trainer.GetBestTime();
                StatusLabel.Text = "あなたのタイム:" + $@"{time.TotalSeconds:0.000}" + "s!";    //0.001s
                t = $@"{time.TotalSeconds:0.000}".ToString();
                StatusPanel.Visible = true;
                MenuControl(false);
                StatusPanel.Enabled = false;
                StopTrainingElement.Enabled = false;
                PinkElement.Enabled = false;
                GreenElement.Enabled = false;
                AreaBox.Enabled = false;

                //Form2 form2 = new Form2();
                form2.Show(); 　　　　　　　　　　　//Form2表示
            }
            else
            { // ブラック
                trainer.StopCounting();
                StatusLabel.Text = "早い!";
                StatusPanel.Visible = true;
                PinkElement.Enabled = false;
                GreenElement.Enabled = false;
                MenuControl(true);
            }
            //form2.Show();
        }

        public void MenuControl(bool value) //メニュータブ１・２
        {
            var a = menuStrip1.Items.Find("StartTrainingElement", true); // 開始
            var b = menuStrip1.Items.Find("RecordElement", true);       // record
            var c = menuStrip1.Items.Find("StopTrainingElement", true);  // 停止
           
            a[0].Enabled = value;
            b[0].Enabled = value;
            c[0].Enabled = !value;　　　　　　　　　　　　　　　　　　// 非トレーニングモードでは、「停止」メニューはブロックされている必要があるため、ここでは否定します。
        }

        private void StatusLabel_Click(object sender, EventArgs e)　　　//ラベル
        {
            StartTraining();
        }

        private void StartTraining()      //スタート
        {
            MenuControl(false);　　　　　　　　　　　　　　　　　　　    　// メニューの入力を無効
            StatusPanel.Visible = false; 　　　　　　　　　　　　　　  　// ステータスパネルを隠す
            trainer = new Trainer(AreaBox); 　　　　　　　　　　　　　 // トレーナーのインスタンスを作成。
            trainer.BlackArea(); 　　　　　　　　　　　　　　　　　　// トレーナーエリアが黒色の場合
            AreaBox.Click += new EventHandler(AreaClicked); 　　　 // クリックハンドラが追加されていることを確認します。
            trainer.StartCounting();                             // 時間のカウントを開始します。
            PinkElement.Enabled = false;
            GreenElement.Enabled = false;
            AreaBox.Enabled = true;　　　　　　　　　　　　　　　//Areaboxをクリックできるようになる
        }

        private void StopTraining()       　　//停止
        {
            MenuControl(true); 　　　　　　　　　　　　　　　　　　　　// メニューのブロックを解除する。
            StatusPanel.Visible = true; 　　　　　　　　　　　　　　　// パネルを表示する
            StatusLabel.Text = "もう一度ボタンを押すと始めるよ！"; 　// メッセージを表示します。
            trainer.StopCounting(); 　　　　　　　　　　　　　　　　// すべてのカウントを停止する,
            trainer.BlackArea();                                   // トレーニングエリアを再度黒に設定する。
            //AreaBox.Enabled = true;　　
        }

        private void StatusPanel_Click(object sender, EventArgs e)　　//パネル
        {
            StartTraining();
        }

        private void RecordElement_Click(object sender, EventArgs e)  //記録一覧
        {
            var info = new RecordForm();
            info.ShowDialog();
        }

        private void PinkElement_Click(object sender, EventArgs e)　　//ピンク色
        {
            //AreaColor = Color.Pink;
            Trainer.NextColor = Color.Pink;
        }

        private void GreenElement_Click(object sender, EventArgs e)   //緑色
        {
            Trainer.NextColor = Color.Green;
        }
    }
}
