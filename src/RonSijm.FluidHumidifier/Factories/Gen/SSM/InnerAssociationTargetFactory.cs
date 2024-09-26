// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerAssociationTargetFactory(Action<Humidifier.SSM.AssociationTypes.Target> factoryAction = null) : SubResourceFactory<Humidifier.SSM.AssociationTypes.Target>
{

    protected override Humidifier.SSM.AssociationTypes.Target Create()
    {
        var targetResult = CreateTarget();
        factoryAction?.Invoke(targetResult);

        return targetResult;
    }

    private Humidifier.SSM.AssociationTypes.Target CreateTarget()
    {
        var targetResult = new Humidifier.SSM.AssociationTypes.Target();

        return targetResult;
    }

} // End Of Class

public static class InnerAssociationTargetFactoryExtensions
{
}
