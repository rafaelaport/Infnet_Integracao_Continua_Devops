using DockerApi.Controllers;

namespace TestApi
{
    public class WeatherForecastControllerTest
    {
        [Fact]
        public void DeveFazerGetComSucesso()
        {
            var controller = new WeatherForecastController();

            var result = controller.Get();

            Assert.True(result.Any());
        }

        [Fact]
        public void DeveFazerPostComSucesso()
        {
            var controller = new WeatherForecastController();

            var result = controller.Post();

            Assert.True(result.TemperatureC != 0);
        }

    }
}