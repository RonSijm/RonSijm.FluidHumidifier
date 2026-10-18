// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowNdiConfigFactory(Action<Humidifier.MediaConnect.FlowTypes.NdiConfig> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.NdiConfig>
{

    protected override Humidifier.MediaConnect.FlowTypes.NdiConfig Create()
    {
        var ndiConfigResult = CreateNdiConfig();
        factoryAction?.Invoke(ndiConfigResult);

        return ndiConfigResult;
    }

    private Humidifier.MediaConnect.FlowTypes.NdiConfig CreateNdiConfig()
    {
        var ndiConfigResult = new Humidifier.MediaConnect.FlowTypes.NdiConfig();

        return ndiConfigResult;
    }

} // End Of Class

public static class InnerFlowNdiConfigFactoryExtensions
{
}
