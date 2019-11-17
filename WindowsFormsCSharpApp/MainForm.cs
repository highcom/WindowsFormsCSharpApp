using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCSharpApp
{
    public partial class MainForm : Form
    {
        private BackGroundProcess backGroundProcess;
        private CancellationTokenSource tokenSource;

        public MainForm()
        {
            InitializeComponent();
        }

        // 単純なボタンのイベントハンドラ
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        // SubFormにデリゲートをセットする
        private void DispSubButton_Click(object sender, EventArgs e)
        {
            SubForm subObj = new SubForm();
            subObj.updateTextDelegate += new UpdateTextDelegate(UpdateTextHandler);
            subObj.Show();
        }

        // SubFormから呼ばれるデリゲートメソッド
        private void UpdateTextHandler(string message)
        {
            DispTextBox.Text = message;
        }

        // バックグラウンドプロセスの実行処理
        async private void StartBackGround_Click(object sender, EventArgs e)
        {
            // cancel用のtokenを渡してインスタンス化
            tokenSource = new CancellationTokenSource();
            backGroundProcess = new BackGroundProcess(tokenSource.Token);
            // プロパティへのアクセス
            backGroundProcess.X = 100;
            //backGroundProcess.Y = 200; // これはできない
            // delegateによりプログレスバーの更新処理を登録
            backGroundProcess.updateBackGroundProcess += new UpdateBackGroundProcess(UpdateBackGroundProgressBar);
            Status.Text = "Processing...";

            try {
                // 別タスクでプロセスを開始する
                Boolean result = await Task.Run(async () =>
                {
                    return backGroundProcess.StartProcess();
                });

                // async修飾子によってスレッドの終了後に実行される
                if (result) {
                    Status.Text = "Success!";
                } else {
                    Status.Text = "Failure!";
                }
            } catch(Exception exception) {
                // Stopボタンでtokenのcancelフラグが立つとBackGroundProcessでExceptionする
                Status.Text = exception.Message;
            } finally {
                tokenSource.Dispose();
            }
        }

        // バックグラウンドプロセスを終了させる
        private void StopBackGround_Click(object sender, EventArgs e)
        {
            if (tokenSource is null) {
                return;
            }
            // tokenのcancelフラグを立てる
            tokenSource.Cancel();
        }

        // 別タスクからのコントロール操作はdelegateで呼び出しが必要
        private delegate void DelegateUpdate(int progress);

        // 別タスクからの更新通知
        private void UpdateBackGroundProgressBar(int progress)
        {
            // Invokeが必要
            Invoke(new DelegateUpdate(UpdateBackGroundProgressBarImpl), progress);
        }

        // 実際のコントロール更新処理
        private void UpdateBackGroundProgressBarImpl(int progress)
        {
            BackGroundProgress.Value = progress;
        }

        // yield修飾子のサンプル
        private void YieldStart_Click(object sender, EventArgs e)
        {
            var allStr = "";
            // yield return されるので配列の処理のように書ける
            foreach (var str in new YieldObject()) {
                allStr += str;
                YieldLabel.Text = allStr;
            }
        }
    }
}
