// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerContentAssociationAmazonConnectGuideAssociationDataFactory(Action<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData>
{

    protected override Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData Create()
    {
        var amazonConnectGuideAssociationDataResult = CreateAmazonConnectGuideAssociationData();
        factoryAction?.Invoke(amazonConnectGuideAssociationDataResult);

        return amazonConnectGuideAssociationDataResult;
    }

    private Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData CreateAmazonConnectGuideAssociationData()
    {
        var amazonConnectGuideAssociationDataResult = new Humidifier.Wisdom.ContentAssociationTypes.AmazonConnectGuideAssociationData();

        return amazonConnectGuideAssociationDataResult;
    }

} // End Of Class

public static class InnerContentAssociationAmazonConnectGuideAssociationDataFactoryExtensions
{
}
