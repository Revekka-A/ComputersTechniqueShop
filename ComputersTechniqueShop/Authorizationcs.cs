using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFAprepearing
{
    public partial class Authorizationcs : Form
    {
        DataBase dataBase = new DataBase(); //подключаем класс БД
        public Authorizationcs()
        {
            InitializeComponent();
            CenterToScreen();
            tbox_Passw.UseSystemPasswordChar = false; //пароль скрывается
            tbox_Passw.PasswordChar = '*';
        }
        private void picture_open_Click(object sender, EventArgs e)
        {
            tbox_Passw.UseSystemPasswordChar = false; //пароль скрывается
            picture_open.Visible = false;
            picture_close.Visible = true;
        }
        private void picture_close_Click(object sender, EventArgs e)
        {
            tbox_Passw.UseSystemPasswordChar = true; //пароль скрывается
            tbox_Passw.PasswordChar = '*';
            picture_open.Visible = true;
            picture_close.Visible = false;
        }
        private void buttonAccount_Click(object sender, EventArgs e)
        {
            var loginUser = tbox_Login.Text;
            var passUser = tbox_Passw.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(); 
            DataTable table = new DataTable(); 

            string querystring = $"select * from Пользователи where Логин = '{loginUser}' and Пароль = '{passUser}' ";
            SqlCommand command = new SqlCommand(querystring, dataBase.getCon()); 
            adapter.SelectCommand = command;
            adapter.Fill(table); 

            if (table.Rows.Count == 1)   //Если кол-во строк = 1 (пошел под одним пользователем)
            {
                var user = new CheckUser(table.Rows[0].ItemArray[1].ToString(), table.Rows[0].ItemArray[5].ToString(), table.Rows[0].ItemArray[4].ToString()); //Берем фамилию и должность
                int code_user = Convert.ToInt32(table.Rows[0].ItemArray[0].ToString());
                MessageBox.Show("Авторизация прошла успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main form1 = new Main(user);

                DataBase db = new DataBase();
                db.OpenCon();
                DateTime currentTime = DateTime.Now;
                string sql = "Insert into История_входа VALUES (@CodeUser, @CurrentTime)";
                SqlCommand cmd = new SqlCommand(sql, db.getCon());
                cmd.Parameters.AddWithValue("@CodeUser", code_user); // здесь code_user - это значение кода пользователя
                cmd.Parameters.AddWithValue("@CurrentTime", currentTime);
                cmd.ExecuteNonQuery();
                db.CloseCon();

                this.Hide();//скрывает форму при наложении
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Авторизация не прошла успешно, проверьте свой логин и пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Captcha form = new Captcha();
                this.Hide();
                form.ShowDialog();
            }    
                
        }

        private void Log_in_account_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Authorizationcs_Load(object sender, EventArgs e)
        {
            tbox_Login.MaxLength = 35;
            tbox_Passw.MaxLength = 35;
        }

    }
}

