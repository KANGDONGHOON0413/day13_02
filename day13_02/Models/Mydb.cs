using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace day13_02.Models
{
    public class Mydb : DbContext
    {
        //이 DB가 어떤 서버를 가르키는지를 명시하는 부분
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =(local);Initial=MyDB; Integrated Security=SSPI");
        }

        //실제 테이블을 정의한 클래스이다.
        public DbSet<Employee> Employees { get; set; } //Employees 속성을 통해 테이블 데이터를 엑세스한다.

        //한 데이터베이스 안에 여러개의 테이블을 갖을 경우 아래에 추가로 적는다.
        //public DbSet<Employee> Employees2 { get; set; }
    }
}
