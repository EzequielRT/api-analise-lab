namespace LabCaseus.Analise.Domain.Entities
{
    public class FarmaceuticoResponsavel : Base
    {
        public FarmaceuticoResponsavel(string farmaceuticoNome, string farmaceuticoEspecialidade, string farmaceuticoRegistroCrq)
        {
            FarmaceuticoNome = farmaceuticoNome;
            FarmaceuticoEspecialidade = farmaceuticoEspecialidade;
            FarmaceuticoRegistroCrq = farmaceuticoRegistroCrq;
        }

        public FarmaceuticoResponsavel(int id, string farmaceuticoNome, string farmaceuticoEspecialidade, string farmaceuticoRegistroCrq)
        {
            Id = id;
            FarmaceuticoNome = farmaceuticoNome;
            FarmaceuticoEspecialidade = farmaceuticoEspecialidade;
            FarmaceuticoRegistroCrq = farmaceuticoRegistroCrq;
        }

        public int Id { get; private set; }

        public string FarmaceuticoNome { get; private set; }
        public string FarmaceuticoEspecialidade { get; private set; }
        public string FarmaceuticoRegistroCrq { get; private set; }
    }
}