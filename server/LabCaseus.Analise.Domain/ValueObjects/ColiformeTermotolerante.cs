using LabCaseus.Analise.Domain.Entities;

namespace LabCaseus.Analise.Domain.ValueObjects
{
    public class ColiformeTermotolerante : Base
    {
        public ColiformeTermotolerante(string especificacao, string resultado)
        {
            Especificacao = especificacao;
            Resultado = resultado;
        }

        public ColiformeTermotolerante(int id, string especificacao, string resultado)
        {
            Id = id;
            Especificacao = especificacao;
            Resultado = resultado;
        }

        public int Id { get; private set; }

        public string Especificacao { get; private set; }
        public string Resultado { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is ColiformeTermotolerante termotolerante &&
                   Especificacao == termotolerante.Especificacao &&
                   Resultado == termotolerante.Resultado;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Especificacao, Resultado);
        }
    }
}