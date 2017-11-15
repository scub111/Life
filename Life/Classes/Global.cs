using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Life
{
    /// <summary>
    /// Основной класс глобальных переменных, которых можно сохранить в XML-файд
    /// </summary>
    public class VarXml
    {
        /// <summary>
        /// Класс подключения к БД.
        /// </summary>
        public class DBConnectionXml
        {
            /// <summary>
            /// Тип БД.
            /// </summary>
            public int DataBaseType;

            /// <summary>
            /// Сервер.
            /// </summary>
            public string Server;           

            /// <summary>
            /// Имя БД.
            /// </summary>
            public string DataBase;

            /// <summary>
            /// Необходимость окна ввода пользователя и пароля.
            /// </summary>
            public bool LoginFormNeed;

            /// <summary>
            /// Необходимость ввода пароля.
            /// </summary>
            public bool PasswordNeed;

            /// <summary>
            /// Пользователь.
            /// </summary>
            public string User;

            /// <summary>
            /// Пароль.
            /// </summary>
            public string Password;
        }

        /// <summary>
        /// Класс дисбаланса.
        /// </summary>
        public class DisbalanceXlm
        {
            /// <summary>
            /// Счет 1.
            /// </summary>
            public string Account1;

            /// <summary>
            /// Счет 2.
            /// </summary>
            public string Account2;

            /// <summary>
            /// Счет 3.
            /// </summary>
            public string Account3;

            /// <summary>
            /// Счет 4.
            /// </summary>
            public string Account4;

            /// <summary>
            /// Счет 5.
            /// </summary>
            public string Account5;

            /// <summary>
            /// Счет 6.
            /// </summary>
            public string Account6;

            /// <summary>
            /// Счет 7.
            /// </summary>
            public string Account7;

            /// <summary>
            /// Счет 8.
            /// </summary>
            public string Account8;

            /// <summary>
            /// Счет 9.
            /// </summary>
            public string Account9;

            /// <summary>
            /// Счет 10.
            /// </summary>
            public string Account10;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public VarXml(string strFileXml)
        {
            FileXml = strFileXml;
            DBConnection = new DBConnectionXml();
            Disbalance = new DisbalanceXlm();
            Init();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public VarXml()
            : this("Config.xml")
        {
        }

        void Init()
        {
            FilePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + FileXml;
            DBConnection.DataBaseType = 1;
            DBConnection.Server = "";
            DBConnection.DataBase = "DataBase.accdb";
            DBConnection.PasswordNeed = false;
            DBConnection.LoginFormNeed = false;
            DBConnection.User = "admin";
            DBConnection.Password = "123456";
            Disbalance.Account1 = "asdfsf";
        }

        /// <summary>
        /// Название файла, куда будет сохняться данные.
        /// </summary>
        [XmlIgnore]
        string FileXml;

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        [XmlIgnore]
        public string FilePath;

        /// <summary>
        /// Подплючение к БД.
        /// </summary>
        public DBConnectionXml DBConnection;

        /// <summary>
        /// Дисбаланс.
        /// </summary>
        public DisbalanceXlm Disbalance;

        /// <summary>
        /// Сохранить данные в XML-файл.
        /// </summary>
        public void SaveToXML()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(VarXml));
            TextWriter textWriter = new StreamWriter(FilePath);
            deserializer.Serialize(textWriter, this);
            textWriter.Close();
        }

        /// <summary>
        /// Загрузить данные из XML-файла.
        /// </summary>
        /// <returns></returns>
        public void LoadFromXML()
        {
            if (File.Exists(FilePath))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(VarXml));
                TextReader textReader = new StreamReader(FilePath);
                VarXml obj = (VarXml)deserializer.Deserialize(textReader);
                textReader.Close();

                DBConnection.DataBaseType = obj.DBConnection.DataBaseType;
                DBConnection.DataBase = obj.DBConnection.DataBase;
                DBConnection.Server = obj.DBConnection.Server;
                DBConnection.PasswordNeed = obj.DBConnection.PasswordNeed;
                DBConnection.LoginFormNeed = obj.DBConnection.LoginFormNeed;
                DBConnection.User = obj.DBConnection.User;
                DBConnection.Password = obj.DBConnection.Password;

                Disbalance.Account1 = obj.Disbalance.Account1;
                Disbalance.Account2 = obj.Disbalance.Account2;
                Disbalance.Account3 = obj.Disbalance.Account3;
                Disbalance.Account4 = obj.Disbalance.Account4;
                Disbalance.Account5 = obj.Disbalance.Account5;
                Disbalance.Account6 = obj.Disbalance.Account6;
                Disbalance.Account7 = obj.Disbalance.Account7;
                Disbalance.Account8 = obj.Disbalance.Account8;
                Disbalance.Account9 = obj.Disbalance.Account9;
                Disbalance.Account10 = obj.Disbalance.Account10;
            }
        }
    }

    public class GlobalDefault
    {
        /// <summary>
        /// Версия программы.
        /// </summary>
        public string Version;

        /// <summary>
        /// Переменные из файла настроек.
        /// </summary>
        public VarXml varXml;


        public void Init()
        {
            //Version = "v1.6.50";
            Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            varXml = new VarXml("Config.xml");
            varXml.LoadFromXML();
            //varXml.SaveToXML();
        }
    }

    public class Global
    {
        private static GlobalDefault defaultInstance = new GlobalDefault();
        public static GlobalDefault Default { get { return defaultInstance; } }
    }
}
