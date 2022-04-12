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
using System.Windows.Media;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ToddBot
{
     public partial class Form1 : Form
     {
          private string projectFolder = null;

          private Dictionary<string, List<VoiceSound>> sounds = new Dictionary<string, List<VoiceSound>>();

          public Form1()
          {
               InitializeComponent();
          }

          private void ImportProject(string projectFolder)
          {
               if (Directory.Exists(projectFolder))
               {
                    Console.WriteLine(projectFolder);

                    this.projectFolder = projectFolder;

                    ImportSounds();

                    PopulateComboBox();

                    UpdateUI(projectFolder);
               }
          }

          private void ImportSounds()
          {
               DirectoryInfo projectDirInfo = new DirectoryInfo(projectFolder);
               foreach (var voiceFolder in projectDirInfo.GetDirectories())
               {
                    sounds[voiceFolder.Name] = PlayerUtilities.GetVoiceSounds(voiceFolder.FullName);
               }
          }

          private void PopulateComboBox()
          {
               comboBoxVoiceFolder.Items.Clear();
               foreach (var voiceFolder in sounds.Keys)
               {
                    comboBoxVoiceFolder.Items.Add(voiceFolder);
               }
          }

          private void UpdateUI(string folder)
          {
               comboBoxVoiceFolder.SelectedIndex = comboBoxVoiceFolder.Items.Count > 0 ? 0 : -1;
               txtVoiceProjectFolder.Text = folder;
          }

          private void btnChooseVoiceFolder_Click(object sender, EventArgs e)
          {
               CommonOpenFileDialog dialog = new CommonOpenFileDialog();
               dialog.IsFolderPicker = true;
               if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
               {
                    string folder = dialog.FileName;
                    ImportProject(folder);
               }
          }

          private void comboBoxVoiceFolder_SelectedValueChanged(object sender, EventArgs e)
          {
               Console.WriteLine($"Selected value changed to {comboBoxVoiceFolder.SelectedItem}");

               var voiceControls = new List<Control>();

               foreach (var sound in sounds[(string)comboBoxVoiceFolder.Items[comboBoxVoiceFolder.SelectedIndex]])
               {
                    voiceControls.Add(new VoiceSoundControl(sound));
               }

               flpVoiceItems.Controls.Clear();
               flpVoiceItems.Controls.AddRange(voiceControls.ToArray());
          }
     }

     public class PlayerUtilities
     {
          private static ToddBotView toddBotView = null;

          public static List<VoiceSound> GetVoiceSounds(string voiceFolder)
          {
               List<VoiceSound> sounds = new List<VoiceSound>();

               DirectoryInfo voicePlayerDirInfo = new DirectoryInfo(voiceFolder);
               foreach (var voiceSound in voicePlayerDirInfo.GetFiles("*.wav"))
               {
                    sounds.Add(new VoiceSound(voiceSound.FullName, voiceSound.Name));
               }

               return sounds;
          }

          public static void PlayToddBot(string videoPath)
          {
               if(toddBotView == null)
               {
                    toddBotView = new ToddBotView();
               }

               toddBotView.Show();
               toddBotView.PlayVideo(videoPath);
          }
     }

     public class VoiceSound
     {

          public string VoiceSoundPath { get; private set; }
          public string VoiceSoundName { get; private set; }
          private FileStream Sound { get; set; }
          private System.Media.SoundPlayer Player { get; set; }


          public VoiceSound(string voiceSoundPath, string voiceSoundName)
          {
               Console.WriteLine($"VS: {voiceSoundPath}");
               Sound = new FileStream(voiceSoundPath, FileMode.Open);
               VoiceSoundName = voiceSoundName;
               VoiceSoundPath = voiceSoundPath;
               Player = new System.Media.SoundPlayer(Sound);
          }

          public void Play()
          {
               Player.Play();

               FileInfo voiceFile = new FileInfo(VoiceSoundPath);
               string voiceVideoFile = voiceFile.DirectoryName + Path.DirectorySeparatorChar + voiceFile.Name.Substring(0,voiceFile.Name.Length-voiceFile.Extension.Length) + ".mp4";

               if (File.Exists(voiceVideoFile))
               {
                    PlayerUtilities.PlayToddBot(voiceVideoFile);
               }
          }
     }
}
