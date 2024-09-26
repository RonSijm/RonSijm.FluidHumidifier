// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionNodePropertiesFactory(Action<Humidifier.Batch.JobDefinitionTypes.NodeProperties> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.NodeProperties>
{

    protected override Humidifier.Batch.JobDefinitionTypes.NodeProperties Create()
    {
        var nodePropertiesResult = CreateNodeProperties();
        factoryAction?.Invoke(nodePropertiesResult);

        return nodePropertiesResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.NodeProperties CreateNodeProperties()
    {
        var nodePropertiesResult = new Humidifier.Batch.JobDefinitionTypes.NodeProperties();

        return nodePropertiesResult;
    }

} // End Of Class

public static class InnerJobDefinitionNodePropertiesFactoryExtensions
{
}
