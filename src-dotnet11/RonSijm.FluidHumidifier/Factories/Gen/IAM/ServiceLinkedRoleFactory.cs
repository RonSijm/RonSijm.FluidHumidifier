// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class ServiceLinkedRoleFactory(string resourceName = null, Action<Humidifier.IAM.ServiceLinkedRole> factoryAction = null) : ResourceFactory<Humidifier.IAM.ServiceLinkedRole>(resourceName)
{

    protected override Humidifier.IAM.ServiceLinkedRole Create()
    {
        var serviceLinkedRoleResult = CreateServiceLinkedRole();
        factoryAction?.Invoke(serviceLinkedRoleResult);

        return serviceLinkedRoleResult;
    }

    private Humidifier.IAM.ServiceLinkedRole CreateServiceLinkedRole()
    {
        var serviceLinkedRoleResult = new Humidifier.IAM.ServiceLinkedRole
        {
            GivenName = InputResourceName,
        };

        return serviceLinkedRoleResult;
    }

} // End Of Class

public static class ServiceLinkedRoleFactoryExtensions
{
}
