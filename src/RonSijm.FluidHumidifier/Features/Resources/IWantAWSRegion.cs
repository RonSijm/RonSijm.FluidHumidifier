namespace RonSijm.FluidHumidifier.Features.Resources;

public interface IWantAWSRegion : IWantProperty
{
    string AWSRegion { get; set; }
}