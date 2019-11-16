using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCSharpApp
{
    public partial class MainForm : Form
    {
        private BackGroundProcess backGroundProcess;

        public MainForm()
        {
            InitializeComponent();
            backGroundProcess = new BackGroundProcess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        private void DispSubButton_Click(object sender, EventArgs e)
        {
            SubForm subObj = new SubForm();
            subObj.updateTextDelegate += new UpdateTextDelegate(UpdateTextHandler);
            subObj.Show();
        }

        private void UpdateTextHandler(string message)
        {
            DispTextBox.Text = message;
        }

        private void StartBackGround_Click(object sender, EventArgs e)
        {
            backGroundProcess.updateBackGroundProcess += new UudateBackGroundProcess(UpdateBackGroundProgressBar);

            // 別タスクでプロセスを開始する
            Task<Boolean> task = Task.Run(() =>
            {
                return backGroundProcess.StartProcess();
            });
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

    }
}
