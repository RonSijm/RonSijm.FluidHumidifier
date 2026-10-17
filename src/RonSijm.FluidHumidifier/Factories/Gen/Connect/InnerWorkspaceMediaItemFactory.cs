// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerWorkspaceMediaItemFactory(Action<Humidifier.Connect.WorkspaceTypes.MediaItem> factoryAction = null) : SubResourceFactory<Humidifier.Connect.WorkspaceTypes.MediaItem>
{

    protected override Humidifier.Connect.WorkspaceTypes.MediaItem Create()
    {
        var mediaItemResult = CreateMediaItem();
        factoryAction?.Invoke(mediaItemResult);

        return mediaItemResult;
    }

    private Humidifier.Connect.WorkspaceTypes.MediaItem CreateMediaItem()
    {
        var mediaItemResult = new Humidifier.Connect.WorkspaceTypes.MediaItem();

        return mediaItemResult;
    }

} // End Of Class

public static class InnerWorkspaceMediaItemFactoryExtensions
{
}
