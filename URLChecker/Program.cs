﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace URLChecker
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(args.FirstOrDefault()));
        }
    }
}
