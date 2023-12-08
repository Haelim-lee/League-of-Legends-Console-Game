using System;
using System.Data.SqlClient;

namespace lol
{
    public class 데이터베이스관리자
    {
        public SqlConnection 연결관리자 { get; set; }
        public SqlCommand 명령관리자 { get; set; }
        public SqlDataAdapter 연동관리자 { get; set; }
        public SqlTransaction  트렌젝션 { get; set; }

        public 데이터베이스관리자()
        {
            속성초기화();        
            //연결관리자.Open();
        }

        private void 속성초기화()
        {
            연결관리자 = new SqlConnection();
            연결관리자.ConnectionString = @"Data Source=192.168.75.205;Initial Catalog=lol;Integrated Security =False; user id = sa; password = gksmf950**;";
            명령관리자 = new SqlCommand();
            명령관리자.Connection = 연결관리자;
            연동관리자 = new SqlDataAdapter();
            연동관리자.SelectCommand = 명령관리자;

        }
        public void 트렌젝션시작()
        {
            this.트렌젝션 = this.연결관리자.BeginTransaction();
        }

        public void 트렌젝션종료()
        {
            try { this.트렌젝션.Commit(); }
            catch { }
        }
        public  void 명령수행(string 명령어)
        {
            try
            {
                this.명령관리자.CommandText = 명령어;
                this.명령관리자.Transaction = 트렌젝션;
                this.명령관리자.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine("명령수행  중 오류 발생 \n" + e.Message);
                this.명령관리자.Transaction.Rollback();
            }
        }

        //public DateTable 조회수행(string 명령어)
       // {
       //     DateTable 결과표 = new DateTable();
       //     연결관리자.SelectCommand.CommandText = 명령어;
       //     연동관리자 .Fill(결과표);
       //
       //     return 결과표;
       
       // }
    }
}