// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GreengrassV2;

public class InnerComponentVersionLambdaContainerParamsFactory(Action<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams> factoryAction = null) : SubResourceFactory<Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams>
{

    protected override Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams Create()
    {
        var lambdaContainerParamsResult = CreateLambdaContainerParams();
        factoryAction?.Invoke(lambdaContainerParamsResult);

        return lambdaContainerParamsResult;
    }

    private Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams CreateLambdaContainerParams()
    {
        var lambdaContainerParamsResult = new Humidifier.GreengrassV2.ComponentVersionTypes.LambdaContainerParams();

        return lambdaContainerParamsResult;
    }

} // End Of Class

public static class InnerComponentVersionLambdaContainerParamsFactoryExtensions
{
}
