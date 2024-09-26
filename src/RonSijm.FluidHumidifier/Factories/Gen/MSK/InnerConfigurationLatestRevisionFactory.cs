// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerConfigurationLatestRevisionFactory(Action<Humidifier.MSK.ConfigurationTypes.LatestRevision> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ConfigurationTypes.LatestRevision>
{

    protected override Humidifier.MSK.ConfigurationTypes.LatestRevision Create()
    {
        var latestRevisionResult = CreateLatestRevision();
        factoryAction?.Invoke(latestRevisionResult);

        return latestRevisionResult;
    }

    private Humidifier.MSK.ConfigurationTypes.LatestRevision CreateLatestRevision()
    {
        var latestRevisionResult = new Humidifier.MSK.ConfigurationTypes.LatestRevision();

        return latestRevisionResult;
    }

} // End Of Class

public static class InnerConfigurationLatestRevisionFactoryExtensions
{
}
