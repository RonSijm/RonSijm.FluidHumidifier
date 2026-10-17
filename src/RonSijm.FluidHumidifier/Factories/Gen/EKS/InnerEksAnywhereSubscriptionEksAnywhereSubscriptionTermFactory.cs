// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactory(Action<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm> factoryAction = null) : SubResourceFactory<Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm>
{

    protected override Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm Create()
    {
        var eksAnywhereSubscriptionTermResult = CreateEksAnywhereSubscriptionTerm();
        factoryAction?.Invoke(eksAnywhereSubscriptionTermResult);

        return eksAnywhereSubscriptionTermResult;
    }

    private Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm CreateEksAnywhereSubscriptionTerm()
    {
        var eksAnywhereSubscriptionTermResult = new Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm();

        return eksAnywhereSubscriptionTermResult;
    }

} // End Of Class

public static class InnerEksAnywhereSubscriptionEksAnywhereSubscriptionTermFactoryExtensions
{
}
