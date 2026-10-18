// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorKafkaClusterOAuthIamJwtBearerFactory(Action<Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthIamJwtBearer> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthIamJwtBearer>
{

    protected override Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthIamJwtBearer Create()
    {
        var kafkaClusterOAuthIamJwtBearerResult = CreateKafkaClusterOAuthIamJwtBearer();
        factoryAction?.Invoke(kafkaClusterOAuthIamJwtBearerResult);

        return kafkaClusterOAuthIamJwtBearerResult;
    }

    private Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthIamJwtBearer CreateKafkaClusterOAuthIamJwtBearer()
    {
        var kafkaClusterOAuthIamJwtBearerResult = new Humidifier.MSK.ReplicatorTypes.KafkaClusterOAuthIamJwtBearer();

        return kafkaClusterOAuthIamJwtBearerResult;
    }

} // End Of Class

public static class InnerReplicatorKafkaClusterOAuthIamJwtBearerFactoryExtensions
{
}
