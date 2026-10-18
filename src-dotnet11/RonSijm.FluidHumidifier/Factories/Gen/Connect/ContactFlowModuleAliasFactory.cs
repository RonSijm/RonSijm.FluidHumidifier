// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class ContactFlowModuleAliasFactory(string resourceName = null, Action<Humidifier.Connect.ContactFlowModuleAlias> factoryAction = null) : ResourceFactory<Humidifier.Connect.ContactFlowModuleAlias>(resourceName)
{

    protected override Humidifier.Connect.ContactFlowModuleAlias Create()
    {
        var contactFlowModuleAliasResult = CreateContactFlowModuleAlias();
        factoryAction?.Invoke(contactFlowModuleAliasResult);

        return contactFlowModuleAliasResult;
    }

    private Humidifier.Connect.ContactFlowModuleAlias CreateContactFlowModuleAlias()
    {
        var contactFlowModuleAliasResult = new Humidifier.Connect.ContactFlowModuleAlias
        {
            GivenName = InputResourceName,
        };

        return contactFlowModuleAliasResult;
    }

} // End Of Class

public static class ContactFlowModuleAliasFactoryExtensions
{
}
