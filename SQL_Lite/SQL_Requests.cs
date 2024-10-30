using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lite
{
    public static class SQL_Requests
    {
        public static string SelectMovies()
        {
            return @"SELECT
                    movie_title AS 'Название фильма',
                    release_date AS 'Дата выхода в прокат',
                    age_limit AS 'Возрастное ограничение',
                    duration AS 'Длительность'
                    FROM movie";
        }
        public static string SelectSessions()
        {
            return @"SELECT
                    start_time AS 'Время начала',
                    cost AS 'Стоимость'
                    FROM session";
        }
        public static string SelectGenres()
        {
            return @"SELECT
                    genre_title AS 'Жанра'
                    FROM genre";
        }
        public static string SelectTickets()
        {
            return @"SELECT
                    purchase_time AS 'Время покупки',
                    row AS 'Ряд',
                    seat AS 'Место'
                    FROM ticket";
        }
        public static string SelectClients()
        {
            return @"SELECT
                    name AS 'ФИО',
                    birthday AS 'Дата рождения'
                    FROM client";
        }
        public static string SelectHalls()
        {
            return @"SELECT
                    hall_title AS 'Зал'
                    FROM hall";
        }
    }
}
