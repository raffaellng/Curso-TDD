using CursoOnline.Domain.Curso.Enum;
using Xunit;

namespace CursoOnline.Domain.Test.Cursos
{
    public class CursoTest
    {
        //Criar um curso com os seguintes dados:
        //Nome, carga horaria, publico, valor curso

        [Fact]
        public void Curso_CriarCurso_RetornaCurso_Green()
        {
            var CursoEsperado = new
            {
                Nome = "Curso de TDD",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicAlvo.Empresarial,
                Valor = (decimal)100
            };

            var curso = new Curso.Curso(CursoEsperado.Nome, CursoEsperado.CargaHoraria, CursoEsperado.PublicoAlvo, CursoEsperado.Valor);

            Assert.Equal(CursoEsperado.Nome, curso.Nome);
        }

        [Fact]
        public void Curso_CriarCurso_RetornaCurso_Red()
        {
            var CursoEsperado = new
            {
                Nome = "Curso de TDD",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicAlvo.Empresarial,
                Valor = (decimal)100
            };

            var curso = new Curso.Curso(CursoEsperado.Nome, CursoEsperado.CargaHoraria, CursoEsperado.PublicoAlvo, CursoEsperado.Valor);

            var cursoAlterado = "Curso na pratica com TDD";

            Assert.Equal(cursoAlterado, curso.Nome);
        }
    }
}
