// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerIndexJsonTokenTypeConfigurationFactory(Action<Humidifier.Kendra.IndexTypes.JsonTokenTypeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.IndexTypes.JsonTokenTypeConfiguration>
{

    protected override Humidifier.Kendra.IndexTypes.JsonTokenTypeConfiguration Create()
    {
        var jsonTokenTypeConfigurationResult = CreateJsonTokenTypeConfiguration();
        factoryAction?.Invoke(jsonTokenTypeConfigurationResult);

        return jsonTokenTypeConfigurationResult;
    }

    private Humidifier.Kendra.IndexTypes.JsonTokenTypeConfiguration CreateJsonTokenTypeConfiguration()
    {
        var jsonTokenTypeConfigurationResult = new Humidifier.Kendra.IndexTypes.JsonTokenTypeConfiguration();

        return jsonTokenTypeConfigurationResult;
    }

} // End Of Class

public static class InnerIndexJsonTokenTypeConfigurationFactoryExtensions
{
}
