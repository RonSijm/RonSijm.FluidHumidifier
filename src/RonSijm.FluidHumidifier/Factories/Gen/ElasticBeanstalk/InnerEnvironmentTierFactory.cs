// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerEnvironmentTierFactory(Action<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier>
{

    protected override Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier Create()
    {
        var tierResult = CreateTier();
        factoryAction?.Invoke(tierResult);

        return tierResult;
    }

    private Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier CreateTier()
    {
        var tierResult = new Humidifier.ElasticBeanstalk.EnvironmentTypes.Tier();

        return tierResult;
    }

} // End Of Class

public static class InnerEnvironmentTierFactoryExtensions
{
}
