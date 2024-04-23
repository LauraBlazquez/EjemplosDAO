namespace AC4
{
    public interface IComarcaDAO
    {
        public List<ComarcaDTO> GetAllComarques();
        void InsertComarca(ComarcaDTO contact);
    }
}
