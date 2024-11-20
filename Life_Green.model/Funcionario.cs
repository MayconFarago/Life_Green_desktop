using System.ComponentModel.DataAnnotations;

namespace Life_Green.model
{
    public class Funcionario
    {
        //atributos
        [Key]
        private int id;
        private string nome;
        private string cargo;
        private string cpffunc;
        private string nomeUser;
        private string senhaUser;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Cpffunc { get => cpffunc; set => cpffunc = value; }
        public string NomeUser { get => nomeUser; set => nomeUser = value; }
        public string SenhaUser { get => senhaUser; set => senhaUser = value; }
    }
}
