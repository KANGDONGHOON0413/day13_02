using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace day13_02.Models
{
    //Employee 클래스는 테이블의 구조, 메타데이터를 정의한 것이다.

    [Table("Emp")]  //sql의 EMP테이블을 C#의 Employee 클래스에 대입
    public class Employee //관계형 DB에서 테이블의 이름이 다를경우 위에처럼 써줘야한다.(같은경우 위를 생략해도 된다)
    {
        [Key]
        public int Id { get; set; } //id는 자동적으로 key로 인식하지만, 다른 이름으로 하고싶을때는 [key]로 명시해야한다
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public decimal Salary { get; set; }
    }
}
