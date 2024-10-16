// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterApplicationFactory(Action<Humidifier.EMR.ClusterTypes.Application> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.Application>
{

    protected override Humidifier.EMR.ClusterTypes.Application Create()
    {
        var applicationResult = CreateApplication();
        factoryAction?.Invoke(applicationResult);

        return applicationResult;
    }

    private Humidifier.EMR.ClusterTypes.Application CreateApplication()
    {
        var applicationResult = new Humidifier.EMR.ClusterTypes.Application();

        return applicationResult;
    }

} // End Of Class

public static class InnerClusterApplicationFactoryExtensions
{
}
