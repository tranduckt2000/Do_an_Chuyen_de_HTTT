using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ChungKhoan
{
    static class Program
    {
        public static System.Data.SqlClient.SqlDataReader reader;
        public static SqlConnection ketnoi = new SqlConnection();
        public static SqlDataReader myReader;
        public static String servername = "DUCANH00"; // luu ten server tra vè ở form dang nhap
        public static String username = "sa";
        public static String password = "123";
        public static Boolean check = true;
        public static String database = "ChungKhoan";
        public static SqlDataReader ExecSqlDataReader(String strLenh) // doc du lieu
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, ketnoi);
            sqlcmd.CommandType = CommandType.Text;
            if (ketnoi.State == ConnectionState.Closed) ketnoi.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                ketnoi.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static int KetNoi()
        {
            if (Program.ketnoi != null && Program.ketnoi.State == ConnectionState.Open)
                Program.ketnoi.Close();
            try
            {
                String cntstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.username + ";password=" + Program.password;
                Program.ketnoi.ConnectionString = cntstr;

                Program.ketnoi.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Kiểm tra lại username và password trong bài code.\n " + e.Message, "Kết nối", MessageBoxButtons.OK);
                return 0;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGiaoDich());
        }
    }
}
