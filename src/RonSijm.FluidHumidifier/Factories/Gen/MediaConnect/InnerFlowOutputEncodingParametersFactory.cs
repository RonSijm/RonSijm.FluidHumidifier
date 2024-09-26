// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowOutputEncodingParametersFactory(Action<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters>
{

    protected override Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters Create()
    {
        var encodingParametersResult = CreateEncodingParameters();
        factoryAction?.Invoke(encodingParametersResult);

        return encodingParametersResult;
    }

    private Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters CreateEncodingParameters()
    {
        var encodingParametersResult = new Humidifier.MediaConnect.FlowOutputTypes.EncodingParameters();

        return encodingParametersResult;
    }

} // End Of Class

public static class InnerFlowOutputEncodingParametersFactoryExtensions
{
}
