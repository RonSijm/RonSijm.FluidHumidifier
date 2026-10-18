// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerSpaceResourceSpecFactory(Action<Humidifier.SageMaker.SpaceTypes.ResourceSpec> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.SpaceTypes.ResourceSpec>
{

    protected override Humidifier.SageMaker.SpaceTypes.ResourceSpec Create()
    {
        var resourceSpecResult = CreateResourceSpec();
        factoryAction?.Invoke(resourceSpecResult);

        return resourceSpecResult;
    }

    private Humidifier.SageMaker.SpaceTypes.ResourceSpec CreateResourceSpec()
    {
        var resourceSpecResult = new Humidifier.SageMaker.SpaceTypes.ResourceSpec();

        return resourceSpecResult;
    }

} // End Of Class

public static class InnerSpaceResourceSpecFactoryExtensions
{
}
