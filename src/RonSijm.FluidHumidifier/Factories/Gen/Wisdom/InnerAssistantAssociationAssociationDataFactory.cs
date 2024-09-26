// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAssistantAssociationAssociationDataFactory(Action<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AssistantAssociationTypes.AssociationData>
{

    protected override Humidifier.Wisdom.AssistantAssociationTypes.AssociationData Create()
    {
        var associationDataResult = CreateAssociationData();
        factoryAction?.Invoke(associationDataResult);

        return associationDataResult;
    }

    private Humidifier.Wisdom.AssistantAssociationTypes.AssociationData CreateAssociationData()
    {
        var associationDataResult = new Humidifier.Wisdom.AssistantAssociationTypes.AssociationData();

        return associationDataResult;
    }

} // End Of Class

public static class InnerAssistantAssociationAssociationDataFactoryExtensions
{
}
