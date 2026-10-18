// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceIdentityCenterConfigurationFactory(Action<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration>
{

    protected override Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration Create()
    {
        var identityCenterConfigurationResult = CreateIdentityCenterConfiguration();
        factoryAction?.Invoke(identityCenterConfigurationResult);

        return identityCenterConfigurationResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration CreateIdentityCenterConfiguration()
    {
        var identityCenterConfigurationResult = new Humidifier.QuickSight.DataSourceTypes.IdentityCenterConfiguration();

        return identityCenterConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceIdentityCenterConfigurationFactoryExtensions
{
}
