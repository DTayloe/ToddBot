﻿
namespace ToddBot
{
     partial class ToddBotView
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

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToddBotView));
               this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
               ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
               this.SuspendLayout();
               // 
               // axVLCPlugin21
               // 
               this.axVLCPlugin21.Dock = System.Windows.Forms.DockStyle.Fill;
               this.axVLCPlugin21.Enabled = true;
               this.axVLCPlugin21.Location = new System.Drawing.Point(0, 0);
               this.axVLCPlugin21.Name = "axVLCPlugin21";
               this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
               this.axVLCPlugin21.Size = new System.Drawing.Size(800, 450);
               this.axVLCPlugin21.TabIndex = 0;
               // 
               // ToddBotView
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.axVLCPlugin21);
               this.Name = "ToddBotView";
               this.Text = "Form2";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToddBotView_FormClosing);
               ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
     }
}