using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace People.Model
{
    [Table("T_People)" ]
    public class Person


    {
        //Miembro Properties
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        [MaxLength(50), Unique]

    public string Name { get; set; }

    }
}
