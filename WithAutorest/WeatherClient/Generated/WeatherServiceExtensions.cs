// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace WeatherClient
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WeatherService.
    /// </summary>
    public static partial class WeatherServiceExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<WeatherForecast> GetWeatherForecast(this IWeatherService operations)
            {
                return operations.GetWeatherForecastAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<WeatherForecast>> GetWeatherForecastAsync(this IWeatherService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWeatherForecastWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='zipCode'>
            /// </param>
            public static IList<WeatherForecast> GetWeatherForecastByZipCode(this IWeatherService operations, string zipCode)
            {
                return operations.GetWeatherForecastByZipCodeAsync(zipCode).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='zipCode'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<WeatherForecast>> GetWeatherForecastByZipCodeAsync(this IWeatherService operations, string zipCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWeatherForecastByZipCodeWithHttpMessagesAsync(zipCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}