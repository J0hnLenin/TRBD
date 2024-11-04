using System;
using System.Collections.Generic;
using System.Drawing;
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
                    strftime('%d.%m.%Y', release_date) AS 'Дата выхода в прокат',
                    age_limit||'+' AS 'Возрастное ограничение',
                    strftime('%H:%M', duration) AS 'Длительность'
                    FROM movie";
        }
        public static string SelectSessions()
        {
            return @"SELECT
                    session_id AS 'id',
                    movie_title AS 'Фильм',
                    hall_title AS 'Зал',
                    strftime('%d.%m.%Y', start_time) AS 'Дата сеанса',
                    strftime('%H:%M', start_time) AS 'Время начала',
                    strftime('%H:%M', 
                            (strftime('%s', start_time) 
		                    + strftime('%s', duration)),
			                    'unixepoch') AS 'Время завершения',
                    cost AS 'Стоимость'
                    FROM session
                    INNER JOIN movie ON
                    session.movie_id = movie.movie_id
                    INNER JOIN hall ON
                    session.hall_id = hall.hall_id";
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
                    strftime('%d.%m.%Y %H:%M:%S', purchase_time) AS 'Время покупки',
                    row AS 'Ряд',
                    seat AS 'Место'
                    FROM ticket";
        }
        public static string SelectClients()
        {
            return @"SELECT
                    client_id AS 'id',
                    name AS 'ФИО',
                    strftime('%d.%m.%Y', birthday) AS 'Дата рождения'
                    FROM client";
        }
        public static string SelectHalls()
        {
            return @"SELECT
                    hall.hall_id AS 'id',
                    hall_title AS 'Зал',
                    SUM(num_seats) AS 'Количество мест'
                    FROM hall
                    LEFT JOIN row ON
                    row.hall_id = hall.hall_id
                    GROUP BY 
                    hall.hall_id,
                    hall_title";
        }
        public static string SelectHallByID()
        {
            return @"SELECT
                    hall_title AS 'Зал'
                    FROM hall
                    WHERE hall_id = @id";
        }

        public static string SelectClietByID()
        {
            return @"SELECT
                    name,
                    strftime('%d.%m.%Y', birthday)
                    FROM client
                    WHERE client_id = @id";
        }
        public static string SelectGenreByID()
        {
            return @"SELECT
                    genre_title
                    FROM genre
                    WHERE genre_id = @id";
        }
        public static string SelectMovieByID()
        {
            return @"SELECT
                    movie_title,
                    strftime('%d.%m.%Y', release_date),
                    age_limit||'+',
                    duration
                    FROM movie
                    WHERE movie_id = @id";
        }
        public static string SelectSessionByID()
        {
            return @"SELECT
                    hall.hall_id,
                    hall_title,
                    movie.movie_id,
                    movie_title,
                    strftime('%d.%m.%Y', start_time),
                    strftime('%H:%M', start_time),
                    strftime('%H:%M', duration),
                    cost
                    FROM session
                    INNER JOIN movie ON
                    session.movie_id = movie.movie_id
                    INNER JOIN hall ON
                    session.hall_id = hall.hall_id
                    WHERE session_id = @id";
        }
        public static string SelectClietTiketsByID()
        {
            return @"SELECT
                    ticket_id AS 'id',
                    movie_title AS 'Фильм',
                    strftime('%d.%m.%Y %H:%M:%S', purchase_time) AS 'Время покупки',
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
        public static string SelectHallRowsByID()
        {
            return @"SELECT
                    row_id,
                    row_num AS 'Номер ряда',
                    num_seats AS 'Количество мест'
                    FROM row
                    WHERE hall_id = @id
                    ORDER BY row_num";
        }
        public static string SelectMovieGenresByID()
        {
            return @"SELECT
                    movie_genre_id,
                    movie_genre.genre_id,
                    genre_title AS 'Жанр'
                    FROM movie_genre 
                    INNER JOIN genre ON
                    movie_genre.genre_id = genre.genre_id
                    AND movie_id = @id";
        }
        public static string SelectOrherGenres(string[] genres)
        {
            return String.Format(@"SELECT
                    genre_id,
                    genre_title AS 'Жанр'
                    FROM genre
                    WHERE genre_id NOT IN ({0})", string.Join(", ", genres));
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
        public static string InsertHall() 
        {
            return @"INSERT
                    INTO hall
                    (hall_title)
                    VALUES
                    (@hall_title)";
        }
        public static string InsertGenre()
        {
            return @"INSERT 
                    INTO genre
                    (genre_title)
                    VALUES 
                    (@genre_title)";
        }
        public static string InsertMovie()
        {
            return @"INSERT 
                    INTO movie
                    (movie_title, release_date, age_limit, duration)
                    VALUES 
                    (@movie_title, @release_date, @age_limit, @duration)";
        }
        public static string InsertSession()
        {
            return @"INSERT 
                    INTO session
                    (hall_id, movie_id, start_time, cost)
                    VALUES 
                    (@hall_id, @movie_id, @start_time, @cost)";
        }
        public static string InsertMovieGenres(int valuesCount)
        {
            string[] valuesArray = new string[valuesCount];
            for (int i = 0; i<valuesCount; i++)
            {
                valuesArray[i] = string.Format("(@genre_id_{0}, @movie_id_{0})", i);
            }
            return string.Format(@"INSERT 
                    INTO movie_genre
                    (genre_id, movie_id)
                    VALUES {0}", string.Join(", ", valuesArray));
        }
        public static string InsertHallRows(int valuesCount)
        {
            string[] valuesArray = new string[valuesCount];
            for (int i = 0; i < valuesCount; i++)
            {
                valuesArray[i] = string.Format("(@hall_id_{0}, @row_num_{0}, @num_seats_{0})", i);
            }
            return string.Format(@"INSERT 
                    INTO row
                    (hall_id, row_num, num_seats)
                    VALUES {0}", string.Join(", ", valuesArray));
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
        public static string UpdateGenre()
        {
            return @"UPDATE genre
                    SET
                    genre_title=@genre_title
                    WHERE 
                    genre_id = @id";
        }
        public static string UpdateHall()
        {
            return @"UPDATE hall
                    SET
                    hall_title=@hall_title
                    WHERE
                    hall_id = @id";
        }
        public static string UpdateMovie()
        {
            return @"UPDATE movie
                    SET
                    movie_title=@movie_title, 
                    release_date=@release_date, 
                    age_limit=@age_limit, 
                    duration=@duration
                    WHERE 
                    movie_id = @id";
        }
        public static string UpdateSession()
        {
            return @"UPDATE session
                    SET
                    hall_id=@hall_id, 
                    movie_id=@movie_id, 
                    start_time=@start_time, 
                    cost=@cost
                    WHERE 
                    movie_id = @id";
        }

        /////////////////////////////////////
        //          DELETE REQUESTS        //
        /////////////////////////////////////
        public static string DeleteByID(string tableName)
        {
            return string.Format("DELETE FROM {0} WHERE {0}_id = @id", tableName);
        }
        public static string MultyplyDeleteByID(string tableName, string[] id)
        {
            return string.Format("DELETE FROM {0} WHERE {0}_id IN ({1})", tableName, string.Join(", ", id));
        }
        public static string MultyplyDeleteRows()
        {
            return "DELETE FROM row WHERE hall_id = @id";
        }
    }
}
