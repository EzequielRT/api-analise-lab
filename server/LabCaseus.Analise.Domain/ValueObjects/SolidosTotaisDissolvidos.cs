using LabCaseus.Analise.Domain.Entities;

namespace LabCaseus.Analise.Domain.ValueObjects
{
    public class SolidosTotaisDissolvidos : Base
    {
        public SolidosTotaisDissolvidos(string especificacao, string resultado)
        {
            Especificacao = especificacao;
            Resultado = resultado;
        }

        public SolidosTotaisDissolvidos(int id, string especificacao, string resultado)
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
            return obj is SolidosTotaisDissolvidos visual &&
                   Especificacao == visual.Especificacao &&
                   Resultado == visual.Resultado;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Especificacao, Resultado);
        }
    }
}