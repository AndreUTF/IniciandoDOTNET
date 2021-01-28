using System;
namespace Revisao
{
    public class Aluno
    {
        private String name;
        private int grade;
         public Aluno()
        {
            this.name = "";
            this.grade = 0;
        }
        public Aluno(String name , int grade)
        {
            this.name = name;
            this.grade = grade;
        }
        public int Grade { get => grade; set => grade = value; }
        public string Name { get => name; set => name = value; }
    }
}