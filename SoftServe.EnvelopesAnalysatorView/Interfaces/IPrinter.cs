namespace SoftServe.EnvelopesAnalysatorView
{
    interface IPrinter
    {
        void Instraction(string instractionFilePath);

        void Message(string message);

        void PrintResult(bool isInserted);
    }
}
