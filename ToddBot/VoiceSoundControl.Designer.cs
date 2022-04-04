
namespace ToddBot
{
     partial class VoiceSoundControl
     {
          /// <summary> 
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary> 
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.btnVoicePlay = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // btnVoicePlay
               // 
               this.btnVoicePlay.AutoSize = true;
               this.btnVoicePlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.btnVoicePlay.Dock = System.Windows.Forms.DockStyle.Fill;
               this.btnVoicePlay.Location = new System.Drawing.Point(0, 0);
               this.btnVoicePlay.MinimumSize = new System.Drawing.Size(100, 50);
               this.btnVoicePlay.Name = "btnVoicePlay";
               this.btnVoicePlay.Size = new System.Drawing.Size(100, 50);
               this.btnVoicePlay.TabIndex = 1;
               this.btnVoicePlay.Text = "Play";
               this.btnVoicePlay.UseVisualStyleBackColor = true;
               this.btnVoicePlay.Click += new System.EventHandler(this.btnVoicePlay_Click);
               // 
               // VoiceSoundControl
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.BackColor = System.Drawing.SystemColors.ControlDark;
               this.Controls.Add(this.btnVoicePlay);
               this.Name = "VoiceSoundControl";
               this.Size = new System.Drawing.Size(100, 50);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion
          private System.Windows.Forms.Button btnVoicePlay;
     }
}
