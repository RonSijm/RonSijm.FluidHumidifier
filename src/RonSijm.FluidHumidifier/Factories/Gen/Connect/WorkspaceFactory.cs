// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class WorkspaceFactory(string resourceName = null, Action<Humidifier.Connect.Workspace> factoryAction = null) : ResourceFactory<Humidifier.Connect.Workspace>(resourceName)
{

    internal List<InnerWorkspaceWorkspacePageFactory> PagesFactories { get; set; } = [];

    internal List<InnerWorkspaceMediaItemFactory> MediaFactories { get; set; } = [];

    internal InnerWorkspaceWorkspaceThemeFactory ThemeFactory { get; set; }

    protected override Humidifier.Connect.Workspace Create()
    {
        var workspaceResult = CreateWorkspace();
        factoryAction?.Invoke(workspaceResult);

        return workspaceResult;
    }

    private Humidifier.Connect.Workspace CreateWorkspace()
    {
        var workspaceResult = new Humidifier.Connect.Workspace
        {
            GivenName = InputResourceName,
        };

        return workspaceResult;
    }
    public override void CreateChildren(Humidifier.Connect.Workspace result)
    {
        base.CreateChildren(result);

        result.Pages = PagesFactories.Any() ? PagesFactories.Select(x => x.Build()).ToList() : null;
        result.Media = MediaFactories.Any() ? MediaFactories.Select(x => x.Build()).ToList() : null;
        result.Theme ??= ThemeFactory?.Build();
    }

} // End Of Class

public static class WorkspaceFactoryExtensions
{
    public static CombinedResult<WorkspaceFactory, InnerWorkspaceWorkspacePageFactory> WithPages(this WorkspaceFactory parentFactory, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null)
    {
        var factory = new InnerWorkspaceWorkspacePageFactory(subFactoryAction);
        parentFactory.PagesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WorkspaceFactory, InnerWorkspaceMediaItemFactory> WithMedia(this WorkspaceFactory parentFactory, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null)
    {
        var factory = new InnerWorkspaceMediaItemFactory(subFactoryAction);
        parentFactory.MediaFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<WorkspaceFactory, InnerWorkspaceWorkspaceThemeFactory> WithTheme(this WorkspaceFactory parentFactory, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null)
    {
        parentFactory.ThemeFactory = new InnerWorkspaceWorkspaceThemeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ThemeFactory);
    }

    public static CombinedResult<WorkspaceFactory, T1, InnerWorkspaceWorkspacePageFactory> WithPages<T1>(this CombinedResult<WorkspaceFactory, T1> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, WithPages(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, InnerWorkspaceWorkspacePageFactory> WithPages<T1>(this CombinedResult<T1, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, WithPages(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2>(this CombinedResult<WorkspaceFactory, T1, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2>(this CombinedResult<T1, WorkspaceFactory, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2>(this CombinedResult<T1, T2, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2, T3>(this CombinedResult<WorkspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2, T3>(this CombinedResult<T1, WorkspaceFactory, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceFactory, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, T4, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2, T3, T4>(this CombinedResult<WorkspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, T4, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, T4, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceFactory, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, T4, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceFactory, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkspaceFactory, InnerWorkspaceWorkspacePageFactory> WithPages<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspacePage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPages(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, InnerWorkspaceMediaItemFactory> WithMedia<T1>(this CombinedResult<WorkspaceFactory, T1> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, InnerWorkspaceMediaItemFactory> WithMedia<T1>(this CombinedResult<T1, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2>(this CombinedResult<WorkspaceFactory, T1, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2>(this CombinedResult<T1, WorkspaceFactory, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2>(this CombinedResult<T1, T2, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2, T3>(this CombinedResult<WorkspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2, T3>(this CombinedResult<T1, WorkspaceFactory, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceFactory, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, T4, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<WorkspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, T4, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, T4, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceFactory, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, T4, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceFactory, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkspaceFactory, InnerWorkspaceMediaItemFactory> WithMedia<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.MediaItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMedia(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1>(this CombinedResult<WorkspaceFactory, T1> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, WithTheme(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1>(this CombinedResult<T1, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, WithTheme(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2>(this CombinedResult<WorkspaceFactory, T1, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2>(this CombinedResult<T1, WorkspaceFactory, T2> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2>(this CombinedResult<T1, T2, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2, T3>(this CombinedResult<WorkspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2, T3>(this CombinedResult<T1, WorkspaceFactory, T2, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceFactory, T3> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, T4, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2, T3, T4>(this CombinedResult<WorkspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, T4, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, T4, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceFactory, T3, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, T4, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceFactory, T4> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, WorkspaceFactory, InnerWorkspaceWorkspaceThemeFactory> WithTheme<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceFactory> combinedResult, Action<Humidifier.Connect.WorkspaceTypes.WorkspaceTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTheme(combinedResult.T5, subFactoryAction).T2);
}
