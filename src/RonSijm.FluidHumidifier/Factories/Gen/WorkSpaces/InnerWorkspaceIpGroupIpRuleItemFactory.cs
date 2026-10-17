// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerWorkspaceIpGroupIpRuleItemFactory(Action<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem>
{

    protected override Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem Create()
    {
        var ipRuleItemResult = CreateIpRuleItem();
        factoryAction?.Invoke(ipRuleItemResult);

        return ipRuleItemResult;
    }

    private Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem CreateIpRuleItem()
    {
        var ipRuleItemResult = new Humidifier.WorkSpaces.WorkspaceIpGroupTypes.IpRuleItem();

        return ipRuleItemResult;
    }

} // End Of Class

public static class InnerWorkspaceIpGroupIpRuleItemFactoryExtensions
{
}
