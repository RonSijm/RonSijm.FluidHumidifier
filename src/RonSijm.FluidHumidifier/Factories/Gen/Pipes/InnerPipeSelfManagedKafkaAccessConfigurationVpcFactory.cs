// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeSelfManagedKafkaAccessConfigurationVpcFactory(Action<Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationVpc> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationVpc>
{

    protected override Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationVpc Create()
    {
        var selfManagedKafkaAccessConfigurationVpcResult = CreateSelfManagedKafkaAccessConfigurationVpc();
        factoryAction?.Invoke(selfManagedKafkaAccessConfigurationVpcResult);

        return selfManagedKafkaAccessConfigurationVpcResult;
    }

    private Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationVpc CreateSelfManagedKafkaAccessConfigurationVpc()
    {
        var selfManagedKafkaAccessConfigurationVpcResult = new Humidifier.Pipes.PipeTypes.SelfManagedKafkaAccessConfigurationVpc();

        return selfManagedKafkaAccessConfigurationVpcResult;
    }

} // End Of Class

public static class InnerPipeSelfManagedKafkaAccessConfigurationVpcFactoryExtensions
{
}
