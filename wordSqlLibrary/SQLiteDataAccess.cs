using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace wordSqlLibrary
{
    public class SQLiteDataAccess
    {
        //public static List<WordModel> LoadWords(int? diff)
        //{
        //    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
        //    {
        //        var output = cnn.Query<WordModel>("SELECT * FROM Words WHERE Difficulty = " + diff.ToString(), new DynamicParameters());
        //        return output.ToList();
        //    }
        //}
        public static List<WordModel> LoadWords(int? diff, string? topic)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<WordModel>("SELECT Word, Query FROM Words WHERE Difficulty = " + diff.ToString() + " AND Topic='" + topic + "'", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveWord(WordModel word)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Words (Id, Word, Difficulty, Topic) values " +
                    "(@Id, @Word, @Difficulty, @Topic)", word);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
