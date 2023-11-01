Using System.Data;
Using MySql.Data;
Using MySql.Data.MySqlClient;
namespace api.database
{
    public class Database
    {
        
        private string host {get;set;}

        private string database {get;set;}

        private string username {get;set;}

        private string port {get;set;}

        private string password {get;set;}

        public string cs {get; set;}

        public Database()
        {
            host= "lcpbq9az4jklobvq.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            database="v83wgosaa28wjfj6";
            username="dr9outou5qo0rkmg";
            port="3306";
            password="sd9fvrxgafxrkq0e";

           cs= $"server={host};user={username};database={database};port={port}; password={password}";

        }
    
    }
}