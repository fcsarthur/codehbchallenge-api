using System;
using System.Collections.Generic;
using System.Text;

namespace codehbchallenge_api.Domain.Entities
{
    public class Location
    {
        public int id { get; set; }
        public string data_extracao { get; set; }
        public string dep_administrativa { get; set; }
        public string tipo { get; set; }
        public int codigo { get; set; }
        public int inep { get; set; }
        public string nome { get; set; }
        public string abr_nome { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public int cep { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public int telefone { get; set; }
        public string email { get; set; }
        public string url_website { get; set; }
    }
}
