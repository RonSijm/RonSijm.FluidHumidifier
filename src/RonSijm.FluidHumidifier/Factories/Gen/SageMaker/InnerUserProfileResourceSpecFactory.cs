// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerUserProfileResourceSpecFactory(Action<Humidifier.SageMaker.UserProfileTypes.ResourceSpec> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.UserProfileTypes.ResourceSpec>
{

    protected override Humidifier.SageMaker.UserProfileTypes.ResourceSpec Create()
    {
        var resourceSpecResult = CreateResourceSpec();
        factoryAction?.Invoke(resourceSpecResult);

        return resourceSpecResult;
    }

    private Humidifier.SageMaker.UserProfileTypes.ResourceSpec CreateResourceSpec()
    {
        var resourceSpecResult = new Humidifier.SageMaker.UserProfileTypes.ResourceSpec();

        return resourceSpecResult;
    }

} // End Of Class

public static class InnerUserProfileResourceSpecFactoryExtensions
{
}
