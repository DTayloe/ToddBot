
namespace ToddBot
{
     partial class Form1
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
               this.tlpVoiceItems = new System.Windows.Forms.TableLayoutPanel();
               this.flpVoiceItems = new System.Windows.Forms.FlowLayoutPanel();
               this.comboBoxVoiceFolder = new System.Windows.Forms.ComboBox();
               this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
               this.btnChooseVoiceProjectFolder = new System.Windows.Forms.Button();
               this.txtVoiceProjectFolder = new System.Windows.Forms.TextBox();
               this.tlpVoiceItems.SuspendLayout();
               this.tableLayoutPanel1.SuspendLayout();
               this.SuspendLayout();
               // 
               // tlpVoiceItems
               // 
               this.tlpVoiceItems.ColumnCount = 1;
               this.tlpVoiceItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
               this.tlpVoiceItems.Controls.Add(this.flpVoiceItems, 0, 2);
               this.tlpVoiceItems.Controls.Add(this.comboBoxVoiceFolder, 0, 1);
               this.tlpVoiceItems.Controls.Add(this.tableLayoutPanel1, 0, 0);
               this.tlpVoiceItems.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tlpVoiceItems.Location = new System.Drawing.Point(0, 0);
               this.tlpVoiceItems.Name = "tlpVoiceItems";
               this.tlpVoiceItems.RowCount = 3;
               this.tlpVoiceItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tlpVoiceItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tlpVoiceItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
               this.tlpVoiceItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
               this.tlpVoiceItems.Size = new System.Drawing.Size(711, 528);
               this.tlpVoiceItems.TabIndex = 0;
               // 
               // flpVoiceItems
               // 
               this.flpVoiceItems.AutoScroll = true;
               this.flpVoiceItems.Dock = System.Windows.Forms.DockStyle.Fill;
               this.flpVoiceItems.Location = new System.Drawing.Point(3, 65);
               this.flpVoiceItems.Name = "flpVoiceItems";
               this.flpVoiceItems.Size = new System.Drawing.Size(705, 460);
               this.flpVoiceItems.TabIndex = 5;
               // 
               // comboBoxVoiceFolder
               // 
               this.comboBoxVoiceFolder.Dock = System.Windows.Forms.DockStyle.Fill;
               this.comboBoxVoiceFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.comboBoxVoiceFolder.FormattingEnabled = true;
               this.comboBoxVoiceFolder.Location = new System.Drawing.Point(3, 38);
               this.comboBoxVoiceFolder.Name = "comboBoxVoiceFolder";
               this.comboBoxVoiceFolder.Size = new System.Drawing.Size(705, 21);
               this.comboBoxVoiceFolder.TabIndex = 2;
               this.comboBoxVoiceFolder.SelectedValueChanged += new System.EventHandler(this.comboBoxVoiceFolder_SelectedValueChanged);
               // 
               // tableLayoutPanel1
               // 
               this.tableLayoutPanel1.AutoSize = true;
               this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.tableLayoutPanel1.ColumnCount = 2;
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
               this.tableLayoutPanel1.Controls.Add(this.btnChooseVoiceProjectFolder, 1, 0);
               this.tableLayoutPanel1.Controls.Add(this.txtVoiceProjectFolder, 0, 0);
               this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
               this.tableLayoutPanel1.Name = "tableLayoutPanel1";
               this.tableLayoutPanel1.RowCount = 1;
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 29);
               this.tableLayoutPanel1.TabIndex = 6;
               // 
               // btnChooseVoiceProjectFolder
               // 
               this.btnChooseVoiceProjectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
               this.btnChooseVoiceProjectFolder.Location = new System.Drawing.Point(627, 3);
               this.btnChooseVoiceProjectFolder.Name = "btnChooseVoiceProjectFolder";
               this.btnChooseVoiceProjectFolder.Size = new System.Drawing.Size(75, 23);
               this.btnChooseVoiceProjectFolder.TabIndex = 4;
               this.btnChooseVoiceProjectFolder.Text = "Choose...";
               this.btnChooseVoiceProjectFolder.UseVisualStyleBackColor = true;
               this.btnChooseVoiceProjectFolder.Click += new System.EventHandler(this.btnChooseVoiceFolder_Click);
               // 
               // txtVoiceProjectFolder
               // 
               this.txtVoiceProjectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
               this.txtVoiceProjectFolder.Location = new System.Drawing.Point(3, 3);
               this.txtVoiceProjectFolder.Name = "txtVoiceProjectFolder";
               this.txtVoiceProjectFolder.ReadOnly = true;
               this.txtVoiceProjectFolder.Size = new System.Drawing.Size(618, 20);
               this.txtVoiceProjectFolder.TabIndex = 3;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(711, 528);
               this.Controls.Add(this.tlpVoiceItems);
               this.Name = "Form1";
               this.Text = "Form1";
               this.tlpVoiceItems.ResumeLayout(false);
               this.tlpVoiceItems.PerformLayout();
               this.tableLayoutPanel1.ResumeLayout(false);
               this.tableLayoutPanel1.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.TableLayoutPanel tlpVoiceItems;
          private System.Windows.Forms.ComboBox comboBoxVoiceFolder;
          private System.Windows.Forms.TextBox txtVoiceProjectFolder;
          private System.Windows.Forms.Button btnChooseVoiceProjectFolder;
          private System.Windows.Forms.FlowLayoutPanel flpVoiceItems;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
     }
}

