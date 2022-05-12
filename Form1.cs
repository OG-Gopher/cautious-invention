using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessAroundApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK to confirm that you want to close the application.");
            // This order displays a MessageBox Dialog before closing the app.
            
            Application.Exit();
            // When this line above is triggered, the app closes.
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Unused worker
            // For future reference
        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Unused, for future reference
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.DefaultExt = "*.cautious";
            openFile1.Filter = "CAUTIOUS files|*.cautious";

            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile1.FileName.Length > 0)

            {
                richTextBox1.LoadFile(openFile1.FileName);
            }

            MessageBox.Show("Successfully opened CAUTIOUS Text file located at " + openFile1.FileName + "!");

            // openFileDialog1.ShowDialog();
            // richTextBox1.LoadFile(openFileDialog1.FileName);
            // Old test code, don't use.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // saveFileDialog1.ShowDialog();
            SaveFileDialog saveFile1 = new SaveFileDialog();


            saveFile1.DefaultExt = "*.cautious";
            saveFile1.Filter = "CAUTIOUS files|*.cautious";

            // Determine user selections
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)

            {

                richTextBox1.SaveFile(saveFile1.FileName);

                // richTextBox1.SaveFile(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\txt.gopher", RichTextBoxStreamType.RichNoOleObjs);
                // Above unused, saves to a default file (under C:\Users\UserAcct\Documents\*.cautious) but does not allow a user selection.
            }

            richTextBox1.Clear();
            // Clear contents of Rich Text Box, then display Save Success dialog.
            MessageBox.Show("Successfully saved CAUTIOUS Text file to " + saveFile1.FileName + "!");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Unused, for future reference
        }

    }
}
