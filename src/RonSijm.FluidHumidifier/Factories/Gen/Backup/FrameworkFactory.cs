// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class FrameworkFactory(string resourceName = null, Action<Humidifier.Backup.Framework> factoryAction = null) : ResourceFactory<Humidifier.Backup.Framework>(resourceName)
{

    internal List<InnerFrameworkFrameworkControlFactory> FrameworkControlsFactories { get; set; } = [];

    protected override Humidifier.Backup.Framework Create()
    {
        var frameworkResult = CreateFramework();
        factoryAction?.Invoke(frameworkResult);

        return frameworkResult;
    }

    private Humidifier.Backup.Framework CreateFramework()
    {
        var frameworkResult = new Humidifier.Backup.Framework
        {
            GivenName = InputResourceName,
        };

        return frameworkResult;
    }
    public override void CreateChildren(Humidifier.Backup.Framework result)
    {
        base.CreateChildren(result);

        result.FrameworkControls = FrameworkControlsFactories.Any() ? FrameworkControlsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class FrameworkFactoryExtensions
{
    public static CombinedResult<FrameworkFactory, InnerFrameworkFrameworkControlFactory> WithFrameworkControls(this FrameworkFactory parentFactory, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null)
    {
        var factory = new InnerFrameworkFrameworkControlFactory(subFactoryAction);
        parentFactory.FrameworkControlsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FrameworkFactory, T1, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1>(this CombinedResult<FrameworkFactory, T1> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, WithFrameworkControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FrameworkFactory, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1>(this CombinedResult<T1, FrameworkFactory> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, WithFrameworkControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FrameworkFactory, T1, T2, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2>(this CombinedResult<FrameworkFactory, T1, T2> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FrameworkFactory, T2, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2>(this CombinedResult<T1, FrameworkFactory, T2> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FrameworkFactory, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2>(this CombinedResult<T1, T2, FrameworkFactory> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FrameworkFactory, T1, T2, T3, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2, T3>(this CombinedResult<FrameworkFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FrameworkFactory, T2, T3, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2, T3>(this CombinedResult<T1, FrameworkFactory, T2, T3> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FrameworkFactory, T3, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2, T3>(this CombinedResult<T1, T2, FrameworkFactory, T3> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FrameworkFactory, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2, T3>(this CombinedResult<T1, T2, T3, FrameworkFactory> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FrameworkFactory, T1, T2, T3, T4, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2, T3, T4>(this CombinedResult<FrameworkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FrameworkFactory, T2, T3, T4, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2, T3, T4>(this CombinedResult<T1, FrameworkFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FrameworkFactory, T3, T4, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, FrameworkFactory, T3, T4> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FrameworkFactory, T4, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FrameworkFactory, T4> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FrameworkFactory, InnerFrameworkFrameworkControlFactory> WithFrameworkControls<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FrameworkFactory> combinedResult, Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFrameworkControls(combinedResult.T5, subFactoryAction));
}
