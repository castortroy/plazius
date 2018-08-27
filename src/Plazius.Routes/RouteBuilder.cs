using Plazius.Routes.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Plazius.Routes
{
    /// <summary>
    /// Класс для построения маршрутов
    /// </summary>
    public class RouteBuilder
    {
        /// <summary>
        /// Строит непрерывный маршурт по списку карточек
        /// Сложность О(n^2)
        /// </summary>
        /// <param name="routeParts">Список карточек</param>
        /// <returns>Маршрут</returns>
        public static List<RoutePart> Build(List<RoutePart> routeParts)
        {
            if(routeParts == null)
            {
                throw new ArgumentNullException(nameof(routeParts));
            }
            var route = new List<RoutePart>(routeParts.Count);
            if (routeParts.Count > 0) {
                route.Add(routeParts[0]);

                while (route.Count < routeParts.Count)
                {
                    for (int j = 1; j < routeParts.Count; j++)
                    {
                        if (route[route.Count - 1].Destination.Equals(routeParts[j].Departure)) {
                            route.Add(routeParts[j]);
                            break;
                        }
                    }
                    for (int j = 1; j < routeParts.Count; j++)
                    {
                        if (route[0].Departure.Equals(routeParts[j].Destination))
                        {
                            route.Insert(0, routeParts[j]);
                            break;

                        }
                    }
                }
            }
            return route;
        }
    }
}