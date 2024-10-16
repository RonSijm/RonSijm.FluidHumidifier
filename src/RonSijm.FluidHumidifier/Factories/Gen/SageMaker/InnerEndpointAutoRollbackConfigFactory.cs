// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointAutoRollbackConfigFactory(Action<Humidifier.SageMaker.EndpointTypes.AutoRollbackConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointTypes.AutoRollbackConfig>
{

    protected override Humidifier.SageMaker.EndpointTypes.AutoRollbackConfig Create()
    {
        var autoRollbackConfigResult = CreateAutoRollbackConfig();
        factoryAction?.Invoke(autoRollbackConfigResult);

        return autoRollbackConfigResult;
    }

    private Humidifier.SageMaker.EndpointTypes.AutoRollbackConfig CreateAutoRollbackConfig()
    {
        var autoRollbackConfigResult = new Humidifier.SageMaker.EndpointTypes.AutoRollbackConfig();

        return autoRollbackConfigResult;
    }

} // End Of Class

public static class InnerEndpointAutoRollbackConfigFactoryExtensions
{
}
