// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerWorkspaceWorkspaceThemeFactory(Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> factoryAction = null) : SubResourceFactory<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme>
{

    internal InnerWorkspaceWorkspaceThemeConfigFactory LightFactory { get; set; }

    internal InnerWorkspaceWorkspaceThemeConfigFactory DarkFactory { get; set; }

    protected override Humidifier.Connect.WorkspaceTypes.WorkspaceTheme Create()
    {
        var workspaceThemeResult = CreateWorkspaceTheme();
        factoryAction?.Invoke(workspaceThemeResult);

        return workspaceThemeResult;
    }

    private Humidifier.Connect.WorkspaceTypes.WorkspaceTheme CreateWorkspaceTheme()
    {
        var workspaceThemeResult = new Humidifier.Connect.WorkspaceTypes.WorkspaceTheme();

        return workspaceThemeResult;
    }
    public override void CreateChildren(Humidifier.Connect.WorkspaceTypes.WorkspaceTheme result)
    {
        base.CreateChildren(result);

        result.Light ??= LightFactory?.Build();
        result.Dark ??= DarkFactory?.Build();
    }

} // End Of Class

public static class InnerWorkspaceWorkspaceThemeFactoryExtensions
{
    public static CombinedResult<InnerWorkspaceWorkspaceThemeFactory, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight(this InnerWorkspaceWorkspaceThemeFactory parentFactory, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null)
    {
        parentFactory.LightFactory = new InnerWorkspaceWorkspaceThemeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LightFactory);
    }

    public static CombinedResult<InnerWorkspaceWorkspaceThemeFactory, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark(this InnerWorkspaceWorkspaceThemeFactory parentFactory, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null)
    {
        parentFactory.DarkFactory = new InnerWorkspaceWorkspaceThemeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DarkFactory);
    }

    public static CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1>(this CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2>(this CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2, T3>(this CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2, T3>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory, T3, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeFactory, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2, T3, T4>(this CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2, T3, T4, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory, T3, T4, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeFactory, T4, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeFactory, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeFactory, InnerWorkspaceWorkspaceThemeConfigFactory> WithLight<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLight(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1>(this CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDark(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDark(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2>(this CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2, T3>(this CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2, T3>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory, T3, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeFactory, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2, T3, T4>(this CombinedResult<InnerWorkspaceWorkspaceThemeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2, T3, T4, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory, T3, T4, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeFactory, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeFactory, T4, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeFactory, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeFactory, InnerWorkspaceWorkspaceThemeConfigFactory> WithDark<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDark(combinedResult.T5, subFactoryAction).T2);
}
