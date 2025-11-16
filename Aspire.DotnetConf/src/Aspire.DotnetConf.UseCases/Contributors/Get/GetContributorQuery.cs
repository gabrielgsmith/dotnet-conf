using Aspire.DotnetConf.Core.ContributorAggregate;

namespace Aspire.DotnetConf.UseCases.Contributors.Get;

public record GetContributorQuery(ContributorId ContributorId) : IQuery<Result<ContributorDto>>;
