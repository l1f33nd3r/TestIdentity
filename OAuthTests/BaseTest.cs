using System;
using System.Threading.Tasks;
using Xunit;

namespace OAuthTests
{
    public class WeatherForecastTests : IClassFixture<WebApiFixture>
    {
        private readonly WebApiFixture _fixture;

        public WeatherForecastTests(WebApiFixture fixture)
        {
            _fixture = fixture;
        }
        [Fact]
        public async Task Get_Forecast()
        {
            var client = _fixture.GetOauthClient();
            var response = await client.GetAsync("weather-forecast");
            response.EnsureSuccessStatusCode();
        }
    }
}
