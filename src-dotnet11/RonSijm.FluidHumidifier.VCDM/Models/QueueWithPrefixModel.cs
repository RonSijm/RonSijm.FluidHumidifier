using QueueFactory = RonSijm.FluidHumidifier.Factories.SQS.QueueFactory;

namespace RonSijm.FluidHumidifier.VCDM.Models
{
    public record QueueWithPrefixModel(QueueFactory Queue, string Prefix);
}