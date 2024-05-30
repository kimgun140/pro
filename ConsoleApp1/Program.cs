using MySql.Data.MySqlClient;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   string ip = "127.0.0.1";
            int port = 3306;
            string uid = "root";
            string pwd = "1234";
            string dbname = "employees";
            MySqlConnection conn ;
            string connectString = $"Server={ip};Port={port};Database={dbname};Uid={uid};Pwd={pwd};CharSet=utf8;";
            //연결확인
            conn = new MySqlConnection(connectString);
            conn.Open();
            conn.Ping();
            
            //조회할 쿼리문 
            string query = "SELECT * FROM departments;";
            MySqlDataReader? dr = null;
            //쿼리 결과 담을 list 
            List<string> result = new List<string>();
            // 쿼리 명령 실행 
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //조회 결과
            dr = cmd.ExecuteReader();
         
            while (dr.Read())
            {
                // 데이터 조회시 Null 값이 있을 경우에는 예외처리 필요
                result.Add($"{(dr[0].ToString())}, {dr[1].ToString()}");
            }
            
            //조회 결과 출력
            foreach (string item in result)
            {
                Console.WriteLine(item);   
                
            }
            conn.Close();
        }
    }
}
