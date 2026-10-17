// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerQuantumTaskAssociationFactory(Action<Humidifier.Braket.QuantumTaskTypes.Association> factoryAction = null) : SubResourceFactory<Humidifier.Braket.QuantumTaskTypes.Association>
{

    protected override Humidifier.Braket.QuantumTaskTypes.Association Create()
    {
        var associationResult = CreateAssociation();
        factoryAction?.Invoke(associationResult);

        return associationResult;
    }

    private Humidifier.Braket.QuantumTaskTypes.Association CreateAssociation()
    {
        var associationResult = new Humidifier.Braket.QuantumTaskTypes.Association();

        return associationResult;
    }

} // End Of Class

public static class InnerQuantumTaskAssociationFactoryExtensions
{
}
