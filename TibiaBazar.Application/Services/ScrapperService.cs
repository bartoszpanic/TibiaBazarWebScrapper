using FluentResults;
using TibiaBazar.Application.Services.Interfaces;
using TibiaBazar.Domain.Entity;

namespace TibiaBazar.Application.Services;

public class ScrapperService : IScrapperService
{
    public Result<List<Auction>> Scrap()
    {
        var result = new Result<List<Auction>>();


        return result;
    }
}
