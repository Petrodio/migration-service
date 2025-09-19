using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Migration_service.Controller
{
    class Query
    { 
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable buffer;

        public Query () //конструктор класса Query
        {
            connection = new OleDbConnection(ConnectionString.ConnStr);
            buffer = new DataTable();
        }

        public DataTable Мигрант1() //запрос для главной формы
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT Мигрант.ID_миг, Мигрант.ФИО, Мигрант.Дата_рожд, Мигрант.Пол, Страна.Назв_стран AS Страна, Мигрант.Мест_рожд, Мигрант.Пасп, Мигрант.Ном_МК, Мигрант.Цель, Мигрант.Прин_стор, Мигрант.Срок_с, Мигрант.Срок_до " +
"FROM Страна INNER JOIN Мигрант ON Страна.ID_стран = Мигрант.Страна ORDER BY Мигрант.ФИО", connection);
            buffer.Clear();
            dataAdapter.Fill(buffer);
            connection.Close();
            return buffer;
        }

        //добавление записи в таблицу Мигрант
        public void AddМигрант(string FIO, DateTime birthD, string gender, string state, string birthP, string pasp, string numMC, string purp, string host, DateTime stayFrom, DateTime stayTo)
        {
            connection.Open();
            string query = "INSERT INTO Мигрант(ФИО, Дата_рожд, Пол, Страна, Мест_рожд, Пасп, Ном_МК, Цель, Прин_стор, Срок_с, Срок_до)" +
                $"VALUES ('{FIO}', '{birthD.ToShortDateString()}', '{gender}', '{state}', '{birthP}', '{pasp}', '{numMC}', '{purp}', '{host}', '{stayFrom.ToShortDateString()}', '{stayTo.ToShortDateString()}')";
            //string query = "INSERT INTO Мигрант(ФИО, Дата_рожд, Пол, Страна, Мест_рожд)" + $"VALUES ('{FIO}', '{birthD.ToShortDateString()}', '{gender}', '{state}', '{birthP}')";
            MessageBox.Show(query);
            command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditМигрант(int id, string FIO, string birthD, string gender, string state, string birthP, string pasp, string numMC, string purp, string host, string stayFrom, string stayTo) //редактирование записи в таблице Мигрант
        {
            connection.Open();
            string query = $"UPDATE Мигрант SET ФИО = '{FIO}', Дата_рожд = '{birthD}', Пол = '{gender}', Страна = '{state}', Мест_рожд = '{birthP}', " +
                $"Пасп = '{pasp}', Ном_МК = '{numMC}', Цель = '{purp}', Прин_стор = '{host}', Срок_с = '{stayFrom}', Срок_до = '{stayTo}' WHERE ID_миг = {id}";
            command = new OleDbCommand(query, connection);
            MessageBox.Show(query);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(string table, string idCol, int id) //удаление записи по таблице и id
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM {table} WHERE {idCol} = {id}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddSprav(string table, string nameCol, string name) //добавление записи в справочник по таблице и названию столбца
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO {table} ({nameCol}) VALUES ('{name}')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditSprav(string table, string nameCol, string name, string idCol, int id) //редактирование записи в справочнике по таблице и названию столбца
        {
            connection.Open();
            command = new OleDbCommand($"UPDATE {table} SET {nameCol} = '{name}' WHERE {idCol} = {id}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddRVP(int idMig, string number, DateTime dateResh, DateTime dateTo) //добавление записи в таблицу РВП
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO РВП(ID_миг, Номер, Дата_реш, Срок) VALUES ({idMig}, '{number}', '{dateResh.ToShortDateString()}', '{dateTo.ToShortDateString()}')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditRVP(int id, int idMig, string number, DateTime dateResh, DateTime dateTo) //редактирование записи в таблице РВП
        {
            connection.Open();
            string query = $"UPDATE РВП SET ID_миг = {idMig}, Номер = '{number}', Дата_реш = '{dateResh.ToShortDateString()}', Срок = '{dateTo.ToShortDateString()}' " +
                $"WHERE ID_РВП = {id}";
            command = new OleDbCommand(query, connection);
            //MessageBox.Show(query);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void AddPatent(int idMig, string seria, string number, int prof, DateTime dateVyd) //добавление записи в таблицу РВП
        {
            connection.Open();
            string query = $"INSERT INTO Патент(ID_миг, Серия, Номер, Проф, Дата_выд) VALUES ({idMig}, '{seria}', '{number}', {prof}, '{dateVyd.ToShortDateString()}')";
            command = new OleDbCommand(query, connection);
            MessageBox.Show(query);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void EditPatent(int id, int idMig, string seria, string number, int prof, DateTime dateVyd) //редактирование записи в таблице РВП
        {
            connection.Open();
            string query = $"UPDATE Патент SET ID_миг = {idMig}, Серия = '{seria}', Номер = '{number}', Проф = {prof}, Дата_выд = '{dateVyd.ToShortDateString()}'" +
                $"WHERE ID_пат = {id}";
            command = new OleDbCommand(query, connection);
            //MessageBox.Show(query);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

