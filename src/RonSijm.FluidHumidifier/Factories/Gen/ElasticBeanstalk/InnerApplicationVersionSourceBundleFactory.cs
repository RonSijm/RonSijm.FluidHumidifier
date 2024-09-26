// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticBeanstalk;

public class InnerApplicationVersionSourceBundleFactory(Action<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle> factoryAction = null) : SubResourceFactory<Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle>
{

    protected override Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle Create()
    {
        var sourceBundleResult = CreateSourceBundle();
        factoryAction?.Invoke(sourceBundleResult);

        return sourceBundleResult;
    }

    private Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle CreateSourceBundle()
    {
        var sourceBundleResult = new Humidifier.ElasticBeanstalk.ApplicationVersionTypes.SourceBundle();

        return sourceBundleResult;
    }

} // End Of Class

public static class InnerApplicationVersionSourceBundleFactoryExtensions
{
}
