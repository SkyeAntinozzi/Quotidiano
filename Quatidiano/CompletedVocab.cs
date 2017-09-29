using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quatidiano {
     public partial class CompletedVocab : Form {
          public CompletedVocab() {
               InitializeComponent();
          }

          private void doneButton_Click(object sender, EventArgs e) {
               Application.Exit();
          }

          private void copyTextButton_Click(object sender, EventArgs e) {
               Clipboard.SetText(vocabulary.Text, TextDataFormat.Text);
          }

          public void setText(String text) {
               vocabulary.Text = text;
          }

          private void CompletedVocab_FormClosing(object sender, FormClosingEventArgs e) {
               Application.Exit();
          }
     }
}
