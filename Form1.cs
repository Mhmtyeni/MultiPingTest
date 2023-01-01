using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
namespace multiPingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct sExplain
        {
            public string sIpAdress;
            public string sExplaining;
        }
        // ======================
        List<myNetwork> myIps = new List<myNetwork>();
        List<sExplain> lExplain = new List<sExplain>();
        public bool bAllStopped = false;
        // ======================
        class myNetwork
        {
            // ======================
            public string sIpAdress = "";
            public string sIpStatus = "";
            public string sExplain = "";
            public bool bSync, bReply;
            public int iPingTime, iReplyTime, iTotalPing, iAbovePingReplyTime, iBelowPingReplyTime;
            public double iTotalFailTime = 0;
            public long iCurrentReplyTime;
            public Thread th;
            // ======================
            public myNetwork(string sIpAdress, bool bSync, int iPingTime, int iReplyTime, string sExplanition)
            {
                this.sIpAdress = sIpAdress;
                this.bSync = bSync;
                this.iPingTime = iPingTime;
                this.iReplyTime = iReplyTime;
                this.sExplain = sExplanition;
                th = new Thread(new ThreadStart(sendPing));
                th.Name = this.sIpAdress;
                start();
            }
            // ======================
            public void start()
            {
                th.Start();
            }
            // ======================
            public void stop()
            {
                th.Suspend();
            }
            public void unSuspend()
            {
                if (th.ThreadState == ThreadState.Suspended)
                {
                    th.Resume();
                }
            }
            // ======================
            private void sendPing()
            {
                while (th.ThreadState == ThreadState.Running)
                {
                    Ping pinger = null;
                    try
                    {
                        if (this.bSync)
                        {
                            pinger = new Ping();
                            PingReply reply = pinger.Send(this.sIpAdress, 1000);
                            bReply = reply.Status == IPStatus.Success;
                            if (reply.Status == IPStatus.Success)
                            {
                                sIpStatus = "Başarılı";
                            }
                            if (reply.Status == IPStatus.TimedOut)
                            {
                                sIpStatus = "Zaman Aşımı";
                            }
                            if (reply.Status != IPStatus.Success && reply.Status != IPStatus.TimedOut)
                            {
                                sIpStatus = "Başarısız";
                            }
                            iCurrentReplyTime = reply.RoundtripTime;
                            if (this.iReplyTime > reply.RoundtripTime)
                            {
                                iAbovePingReplyTime++;
                            }
                            else
                            {
                                iBelowPingReplyTime++;
                            }
                            if (reply.Status != IPStatus.Success)
                            {
                                iTotalFailTime = iTotalFailTime + iPingTime;
                            }
                        }
                        else
                        {
                            Random random = new Random();
                            iPingTime = random.Next(0, 2000);
                            pinger = new Ping();
                            PingReply reply = pinger.Send(this.sIpAdress, 1000);
                            bReply = reply.Status == IPStatus.Success;
                            if (reply.Status == IPStatus.Success)
                            {
                                sIpStatus = "Başarılı";
                            }
                            if (reply.Status == IPStatus.TimedOut)
                            {
                                sIpStatus = "Zaman Aşımı";
                            }
                            if (reply.Status != IPStatus.Success && reply.Status != IPStatus.TimedOut)
                            {
                                sIpStatus = "Başarısız";
                            }
                            iCurrentReplyTime = reply.RoundtripTime;
                            if (this.iReplyTime > reply.RoundtripTime)
                            {
                                iAbovePingReplyTime++;
                            }
                            else
                            {
                                iBelowPingReplyTime++;
                            }
                            if (reply.Status != IPStatus.Success)
                            {
                                iTotalFailTime = iTotalFailTime + iPingTime;
                            }
                        }
                    }
                    catch (PingException)
                    {
                        iTotalFailTime = iTotalFailTime + iPingTime;
                        // return false
                    }
                    finally
                    {
                        if (pinger != null)
                        {
                            pinger.Dispose();
                            this.iTotalPing++;
                        }
                    }
                    Thread.Sleep(iPingTime);
                }
            }
            // ======================
        }
        // ======================
        #region ' Check Box '
        // ======================
        private void cbSync_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSync.Checked)
            {
                tbPingTime.Enabled = true;
                cbAsync.Enabled = false;
            }
            else
            {
                cbAsync.Enabled = true;
                tbPingTime.Enabled = false;
            }
        }
        // ======================
        private void cbAsync_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAsync.Checked)
            {
                tbPingTime.Enabled = false;
                cbSync.Enabled = false;
            }
            else
            {
                cbSync.Enabled = true;
            }
        }
        // ======================
        #endregion
        // ======================
        #region ' Buttons '
        // ======================
        private void btnAddIp_Click(object sender, EventArgs e)
        {
            if (tbIpAddress.Text != "")
            {
                if (!cmbIpAdresses.Items.Contains(tbIpAddress.Text))
                {
                    sExplain tempStruct = new sExplain();
                    cmbIpAdresses.Items.Add(tbIpAddress.Text);
                    cmbIpAdresses.SelectedItem = cmbIpAdresses.Items[cmbIpAdresses.Items.Count - 1];
                    tempStruct.sIpAdress = tbIpAddress.Text;
                    tempStruct.sExplaining = tbExplain.Text;
                    lExplain.Add(tempStruct);
                }
                else
                {
                    pokeMessage("Bu IP adresi zaten kayıtlı!", MessageBoxIcon.Error);
                }
            }
            else
            {
                pokeMessage("Lütfen IP adresini giriniz!", MessageBoxIcon.Error);
            }
        }
        // ======================
        private void btnStartSendPing_Click(object sender, EventArgs e)
        {
            if (cbSync.Checked && !cbAsync.Checked)
            {
                sendSync();
            }
            else if (cbAsync.Checked && !cbSync.Checked)
            {
                sendAsync();
            }
            else if (!cbSync.Checked && !cbAsync.Checked)
            {
                pokeMessage("Senkron veya asenkron seçimi yapmadınız!", MessageBoxIcon.Error);
            }
        }
        // ======================
        private void btnStopSendPing_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myIps.Count; i++)
            {
                if (myIps[i].sIpAdress == cmbIpAdresses.SelectedItem.ToString())
                {
                    myIps[i].stop();
                }
            }
        }
        // ======================
        private void btnSaveToExcell_Click(object sender, EventArgs e)
        {
            if (dgvIpAddresses.Rows.Count >= 1)
            {
                if (bAllStopped)
                {
                    try
                    {
                        string folderPath = "";
                        FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
                        if (directchoosedlg.ShowDialog() == DialogResult.OK)
                        {
                            folderPath = directchoosedlg.SelectedPath;
                        }
                        System.IO.StreamWriter file = new System.IO.StreamWriter(@folderPath + "\\" + DateTime.Today.ToShortDateString() + ".txt");
                        string sLine = "";
                        for (int r = 0; r <= dgvIpAddresses.Rows.Count - 1; r++)
                        {
                            for (int c = 0; c <= dgvIpAddresses.Columns.Count - 1; c++)
                            {
                                file.Write(dgvIpAddresses.Columns[c].HeaderText + " : " + dgvIpAddresses.Rows[r].Cells[c].Value + " | ");
                            }
                            foreach (myNetwork x in myIps)
                            {
                                if (x.sIpAdress == dgvIpAddresses.Rows[r].Cells[1].Value.ToString())
                                {
                                    file.Write("===== " + "Ayarlar -->  Ping Cevap Süresi [ms] : " + x.iReplyTime + " | Ping Atma Aralığı [ms] : " + x.iPingTime + " | Senkron/Asenkron [True=Senkron/False=Asenkron] : " + x.bSync);
                                }
                            }
                            file.WriteLine(sLine);
                            file.WriteLine("========================================================");
                            sLine = "";
                        }
                        file.Close();
                    }
                    catch
                    {
                        pokeMessage("Veriler kaydedilirken bir problem oluştu.", MessageBoxIcon.Error);
                    }
                }
                else
                {
                    pokeMessage("Tüm iş parçacıklarını durdurduktan sonra kaydedebilirsiniz.", MessageBoxIcon.Error);
                }
            }
            else
            {
                pokeMessage("Kaydedilecek log bulunmamaktadır.", MessageBoxIcon.Error);
            }
        }
        // ======================
        private void btnStopAll_Click(object sender, EventArgs e)
        {
            foreach (myNetwork x in myIps)
            {
                x.stop();
            }
            bAllStopped = true;
        }
        // ======================
        #endregion
        // ======================
        #region ' Sub Methods '
        // ======================
        public void sendSync()
        {
            bool isExist = false;
            bool threadRunning = false;
            string sExplanition = "";
            if (cbSync.Checked && tbReplyTime.Text != "" && tbPingTime.Text != "")
            {
                foreach (myNetwork x in myIps)
                {
                    if (x.sIpAdress == cmbIpAdresses.SelectedItem.ToString())
                    {
                        if (x.th.ThreadState == ThreadState.Suspended)
                        {
                            x.bSync = true;
                            x.iPingTime = Convert.ToInt32(tbPingTime.Text);
                            x.iReplyTime = Convert.ToInt32(tbReplyTime.Text);
                            x.unSuspend();
                            bAllStopped = false;
                            threadRunning = true;
                        }
                        else
                        {
                            isExist = true;
                        }
                    }
                }
                if (!isExist && !threadRunning)
                {
                    foreach (sExplain explain in lExplain)
                    {
                        if (explain.sIpAdress == cmbIpAdresses.SelectedItem.ToString())
                        {
                            sExplanition = explain.sExplaining;
                        }
                    }
                    myNetwork ping1 = new myNetwork(cmbIpAdresses.SelectedItem.ToString(), true, Convert.ToInt32(tbPingTime.Text), Convert.ToInt32(tbReplyTime.Text), sExplanition);
                    myIps.Add(ping1);
                    bAllStopped = false;
                }
                if (isExist && !threadRunning)
                {
                    pokeMessage("Bu ping görevi zaten başlatıldı!", MessageBoxIcon.Error);
                }
            }
            else
            {
                pokeMessage("Gerekli tüm alanları işaretleyiniz!", MessageBoxIcon.Error);
            }
        }
        // ======================
        private void sendAsync()
        {
            bool isExist = false;
            bool threadRunning = false;
            if (cbAsync.Checked && tbReplyTime.Text != "")
            {
                foreach (myNetwork x in myIps)
                {
                    if (x.sIpAdress == cmbIpAdresses.SelectedItem.ToString())
                    {
                        if (x.th.ThreadState == ThreadState.Suspended)
                        {
                            x.bSync = false;
                            x.iReplyTime = Convert.ToInt32(tbReplyTime.Text);
                            x.unSuspend();
                            bAllStopped = false;
                            threadRunning = true;
                        }
                        else
                        {
                            isExist = true;
                        }
                    }
                }
                if (!isExist && !threadRunning)
                {
                    myNetwork ping1 = new myNetwork(cmbIpAdresses.SelectedItem.ToString(), false, 0, Convert.ToInt32(tbReplyTime.Text), tbExplain.Text);
                    myIps.Add(ping1);
                    bAllStopped = false;
                }
                if (isExist && !threadRunning)
                {
                    pokeMessage("Bu ping görevi zaten başlatıldı!", MessageBoxIcon.Error);
                }
            }
            else
            {
                pokeMessage("Gerekli tüm alanları işaretleyiniz!", MessageBoxIcon.Error);
            }
        }
        // ======================
        private void pokeMessage(string sMessage, MessageBoxIcon messageBoxIcon)
        {
            MessageBox.Show(sMessage, "Ping Uygulaması", MessageBoxButtons.OK, messageBoxIcon);
        }
        // ======================
        private void tbIpAddress_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbIpAddress.Text, "[^0-9-.]"))
            {
                pokeMessage("Ip adresinde harf olamaz!", MessageBoxIcon.Error);
                tbIpAddress.Text = tbIpAddress.Text.Remove(tbIpAddress.Text.Length - 1);
                tbIpAddress.Select(tbIpAddress.Text.Length, tbIpAddress.Text.Length);
            }
        }
        // ======================
        private void tbPingTime_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbPingTime.Text, "[^0-9]"))
            {
                pokeMessage("Ping süresinde harf olamaz!", MessageBoxIcon.Error);
                tbPingTime.Text = tbPingTime.Text.Remove(tbPingTime.Text.Length - 1);
                tbPingTime.Select(tbPingTime.Text.Length, tbIpAddress.Text.Length);
            }
        }
        // ======================
        private void tbReplyTime_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbReplyTime.Text, "[^0-9]"))
            {
                pokeMessage("Ping cevap limit süresinde harf olamaz!", MessageBoxIcon.Error);
                tbReplyTime.Text = tbReplyTime.Text.Remove(tbReplyTime.Text.Length - 1);
                tbReplyTime.Select(tbReplyTime.Text.Length, 0);
            }
        }
        // ======================
        private void showData()
        {
            dgvIpAddresses.Rows.Clear();
            for (int i = 0; i < myIps.Count; i++)
            {
                dgvIpAddresses.Rows.Add();
                dgvIpAddresses.Rows[i].Cells[0].Value = myIps[i].sExplain;
                dgvIpAddresses.Rows[i].Cells[1].Value = myIps[i].sIpAdress;
                dgvIpAddresses.Rows[i].Cells[2].Value = myIps[i].iBelowPingReplyTime;
                dgvIpAddresses.Rows[i].Cells[3].Value = myIps[i].iAbovePingReplyTime;
                dgvIpAddresses.Rows[i].Cells[4].Value = myIps[i].iTotalPing;
                dgvIpAddresses.Rows[i].Cells[5].Value = myIps[i].iCurrentReplyTime;
                dgvIpAddresses.Rows[i].Cells[6].Value = myIps[i].iTotalFailTime / 1000;
                dgvIpAddresses.Rows[i].Cells[7].Value = myIps[i].sIpStatus;
            }
        }
        #endregion
        // ======================
        #region ' Form Methods '
        // ======================
        private void Form1_Load(object sender, EventArgs e)
        {
            tbPingTime.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;
            dataTimer.Start();
        }
        // ======================
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (myNetwork x in myIps)
            {
                x.unSuspend();
                x.th.Abort();
                dataTimer.Stop();
            }
        }
        // ======================
        private void dataTimer_Tick(object sender, EventArgs e)
        {
            showData();
        }
        // ======================
        #endregion
        // ======================
    }
}
