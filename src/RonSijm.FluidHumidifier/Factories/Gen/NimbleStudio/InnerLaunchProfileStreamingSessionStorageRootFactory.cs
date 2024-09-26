// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerLaunchProfileStreamingSessionStorageRootFactory(Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot>
{

    protected override Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot Create()
    {
        var streamingSessionStorageRootResult = CreateStreamingSessionStorageRoot();
        factoryAction?.Invoke(streamingSessionStorageRootResult);

        return streamingSessionStorageRootResult;
    }

    private Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot CreateStreamingSessionStorageRoot()
    {
        var streamingSessionStorageRootResult = new Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot();

        return streamingSessionStorageRootResult;
    }

} // End Of Class

public static class InnerLaunchProfileStreamingSessionStorageRootFactoryExtensions
{
}
