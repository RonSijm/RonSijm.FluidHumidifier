// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerTagAssociationLFTagPairFactory(Action<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.TagAssociationTypes.LFTagPair>
{

    protected override Humidifier.LakeFormation.TagAssociationTypes.LFTagPair Create()
    {
        var lFTagPairResult = CreateLFTagPair();
        factoryAction?.Invoke(lFTagPairResult);

        return lFTagPairResult;
    }

    private Humidifier.LakeFormation.TagAssociationTypes.LFTagPair CreateLFTagPair()
    {
        var lFTagPairResult = new Humidifier.LakeFormation.TagAssociationTypes.LFTagPair();

        return lFTagPairResult;
    }

} // End Of Class

public static class InnerTagAssociationLFTagPairFactoryExtensions
{
}
