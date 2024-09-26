// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodePipeline;

public class InnerPipelineEncryptionKeyFactory(Action<Humidifier.CodePipeline.PipelineTypes.EncryptionKey> factoryAction = null) : SubResourceFactory<Humidifier.CodePipeline.PipelineTypes.EncryptionKey>
{

    protected override Humidifier.CodePipeline.PipelineTypes.EncryptionKey Create()
    {
        var encryptionKeyResult = CreateEncryptionKey();
        factoryAction?.Invoke(encryptionKeyResult);

        return encryptionKeyResult;
    }

    private Humidifier.CodePipeline.PipelineTypes.EncryptionKey CreateEncryptionKey()
    {
        var encryptionKeyResult = new Humidifier.CodePipeline.PipelineTypes.EncryptionKey();

        return encryptionKeyResult;
    }

} // End Of Class

public static class InnerPipelineEncryptionKeyFactoryExtensions
{
}
