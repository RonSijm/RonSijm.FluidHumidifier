// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OSIS;

public class InnerPipelineEncryptionAtRestOptionsFactory(Action<Humidifier.OSIS.PipelineTypes.EncryptionAtRestOptions> factoryAction = null) : SubResourceFactory<Humidifier.OSIS.PipelineTypes.EncryptionAtRestOptions>
{

    protected override Humidifier.OSIS.PipelineTypes.EncryptionAtRestOptions Create()
    {
        var encryptionAtRestOptionsResult = CreateEncryptionAtRestOptions();
        factoryAction?.Invoke(encryptionAtRestOptionsResult);

        return encryptionAtRestOptionsResult;
    }

    private Humidifier.OSIS.PipelineTypes.EncryptionAtRestOptions CreateEncryptionAtRestOptions()
    {
        var encryptionAtRestOptionsResult = new Humidifier.OSIS.PipelineTypes.EncryptionAtRestOptions();

        return encryptionAtRestOptionsResult;
    }

} // End Of Class

public static class InnerPipelineEncryptionAtRestOptionsFactoryExtensions
{
}
