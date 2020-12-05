using System;

namespace Ado.net
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleSql simpleSql = new SimpleSql();
            //  simpleSql.serverpage_load();

            // databasecreation.databasemethod();

            //  AlterDatabase.changedatabase();

            AlterDatabase alterDatabase = new AlterDatabase();

           // alterDatabase.createTable();

            Insertiondata insertiondata = new Insertiondata();
            insertiondata.insertion();
        }
    }
}
