namespace OtoTus2
{
    public partial class Form1 : Form
    {
        
        private System.Windows.Forms.Timer _timer1 = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer _timer2 = new System.Windows.Forms.Timer();



        public Form1()
        {
            InitializeComponent();
            _timer1.Interval = 1000; // 1 saniyede bir vuruþ yapmasý için
            _timer1.Tick += Timer1_Tick;
            _timer2.Interval = 1000;
            _timer2.Tick += Timer2_Tick;
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            SendKeys.Send("{é}");
        }

        private void Timer2_Tick(object? sender, EventArgs e)
        {
            SendKeys.Send("1");
        }
        private bool _isKey1Active = false;

        private void btnKey1_Click(object sender, EventArgs e)
        {
            _isKey1Active = !_isKey1Active; // Durumu tersine çevir

            if (_isKey1Active)
            {
                btnKey1.Text = "Deaktif Et";
                _timer1.Start(); // Timer1'i baþlat
            }
            else
            {
                btnKey1.Text = "Aktif Et";
                _timer1.Stop(); // Timer1'i durdur
            }
        }
        private bool _isKey2Active = false;
        private void btnKey2_Click(object sender, EventArgs e)
        {
            _isKey2Active = !_isKey2Active; // Durumu tersine çevir

            if (_isKey2Active)
            {
                btnKey2.Text = "Deaktif Et";
                _timer2.Start(); // Timer2'yi baþlat
            }
            else
            {
                btnKey2.Text = "Aktif Et";
                _timer2.Stop(); // Timer2'yi durdur
            }
        }
    }
}
