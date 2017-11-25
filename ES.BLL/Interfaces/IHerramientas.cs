namespace ES.BLL.Interfaces
{
    public interface IHerramientas
    {
        #region Encryption

        // Encrypt()
        string Encrypt(string data);

        // Decrypt()
        string Decrypt(string data);

        #endregion Encryption

        // CapitalizeByWord()
        string CapitalizeByWord(string data);

        // Capitalize()
        string Capitalize(string data);
    }
}
