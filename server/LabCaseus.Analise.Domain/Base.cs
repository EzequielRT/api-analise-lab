namespace LabCaseus.Analise.Domain
{
    public abstract class Base
    {
        protected Base()
        {
            UId = Guid.NewGuid();
        }

        public Guid UId { get; protected set; }
    }
}