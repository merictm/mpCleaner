using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mpCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string batFilePath = "genelTemizle.bat";
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = batFilePath,
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process process = Process.Start(processInfo);
                process.WaitForExit();

                MessageBox.Show("Genel Temizleme İşlemi Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string batFilePath = "logTemizle.bat";
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = batFilePath,
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process process = Process.Start(processInfo);
                process.WaitForExit();

                MessageBox.Show("Log Temizleme İşlemi Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string batFilePath = "geriDonusum.bat";
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = batFilePath,
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process process = Process.Start(processInfo);
                process.WaitForExit();

                MessageBox.Show("Geri Dönüşüm Temizleme İşlemi Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string batFilePath = "updateTemizle.bat";
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = batFilePath,
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process process = Process.Start(processInfo);
                process.WaitForExit();

                MessageBox.Show("Update Artıkları Temizleme İşlemi Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string batFilePath = "prefecthTemizle.bat";
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = batFilePath,
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process process = Process.Start(processInfo);
                process.WaitForExit();

                MessageBox.Show("Prefecht Temizleme İşlemi Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CMD ile yapılabilecek temizlik işlemlerinin bir kısmı burada sunulmuştur.","mpCleaner");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "www.instagram.com/mericktm/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }
    }
}
