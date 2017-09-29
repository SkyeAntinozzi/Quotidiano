namespace Quatidiano {
     partial class CompletedVocab {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing) {
               if (disposing && (components != null)) {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent() {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletedVocab));
               this.vocabulary = new System.Windows.Forms.RichTextBox();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.doneButton = new System.Windows.Forms.Button();
               this.copyTextButton = new System.Windows.Forms.Button();
               this.groupBox1.SuspendLayout();
               this.SuspendLayout();
               // 
               // vocabulary
               // 
               this.vocabulary.Dock = System.Windows.Forms.DockStyle.Fill;
               this.vocabulary.Location = new System.Drawing.Point(3, 16);
               this.vocabulary.Name = "vocabulary";
               this.vocabulary.ReadOnly = true;
               this.vocabulary.Size = new System.Drawing.Size(416, 265);
               this.vocabulary.TabIndex = 0;
               this.vocabulary.Text = "";
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.vocabulary);
               this.groupBox1.Location = new System.Drawing.Point(12, 3);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(422, 284);
               this.groupBox1.TabIndex = 1;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Vocabolario";
               // 
               // doneButton
               // 
               this.doneButton.Location = new System.Drawing.Point(356, 290);
               this.doneButton.Name = "doneButton";
               this.doneButton.Size = new System.Drawing.Size(75, 23);
               this.doneButton.TabIndex = 2;
               this.doneButton.Text = "Finito";
               this.doneButton.UseVisualStyleBackColor = true;
               this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
               // 
               // copyTextButton
               // 
               this.copyTextButton.Location = new System.Drawing.Point(275, 290);
               this.copyTextButton.Name = "copyTextButton";
               this.copyTextButton.Size = new System.Drawing.Size(75, 23);
               this.copyTextButton.TabIndex = 3;
               this.copyTextButton.Text = "Copia";
               this.copyTextButton.UseVisualStyleBackColor = true;
               this.copyTextButton.Click += new System.EventHandler(this.copyTextButton_Click);
               // 
               // CompletedVocab
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(442, 318);
               this.Controls.Add(this.copyTextButton);
               this.Controls.Add(this.doneButton);
               this.Controls.Add(this.groupBox1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "CompletedVocab";
               this.Text = "Vocabolario Completo";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompletedVocab_FormClosing);
               this.groupBox1.ResumeLayout(false);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.RichTextBox vocabulary;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.Button doneButton;
          private System.Windows.Forms.Button copyTextButton;
     }
}