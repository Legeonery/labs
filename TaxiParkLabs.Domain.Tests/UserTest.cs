using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiParkLabs.Domain.Model;
using TaxiParkLabs.Domain.Services.InMemory;
using Xunit;

namespace TaxiParkLabs.Domain.Tests;
/// <summary>
///  Класс с юнит-тестами репозитория с пользователями
/// </summary>
public class UserRepositoryTests
{
    /// <summary>
    /// Тест проверяет успешное получение пассажиров за указанный период поездок.
    /// </summary>
    [Fact]
    public async Task GetPassengersByTripPeriod_Success()
    {
        var repo = new UserInMemoryRepository();
        var passengers = await repo.GetPassengersByTripPeriod(20230101, 20231231);

        Assert.NotNull(passengers);
    }

    /// <summary>
    /// Тест проверяет успешное получение количества поездок для каждого пассажира.
    /// </summary>
    [Fact]
    public async Task GetTripCountByPassenger_Success()
    {
        var repo = new UserInMemoryRepository();
        var tripCounts = await repo.GetTripCountByPassenger();

        Assert.NotNull(tripCounts);
    }

    /// <summary>
    /// Тест проверяет успешное получение топ-пассажиров по количеству поездок за указанный период.
    /// </summary>
    [Fact]
    public async Task GetTopPassengersByTripPeriod_Success()
    {
        var repo = new UserInMemoryRepository();
        var topPassengers = await repo.GetTopPassengersByTripPeriod(20230101, 20231231);

        Assert.NotNull(topPassengers);
    }
}