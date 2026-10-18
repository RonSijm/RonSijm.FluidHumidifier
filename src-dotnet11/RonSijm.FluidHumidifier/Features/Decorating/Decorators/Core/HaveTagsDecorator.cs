using Humidifier.Base;
using Humidifier.Interfaces;
using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Decorating.Decorators.Core;

public class HaveTagsDecorator : BaseTypeDecorator<IHaveTags>
{
    // Rank matters because want to add the name tag as late as possible, after all other decorators are done
    public override int Rank { get; set; } = 900;

    public override void Decorate(IHaveTags target)
    {
        if (target is BaseResource baseResource && UnionValue.Unwrap(target.Tags) is not BaseFunction)
        {
            var tags = target.Tags.GetItems().ToList();

            // Only add the Name tag if it doesn't exist yet
            if (!tags.Any(value => value is Tag tag && tag.Key is string key && key == "Name"))
            {
                tags.Add(new Tag { Key = "Name", Value = baseResource.GivenName });
            }

            target.Tags = tags;
        }
    }
}
