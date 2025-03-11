using TaxiParkLabs.Domain.Services.InMemory;
using TaxiParkLabs.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace TaxiParkLabs.Domain.Tests;
/// <summary>
///  Класс с юнит-тестами репозитория с поездками
/// </summary>
public class TripRepositoryTests
{
    /// <summary>
    /// Тест проверяет успешное получение статистики по поездкам водителей.
    /// </summary>
    [Fact]
    public async Task GetDriverTripStatistics_Success()
    {
        var repo = new TripInMemoryRepository();
        var statistics = await repo.GetDriverTripStatistics();

        Assert.NotNull(statistics);
    }
}
