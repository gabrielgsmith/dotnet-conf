using Aspire.DotnetConf.Core.ContributorAggregate;

namespace Aspire.DotnetConf.UseCases.Contributors.Update;

public record UpdateContributorCommand(ContributorId ContributorId, ContributorName NewName) : ICommand<Result<ContributorDto>>;
