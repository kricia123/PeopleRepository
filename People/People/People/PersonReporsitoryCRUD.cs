using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using People.Model;


namespace People
{
    public class PersonReporsitoryCRUD
    {
      SQLiteConnection conn;

        public string StatusMessage { get; set; }

        public PersonReporsitoryCRUD(string dbpath) {
            conn = new SQLiteConnection(dbpath);
            conn.CreateTable<Person>();

        }


    }
}
