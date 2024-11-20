using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Green.model
{
    public class Produtos
    {
        //Atributos
        [Key]
        private int id;
        private string nomeProd;
        private string categoriaProd;
        private int qtdProd;
        private double precoProd;
        private string medidaProd;

        public int Id { get => id; set => id = value; }
        public string NomeProd { get => nomeProd; set => nomeProd = value; }
        public string CategoriaProd { get => categoriaProd; set => categoriaProd = value; }
        public int QtdProd { get => qtdProd; set => qtdProd = value; }
        public double PrecoProd { get => precoProd; set => precoProd = value; }
        public string MedidaProd { get => medidaProd; set => medidaProd = value; }
    }
}
