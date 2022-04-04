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
     public partial class VoiceSoundControl : UserControl
     {
          private VoiceSound voiceSound = null;

          public VoiceSoundControl(VoiceSound voiceSound)
          {
               InitializeComponent();
               this.voiceSound = voiceSound;

               btnVoicePlay.Text = voiceSound.VoiceSoundName;
          }

          private void btnVoicePlay_Click(object sender, EventArgs e)
          {
               voiceSound.Play();
          }
     }
}
