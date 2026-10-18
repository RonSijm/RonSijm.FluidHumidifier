// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerStreamProcessorBoundingBoxFactory(Action<Humidifier.Rekognition.StreamProcessorTypes.BoundingBox> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.StreamProcessorTypes.BoundingBox>
{

    protected override Humidifier.Rekognition.StreamProcessorTypes.BoundingBox Create()
    {
        var boundingBoxResult = CreateBoundingBox();
        factoryAction?.Invoke(boundingBoxResult);

        return boundingBoxResult;
    }

    private Humidifier.Rekognition.StreamProcessorTypes.BoundingBox CreateBoundingBox()
    {
        var boundingBoxResult = new Humidifier.Rekognition.StreamProcessorTypes.BoundingBox();

        return boundingBoxResult;
    }

} // End Of Class

public static class InnerStreamProcessorBoundingBoxFactoryExtensions
{
}
