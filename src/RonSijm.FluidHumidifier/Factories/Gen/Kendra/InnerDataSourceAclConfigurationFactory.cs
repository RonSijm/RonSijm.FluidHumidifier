// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceAclConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.AclConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.AclConfiguration>
{

    protected override Humidifier.Kendra.DataSourceTypes.AclConfiguration Create()
    {
        var aclConfigurationResult = CreateAclConfiguration();
        factoryAction?.Invoke(aclConfigurationResult);

        return aclConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.AclConfiguration CreateAclConfiguration()
    {
        var aclConfigurationResult = new Humidifier.Kendra.DataSourceTypes.AclConfiguration();

        return aclConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceAclConfigurationFactoryExtensions
{
}
