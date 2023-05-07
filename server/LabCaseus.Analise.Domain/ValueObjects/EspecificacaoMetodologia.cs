namespace LabCaseus.Analise.Domain.ValueObjects
{
    public class EspecificacaoMetodologia : Base
    {
        public EspecificacaoMetodologia(string descricao)
        {
            Descricao = descricao;
        }

        public EspecificacaoMetodologia(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id { get; private set; }

        public string Descricao { get; private set; }
    }
}