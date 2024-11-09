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
                    ticket_id AS 'Номер билета',
                    name AS 'Клиент',
                    strftime('%d.%m.%Y %H:%M:%S', purchase_time) AS 'Время покупки',
                    row AS 'Ряд',
                    seat AS 'Место'
                    FROM ticket
                    INNER JOIN client ON
                    ticket.client_id = client.client_id";
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
                    ticket_id AS 'Номер билета',
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
        public static string SelectTicketByID()
        {
            return @"SELECT
                    client.client_id,
                    client.name,
                    session.session_id,
                    session.hall_id,
                    session.cost,
                    strftime('%d.%m.%Y %H:%M', ticket.purchase_time),
                    ticket.row,
                    ticket.seat,
                    movie_title,
                    strftime('%d.%m.%Y', start_time),
                    strftime('%H:%M', start_time),
                    strftime('%H:%M', duration),
                    COUNT(row_id),
                    MAX(num_seats)
                    FROM ticket 
                    INNER JOIN client ON
                    ticket.client_id = client.client_id
                    INNER JOIN session ON
                    ticket.session_id = session.session_id
                    INNER JOIN movie ON
                    session.movie_id = movie.movie_id
                    INNER JOIN row ON
                    session.hall_id = row.hall_id
                    WHERE ticket_id = @id
                    GROUP BY 
                    client.client_id,
                    client.name,
                    session.session_id,
                    session.cost,
                    ticket.row,
                    ticket.seat,
                    movie_title,
                    start_time,
                    duration";
        }
        public static string SelectSessionsWithRows()
        {
            return @"SELECT
                    session_id AS 'id',
                    COUNT(row_id) AS 'Количество рядов',
                    MAX(num_seats) AS 'Максимальное количество строк в ряду',
                    hall.hall_id,
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
                    session.hall_id = hall.hall_id
                    INNER JOIN row ON
                    hall.hall_id = row.hall_id
                    GROUP BY
                    session_id,
                    movie_title,
                    hall_title,
                    start_time,
                    duration,
                    cost";
        }
        public static string SelectOtherSeats()
        {
            return @"SELECT
                    ticket.row,
                    ticket.seat
                    FROM ticket 
                    WHERE
                    ticket_id <> @ticket_id
                    AND session_id = @session_id";
        }

        public static string SelectVacancySeatReport()
        {
            return @"SELECT
                    session.session_id AS 'id',
                    movie_title AS 'Фильм',
                    hall_title AS 'Зал',
                    strftime('%d.%m.%Y', start_time) AS 'Дата сеанса',
                    strftime('%H:%M', start_time) AS 'Время начала',
                    strftime('%H:%M', 
                            (strftime('%s', start_time) 
		                    + strftime('%s', duration)),
			                    'unixepoch') AS 'Время завершения',
					SUM(num_seats) AS 'Мест в зале',
					(SELECT COUNT(ticket_id) FROM ticket WHERE ticket.session_id = session.session_id) AS 'Занятых мест',
                    SUM(num_seats) - (SELECT COUNT(ticket_id) FROM ticket WHERE ticket.session_id = session.session_id) AS 'Свободных мест'
                    FROM session
                    INNER JOIN movie ON
                    session.movie_id = movie.movie_id
                    INNER JOIN hall ON
                    session.hall_id = hall.hall_id
                    INNER JOIN row ON
                    hall.hall_id = row.hall_id
                    GROUP BY
                    session.session_id,
                    movie_title,
                    hall_title,
                    start_time,
                    duration";
        }

        public static string SelectRevenueReport()
        {
            return @"SELECT 
	                m.id,
                    m.month AS 'Месяц',
                    ROUND(COALESCE(SUM(s.cost), 0), 1)||'0 р.' AS 'Выручка'
                    FROM 
                    (SELECT strftime('%m.%Y', date('now', 'start of year', '+' || (n || ' month'))) AS month,
	                n AS id
                    FROM (
                        SELECT 0 AS n UNION ALL SELECT 1 UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4
                        UNION ALL SELECT 5 UNION ALL SELECT 6 UNION ALL SELECT 7 UNION ALL SELECT 8 UNION ALL SELECT 9
                        UNION ALL SELECT 10 UNION ALL SELECT 11
                    )) m
                    LEFT JOIN 
                    session s ON strftime('%m.%Y', s.start_time) = m.month
                    LEFT JOIN 
                    ticket t ON s.session_id = t.session_id
                    GROUP BY 
                    m.month
                    ORDER BY 
                    m.month";
        }
        public static string SelectGenreVievsReport()
        {
            return @"SELECT 
	                genre.genre_id AS 'id',
	                genre.genre_title AS 'Жанр', 
	                COUNT(movie_genre.movie_id) AS 'Фильмов в данном жанре',
	                COUNT(ticket.ticket_id) AS 'Сумма просмотров фильмов',
	                ROUND(COUNT(ticket.ticket_id)* 1.0/COUNT(movie_genre.movie_id), 2) AS 'Среднее значение просмотров'
	                FROM 
	                genre
	                LEFT JOIN 
	                movie_genre ON 
	                genre.genre_id = movie_genre.genre_id
	                LEFT JOIN 
	                session ON movie_genre.movie_id = session.movie_id 
	                LEFT JOIN
	                ticket ON ticket.session_id = session.session_id
	                GROUP BY 
	                genre.genre_id,
	                genre.genre_title
	                ORDER BY 
	                COUNT(ticket.ticket_id) DESC";
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
        public static string InsertTicket()
        {
            return @"INSERT 
                    INTO ticket
                    (client_id, session_id, purchase_time, row, seat)
                    VALUES 
                    (@client_id, @session_id, strftime('%Y-%m-%d %H:%M:%S', datetime('now')), @row, @seat)";
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
        public static string UpdateTicket()
        {
            return @"UPDATE ticket
                    SET
                    client_id = @client_id, 
                    session_id = @session_id, 
                    row = @row, 
                    seat = @seat
                    WHERE 
                    ticket_id = @id";
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
