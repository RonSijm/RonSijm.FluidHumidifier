// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EFS;

public class InnerFileSystemLifecyclePolicyFactory(Action<Humidifier.EFS.FileSystemTypes.LifecyclePolicy> factoryAction = null) : SubResourceFactory<Humidifier.EFS.FileSystemTypes.LifecyclePolicy>
{

    protected override Humidifier.EFS.FileSystemTypes.LifecyclePolicy Create()
    {
        var lifecyclePolicyResult = CreateLifecyclePolicy();
        factoryAction?.Invoke(lifecyclePolicyResult);

        return lifecyclePolicyResult;
    }

    private Humidifier.EFS.FileSystemTypes.LifecyclePolicy CreateLifecyclePolicy()
    {
        var lifecyclePolicyResult = new Humidifier.EFS.FileSystemTypes.LifecyclePolicy();

        return lifecyclePolicyResult;
    }

} // End Of Class

public static class InnerFileSystemLifecyclePolicyFactoryExtensions
{
}
