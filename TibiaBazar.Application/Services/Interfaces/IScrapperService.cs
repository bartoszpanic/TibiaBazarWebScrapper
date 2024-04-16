using FluentResults;
using TibiaBazar.Domain.Entity;

namespace TibiaBazar.Application.Services.Interfaces;

public interface IScrapperService
{
    public Task<Result<List<Auction>>> Scrap();
}
