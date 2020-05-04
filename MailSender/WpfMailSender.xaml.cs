using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.Net.Mail;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            // комментарий для git
            // комментарий для git от aka-skif
            // комментарий из ветви test
            // комментарий с работы
            // еще один комментарий с работы
            // ещё один комментарий с github
            InitializeComponent();
            //cbSenderSelect.ItemsSource = VariablesClass.Senders;
            //cbSenderSelect.DisplayMemberPath = "Key";
            //cbSenderSelect.SelectedValuePath = "Value";
        }

        private void btnSendEmail_Click(object sender, RoutedEventArgs e)
        {
            List<string> listStrMails = new List<string> { "uli4kapo4ta@gmail.com" };  // Список email'ов //кому мы отправляем письмо
            string strPassword = passwordBox.Password;  // для WinForms - string strPassword = passwordBox.Text;
            foreach (string mail in listStrMails)
            {
                // Используем using, чтобы гарантированно удалить объект MailMessage после использования
                using (MailMessage mm = new MailMessage("uli4ka_mail@mail.ru", mail))
                {
                    // Формируем письмо
                    mm.Subject = Name_Letter.Text; // Заголовок письма
                    mm.Body = Text_Letter.Text;       // Тело письма
                    mm.IsBodyHtml = false;           // Не используем html в теле письма
                                                     // Авторизуемся на smtp-сервере и отправляем письмо
                                                     // Оператор using гарантирует вызов метода Dispose, даже если при вызове 
                                                     // методов в объекте происходит исключение.
                    using (SmtpClient sc = new SmtpClient("smtp.yandex.ru", 465))
                    {
                        sc.EnableSsl = true;
                        sc.Credentials = new NetworkCredential("uli4ka_mail@mail.ru", strPassword);
                        try
                        {
                            sc.Send(mm);
                        }
                        catch (Exception ex)
                        {
                            SendingError se = new SendingError();
                            se.ShowDialog();
                            //MessageBox.Show("Невозможно отправить письмо " + ex.ToString());
                        }
                    }
                } //using (MailMessage mm = new MailMessage("sender@yandex.ru", mail))
            }
            SendEndWindow sew = new SendEndWindow();
            sew.ShowDialog();                        
        }
    }
}
