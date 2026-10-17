// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobSSEKMSEncryptionFactory(Action<Humidifier.S3.JobTypes.SSEKMSEncryption> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.SSEKMSEncryption>
{

    protected override Humidifier.S3.JobTypes.SSEKMSEncryption Create()
    {
        var sSEKMSEncryptionResult = CreateSSEKMSEncryption();
        factoryAction?.Invoke(sSEKMSEncryptionResult);

        return sSEKMSEncryptionResult;
    }

    private Humidifier.S3.JobTypes.SSEKMSEncryption CreateSSEKMSEncryption()
    {
        var sSEKMSEncryptionResult = new Humidifier.S3.JobTypes.SSEKMSEncryption();

        return sSEKMSEncryptionResult;
    }

} // End Of Class

public static class InnerJobSSEKMSEncryptionFactoryExtensions
{
}
