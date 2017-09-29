namespace Quatidiano {
     partial class MainForm {
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
               this.englishInput = new System.Windows.Forms.TextBox();
               this.italianInput = new System.Windows.Forms.TextBox();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.submitButton = new System.Windows.Forms.Button();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.label1 = new System.Windows.Forms.Label();
               this.maxDailyTotal = new System.Windows.Forms.TextBox();
               this.currentDailyTotal = new System.Windows.Forms.TextBox();
               this.groupBox3 = new System.Windows.Forms.GroupBox();
               this.accentLeftBigO = new System.Windows.Forms.Button();
               this.accentLeftBigU = new System.Windows.Forms.Button();
               this.accentLeftBigI = new System.Windows.Forms.Button();
               this.accentRightBigE = new System.Windows.Forms.Button();
               this.accentLeftBigE = new System.Windows.Forms.Button();
               this.accentLeftLittleA = new System.Windows.Forms.Button();
               this.accentLeftBigA = new System.Windows.Forms.Button();
               this.accentLeftLittleE = new System.Windows.Forms.Button();
               this.accentRightLittleE = new System.Windows.Forms.Button();
               this.accentLeftLittleI = new System.Windows.Forms.Button();
               this.accentLeftLittleU = new System.Windows.Forms.Button();
               this.accentLeftLittleO = new System.Windows.Forms.Button();
               this.groupBox4 = new System.Windows.Forms.GroupBox();
               this.savedVocabularyGrid = new System.Windows.Forms.DataGridView();
               this.groupBox5 = new System.Windows.Forms.GroupBox();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.groupBox3.SuspendLayout();
               this.groupBox4.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.savedVocabularyGrid)).BeginInit();
               this.groupBox5.SuspendLayout();
               this.SuspendLayout();
               // 
               // englishInput
               // 
               this.englishInput.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.englishInput.Location = new System.Drawing.Point(76, 100);
               this.englishInput.Name = "englishInput";
               this.englishInput.Size = new System.Drawing.Size(297, 39);
               this.englishInput.TabIndex = 2;
               // 
               // italianInput
               // 
               this.italianInput.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.italianInput.Location = new System.Drawing.Point(76, 29);
               this.italianInput.Name = "italianInput";
               this.italianInput.Size = new System.Drawing.Size(297, 39);
               this.italianInput.TabIndex = 1;
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.submitButton);
               this.groupBox1.Controls.Add(this.pictureBox2);
               this.groupBox1.Controls.Add(this.pictureBox1);
               this.groupBox1.Controls.Add(this.englishInput);
               this.groupBox1.Controls.Add(this.italianInput);
               this.groupBox1.Location = new System.Drawing.Point(12, 7);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(452, 157);
               this.groupBox1.TabIndex = 2;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Nuovo Vocabolario";
               // 
               // submitButton
               // 
               this.submitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitButton.BackgroundImage")));
               this.submitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.submitButton.Location = new System.Drawing.Point(388, 58);
               this.submitButton.Name = "submitButton";
               this.submitButton.Size = new System.Drawing.Size(51, 50);
               this.submitButton.TabIndex = 3;
               this.submitButton.UseVisualStyleBackColor = true;
               this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
               // 
               // pictureBox2
               // 
               this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
               this.pictureBox2.Location = new System.Drawing.Point(6, 84);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(64, 64);
               this.pictureBox2.TabIndex = 3;
               this.pictureBox2.TabStop = false;
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(6, 14);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(64, 64);
               this.pictureBox1.TabIndex = 2;
               this.pictureBox1.TabStop = false;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(48, 19);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(27, 19);
               this.label1.TabIndex = 0;
               this.label1.Text = "di";
               // 
               // maxDailyTotal
               // 
               this.maxDailyTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.maxDailyTotal.Location = new System.Drawing.Point(80, 16);
               this.maxDailyTotal.Name = "maxDailyTotal";
               this.maxDailyTotal.Size = new System.Drawing.Size(30, 26);
               this.maxDailyTotal.TabIndex = 1;
               this.maxDailyTotal.TabStop = false;
               this.maxDailyTotal.Text = "50";
               this.maxDailyTotal.LostFocus += new System.EventHandler(this.maxDailyTotal_LostFocus);
               // 
               // currentDailyTotal
               // 
               this.currentDailyTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.currentDailyTotal.Location = new System.Drawing.Point(14, 16);
               this.currentDailyTotal.Name = "currentDailyTotal";
               this.currentDailyTotal.ReadOnly = true;
               this.currentDailyTotal.Size = new System.Drawing.Size(30, 26);
               this.currentDailyTotal.TabIndex = 0;
               this.currentDailyTotal.TabStop = false;
               this.currentDailyTotal.Text = "0";
               // 
               // groupBox3
               // 
               this.groupBox3.Controls.Add(this.accentLeftBigO);
               this.groupBox3.Controls.Add(this.accentLeftBigU);
               this.groupBox3.Controls.Add(this.accentLeftBigI);
               this.groupBox3.Controls.Add(this.accentRightBigE);
               this.groupBox3.Controls.Add(this.accentLeftBigE);
               this.groupBox3.Controls.Add(this.accentLeftLittleA);
               this.groupBox3.Controls.Add(this.accentLeftBigA);
               this.groupBox3.Controls.Add(this.accentLeftLittleE);
               this.groupBox3.Controls.Add(this.accentRightLittleE);
               this.groupBox3.Controls.Add(this.accentLeftLittleI);
               this.groupBox3.Controls.Add(this.accentLeftLittleU);
               this.groupBox3.Controls.Add(this.accentLeftLittleO);
               this.groupBox3.Location = new System.Drawing.Point(470, 7);
               this.groupBox3.Name = "groupBox3";
               this.groupBox3.Size = new System.Drawing.Size(129, 109);
               this.groupBox3.TabIndex = 4;
               this.groupBox3.TabStop = false;
               this.groupBox3.Text = "Personaggi Italiani";
               // 
               // accentLeftBigO
               // 
               this.accentLeftBigO.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentLeftBigO.Location = new System.Drawing.Point(35, 72);
               this.accentLeftBigO.Name = "accentLeftBigO";
               this.accentLeftBigO.Size = new System.Drawing.Size(30, 30);
               this.accentLeftBigO.TabIndex = 14;
               this.accentLeftBigO.TabStop = false;
               this.accentLeftBigO.Text = "Ò";
               this.accentLeftBigO.UseVisualStyleBackColor = true;
               this.accentLeftBigO.Click += new System.EventHandler(this.accentLeftBigO_Click);
               // 
               // accentLeftBigU
               // 
               this.accentLeftBigU.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentLeftBigU.Location = new System.Drawing.Point(64, 72);
               this.accentLeftBigU.Name = "accentLeftBigU";
               this.accentLeftBigU.Size = new System.Drawing.Size(30, 30);
               this.accentLeftBigU.TabIndex = 15;
               this.accentLeftBigU.TabStop = false;
               this.accentLeftBigU.Text = "Ù";
               this.accentLeftBigU.UseVisualStyleBackColor = true;
               this.accentLeftBigU.Click += new System.EventHandler(this.accentLeftBigU_Click);
               // 
               // accentLeftBigI
               // 
               this.accentLeftBigI.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentLeftBigI.Location = new System.Drawing.Point(6, 72);
               this.accentLeftBigI.Name = "accentLeftBigI";
               this.accentLeftBigI.Size = new System.Drawing.Size(30, 30);
               this.accentLeftBigI.TabIndex = 13;
               this.accentLeftBigI.TabStop = false;
               this.accentLeftBigI.Text = "Ì";
               this.accentLeftBigI.UseVisualStyleBackColor = true;
               this.accentLeftBigI.Click += new System.EventHandler(this.accentLeftBigI_Click);
               // 
               // accentRightBigE
               // 
               this.accentRightBigE.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentRightBigE.Location = new System.Drawing.Point(93, 72);
               this.accentRightBigE.Name = "accentRightBigE";
               this.accentRightBigE.Size = new System.Drawing.Size(30, 30);
               this.accentRightBigE.TabIndex = 16;
               this.accentRightBigE.TabStop = false;
               this.accentRightBigE.Text = "É";
               this.accentRightBigE.UseVisualStyleBackColor = true;
               this.accentRightBigE.Click += new System.EventHandler(this.accentRightBigE_Click);
               // 
               // accentLeftBigE
               // 
               this.accentLeftBigE.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentLeftBigE.Location = new System.Drawing.Point(93, 43);
               this.accentLeftBigE.Name = "accentLeftBigE";
               this.accentLeftBigE.Size = new System.Drawing.Size(30, 30);
               this.accentLeftBigE.TabIndex = 12;
               this.accentLeftBigE.TabStop = false;
               this.accentLeftBigE.Text = "È";
               this.accentLeftBigE.UseVisualStyleBackColor = true;
               this.accentLeftBigE.Click += new System.EventHandler(this.accentLeftBigE_Click);
               // 
               // accentLeftLittleA
               // 
               this.accentLeftLittleA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentLeftLittleA.Location = new System.Drawing.Point(6, 14);
               this.accentLeftLittleA.Name = "accentLeftLittleA";
               this.accentLeftLittleA.Size = new System.Drawing.Size(30, 30);
               this.accentLeftLittleA.TabIndex = 0;
               this.accentLeftLittleA.TabStop = false;
               this.accentLeftLittleA.Text = "à";
               this.accentLeftLittleA.UseVisualStyleBackColor = true;
               this.accentLeftLittleA.Click += new System.EventHandler(this.accentLeftLittleA_Click);
               // 
               // accentLeftBigA
               // 
               this.accentLeftBigA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentLeftBigA.Location = new System.Drawing.Point(64, 43);
               this.accentLeftBigA.Name = "accentLeftBigA";
               this.accentLeftBigA.Size = new System.Drawing.Size(30, 30);
               this.accentLeftBigA.TabIndex = 11;
               this.accentLeftBigA.TabStop = false;
               this.accentLeftBigA.Text = "À";
               this.accentLeftBigA.UseVisualStyleBackColor = true;
               this.accentLeftBigA.Click += new System.EventHandler(this.accentLeftBigA_Click);
               // 
               // accentLeftLittleE
               // 
               this.accentLeftLittleE.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentLeftLittleE.Location = new System.Drawing.Point(35, 14);
               this.accentLeftLittleE.Name = "accentLeftLittleE";
               this.accentLeftLittleE.Size = new System.Drawing.Size(30, 30);
               this.accentLeftLittleE.TabIndex = 6;
               this.accentLeftLittleE.TabStop = false;
               this.accentLeftLittleE.Text = "è";
               this.accentLeftLittleE.UseVisualStyleBackColor = true;
               this.accentLeftLittleE.Click += new System.EventHandler(this.accentLeftLittleE_Click);
               // 
               // accentRightLittleE
               // 
               this.accentRightLittleE.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentRightLittleE.Location = new System.Drawing.Point(35, 43);
               this.accentRightLittleE.Name = "accentRightLittleE";
               this.accentRightLittleE.Size = new System.Drawing.Size(30, 30);
               this.accentRightLittleE.TabIndex = 10;
               this.accentRightLittleE.TabStop = false;
               this.accentRightLittleE.Text = "é";
               this.accentRightLittleE.UseVisualStyleBackColor = true;
               this.accentRightLittleE.Click += new System.EventHandler(this.accentRightLittleE_Click);
               // 
               // accentLeftLittleI
               // 
               this.accentLeftLittleI.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentLeftLittleI.Location = new System.Drawing.Point(64, 14);
               this.accentLeftLittleI.Name = "accentLeftLittleI";
               this.accentLeftLittleI.Size = new System.Drawing.Size(30, 30);
               this.accentLeftLittleI.TabIndex = 7;
               this.accentLeftLittleI.TabStop = false;
               this.accentLeftLittleI.Text = "ì";
               this.accentLeftLittleI.UseVisualStyleBackColor = true;
               this.accentLeftLittleI.Click += new System.EventHandler(this.accentLeftLittleI_Click);
               // 
               // accentLeftLittleU
               // 
               this.accentLeftLittleU.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentLeftLittleU.Location = new System.Drawing.Point(6, 43);
               this.accentLeftLittleU.Name = "accentLeftLittleU";
               this.accentLeftLittleU.Size = new System.Drawing.Size(30, 30);
               this.accentLeftLittleU.TabIndex = 9;
               this.accentLeftLittleU.TabStop = false;
               this.accentLeftLittleU.Text = "ù";
               this.accentLeftLittleU.UseVisualStyleBackColor = true;
               this.accentLeftLittleU.Click += new System.EventHandler(this.accentLeftLittleU_Click);
               // 
               // accentLeftLittleO
               // 
               this.accentLeftLittleO.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.accentLeftLittleO.Location = new System.Drawing.Point(93, 14);
               this.accentLeftLittleO.Name = "accentLeftLittleO";
               this.accentLeftLittleO.Size = new System.Drawing.Size(30, 30);
               this.accentLeftLittleO.TabIndex = 8;
               this.accentLeftLittleO.TabStop = false;
               this.accentLeftLittleO.Text = "ò";
               this.accentLeftLittleO.UseVisualStyleBackColor = true;
               this.accentLeftLittleO.Click += new System.EventHandler(this.accentLeftLittleO_Click);
               // 
               // groupBox4
               // 
               this.groupBox4.Controls.Add(this.savedVocabularyGrid);
               this.groupBox4.Location = new System.Drawing.Point(12, 170);
               this.groupBox4.Name = "groupBox4";
               this.groupBox4.Size = new System.Drawing.Size(587, 136);
               this.groupBox4.TabIndex = 5;
               this.groupBox4.TabStop = false;
               this.groupBox4.Text = "Vocabolario Salvato";
               // 
               // savedVocabularyGrid
               // 
               this.savedVocabularyGrid.AllowUserToOrderColumns = true;
               this.savedVocabularyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.savedVocabularyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.savedVocabularyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
               this.savedVocabularyGrid.Location = new System.Drawing.Point(3, 16);
               this.savedVocabularyGrid.Name = "savedVocabularyGrid";
               this.savedVocabularyGrid.Size = new System.Drawing.Size(581, 117);
               this.savedVocabularyGrid.TabIndex = 0;
               this.savedVocabularyGrid.TabStop = false;
               this.savedVocabularyGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.savedVocabularyGrid_RowsAdded);
               // 
               // groupBox5
               // 
               this.groupBox5.Controls.Add(this.label1);
               this.groupBox5.Controls.Add(this.maxDailyTotal);
               this.groupBox5.Controls.Add(this.currentDailyTotal);
               this.groupBox5.Location = new System.Drawing.Point(470, 115);
               this.groupBox5.Name = "groupBox5";
               this.groupBox5.Size = new System.Drawing.Size(129, 49);
               this.groupBox5.TabIndex = 6;
               this.groupBox5.TabStop = false;
               this.groupBox5.Text = "Quotidiano Progresso";
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(609, 312);
               this.Controls.Add(this.groupBox5);
               this.Controls.Add(this.groupBox4);
               this.Controls.Add(this.groupBox3);
               this.Controls.Add(this.groupBox1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Name = "Form1";
               this.Text = "Quotidiano Italiano";
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.groupBox3.ResumeLayout(false);
               this.groupBox4.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.savedVocabularyGrid)).EndInit();
               this.groupBox5.ResumeLayout(false);
               this.groupBox5.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.TextBox englishInput;
          private System.Windows.Forms.TextBox italianInput;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.PictureBox pictureBox2;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.GroupBox groupBox3;
          private System.Windows.Forms.Button accentLeftBigO;
          private System.Windows.Forms.Button accentLeftBigU;
          private System.Windows.Forms.Button accentLeftBigI;
          private System.Windows.Forms.Button accentRightBigE;
          private System.Windows.Forms.Button accentLeftBigE;
          private System.Windows.Forms.Button accentLeftLittleA;
          private System.Windows.Forms.Button accentLeftBigA;
          private System.Windows.Forms.Button accentLeftLittleE;
          private System.Windows.Forms.Button accentRightLittleE;
          private System.Windows.Forms.Button accentLeftLittleI;
          private System.Windows.Forms.Button accentLeftLittleU;
          private System.Windows.Forms.Button accentLeftLittleO;
          private System.Windows.Forms.GroupBox groupBox4;
          private System.Windows.Forms.DataGridView savedVocabularyGrid;
          private System.Windows.Forms.Button submitButton;
          private System.Windows.Forms.TextBox maxDailyTotal;
          private System.Windows.Forms.TextBox currentDailyTotal;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.GroupBox groupBox5;
     }
}

