// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerWorkspaceWorkspaceThemeTypographyFactory(Action<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography> factoryAction = null) : SubResourceFactory<Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography>
{

    internal InnerWorkspaceFontFamilyFactory FontFamilyFactory { get; set; }

    protected override Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography Create()
    {
        var workspaceThemeTypographyResult = CreateWorkspaceThemeTypography();
        factoryAction?.Invoke(workspaceThemeTypographyResult);

        return workspaceThemeTypographyResult;
    }

    private Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography CreateWorkspaceThemeTypography()
    {
        var workspaceThemeTypographyResult = new Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography();

        return workspaceThemeTypographyResult;
    }
    public override void CreateChildren(Humidifier.Connect.WorkspaceTypes.WorkspaceThemeTypography result)
    {
        base.CreateChildren(result);

        result.FontFamily ??= FontFamilyFactory?.Build();
    }

} // End Of Class

public static class InnerWorkspaceWorkspaceThemeTypographyFactoryExtensions
{
    public static CombinedResult<InnerWorkspaceWorkspaceThemeTypographyFactory, InnerWorkspaceFontFamilyFactory> WithFontFamily(this InnerWorkspaceWorkspaceThemeTypographyFactory parentFactory, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null)
    {
        parentFactory.FontFamilyFactory = new InnerWorkspaceFontFamilyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FontFamilyFactory);
    }

    public static CombinedResult<InnerWorkspaceWorkspaceThemeTypographyFactory, T1, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1>(this CombinedResult<InnerWorkspaceWorkspaceThemeTypographyFactory, T1> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontFamily(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeTypographyFactory, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeTypographyFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontFamily(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeTypographyFactory, T1, T2, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2>(this CombinedResult<InnerWorkspaceWorkspaceThemeTypographyFactory, T1, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeTypographyFactory, T2, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeTypographyFactory, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeTypographyFactory, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeTypographyFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeTypographyFactory, T1, T2, T3, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2, T3>(this CombinedResult<InnerWorkspaceWorkspaceThemeTypographyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeTypographyFactory, T2, T3, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2, T3>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeTypographyFactory, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeTypographyFactory, T3, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeTypographyFactory, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeTypographyFactory, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeTypographyFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkspaceWorkspaceThemeTypographyFactory, T1, T2, T3, T4, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2, T3, T4>(this CombinedResult<InnerWorkspaceWorkspaceThemeTypographyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkspaceWorkspaceThemeTypographyFactory, T2, T3, T4, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkspaceWorkspaceThemeTypographyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeTypographyFactory, T3, T4, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkspaceWorkspaceThemeTypographyFactory, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeTypographyFactory, T4, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkspaceWorkspaceThemeTypographyFactory, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeTypographyFactory, InnerWorkspaceFontFamilyFactory> WithFontFamily<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeTypographyFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.FontFamily> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontFamily(combinedResult.T5, subFactoryAction).T2);
}
