// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class InnerStreamStreamEncryptionFactory(Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> factoryAction = null) : SubResourceFactory<Humidifier.Kinesis.StreamTypes.StreamEncryption>
{

    protected override Humidifier.Kinesis.StreamTypes.StreamEncryption Create()
    {
        var streamEncryptionResult = CreateStreamEncryption();
        factoryAction?.Invoke(streamEncryptionResult);

        return streamEncryptionResult;
    }

    private Humidifier.Kinesis.StreamTypes.StreamEncryption CreateStreamEncryption()
    {
        var streamEncryptionResult = new Humidifier.Kinesis.StreamTypes.StreamEncryption();

        return streamEncryptionResult;
    }

} // End Of Class

public static class InnerStreamStreamEncryptionFactoryExtensions
{
}
