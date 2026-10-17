// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Signer;

public class SigningJobFactory(string resourceName = null, Action<Humidifier.Signer.SigningJob> factoryAction = null) : ResourceFactory<Humidifier.Signer.SigningJob>(resourceName)
{

    protected override Humidifier.Signer.SigningJob Create()
    {
        var signingJobResult = CreateSigningJob();
        factoryAction?.Invoke(signingJobResult);

        return signingJobResult;
    }

    private Humidifier.Signer.SigningJob CreateSigningJob()
    {
        var signingJobResult = new Humidifier.Signer.SigningJob
        {
            GivenName = InputResourceName,
        };

        return signingJobResult;
    }

} // End Of Class

public static class SigningJobFactoryExtensions
{
}
