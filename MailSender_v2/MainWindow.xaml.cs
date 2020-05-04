using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace MailSender_v2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClock_Click(object sender, RoutedEventArgs e)
        {
            //tabControl.SelectedItem = tabPlanner;

            TabTimer.IsSelected = true;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSendAtOnce_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(StringFromRichTextBox(LetterBody));


            //if (StringFromRichTextBox(LetterBody) == "\r\n")
            //{
            //    MessageBox.Show(StringFromRichTextBox(LetterBody));
            //}

            if (StringFromRichTextBox(LetterBody).Length <= 2)
            {
                MessageBox.Show("Письмо не заполнено");
                LetterEditor.IsSelected = true;
            }
        }

        string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                // TextPointer to the start of content in the RichTextBox.
                rtb.Document.ContentStart,
                // TextPointer to the end of content in the RichTextBox.
                rtb.Document.ContentEnd
            );

            // The Text property on a TextRange object returns a string
            // representing the plain text content of the TextRange.
            return textRange.Text;
        }
    }
}
