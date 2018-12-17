using System;

public class SqliteHelper
{
	public SqliteHelper()
	{
        SQLiteConnection conn = new SQLiteConnection("sQLi.db3");
        conn.open();
        string query = "select * from keywords";



    }
}
