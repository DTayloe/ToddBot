using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToddBot
{
     public partial class Form1 : Form
     {
          string[] sounds = {
               @"C:\Users\diomo\Documents\Audacity\Hello.wav",
               @"C:\Users\diomo\Documents\Audacity\Meeroh.wav",
               @"C:\Users\diomo\Documents\Audacity\Woah.wav"
          };

          public Form1()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               PlayWav(sounds[0]);
          }

          public void PlayWav(string filePath)
          {
               System.Media.SoundPlayer player = new System.Media.SoundPlayer(filePath);
               player.Play();
          }
     }
}
