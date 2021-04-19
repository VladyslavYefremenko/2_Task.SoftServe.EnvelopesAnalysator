namespace SoftServe.EnvelopesAnalysator
{
    public interface IValidators
    {
        bool ValidatSides(string arg1, string arg2, string arg3, string arg4);

        bool IsNumDouble(string arg);
    }
}
