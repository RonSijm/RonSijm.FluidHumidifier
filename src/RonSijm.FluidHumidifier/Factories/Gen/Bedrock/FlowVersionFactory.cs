// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class FlowVersionFactory(string resourceName = null, Action<Humidifier.Bedrock.FlowVersion> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.FlowVersion>(resourceName)
{

    protected override Humidifier.Bedrock.FlowVersion Create()
    {
        var flowVersionResult = CreateFlowVersion();
        factoryAction?.Invoke(flowVersionResult);

        return flowVersionResult;
    }

    private Humidifier.Bedrock.FlowVersion CreateFlowVersion()
    {
        var flowVersionResult = new Humidifier.Bedrock.FlowVersion
        {
            GivenName = InputResourceName,
        };

        return flowVersionResult;
    }

} // End Of Class

public static class FlowVersionFactoryExtensions
{
}
