using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Lite
{
    public static class SQL_Requests
    {
        /////////////////////////////////////
        //          SELECT REQUESTS        //
        /////////////////////////////////////
        public static string SelectMetadata(string tableName)
        {
            return string.Format("PRAGMA table_info({0})", tableName);
        }
        public static string SelectMovies()
        {
            return @"SELECT
                    movie_id AS 'id',
                    movie_title AS 'Название фильма',
                    release_date AS 'Дата выхода в прокат',
                    age_limit AS 'Возрастное ограничение',
                    duration AS 'Длительность'
                    FROM movie";
        }
        public static string SelectSessions()
        {
            return @"SELECT
                    session_id AS 'id',
                    start_time AS 'Время начала',
                    cost AS 'Стоимость'
                    FROM session";
        }
        public static string SelectGenres()
        {
            return @"SELECT
                    genre_id AS 'id',
                    genre_title AS 'Жанры'
                    FROM genre";
        }
        public static string SelectTickets()
        {
            return @"SELECT
                    ticket_id AS 'id',
                    purchase_time AS 'Время покупки',
                    row AS 'Ряд',
                    seat AS 'Место'
                    FROM ticket";
        }
        public static string SelectClients()
        {
            return @"SELECT
                    client_id AS 'id',
                    name AS 'ФИО',
                    birthday AS 'Дата рождения'
                    FROM client";
        }
        public static string SelectHalls()
        {
            return @"SELECT
                    hall_id AS 'id',
                    hall_title AS 'Зал'
                    FROM hall";
        }

        public static string SelectClietByID()
        {
            return @"SELECT
                    name,
                    birthday
                    FROM client
                    WHERE client_id = @id";
        }
        public static string SelectClietTiketsByID()
        {
            return @"SELECT
                    ticket_id AS 'id',
                    movie_title AS 'Фильм',
                    purchase_time AS 'Время покупки',
                    hall_title AS 'Зал',
                    row AS 'Ряд',
                    seat AS 'Место'
                    FROM ticket 
                    INNER JOIN session ON
                    ticket.session_id = session.session_id
                    INNER JOIN movie ON
                    session.movie_id = movie.movie_id
                    INNER JOIN hall ON
                    session.hall_id = hall.hall_id
                    WHERE client_id = @id
                    ORDER BY purchase_time DESC";
        }

        /////////////////////////////////////
        //          INSERT REQUESTS        //
        /////////////////////////////////////

        public static string InsertCliet()
        {
            return @"INSERT 
                    INTO client
                    (name, birthday)
                    VALUES 
                    (@name, @birthday)";
        }

        /////////////////////////////////////
        //          UPDATE REQUESTS        //
        /////////////////////////////////////

        public static string UpdateCliet()
        {
            return @"UPDATE client
                    SET
                    name=@name,
                    birthday=@birthday
                    WHERE 
                    client_id = @id";
        }

        /////////////////////////////////////
        //          DELETE REQUESTS        //
        /////////////////////////////////////
    }
}
