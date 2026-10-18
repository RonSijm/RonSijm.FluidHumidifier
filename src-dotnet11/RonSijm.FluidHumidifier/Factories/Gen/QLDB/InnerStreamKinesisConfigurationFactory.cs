// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QLDB;

public class InnerStreamKinesisConfigurationFactory(Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QLDB.StreamTypes.KinesisConfiguration>
{

    protected override Humidifier.QLDB.StreamTypes.KinesisConfiguration Create()
    {
        var kinesisConfigurationResult = CreateKinesisConfiguration();
        factoryAction?.Invoke(kinesisConfigurationResult);

        return kinesisConfigurationResult;
    }

    private Humidifier.QLDB.StreamTypes.KinesisConfiguration CreateKinesisConfiguration()
    {
        var kinesisConfigurationResult = new Humidifier.QLDB.StreamTypes.KinesisConfiguration();

        return kinesisConfigurationResult;
    }

} // End Of Class

public static class InnerStreamKinesisConfigurationFactoryExtensions
{
}
