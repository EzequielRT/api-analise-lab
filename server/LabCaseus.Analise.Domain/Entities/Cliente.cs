namespace LabCaseus.Analise.Domain.Entities
{
    public class Cliente : Base
    {
        public Cliente(string razaoSocial, string cnpj, string endereco)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            Endereco = endereco;
        }

        public Cliente(int id, string razaoSocial, string cnpj, string endereco)
        {
            Id = id;
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            Endereco = endereco;
        }

        public int Id { get; private set; }

        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Endereco { get; private set; }
    }
}