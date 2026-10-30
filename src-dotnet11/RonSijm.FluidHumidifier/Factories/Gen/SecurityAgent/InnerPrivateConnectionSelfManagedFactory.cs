// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerPrivateConnectionSelfManagedFactory(Action<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged>
{

    protected override Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged Create()
    {
        var selfManagedResult = CreateSelfManaged();
        factoryAction?.Invoke(selfManagedResult);

        return selfManagedResult;
    }

    private Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged CreateSelfManaged()
    {
        var selfManagedResult = new Humidifier.SecurityAgent.PrivateConnectionTypes.SelfManaged();

        return selfManagedResult;
    }

} // End Of Class

public static class InnerPrivateConnectionSelfManagedFactoryExtensions
{
}
