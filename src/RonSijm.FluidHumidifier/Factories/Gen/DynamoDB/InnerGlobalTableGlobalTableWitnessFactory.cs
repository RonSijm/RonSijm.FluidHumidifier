// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerGlobalTableGlobalTableWitnessFactory(Action<Humidifier.DynamoDB.GlobalTableTypes.GlobalTableWitness> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.GlobalTableTypes.GlobalTableWitness>
{

    protected override Humidifier.DynamoDB.GlobalTableTypes.GlobalTableWitness Create()
    {
        var globalTableWitnessResult = CreateGlobalTableWitness();
        factoryAction?.Invoke(globalTableWitnessResult);

        return globalTableWitnessResult;
    }

    private Humidifier.DynamoDB.GlobalTableTypes.GlobalTableWitness CreateGlobalTableWitness()
    {
        var globalTableWitnessResult = new Humidifier.DynamoDB.GlobalTableTypes.GlobalTableWitness();

        return globalTableWitnessResult;
    }

} // End Of Class

public static class InnerGlobalTableGlobalTableWitnessFactoryExtensions
{
}
