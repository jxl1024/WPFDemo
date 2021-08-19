﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace ApplicationDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow win = new MainWindow();
            // 判断是否存在命令行参数
            if (e.Args.Length>0)
            {
                string file = e.Args[0];
                if (File.Exists(file))
                    win.LoadFile(file);
            }
            win.Show();
        }


        private List<Document> documents = new List<Document>();

        public List<Document> Documents { get { return documents; }

            set { documents = value; }
        
        }
    }
}
