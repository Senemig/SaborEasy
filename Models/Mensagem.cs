using System;

namespace Sabor_Easy_MVC.Models
{
    public class Mensagem
    {
        public int msgId { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string mensagem { get; set; }
        public DateTime msgDate { get; set; }
    }
}