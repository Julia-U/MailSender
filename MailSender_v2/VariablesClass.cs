using System;

public static class VariablesClass
{
    public static Dictionary<string, string> Senders
    {
        get { return dicSenders; }
    }
    private static Dictionary<string, string> dicSenders = new Dictionary<string, string>()
        {
            { "79257443993@yandex.ru",PasswordClass.getPassword("1234l;i") },
            { "sok74@yandex.ru",PasswordClass.getPassword(";liq34tjk") }
        };

    public static Dictionary<string, int> Smpt_server
    {
        get { return dicSmpt_server; }
    }

    private static Dictionary<string, string> dicSmpt_server = new Dictionary<string, int>()
        {
            { "smtp.yandex.ru",25 },
            { "smtp.gmail.com",58 },
            { "smtp.mail.ru",25 }
        };
}