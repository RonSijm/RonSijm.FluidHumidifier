// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTopicV2ResourcePermissionFactory(Action<Humidifier.QuickSight.TopicV2Types.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TopicV2Types.ResourcePermission>
{

    protected override Humidifier.QuickSight.TopicV2Types.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.TopicV2Types.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.TopicV2Types.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerTopicV2ResourcePermissionFactoryExtensions
{
}
