using Spire.Barcode;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessModifiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Personal prsn = new Personal(textBox1.Text,textBox2.Text,textBox3.Text);
            QRYaz(prsn.userInfo());
           // QRYaz("12345");

        }

        public void QRYaz(string data)
        {
            BarcodeSettings.ApplyKey("your key");
            BarcodeSettings settings = new BarcodeSettings();
            settings.Type = BarCodeType.QRCode;
            settings.Unit = GraphicsUnit.Pixel;
            settings.ShowText = false;
            settings.ResolutionType = ResolutionType.UseDpi;

            settings.Data = data;
            settings.X = 10;

            BarCodeGenerator generator = new BarCodeGenerator(settings);
            Image QRbarcode = generator.GenerateImage();
            //display QR code image in picture box  
            pictureBox1.Image = QRbarcode;
        }
    }
}
