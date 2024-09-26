// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainResourceSpecFactory(Action<Humidifier.SageMaker.DomainTypes.ResourceSpec> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.ResourceSpec>
{

    protected override Humidifier.SageMaker.DomainTypes.ResourceSpec Create()
    {
        var resourceSpecResult = CreateResourceSpec();
        factoryAction?.Invoke(resourceSpecResult);

        return resourceSpecResult;
    }

    private Humidifier.SageMaker.DomainTypes.ResourceSpec CreateResourceSpec()
    {
        var resourceSpecResult = new Humidifier.SageMaker.DomainTypes.ResourceSpec();

        return resourceSpecResult;
    }

} // End Of Class

public static class InnerDomainResourceSpecFactoryExtensions
{
}
