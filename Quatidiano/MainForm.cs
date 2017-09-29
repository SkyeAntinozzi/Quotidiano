/* Author: Skye Antinozzi
 * Description: An Italian-English notecard creating program that encourages daily usage by keeping a total of new terms added per day.
 * Each day, the user is encouraged to enter some number of new terms a day and use them in a notecard program like Quizlet.
 */ 
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
     public partial class MainForm : Form {

          // Number of terms to learn per day
          private int currentMaximum = 50;

          // Current number of terms added today
          private int currentTotal = 0;

          // List of Italian/English pairs
          private BindingList<VocabPair> pairs;

          /// <summary>
          /// Nested class for each Italian/English pair
          /// </summary>
          private class VocabPair {

               private String italian;
               public String Italian {
                    get {
                         return italian;
                    }
                    set {
                         italian = value;
                    }
               }

               private String english;
               public String English {
                    get {
                         return english;
                    }
                    set {
                         english = value;
                    }
               }

               public VocabPair(String italian, String english) {
                    this.italian = italian;
                    this.english = english;
               }
          }

          /// <summary>
          /// Initializes the mainform by setting up the vocabulary grid.
          /// </summary>
          public MainForm() {
               
               InitializeComponent();
               
               pairs = new BindingList<VocabPair>();
               BindingSource source = new BindingSource(pairs, null);

               // Setup initial grid
               savedVocabularyGrid.AutoGenerateColumns = false;
               DataGridViewCell cell = new DataGridViewTextBoxCell();
               DataGridViewTextBoxColumn italianColumn = new DataGridViewTextBoxColumn() {
                    CellTemplate = cell,
                    HeaderText = "Italian",
                    DataPropertyName = "Italian" 
               };
               DataGridViewTextBoxColumn englishColumn = new DataGridViewTextBoxColumn() {
                    CellTemplate = cell,
                    HeaderText = "English",
                    DataPropertyName = "English"
               };

               savedVocabularyGrid.Columns.Add(italianColumn);
               savedVocabularyGrid.Columns.Add(englishColumn);
               savedVocabularyGrid.DataSource = source;
          }

          /// <summary>
          /// Appends the passed Button's text to the Italian text field.
          /// </summary>
          /// <param name="button"></param>
          private void appendButtonTextToItalianInput(Object button) {
               Button b = (Button) button;
               italianInput.Text += b.Text;
          }

          // The character button handlers could be refactored to use a single method instead of
          // individual ones for each button. This is fine for now, though.
          # region character button handlers
          private void accentLeftLittleA_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentLeftLittleE_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentLeftLittleI_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentLeftLittleO_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentLeftLittleU_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentRightLittleE_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentLeftBigA_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentLeftBigE_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentLeftBigI_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentLeftBigO_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentLeftBigU_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }

          private void accentRightBigE_Click(object sender, EventArgs e) {
               appendButtonTextToItalianInput(sender);
          }
          #endregion

          /// <summary>
          /// Validates the input to ensure the user hasn't tried to submit an empty string
          /// and is not done for the day. After validation, the new term may or may not be added
          /// to the vocabulary list.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void submitButton_Click(object sender, EventArgs e) {
               bool fieldsAreInvalid = !validateItalianAndEnglishFields();
               bool atMaximum = currentTotal >= currentMaximum;

               if (fieldsAreInvalid) {
                    MessageBox.Show("Niente da salvare!", "Scatole Vuote",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else if (atMaximum) {
                    MessageBox.Show("Tu sei fatto per oggi!", "Quotidiano Vocabolario di Completo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               // Should still add
               else {
                    VocabPair newPair = new VocabPair(italianInput.Text, englishInput.Text);
                    pairs.Add(newPair);
                    updateTotal();
                    resetFields();
               }

               if (currentTotal >= currentMaximum)
                    showCompletedVocab();
          }

          /// <summary>
          /// Validates both the Italian and English fields to ensure an 
          /// empty string is not being passed.
          /// </summary>
          /// <returns></returns>
          private bool validateItalianAndEnglishFields() {
               if ((italianInput.Text.Length > 0) && (englishInput.Text.Length > 0))
                    return true;
               else
                    return false;
          }

          /// <summary>
          /// Sets the fields to empty strings and focuses the Italian text field.
          /// </summary>
          private void resetFields() {
               italianInput.Text = "";
               englishInput.Text = "";
               italianInput.Focus();
          }

          /// <summary>
          /// Increments the daily term total.
          /// </summary>
          private void updateTotal() {
               ++currentTotal;
               currentDailyTotal.Text = "";
               currentDailyTotal.Text += currentTotal;
          }

          /// <summary>
          /// Once the max daily total text field has lost focus, we can save the new total after validation.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void maxDailyTotal_LostFocus(object sender, EventArgs e) {
               TextBox box = (TextBox)sender;
               String text = box.Text;
               int textValue;

               // Empty text box
               if (String.IsNullOrEmpty(text))
                    return;

               // Validate for positive integer
               if (!Int32.TryParse(text, out textValue) || textValue <= 0) {
                    MessageBox.Show("Solo Numeri Naturale (1, 2, 3, ...)!", "Non Valido Quotidiano Massimo",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    box.Text = "";
                    box.Text += currentMaximum;
               }

               // Validate Integer Daily Maximum Restriction
               else if (textValue < currentTotal) {
                    MessageBox.Show("Impossibile Modificare Il Valore Quotidiano Massimo Sotto Il Totale Corrente!", "Non Valido Quotidiano Massimo",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    box.Text = "";
                    box.Text += currentMaximum;
               }
               // Change maximum
               else {
                    currentMaximum = textValue;
               }

               if (currentTotal == currentMaximum)
                    showCompletedVocab();

               System.Diagnostics.Debug.WriteLine(box.Text + " " + currentMaximum);
          }

          /// <summary>
          /// Once the daily maximum has been reached, the user is done for the day.
          /// At this point, we show a delmited list of the terms for the day to be pasted
          /// for use in a 3rd party program (like Quizlet).
          /// </summary>
          private void showCompletedVocab() {
               String completedVocab = "";

               CompletedVocab vocabForm = new CompletedVocab();

               VocabPair lastPair = pairs.Last();
               foreach (VocabPair p in pairs) {
                    completedVocab += p.Italian + "/" + p.English;

                    if (p != lastPair)
                         completedVocab += Environment.NewLine;
               }

               vocabForm.setText(completedVocab);

               vocabForm.ShowDialog();
          }

          /// <summary>
          /// Updates the scrollbar position to the bottom when a term is added.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void savedVocabularyGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
               this.savedVocabularyGrid.CurrentCell = this.savedVocabularyGrid[0, this.savedVocabularyGrid.Rows.Count - 1];
          }
     }
}
