// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerKnowledgeBaseResourcePermissionFactory(Action<Humidifier.QuickSight.KnowledgeBaseTypes.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.KnowledgeBaseTypes.ResourcePermission>
{

    protected override Humidifier.QuickSight.KnowledgeBaseTypes.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.KnowledgeBaseTypes.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.KnowledgeBaseTypes.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerKnowledgeBaseResourcePermissionFactoryExtensions
{
}
