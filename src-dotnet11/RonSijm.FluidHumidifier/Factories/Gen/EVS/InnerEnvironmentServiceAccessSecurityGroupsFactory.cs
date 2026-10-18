// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EVS;

public class InnerEnvironmentServiceAccessSecurityGroupsFactory(Action<Humidifier.EVS.EnvironmentTypes.ServiceAccessSecurityGroups> factoryAction = null) : SubResourceFactory<Humidifier.EVS.EnvironmentTypes.ServiceAccessSecurityGroups>
{

    protected override Humidifier.EVS.EnvironmentTypes.ServiceAccessSecurityGroups Create()
    {
        var serviceAccessSecurityGroupsResult = CreateServiceAccessSecurityGroups();
        factoryAction?.Invoke(serviceAccessSecurityGroupsResult);

        return serviceAccessSecurityGroupsResult;
    }

    private Humidifier.EVS.EnvironmentTypes.ServiceAccessSecurityGroups CreateServiceAccessSecurityGroups()
    {
        var serviceAccessSecurityGroupsResult = new Humidifier.EVS.EnvironmentTypes.ServiceAccessSecurityGroups();

        return serviceAccessSecurityGroupsResult;
    }

} // End Of Class

public static class InnerEnvironmentServiceAccessSecurityGroupsFactoryExtensions
{
}
