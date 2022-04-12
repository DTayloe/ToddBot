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
     public partial class ToddBotView : Form
     {
          public ToddBotView()
          {
               InitializeComponent();
               axVLCPlugin21.AutoPlay = false;
               axVLCPlugin21.AutoLoop = false;
          }

          public void PlayVideo(string videoPath)
          {
               axVLCPlugin21.playlist.stop();
               axVLCPlugin21.playlist.items.clear();

               axVLCPlugin21.playlist.add(@"file:///" + videoPath);
               axVLCPlugin21.playlist.play();
          }

          private void ToddBotView_FormClosing(object sender, FormClosingEventArgs e)
          {
               if (e.CloseReason == CloseReason.UserClosing)
               {
                    e.Cancel = true;
                    Hide();
               }
          }
     }
}
