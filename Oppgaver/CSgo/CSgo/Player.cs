using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSgo
{
    internal class Player
    {
        public bool IsDead { get; set; }
        public int SuccessRate = 5;
        public Guid Id { get; set; }

        public Player()
        {
            Id = Guid.NewGuid();
        }

        public static bool IsSuccessful(int maxValue)
        {
            Random rand = new Random();
            return rand.Next(0, maxValue) == 2;
        }
    }
}


//namespace TodoFullStack.Model
//{
//    public class TodoItem
//    {
//        public Guid Id { get; set; }
//        public string Text { get; set; }
//        public DateTime? Done { get; set; }

//        public TodoItem()
//        {
//            Id = Guid.NewGuid();
//        }
//    }
//}
