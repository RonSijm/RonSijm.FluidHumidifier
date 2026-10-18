// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowEncodingConfigFactory(Action<Humidifier.MediaConnect.FlowTypes.EncodingConfig> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.EncodingConfig>
{

    protected override Humidifier.MediaConnect.FlowTypes.EncodingConfig Create()
    {
        var encodingConfigResult = CreateEncodingConfig();
        factoryAction?.Invoke(encodingConfigResult);

        return encodingConfigResult;
    }

    private Humidifier.MediaConnect.FlowTypes.EncodingConfig CreateEncodingConfig()
    {
        var encodingConfigResult = new Humidifier.MediaConnect.FlowTypes.EncodingConfig();

        return encodingConfigResult;
    }

} // End Of Class

public static class InnerFlowEncodingConfigFactoryExtensions
{
}
