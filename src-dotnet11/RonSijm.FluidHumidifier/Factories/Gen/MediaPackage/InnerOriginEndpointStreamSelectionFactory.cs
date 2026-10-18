// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointStreamSelectionFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection>
{

    protected override Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection Create()
    {
        var streamSelectionResult = CreateStreamSelection();
        factoryAction?.Invoke(streamSelectionResult);

        return streamSelectionResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection CreateStreamSelection()
    {
        var streamSelectionResult = new Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection();

        return streamSelectionResult;
    }

} // End Of Class

public static class InnerOriginEndpointStreamSelectionFactoryExtensions
{
}
