using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.KazanMyo.OyunFrmApp
{
    public partial class frmOyun : Form
    {
        int toplam = 0;
        Random rnd = new Random();
        public frmOyun()
        {
            InitializeComponent();
        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {

            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlGosterge.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Text = rnd.Next(100).ToString();
            btn.Click += btn_Click;
            this.Controls.Add(btn);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblSkor.Text = $"Skor:(toplam)";
            btn.Dispose();
        }
        private void frmOyun_Load(object sender, EventArgs e)
        {
            tmrButton.Start();
            tmrSure.Start();
        }

        FSYaz(lblSkor.Text);

        DialogResult result = new DialogResult();

        result = MessageBox.Show($ GAME OVER! nSkorunuz {lblSkor.Text } Puann +
                Tekrar oynamak için tıklayınız, ÇIKIŞ, MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                   Close();
}
                else
                {
                    Application.Restart();

                }



            }
        }

private static void FSYaz(string deger)
{


    FileStream fs = new FileStream(Skor.txt, FileMode.Append);
    StreamWriter sw = new StreamWriter(fs);
    sw.Write(DateTime.Now +  );
    sw.Write(deger + n);
    fs.Flush();
    sw.Close();
    fs.Close();
}

private void tmrSure_Tick(object sender, EventArgs e)
{
    sure--;
    lblSure.Text = sure.ToString();
    if (lblSure.Text == 0)
    {


        tmrSure.Stop();
        tmrButton.Stop();

        FSYaz(lblSkor.Text);

        DialogResult result = new DialogResult();

        result = MessageBox.Show( $ GAME OVER! nSkorunuz { lblSkor.Text},
        Puann + Tekrar oynamak için tıklayınız , ÇIKIŞ, MessageBoxButtons.YesNo);

        if (result == DialogResult.No)
        {
            Close();
        }
        else
        {
            Application.Restart();

        }

    }
}
