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

namespace Presentation.Dialogs
{
    public partial class Backup : Form
    {
        Thread thBackup;
        bool running = false;
        public Backup()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (running)
            {
                pgsProgress.Value = 0;
                lblLog.Text = "";
                btnStart.Text = "شروع";
                thBackup.Abort();
                running = false;
            }
            else
            {
                if (thBackup == null || thBackup.ThreadState == ThreadState.Aborted)
                {
                    thBackup = new Thread(DoBackup);
                }
                btnStart.Text = "توقف";
                thBackup.Start();
                running = true;
            }
        }
        private void DoBackup()
        {

        }
        private void Log(string msg)
        {
            Invoke(new Action(() =>
            {
                lblLog.Text = msg;
            }));
        }
        private void SetMaxProgress(int max)
        {
            Invoke(new Action(() =>
            {
                pgsProgress.Maximum = max;
            }));
        }
        private void SetProgress(int value)
        {
            Invoke(new Action(() =>
            {
                pgsProgress.Value = value;
            }));
        }
    }
}
