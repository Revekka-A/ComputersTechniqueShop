using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFAprepearing
{
    public partial class Main : Form
    {
        DataBase db = new DataBase();
        int selectedRow;
        string tableName = "";
        private readonly CheckUser _user;
        public Main(CheckUser user)
        {
            _user = user;
            InitializeComponent();
            CenterToScreen();

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            btn_search.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;


            

            label_user.Text = user.UserName + " - " + user.UserPost;

            if (_user.IsAdmin)//если админ
            {
               btn_history.Visible = true;
               
            }
            else //просто пользователь
            {
                btn_history.Visible = false;
            }
        }
        private void DefaultColor()
        {
            btn_postavshiki.BackColor = Color.White;
            btn_postavki.BackColor = Color.White;
            btn_products.BackColor = Color.White;
            btn_details.BackColor = Color.White;
            btn_sales.BackColor = Color.White;
            btn_history.BackColor = Color.White;
        }

        private void ShowDataGrid()
        {
            if (tableName == "")
                return;
            dataGridView1.Columns.Clear();
            db.OpenCon();

            SqlDataAdapter adapter = new SqlDataAdapter($"select * from [{tableName}]", db.getCon());
            DataTable table = new DataTable();
            adapter.Fill(table);

            switch (tableName)
            {
                case "Поставщики":
                    dataGridView1.DataSource = table;
                    break;
                case "Поставки":
                    dataGridView1.DataSource = table;
                    break;
                case "Товары":
                    dataGridView1.DataSource = table;
                    break;
                case "Детали_продажи":
                    dataGridView1.DataSource = table;
                    break;
                case "Продажи":
                    dataGridView1.DataSource = table;
                    break;
                case "История_входа":
                    dataGridView1.DataSource = table;
                    break;
            }

            db.CloseCon();
        }
        private void AccessRights()
        {
            btn_search.Visible = false; btn_search.Enabled = false;
            textBox7.Visible = false;
            label7.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            textBox1.Visible = false; textBox1.Text = "";
            textBox2.Visible = false; textBox2.Text = "";
            textBox3.Visible = false; textBox3.Text = "";
            textBox4.Visible = false; textBox4.Text = "";
            textBox5.Visible = false; textBox5.Text = "";
            textBox6.Visible = false; textBox6.Text = "";
            label1.Text = ""; label2.Text = ""; label3.Text = ""; label4.Text = "";
            label5.Text = ""; label6.Text = "";
            switch (tableName)
            {
                case "Поставщики":
                    if (_user.UserPost == "Администратор")
                    {
                        textBox1.Visible = true; label1.Text = "Код поставщика";
                        textBox2.Visible = true; label2.Text = "Наименование";
                        textBox3.Visible = true; label3.Text = "Адрес";
                        textBox4.Visible = true; label4.Text = "Телефон";

                        button1.Visible = true;
                        button2.Visible = true;
                        button3.Visible = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;

                        btn_search.Visible = true; btn_search.Enabled = true;
                        textBox7.Visible = true;
                        label7.Visible = true;
                    }
                    else
                    {
                        textBox1.Visible = true; label1.Text = "Код поставщика";
                        textBox2.Visible = true; label2.Text = "Наименование";
                        textBox3.Visible = true; label3.Text = "Адрес";
                        textBox4.Visible = true; label4.Text = "Телефон";

                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        btn_search.Visible = false;
                        label7.Visible = false;
                    }
                    
                    break;
                case "Поставки":
                    textBox1.Visible = true; label1.Text = "Код поставки";
                    textBox2.Visible = true; label2.Text = "Код поставщика";
                    textBox3.Visible = true; label3.Text = "Количество";
                    textBox4.Visible = true; label4.Text = "Дата поставки";
                    textBox5.Visible = true; label5.Text = "Код товара";
                    textBox6.Visible = true; label6.Text = "Цена закупки";
                    break;
                case "Товары":
                    textBox1.Visible = true; label1.Text = "Код товара";
                    textBox2.Visible = true; label2.Text = "Наименование";
                    textBox3.Visible = true; label3.Text = "Описание";
                    break;
                case "Детали_продажи":
                    textBox1.Visible = true; label1.Text = "Код деталей продажи";
                    textBox2.Visible = true; label2.Text = "Код товара";
                    textBox3.Visible = true; label3.Text = "Код продажи";
                    textBox4.Visible = true; label4.Text = "Количество";
                    textBox5.Visible = true; label5.Text = "Цена розничная";
                    break;
                case "Продажи":
                    textBox1.Visible = true; label1.Text = "Код продажи";
                    textBox2.Visible = true; label2.Text = "Дата продажи";
                    textBox3.Visible = true; label3.Text = "Общая сумма";
                    break;
            }
        }
        private void btn_products_Click(object sender, EventArgs e)
        {
            DefaultColor();
            tableName = btn_products.Text; ShowDataGrid(); AccessRights();
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            btn_products.BackColor = Color.DarkSeaGreen;
        }

        private void btn_postavki_Click(object sender, EventArgs e)
        {
            DefaultColor();
            tableName = btn_postavki.Text; ShowDataGrid(); AccessRights();
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            btn_postavki.BackColor = Color.DarkSeaGreen;

            DataBase db = new DataBase();
            db.OpenCon();
            tableName = "Товары";
            //Выполнение SELECT-запроса
            string sql = $"SELECT Код_товара FROM Товары";
            SqlCommand cmd = new SqlCommand(sql, db.getCon());
            SqlDataReader reader = cmd.ExecuteReader();
            //Добавление результатов запроса в ComboBox
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["Код_товара"].ToString());
            }
            // Закрытие ридера и соединения
            reader.Close();
            db.CloseCon();

            db = new DataBase();
            db.OpenCon();
            tableName = "Поставщики";
            //Выполнение SELECT-запроса
            sql = $"SELECT Код_поставщика FROM Поставщики";
            cmd = new SqlCommand(sql, db.getCon());
            reader = cmd.ExecuteReader();
            //Добавление результатов запроса в ComboBox
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Код_поставщика"].ToString());
            }
            // Закрытие ридера и соединения
            reader.Close();
            db.CloseCon();
            tableName = "Поставки";
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            DefaultColor();
            tableName = btn_details.Text; ShowDataGrid(); AccessRights();
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            btn_details.BackColor = Color.DarkSeaGreen;
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            DefaultColor();
            tableName = btn_sales.Text; ShowDataGrid(); AccessRights();
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            btn_sales.BackColor = Color.DarkSeaGreen;

        }
        private void btn_postavshiki_Click(object sender, EventArgs e)
        {
            DefaultColor();
            tableName = btn_postavshiki.Text; ShowDataGrid(); AccessRights();
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            btn_postavshiki.BackColor = Color.DarkSeaGreen;
        }
        private void btn_history_Click(object sender, EventArgs e)
        {
            DefaultColor();
            tableName = btn_history.Text; ShowDataGrid(); AccessRights();
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            btn_history.BackColor = Color.DarkSeaGreen;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex < 0)
                return;
            var row = dataGridView1.Rows[selectedRow];
            switch (tableName)
            {
                case "Поставщики":
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    textBox4.Text = row.Cells[3].Value.ToString();
                    break;
                case "Поставки":
                    textBox1.Text = row.Cells[0].Value.ToString();
                    comboBox1.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    textBox4.Text = row.Cells[3].Value.ToString();
                    comboBox2.Text = row.Cells[4].Value.ToString();
                    textBox6.Text = row.Cells[5].Value.ToString();                    
                    break;
                case "Товары":
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    break;
                case "Детали_поставки":
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    textBox4.Text = row.Cells[3].Value.ToString();
                    textBox5.Text = row.Cells[4].Value.ToString();
                    break;
                case "Продажи":
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    break;
            }
        }
        public void UpdateTable(string tableName, string textBox1Value, string textBox2Value, string textBox3Value, string textBox4Value)
        {
            try
            {
                db.OpenCon();

                string sql = "";
                SqlCommand cmd = new SqlCommand();

                switch (tableName)
                {
                    case "Поставщики":
                        sql = "Update Поставщики set Наименование = @Param2, Адрес = @Param3, " +
                            "Телефон = @Param4 where Код_поставщика = @Param1";
                        cmd = new SqlCommand(sql, db.getCon());
                        cmd.Parameters.AddWithValue("@Param1", Convert.ToInt32(textBox1Value));
                        cmd.Parameters.AddWithValue("@Param2", textBox2Value);
                        cmd.Parameters.AddWithValue("@Param3", textBox3Value);
                        cmd.Parameters.AddWithValue("@Param4", textBox4Value);
                        break;
                    case "Поставки":
                        sql = "Update Поставки set Код_поставщика = @Param2 where [Код поставки] = @Param1";
                        cmd = new SqlCommand(sql, db.getCon());
                        cmd.Parameters.AddWithValue("@Param1", Convert.ToInt32(textBox1Value));
                        cmd.Parameters.AddWithValue("@Param2", textBox2Value);
                        break;
                        // Добавьте кейсы для других таблиц
                }
                ExecuteSqlCommand(cmd);

                db.CloseCon();
                ShowDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*Будущий тест-кейс
             * //нужно заменить YourDatabaseClass и YourFormClass на реальные классы из кода.
             * [TestClass]
                public class UpdateTableTests
                {
                    [TestMethod]
                    public void UpdateTable_ShouldExecuteSqlCommand()
                    {
                        // Arrange
                        var fakeSqlCommand = new Mock<SqlCommand>();
                        var fakeDatabase = new Mock<YourDatabaseClass>();
                        var yourForm = new YourFormClass(fakeDatabase.Object);
                        yourForm.ExecuteSqlCommand(fakeSqlCommand.Object);

                        // Act
                        yourForm.UpdateTable("Поставщики", "1", "NewName", "NewAddress", "NewPhone");

                        // Assert
                        fakeSqlCommand.Verify(x => x.ExecuteNonQuery(), Times.Once);
                    }
                }

             * */
        }

        public void ExecuteSqlCommand(SqlCommand cmd)
        {
            cmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTable(tableName,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenCon();
                switch (tableName)
                {
                    case "Поставщики":
                        string sql = $"Insert into Поставщики values ('{textBox2.Text}', '{textBox3.Text}','{textBox4.Text}')";
                        SqlCommand cmd = new SqlCommand(sql, db.getCon());
                        cmd.ExecuteNonQuery();
                        break;
                    //case "Специальность":
                    //    sql = $"Insert into Специальность values ({Convert.ToInt32(textBox2.Text)}, '{textBox3.Text}')";
                    //    cmd = new SqlCommand(sql, db.getCon());
                    //    cmd.ExecuteNonQuery();
                    //    break;
                    //case "Студент":
                    //    sql = $"Insert into Студент values ('{textBox1.Text}', '{textBox2.Text}', {Convert.ToInt32(textBox3.Text)}, {Convert.ToInt32(textBox4.Text)})";
                    //    cmd = new SqlCommand(sql, db.getCon());
                    //    cmd.ExecuteNonQuery();
                    //    break;
                    //case "Успеваемость":
                    //    sql = $"Insert into Успеваемость values ('{textBox1.Text}', {Convert.ToInt32(textBox2.Text)}, {Convert.ToInt32(textBox3.Text)}, '{Convert.ToDateTime(textBox4.Text)}')";
                    //    cmd = new SqlCommand(sql, db.getCon());
                    //    cmd.ExecuteNonQuery();
                    //    break;
                    //case "Факультет":
                    //    sql = $"Insert into Факультет values ({Convert.ToInt32(textBox2.Text)}, '{textBox3.Text}')";
                    //    cmd = new SqlCommand(sql, db.getCon());
                    //    cmd.ExecuteNonQuery();
                    //    break;
                }
                db.CloseCon();
                ShowDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                db.OpenCon();
                switch (tableName)
                {
                    case "Поставщики":
                        string sql = $"Delete from Поставщики where Код_поставщика = {textBox1.Text}";
                        SqlCommand cmd = new SqlCommand(sql, db.getCon());
                        cmd.ExecuteNonQuery();
                        break;
                    //case "Специальность":
                    //    sql = $"Delete from Специальность where [Код специальности] = {Convert.ToInt32(textBox2.Text)}";
                    //    cmd = new SqlCommand(sql, db.getCon());
                    //    cmd.ExecuteNonQuery();
                    //    break;
                    //case "Студент":
                    //    sql = $"Delete from Студент where [Номер зачетки] = '{textBox1.Text}'";
                    //    cmd = new SqlCommand(sql, db.getCon());
                    //    cmd.ExecuteNonQuery();
                    //    break;
                    //case "Успеваемость":
                    //    sql = $"Delete from Успеваемость where [Номер зачетки] = '{textBox1.Text}' and Предмет = {Convert.ToInt32(textBox2.Text)}";
                    //    cmd = new SqlCommand(sql, db.getCon());
                    //    cmd.ExecuteNonQuery();
                    //    break;
                    //case "Факультет":
                    //    sql = $"Delete from Факультет where [Номер факультета] = {Convert.ToInt32(textBox2.Text)}";
                    //    cmd = new SqlCommand(sql, db.getCon());
                    //    cmd.ExecuteNonQuery();
                    //    break;
                }
                db.CloseCon();
                ShowDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.OpenCon();
            tableName = "Поставщики";
            //Выполнение SELECT-запроса
            string sql = $"SELECT Код_поставщика FROM Поставщики";
            SqlCommand cmd = new SqlCommand(sql, db.getCon());
            SqlDataReader reader = cmd.ExecuteReader();

            //Добавление результатов запроса в ComboBox
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Код_поставщика"].ToString());
            }

           // Закрытие ридера и соединения
            reader.Close();
            db.CloseCon();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            db.OpenCon();
            SqlDataAdapter adapter = new SqlDataAdapter($"select * from Поставщики " +
                $"where Наименование like '{textBox7.Text}%'", db.getCon());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            db.CloseCon();
        }
    }
}