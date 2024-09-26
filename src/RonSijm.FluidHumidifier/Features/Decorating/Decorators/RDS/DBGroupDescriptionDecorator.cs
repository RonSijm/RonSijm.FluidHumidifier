using Humidifier.RDS;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
using RonSijm.FluidHumidifier.Features.Resources;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.RDS;

public class DBGroupDescriptionDecorator : BaseTypeDecorator<DBSubnetGroup>, IWantEnvironmentName, IWantStackName
{
    // Rank matter because you could change the resource name to affect the policy name
    public override int Rank { get; set; } = 50;

    public override void Decorate(DBSubnetGroup target)
    {
        target.DBSubnetGroupDescription = $"{StackName}-{EnvironmentName}-{target.GivenName} Subnet Group";
    }

    public string EnvironmentName { get; set; }
    public string StackName { get; set; }
}