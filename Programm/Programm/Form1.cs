using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Programm
{
    public partial class Form1 : Form
    {

        public string i = Environment.UserName;
        Timer timer = new Timer();
        public static DateTime Now { get; } // Uhrzeit holen
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000; // Setzt das Intervall auf 1 Sekunde (1000 Millisekunden)
            timer.Tick += new EventHandler(timer1_Tick); // Fügt das Event hinzu, das bei jedem Tick aufgerufen wird
            timer.Start(); // Startet den Time

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pfad = @"C:\Users\"+i+ @"\Downloads"; 


                // Erhalten Sie alle Bilddateien im Verzeichnis (jpg, png, bmp, gif, etc.)
                var imageFiles = Directory.GetFiles(pfad, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".bmp") || s.EndsWith(".gif"));
            // Durchlaufen Sie jede Bilddatei und löschen Sie sie
            foreach (var imageFile in imageFiles)
            {
                File.Delete(imageFile);
            }
            MessageBox.Show("Fertig!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
