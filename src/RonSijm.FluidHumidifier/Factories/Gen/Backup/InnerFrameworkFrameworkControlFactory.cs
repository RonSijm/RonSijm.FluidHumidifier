// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerFrameworkFrameworkControlFactory(Action<Humidifier.Backup.FrameworkTypes.FrameworkControl> factoryAction = null) : SubResourceFactory<Humidifier.Backup.FrameworkTypes.FrameworkControl>
{

    internal InnerFrameworkControlScopeFactory ControlScopeFactory { get; set; }

    protected override Humidifier.Backup.FrameworkTypes.FrameworkControl Create()
    {
        var frameworkControlResult = CreateFrameworkControl();
        factoryAction?.Invoke(frameworkControlResult);

        return frameworkControlResult;
    }

    private Humidifier.Backup.FrameworkTypes.FrameworkControl CreateFrameworkControl()
    {
        var frameworkControlResult = new Humidifier.Backup.FrameworkTypes.FrameworkControl();

        return frameworkControlResult;
    }
    public override void CreateChildren(Humidifier.Backup.FrameworkTypes.FrameworkControl result)
    {
        base.CreateChildren(result);

        result.ControlScope ??= ControlScopeFactory?.Build();
    }

} // End Of Class

public static class InnerFrameworkFrameworkControlFactoryExtensions
{
    public static CombinedResult<InnerFrameworkFrameworkControlFactory, InnerFrameworkControlScopeFactory> WithControlScope(this InnerFrameworkFrameworkControlFactory parentFactory, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null)
    {
        parentFactory.ControlScopeFactory = new InnerFrameworkControlScopeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ControlScopeFactory);
    }

    public static CombinedResult<InnerFrameworkFrameworkControlFactory, T1, InnerFrameworkControlScopeFactory> WithControlScope<T1>(this CombinedResult<InnerFrameworkFrameworkControlFactory, T1> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, WithControlScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFrameworkFrameworkControlFactory, InnerFrameworkControlScopeFactory> WithControlScope<T1>(this CombinedResult<T1, InnerFrameworkFrameworkControlFactory> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, WithControlScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFrameworkFrameworkControlFactory, T1, T2, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2>(this CombinedResult<InnerFrameworkFrameworkControlFactory, T1, T2> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFrameworkFrameworkControlFactory, T2, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2>(this CombinedResult<T1, InnerFrameworkFrameworkControlFactory, T2> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFrameworkFrameworkControlFactory, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2>(this CombinedResult<T1, T2, InnerFrameworkFrameworkControlFactory> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFrameworkFrameworkControlFactory, T1, T2, T3, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2, T3>(this CombinedResult<InnerFrameworkFrameworkControlFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFrameworkFrameworkControlFactory, T2, T3, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2, T3>(this CombinedResult<T1, InnerFrameworkFrameworkControlFactory, T2, T3> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFrameworkFrameworkControlFactory, T3, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2, T3>(this CombinedResult<T1, T2, InnerFrameworkFrameworkControlFactory, T3> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFrameworkFrameworkControlFactory, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFrameworkFrameworkControlFactory> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFrameworkFrameworkControlFactory, T1, T2, T3, T4, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2, T3, T4>(this CombinedResult<InnerFrameworkFrameworkControlFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFrameworkFrameworkControlFactory, T2, T3, T4, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2, T3, T4>(this CombinedResult<T1, InnerFrameworkFrameworkControlFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFrameworkFrameworkControlFactory, T3, T4, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFrameworkFrameworkControlFactory, T3, T4> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFrameworkFrameworkControlFactory, T4, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFrameworkFrameworkControlFactory, T4> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFrameworkFrameworkControlFactory, InnerFrameworkControlScopeFactory> WithControlScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFrameworkFrameworkControlFactory> combinedResult, Action<Humidifier.Backup.FrameworkTypes.ControlScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithControlScope(combinedResult.T5, subFactoryAction));
}
