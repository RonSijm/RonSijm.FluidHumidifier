// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerWorkspaceWorkspaceThemeConfigFactory(Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig>
{

    internal InnerWorkspaceWorkspaceThemePaletteFactory PaletteFactory { get; set; }

    internal InnerWorkspaceWorkspaceThemeTypographyFactory TypographyFactory { get; set; }

    protected override Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig Create()
    {
        var workspaceThemeConfigResult = CreateWorkspaceThemeConfig();
        factoryAction?.Invoke(workspaceThemeConfigResult);

        return workspaceThemeConfigResult;
    }

    private Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig CreateWorkspaceThemeConfig()
    {
        var workspaceThemeConfigResult = new Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig();

        return workspaceThemeConfigResult;
    }
    public override void CreateChildren(Humidifier.Connect.WorkspaceTypes.WorkspaceThemeConfig result)
    {
        base.CreateChildren(result);

        result.Palette ??= PaletteFactory?.Build();
        result.Typography ??= TypographyFactory?.Build();
    }

} // End Of Class

public static class InnerWorkspaceWorkspaceThemeConfigFactoryExtensions
{
    public static CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette(this InnerWorkspaceWorkspaceThemeConfigFactory parentFactory, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null)
    {
        parentFactory.PaletteFactory = new InnerWorkspaceWorkspaceThemePaletteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PaletteFactory);
    }

    public static CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography(this InnerWorkspaceWorkspaceThemeConfigFactory parentFactory, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null)
    {
        parentFactory.TypographyFactory = new InnerWorkspaceWorkspaceThemeTypographyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TypographyFactory);
    }

    public static CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1>(this CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, WithPalette(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, WithPalette(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2>(this CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2, T3, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2, T3>(this CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2, T3, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2, T3>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory, T3, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2, T3, T4, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2, T3, T4>(this CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2, T3, T4, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory, T3, T4, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory, T4, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeConfigFactory, InnerWorkspaceWorkspaceThemePaletteFactory> WithPalette<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeConfigFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemePalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPalette(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1>(this CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, WithTypography(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, WithTypography(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2>(this CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2, T3, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2, T3>(this CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2, T3, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2, T3>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory, T3, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2, T3, T4>(this CombinedResult<InnerWorkspaceWorkspaceThemeConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2, T3, T4, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory, T3, T4, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeConfigFactory, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory, T4, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeConfigFactory, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeConfigFactory, InnerWorkspaceWorkspaceThemeTypographyFactory> WithTypography<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeConfigFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTypography(combinedResult.T5, subFactoryAction).T2);
}
