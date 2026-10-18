// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class InnerConnectorScaleInPolicyFactory(Action<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy> factoryAction = null) : SubResourceFactory<Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy>
{

    protected override Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy Create()
    {
        var scaleInPolicyResult = CreateScaleInPolicy();
        factoryAction?.Invoke(scaleInPolicyResult);

        return scaleInPolicyResult;
    }

    private Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy CreateScaleInPolicy()
    {
        var scaleInPolicyResult = new Humidifier.KafkaConnect.ConnectorTypes.ScaleInPolicy();

        return scaleInPolicyResult;
    }

} // End Of Class

public static class InnerConnectorScaleInPolicyFactoryExtensions
{
}
