// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerMitigationActionPublishFindingToSnsParamsFactory(Action<Humidifier.IoT.MitigationActionTypes.PublishFindingToSnsParams> factoryAction = null) : SubResourceFactory<Humidifier.IoT.MitigationActionTypes.PublishFindingToSnsParams>
{

    protected override Humidifier.IoT.MitigationActionTypes.PublishFindingToSnsParams Create()
    {
        var publishFindingToSnsParamsResult = CreatePublishFindingToSnsParams();
        factoryAction?.Invoke(publishFindingToSnsParamsResult);

        return publishFindingToSnsParamsResult;
    }

    private Humidifier.IoT.MitigationActionTypes.PublishFindingToSnsParams CreatePublishFindingToSnsParams()
    {
        var publishFindingToSnsParamsResult = new Humidifier.IoT.MitigationActionTypes.PublishFindingToSnsParams();

        return publishFindingToSnsParamsResult;
    }

} // End Of Class

public static class InnerMitigationActionPublishFindingToSnsParamsFactoryExtensions
{
}
