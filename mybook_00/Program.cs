using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook_00
{
    class Program
    {
        class book
        {
            public string variable;
            public string value;
        }
        static void Main(string[] args)
        {
            List<book> list = new List<book>();
            list.Add(new book() { variable = "이름", value = "PHP 프로그밍 입문" });
            list.Add(new book() { variable = "초판 발행", value = "2013년 5월 20일" });
            list.Add(new book() { variable = "지은이", value = "황재호" });
            list.Add(new book() { variable = "펴낸이", value = "김태헌" });
            list.Add(new book() { variable = "펴낸곳", value = "한빛아카데미(주)" });
            list.Add(new book() { variable = "책임편집", value = "김현용" });
            list.Add(new book() { variable = "기획", value = "김이화" });
            list.Add(new book() { variable = "편집", value = "김이화" });
            list.Add(new book() { variable = "디자인", value = "여동일" });

            foreach (var item in list)
            {
                Console.WriteLine(item.variable + " : " + item.value);
            }
        }
    }
}
