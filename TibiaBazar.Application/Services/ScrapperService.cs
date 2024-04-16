using FluentResults;
using HtmlAgilityPack;
using Microsoft.Extensions.Configuration;
using TibiaBazar.Application.Services.Interfaces;
using TibiaBazar.Domain.Entity;

namespace TibiaBazar.Application.Services;

public class ScrapperService : IScrapperService
{
    private readonly IConfiguration _configuration;
    public ScrapperService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public async Task<Result<List<Auction>>> Scrap()
    {
        var result = new Result<List<Auction>>();

        var url = _configuration.GetSection("TibiaBazarUrl").Value;

        HtmlWeb web = new();
        var doc = web.Load(url);

        var nodes = doc.DocumentNode.SelectNodes("//*[@id=\"currentcharactertrades\"]/div[5]/div/div/div[3]/table/tbody/tr/td/div[2]/table/tbody/tr");

        foreach (var node in nodes)
        {
            Auction auction = new Auction
            {
                AuctionEnd = DateTimeOffset.Parse(node.SelectSingleNode("//*[@id=\"currentcharactertrades\"]/div[5]/div/div/div[3]/table/tbody/tr/td/div[2]/table/tbody/tr[2]/td/div/table/tbody/tr/td/div/div[2]/div[3]/div[3]").InnerText)
            };
        }


        return result;
    }
}
