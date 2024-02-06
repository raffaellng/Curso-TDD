using CursoOnline.Domain.Curso.Enum;

namespace CursoOnline.Domain.Curso
{
    public class Curso
    {
        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public PublicAlvo PublicoAlvo { get; set; }
        public decimal Valor { get; set; }

        public Curso(string nome, double cargaHoraria, PublicAlvo publicoAlvo, decimal valor)
        {

            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }
    }
}
