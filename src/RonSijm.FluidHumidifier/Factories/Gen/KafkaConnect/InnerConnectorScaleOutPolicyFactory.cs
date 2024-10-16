// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorScaleOutPolicyFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy Create()
    {
        var scaleOutPolicyResult = CreateScaleOutPolicy();
        factoryAction?.Invoke(scaleOutPolicyResult);

        return scaleOutPolicyResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy CreateScaleOutPolicy()
    {
        var scaleOutPolicyResult = new Humidifier.KafkaConnect.ConnectorTypes.ScaleOutPolicy();

        return scaleOutPolicyResult;
    }

} // End Of Class

public static class InnerConnectorScaleOutPolicyFactoryExtensions
{
}
