using System;

namespace Sabor_Easy_MVC.Models
{
    public class Mensagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Msg { get; set; }
        public DateTime msgDate { get; set; }
    }
}