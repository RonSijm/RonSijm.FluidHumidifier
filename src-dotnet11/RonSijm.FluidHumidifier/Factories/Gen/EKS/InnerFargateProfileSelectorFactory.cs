// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerFargateProfileSelectorFactory(Action<Humidifier.EKS.FargateProfileTypes.Selector> factoryAction = null) : SubResourceFactory<Humidifier.EKS.FargateProfileTypes.Selector>
{

    protected override Humidifier.EKS.FargateProfileTypes.Selector Create()
    {
        var selectorResult = CreateSelector();
        factoryAction?.Invoke(selectorResult);

        return selectorResult;
    }

    private Humidifier.EKS.FargateProfileTypes.Selector CreateSelector()
    {
        var selectorResult = new Humidifier.EKS.FargateProfileTypes.Selector();

        return selectorResult;
    }

} // End Of Class

public static class InnerFargateProfileSelectorFactoryExtensions
{
}
