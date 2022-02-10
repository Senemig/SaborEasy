using System;

namespace Sabor_Easy_MVC.Models
{
    public class Receita
    {
        public int Id { get; set; }
        public string imagePath { get; set; }
        public string videoPath { get; set; }
        public string Titulo { get; set; }
        public string Ingredientes { get; set; }
        public string ModoPreparo { get; set; }
        public string Porcoes { get; set; }
        public string TempoPreparo { get; set; }
        public DateTime dataReceita { get; set; }

    }
}