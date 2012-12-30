using System;
using System.Windows.Forms;

using UsbUirt;
using System.Collections.Generic;
using System.Text;

namespace Enterprisecoding.IRRemote {
    public partial class AnaForm : Form {
        private Controller usbuirtController;
        private LearnCompletedEventArgs learnCompletedEventArgs = null;
        private Dictionary<string, string> sozluk = new Dictionary<string, string>();

        public AnaForm() {
            InitializeComponent();

            usbuirtController = new Controller();

            usbuirtController.Learning += usbuirtController_Learning;
            usbuirtController.LearnCompleted += usbuirtController_LearnCompleted;
        }

        private void btnOgren_Click(object sender, EventArgs e) {
            pbIlerleme.Value = pbSinyalKalitesi.Value = 0;
            lblTasiyiciFrekans.Text = lblIRKodu.Text = "-";
            lblIlerleme.Text = lblSinyalKalitesi.Text = "%0";

            btnIptal.Enabled = true;
            btnOgren.Enabled = gbOgrenmeSonucu.Enabled = false;

            lblIRKodu.Text = "-";
            tbEylemAdi.Text = string.Empty;

            learnCompletedEventArgs = null;

            usbuirtController.LearnAsync(CodeFormat.Uuirt, LearnCodeModifier.None, learnCompletedEventArgs);
        }

        private void btnIptal_Click(object sender, EventArgs e) {
            usbuirtController.LearnAsyncCancel(learnCompletedEventArgs);

            btnOgren.Enabled = true;
            btnIptal.Enabled = false;
        }

        private void usbuirtController_Learning(object sender, LearningEventArgs e) {
            Invoke(new MethodInvoker(delegate {
                pbIlerleme.Value = e.Progress;
                lblIlerleme.Text = "%" + e.Progress;

                pbSinyalKalitesi.Value = e.SignalQuality;
                lblSinyalKalitesi.Text = "%" + e.SignalQuality;

                lblTasiyiciFrekans.Text = e.CarrierFrequency.ToString();
            }));
        }

        private void usbuirtController_LearnCompleted(object sender, LearnCompletedEventArgs e) {
            learnCompletedEventArgs = e;

            Invoke(new MethodInvoker(delegate {
                pbIlerleme.Value = pbSinyalKalitesi.Value = 0;
                lblTasiyiciFrekans.Text = "-";
                lblIlerleme.Text = lblSinyalKalitesi.Text = "%0";

                if (e.Cancelled) { return; }

                lblIRKodu.Text = e.Code;
                
                MessageBox.Show("Öğrenme işlemi tamamlandı");

                btnOgren.Enabled = true;
                btnIptal.Enabled = false;

                gbOgrenmeSonucu.Enabled = true;
            }));
        }

        private void btnTest_Click(object sender, EventArgs e) {
            usbuirtController.Transmit(learnCompletedEventArgs.Code, CodeFormat.Uuirt, 1, TimeSpan.Zero);
            MessageBox.Show("Test tamamlandı");
        }

        private void btnKoduSakla_Click(object sender, EventArgs e) {
            if (sozluk.ContainsKey(tbEylemAdi.Text)) {
                if (MessageBox.Show("Bu girdi daha önceden eklenmiş durumda, güncellemek ister misiniz?", "Girdi Kayıtlı",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) {
                    return;
                }

                sozluk.Remove(tbEylemAdi.Text);
            }

            sozluk.Add(tbEylemAdi.Text, learnCompletedEventArgs.Code);

            MessageBox.Show("Öğrenilen kod '" + tbEylemAdi.Text + "' adıyla saklandı");
        }

        private void btnKodOlustur_Click(object sender, EventArgs e){
            var kod = new StringBuilder();

            foreach (var eylemAdi in sozluk.Keys) {
                kod.AppendFormat(@"const string {0} = ""{1}"";{2}", eylemAdi, sozluk[eylemAdi], Environment.NewLine);
            }

            lblKod.Text = kod.ToString();

            MessageBox.Show("Kod üretildi");
        }
    }
}
