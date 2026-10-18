// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketIntelligentTieringConfigurationFactory(Action<Humidifier.S3.BucketTypes.IntelligentTieringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.IntelligentTieringConfiguration>
{

    protected override Humidifier.S3.BucketTypes.IntelligentTieringConfiguration Create()
    {
        var intelligentTieringConfigurationResult = CreateIntelligentTieringConfiguration();
        factoryAction?.Invoke(intelligentTieringConfigurationResult);

        return intelligentTieringConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.IntelligentTieringConfiguration CreateIntelligentTieringConfiguration()
    {
        var intelligentTieringConfigurationResult = new Humidifier.S3.BucketTypes.IntelligentTieringConfiguration();

        return intelligentTieringConfigurationResult;
    }

} // End Of Class

public static class InnerBucketIntelligentTieringConfigurationFactoryExtensions
{
}
