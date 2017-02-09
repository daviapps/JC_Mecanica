using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data;
using System.Reflection;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace JC_Mecanica {
    static class Program {
        public static DCodePreferences validation;
        public static DCodePreferences settings;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        /*[STAThread]

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_RESTORE = 9;

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);*/

        [STAThread]

        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool SetForegroundWindow(IntPtr hWnd);
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String contate = "\nPor favor, contate o suporte técnico.";

            //AppDomain.CurrentDomain.SetData("DataDirectory", "C:\\Users\\Davi\\AppData\\Roaming\\DaviApps\\JC Mecanica");
            //AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DaviApps\\JC Mecanica\\");

            if (!File.Exists("banco_de_dados.sdf")) {
                AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DaviApps\\JC Mecanica\\");
                //AppDomain.CurrentDomain.SetData("DataDirectory", "\\");
            }

            // CHECK DCODE DLL

            if (!File.Exists("DCode.dll")) {
                MessageBox.Show("Arquivo dll 'DCode' não encontrado." + contate, "DLL Error");
                return;
            }

            String settingsFolder = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DaviApps\\JC Mecanica\\settings\\");

            validation = new DCodePreferences(new DCodeFile(settingsFolder + "validation.DCode"));
            //_validation = new DCodePreferences(new DCodeFile(settingsFolder + "vali.DCode"));
            settings = new DCodePreferences(new DCodeFile(settingsFolder + "settings.DCode"));

            // DEFINE DEFAULT VALIDATION
            validation.Add("ACTIVED.CODE", "");
            validation.Add("AVALIATION.DATE", "");
            //validation.Set("avaliationDate", "Teste");
            //validation.Set("activeCode", "Teste2");
            validation.save();
            // DEFINE DEFAULT SETTINGS
            //settings.Add("teste", "23");
            //settings.Remove("teste");
            //settings.Set("teste", "f");
            //settings.save();
            //MessageBox.Show(settings.Get("teste", "Não encontrado"));

            //MessageBox.Show(validation.Get("teste", "Não encontrado"));
            //MessageBox.Show(validation.Get("activeCode", "Não encontrado"));

            //AppDomain.CurrentDomain.SetData("SettingsDiretory", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DaviApps\\JC Mecanica\\Settings\\");

            UpdateDB.CHECK();

            /*bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "JC_Mecanica", out createdNew)) {
                if (createdNew) {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                } else {
                    Process current = Process.GetCurrentProcess();
                    foreach (Process process in Process.GetProcessesByName(current.ProcessName)) {
                        if (process.Id != current.Id) {
                            //SetForegroundWindow(process.MainWindowHandle);
                            break;
                        }
                    }
                }
            }*/

            /*DB_INFO.INIT();

            if (DB_INFO.DB_VERSION < Properties.Settings.Default.DB_VERSION) {
                if (DB_INFO.DB_VERSION == 1.0) {
                    //DB_INFO.EXECUTE("UPDATE DB_INFO SET value = 1,5 WHERE name = DB_VERSION");
                }
            }

            //MessageBox.Show(Codes.getAvaliableDays() + " - " + Codes.inAvaliationMode());*/

            /* Create dispesas table
             * create table dispesas (
	                id int not null AUTO_INCREMENT,
                    produto varchar(20) not null,
                    valor decimal not null,
                    count int not null,
                    data timestamp default now(),
	                primary key (id)
                )
             */

            bool close = false;

            if (!Codes.checkValidation()) {
                if(!Codes.inAvaliationMode())
                    new ValidationForm().ShowDialog();
                close = !Codes.checkValidation() && !Codes.inAvaliationMode();
            }

            if (close)
                return;

            //MessageBox.Show(Codes.removeDot(Assembly.GetExecutingAssembly().GetName().Version.ToString()));

            //UpdateDB.SET_VALUE("DB_VERSION", "1,23");

            //MessageBox.Show(DB_INFO.DB_VERSION + "");
            //MessageBox.Show(UpdateDB.GET_DB_VERSION() + "");

            /*string str;

            SqlCeConnection mycon = new SqlCeConnection("Data Source = banco_de_dados.sdf");
            str = "CREATE {DATABASE | SCHEMA} [IF NOT EXISTS] banco_de_dados" +
                  "";
            str = "CREATE DATABASE [banco_de_dados2] CONTAINMENT = NONE ON PRIMARY" +
                        "(NAME=N'Masalehforoshi'," +
                        @"FILENAME=N'C:\data\Masalehforoshi.mdf' " +
                        ",SIZE=3072KB,MAXSIZE=UNLIMITED,FILEGROWTH=1024KB)" +
                        "LOG ON (NAME=N'Masalehforoshi_log.', " +
                        @"FILENAME=N'C:\Masalehforoshi_log.ldf' " +
                        ",SIZE=1024KB,MAXSIZE=2048GB,FILEGROWTH=10%)";

            SqlCeCommand mycommand = new SqlCeCommand(str, mycon);

            try {
                mycommand.Connection.Open();
                mycommand.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "myprogram", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } finally {
                if (mycon.State == ConnectionState.Open) {
                    mycon.Close();
                }
            }*/
            /*SqlCeConnection connection;
            try {
                connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
                connection.Open();
            } catch (SqlException ex) {
                MessageBox.Show("Arquivo de banco de dados não encontrado." + contate, "Erro de inicialização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Close();*/

            if (!File.Exists(AppDomain.CurrentDomain.GetData("DataDirectory") + "banco_de_dados.sdf")) {
                MessageBox.Show("Arquivo de banco de dados não encontrado." + contate, "Erro de inicialização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                //Application.Run(new MainForm());
                bool createdNew = true;
                using (Mutex mutex = new Mutex(true, "JC_Mecanica", out createdNew)) {
                    if (createdNew) {
                        Application.Run(new MainForm());
                    } else {
                        Process current = Process.GetCurrentProcess();
                        foreach (Process process in Process.GetProcessesByName(current.ProcessName)) {
                            if (process.Id != current.Id) {
                                //BringWindowToFront();
                                /*process.WaitForInputIdle();
                                var processes = Process.GetProcessesByName("JC_Mecanica.exe");
                                if (processes.Any()){
                                    //I can't currently tell the window's state,
                                    //so I both restore and activate it
                                    var handle = processes.First().MainWindowHandle;
                                    ShowWindow(handle, SW_SHOWMAXIMIZED); //GRR!!!
                                    SetForegroundWindow(handle);
                                    //return true;
                                }*/
                                //SetForegroundWindow(process.MainWindowHandle);
                                //process.WindowState = FormWindowState.Maximized;
                                //Invoke(new MethodInvoker(delegate { this.WindowState = FormWindowState.Normal; }));
                                //Invoke(new Action(() => { this.WindowState = FormWindowState.Normal; }));
                                //process.CloseMainWindow();
                                //new MainForm().ShowDialog();
                                //process.Kill();
                                //((Form) process.MainWindowHandle).WindowState = System.Windows.Forms.FormWindowState.Maximized;
                                //process.Start();
                                break;
                            }
                        }
                    }
                }
            }
        }

        /*[DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string className, string windowTitle);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowPlacement(IntPtr hWnd, ref Windowplacement lpwndpl);

        private enum ShowWindowEnum {
            Hide = 0,
            ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
            Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
            Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
            Restore = 9, ShowDefault = 10, ForceMinimized = 11
        };

        private struct Windowplacement {
            public int length;
            public int flags;
            public int showCmd;
            public System.Drawing.Point ptMinPosition;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Rectangle rcNormalPosition;
        }

        private static void BringWindowToFront() {
            IntPtr wdwIntPtr = FindWindow(null, "JC Mecânica");

            //get the hWnd of the process
            Windowplacement placement = new Windowplacement();
            GetWindowPlacement(wdwIntPtr, ref placement);

            // Check if window is minimized
            if (placement.showCmd == 2) {
                //the window is hidden so we restore it
                ShowWindow(wdwIntPtr, ShowWindowEnum.Restore);
            }

            //set user's focus to the window
            SetForegroundWindow(wdwIntPtr);
        }*/
    }
}
