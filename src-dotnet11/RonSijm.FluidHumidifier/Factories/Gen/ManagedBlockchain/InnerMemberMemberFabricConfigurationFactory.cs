// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class InnerMemberMemberFabricConfigurationFactory(Action<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration>
{

    protected override Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration Create()
    {
        var memberFabricConfigurationResult = CreateMemberFabricConfiguration();
        factoryAction?.Invoke(memberFabricConfigurationResult);

        return memberFabricConfigurationResult;
    }

    private Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration CreateMemberFabricConfiguration()
    {
        var memberFabricConfigurationResult = new Humidifier.ManagedBlockchain.MemberTypes.MemberFabricConfiguration();

        return memberFabricConfigurationResult;
    }

} // End Of Class

public static class InnerMemberMemberFabricConfigurationFactoryExtensions
{
}
