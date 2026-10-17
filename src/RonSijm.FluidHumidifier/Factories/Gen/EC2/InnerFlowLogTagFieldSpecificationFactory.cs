// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerFlowLogTagFieldSpecificationFactory(Action<Humidifier.EC2.FlowLogTypes.TagFieldSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.FlowLogTypes.TagFieldSpecification>
{

    protected override Humidifier.EC2.FlowLogTypes.TagFieldSpecification Create()
    {
        var tagFieldSpecificationResult = CreateTagFieldSpecification();
        factoryAction?.Invoke(tagFieldSpecificationResult);

        return tagFieldSpecificationResult;
    }

    private Humidifier.EC2.FlowLogTypes.TagFieldSpecification CreateTagFieldSpecification()
    {
        var tagFieldSpecificationResult = new Humidifier.EC2.FlowLogTypes.TagFieldSpecification();

        return tagFieldSpecificationResult;
    }

} // End Of Class

public static class InnerFlowLogTagFieldSpecificationFactoryExtensions
{
}
