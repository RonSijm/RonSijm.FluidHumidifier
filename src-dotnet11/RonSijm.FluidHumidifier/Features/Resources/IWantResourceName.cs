namespace RonSijm.FluidHumidifier.Features.Resources;

public interface IWantResourceName : IWantProperty
{
    string ResourceName { get; set; }
}