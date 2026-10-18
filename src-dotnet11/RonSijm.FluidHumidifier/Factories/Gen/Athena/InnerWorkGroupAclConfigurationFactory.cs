// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupAclConfigurationFactory(Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.AclConfiguration>
{

    protected override Humidifier.Athena.WorkGroupTypes.AclConfiguration Create()
    {
        var aclConfigurationResult = CreateAclConfiguration();
        factoryAction?.Invoke(aclConfigurationResult);

        return aclConfigurationResult;
    }

    private Humidifier.Athena.WorkGroupTypes.AclConfiguration CreateAclConfiguration()
    {
        var aclConfigurationResult = new Humidifier.Athena.WorkGroupTypes.AclConfiguration();

        return aclConfigurationResult;
    }

} // End Of Class

public static class InnerWorkGroupAclConfigurationFactoryExtensions
{
}
