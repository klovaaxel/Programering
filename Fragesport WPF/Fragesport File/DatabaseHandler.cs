using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Data.Sqlite;

namespace Fragesport_File
{
    class DatabaseHandler
    {
        // name of database file
        private string dbName = "sqlite.db";
        private string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public string GetPathAndDbName()
        {
            return Path.Combine(docPath, dbName); ;
        }

        /// <summary>
        /// Create database if not exists.
        /// 
        /// Add table towers to database if it does not exist.
        /// 
        /// Add some towers if the table is empty.
        /// </summary>
        public void InitializeDatabase()
        {

            // using reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
            using (SqliteConnection db =
               new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS questions (id INTEGER PRIMARY KEY AUTOINCREMENT , " +
                    "question VARCHAR(128) NOT NULL, " +
                    "answer VARCHAR(128) NOT NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                var result = createTable.ExecuteReader();

                tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS questionsAlt (id INTEGER PRIMARY KEY AUTOINCREMENT , " +
                    "question VARCHAR(128) NOT NULL, " +
                    "alt1 VARCHAR(128) NOT NULL, " +
                    "alt2 VARCHAR(128) NOT NULL, " +
                    "alt3 VARCHAR(128) NOT NULL, " +
                    "alt4 VARCHAR(128) NOT NULL, " +
                    "answer VARCHAR(128) NOT NULL)";

                createTable = new SqliteCommand(tableCommand, db);

                result = createTable.ExecuteReader();

                db.Close();
            }
            if (NumberOfQuestions() == 0)
            {
                AddSomeQuestions();
            }

        }

        /// <summary>
        /// Add a tower with the speicified name and height.
        /// </summary>
        /// <param name="nameOfTower"></param>
        /// <param name="heightOfTower"></param>
        public void AddTextQuestion(string question, string answer)
        {

            using (SqliteConnection db =
              new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO questions (question, answer) VALUES (@question, @answer);";

                insertCommand.Parameters.AddWithValue("@question", question);
                insertCommand.Parameters.AddWithValue("@answer", answer);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }

        public void AddAltQuestion(string question, string alt1, string alt2, string alt3, string alt4, string answer)
        {

            using (SqliteConnection db =
              new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO questionsAlt (question, alt1, alt2, alt3, alt4, answer) VALUES (@question, @alt1, @alt2, @alt3, @alt4, @answer);";

                insertCommand.Parameters.AddWithValue("@question", question);
                insertCommand.Parameters.AddWithValue("@alt1", alt1);
                insertCommand.Parameters.AddWithValue("@alt2", alt2);
                insertCommand.Parameters.AddWithValue("@alt3", alt3);
                insertCommand.Parameters.AddWithValue("@alt4", alt4);
                insertCommand.Parameters.AddWithValue("@answer", answer);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }

        /// <summary>
        /// Get a list of all towers.
        /// </summary>
        /// <returns></returns>
        public List<QuestionCard> GetQuestions()
        {
            //List<String> entries = new List<string>();
            List<QuestionCard> questions = new List<QuestionCard>();


            using (SqliteConnection db =
               new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT * from questions ORDER BY id DESC", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                // add each tower to the list
                while (query.Read())
                {
                    if (int.TryParse(query.GetString(0), out int id))
                    {
                        QuestionText question = new QuestionText(query.GetString(1), query.GetString(2));  
                        questions.Add(question);
                    }

                }

                selectCommand = new SqliteCommand("SELECT * from questionsAlt ORDER BY id DESC", db);

                query = selectCommand.ExecuteReader();

                // add each tower to the list
                while (query.Read())
                {
                    if (int.TryParse(query.GetString(0), out int id))
                    {
                        List<string> alt = new List<string>();
                        alt.Add(query.GetString(2));
                        alt.Add(query.GetString(3));
                        alt.Add(query.GetString(4));
                        alt.Add(query.GetString(5));
                        QuestionChoice question = new QuestionChoice(query.GetString(1), alt, query.GetString(6));
                        questions.Add(question);
                    }
                }

                db.Close();
            }

            return questions;
        }

        /// <summary>
        /// Get the tower with the specified id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns the tower with the selected id if it exists, otherwise null.</returns>
        public QuestionCard GetQuestion(int id)
        {
            QuestionCard question = null;
            using (SqliteConnection db =
              new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand();
                selectCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                selectCommand.CommandText = "SELECT * FROM questions WHERE id=@id";

                selectCommand.Parameters.AddWithValue("@id", id);

                SqliteDataReader query = selectCommand.ExecuteReader();

                if (query.Read())
                {
                    question = new QuestionText(query.GetString(1), query.GetString(2));
                }

                db.Close();
            }

            return question;
        }

        /// <summary>
        /// Edit the tower with the same id. Set new name and height.
        /// </summary>
        /// <param name="tower"></param>
        public void EditQuestion(QuestionCard question)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand sqlCommand = new SqliteCommand();
                sqlCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                sqlCommand.CommandText = "UPDATE questions SET qusetion=@questions, answer=@answer WHERE id=@id";

                sqlCommand.Parameters.AddWithValue("@id", question.Id);
                sqlCommand.Parameters.AddWithValue("@name", question.Question);
                sqlCommand.Parameters.AddWithValue("@height", question.Answer);

                sqlCommand.ExecuteReader();

                db.Close();
            }
        }

        /// <summary>
        /// Delete tower with the same id.
        /// </summary>
        /// <param name="tower"></param>
        public void DeleteQuestion(QuestionCard question)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand sqlCommand = new SqliteCommand();
                sqlCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                sqlCommand.CommandText = "DELETE FROM qusetions WHERE id=@id";

                sqlCommand.Parameters.AddWithValue("@id", question.Id);

                sqlCommand.ExecuteReader();

                db.Close();
            }
        }

        // Add some startup towers.
        private void AddSomeQuestions()
        {
            AddTextQuestion("What is my name", "axel");
            AddAltQuestion("What animal causes the most power outages in the U.S.?", "Squirrels", "Turtles", "Bears", "Snakes", "1");
            AddAltQuestion("What is the inventor of the pringels can burried in?", "Casket", "Pringels Can", "A big box", "His house", "2");
            AddAltQuestion("What was spider webs used as in ancient times?", "Clothes", "Cutlary", "Bandages", "Food", "3");

        }

        // Count rows in table.
        private int NumberOfQuestions()
        {
            int count = 0;
            using (SqliteConnection db =
              new SqliteConnection($"Filename={GetPathAndDbName()}"))
            {
                db.Open();

                SqliteCommand sqlCommand = new SqliteCommand();
                sqlCommand.Connection = db;

                sqlCommand.CommandText = "SELECT COUNT (id) FROM questions";
                SqliteDataReader query = sqlCommand.ExecuteReader();
                if (query.Read())
                {
                    count = int.Parse(query.GetString(0));
                }

                db.Close();
            }

            return count;
        }
    }
}
