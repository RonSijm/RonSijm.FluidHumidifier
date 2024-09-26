// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAppResourceSpecFactory(Action<Humidifier.SageMaker.AppTypes.ResourceSpec> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AppTypes.ResourceSpec>
{

    protected override Humidifier.SageMaker.AppTypes.ResourceSpec Create()
    {
        var resourceSpecResult = CreateResourceSpec();
        factoryAction?.Invoke(resourceSpecResult);

        return resourceSpecResult;
    }

    private Humidifier.SageMaker.AppTypes.ResourceSpec CreateResourceSpec()
    {
        var resourceSpecResult = new Humidifier.SageMaker.AppTypes.ResourceSpec();

        return resourceSpecResult;
    }

} // End Of Class

public static class InnerAppResourceSpecFactoryExtensions
{
}
