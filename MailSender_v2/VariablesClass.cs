﻿using System;

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
}