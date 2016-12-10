import MySQLdb as db
import re
import traceback
import base64

# Setup connection info
HOST        = "mysql.cis.ksu.edu"
USER        = "cberg1"
PASSWORD    = "3c340d"
DB          = "cberg1"
RE1         = r'\s{2,}'
RE2         = r'\{([^}]+)\}'
RE3         = r'\([^)]*\)'

# Indexes relating to data in 'movies.txt'
class MovieIndexes:
    Title, Released, Duration, Homepage, Poster, Genres, Cast, Description = range(8)

# Indexes relating to data in 'series.txt'
class SeriesIndexes:
    Title, Network, NumSeasons, Homepage, Poster, Genres, Cast, Description, Seasons, Episodes = range(10)

try:
    # Connect to database
    conn    = db.Connection(host=HOST,
                            user=USER,
                            passwd=(PASSWORD),
                            db=DB,
                            charset='utf8')
    # Create tables
    file = open('showsdb.sql', 'r')
    sql_statements = " ".join(file.readlines())
    for sql in sql_statements.split(";"):
        if len(sql) != 0:
            cursor = conn.cursor()
            cursor.execute(sql)
            cursor.close()
    file.close()
    conn.commit()

    file = open('accounts.sql', 'r')
    sql_statements = " ".join(file.readlines())
    for sql in sql_statements.split(";"):
        if len(sql) != 0:
            cursor = conn.cursor()
            cursor.execute(sql)
            cursor.close()
    file.close()
    conn.commit()

    file = open('users.sql', 'r')
    sql_statements = " ".join(file.readlines())
    for sql in sql_statements.split(";"):
        if len(sql) != 0:
            cursor = conn.cursor()
            cursor.execute(sql)
            cursor.close()
    file.close()
    conn.commit()

    # Parse movies and populate tables
    cursor = conn.cursor()
    fname = 'movies.txt'
    prog1 = re.compile(RE1)
    prog2 = re.compile(RE2)
    with open(fname) as f:

        f.readline()
        for line in f:
            data = prog1.split(line)

            for i in range(len(data)):
                if data[i] == 'NULL':
                    data[i] = None

            title           = data[MovieIndexes.Title]
            released        = data[MovieIndexes.Released]
            duration        = data[MovieIndexes.Duration]
            homepage        = data[MovieIndexes.Homepage]
            poster          = data[MovieIndexes.Poster]
            genres          = re.split(', ', data[MovieIndexes.Genres][1:-1])
            cast            = prog2.findall(data[MovieIndexes.Cast][1:-1].strip())
            description     = data[MovieIndexes.Description]

            if len(genres) < 1:
                genres = None
            if len(cast) < 1:
                cast = None

            cursor.execute("""INSERT INTO shows(name, homepage, poster, description) VALUES(%s, %s, %s, %s)""",
                (title, homepage, poster, description))
            show_id = cursor.lastrowid

            cursor.execute("""INSERT INTO movies(show_id, released, duration) VALUES(%s, %s, %s)""",
                (show_id, released, duration))

            for genre in genres:
                if genre != '' and genre != 'Foreign':
                    try:
                        cursor.execute("""INSERT INTO genres(name) VALUES(%s)""", (genre,))
                        genre_id = cursor.lastrowid

                    except db.IntegrityError:
                        cursor.execute("""SELECT id FROM genres WHERE name=%s""", (genre,))
                        genre_id = cursor.fetchone()[0]

                    finally:
                        cursor.execute("""INSERT INTO show_genre(show_id, genre_id) VALUES(%s, %s)""",
                            (show_id, genre_id))

            if cast is not None:

                for actor in cast:
                    actor = actor.split(', ')

                    if len(actor) > 2:
                        name = (actor[0] + ', ' + actor[1]).decode('utf8')
                        actor_id = int(actor[2])
                    else:
                        name        = actor[0].decode('utf8')
                        actor_id    = int(actor[1])

                    if len(name) > 0:
                        cursor.execute("""SELECT id FROM actors WHERE name=%s""", (name,))
                        results = cursor.fetchall()
                        flag = True
                        for row in results:
                            if row[0] == actor_id:
                                flag = False
                        if flag:
                            cursor.execute("""INSERT INTO actors(id, name) VALUES(%s, %s)""", (actor_id, name))
                        try:
                            cursor.execute("""INSERT INTO show_actor(show_id, actor_id) VALUES(%s, %s)""",
                                (show_id, actor_id))
                        except db.IntegrityError:
                            pass
    conn.commit()

    # Parse data and populate tables
    cursor  = conn.cursor()
    fname   = 'series.txt'
    prog3   = re.compile(RE3)
    with open(fname) as f:

        f.readline()
        for line in f:
            data = prog1.split(line)

            for i in range(len(data)):
                if data[i] == 'NULL':
                    data[i] = None

            title           = data[SeriesIndexes.Title]
            network         = data[SeriesIndexes.Network].decode('utf8')
            homepage        = data[SeriesIndexes.Homepage]
            poster          = data[SeriesIndexes.Poster]
            genres          = re.split(', ', data[SeriesIndexes.Genres][1:-1])
            cast            = prog2.findall(data[SeriesIndexes.Cast][1:-1].strip())
            description     = data[SeriesIndexes.Description]
            seasons         = prog2.findall(data[SeriesIndexes.Seasons][1:-1].strip())
            episodes        = prog2.findall(data[SeriesIndexes.Episodes][1:-1].strip())

            if len(genres) < 1:
                genres = None
            if len(cast) < 1:
                cast = None
            if len(seasons) < 1:
                seasons = None
            if len(episodes) < 1:
                episodes = None

            cursor.execute("""INSERT INTO shows(name, homepage, poster, description) VALUES(%s, %s, %s, %s)""",
                (title, homepage, poster, description))
            show_id = cursor.lastrowid

            cursor.execute("""INSERT INTO series(show_id, channel) VALUES(%s, %s)""",
                (show_id, network))

            for genre in genres:
                if genre != '' and genre != 'Foreign':
                    try:
                        cursor.execute("""INSERT INTO genres(name) VALUES(%s)""", (genre,))
                        genre_id = cursor.lastrowid

                    except db.IntegrityError:
                        cursor.execute("""SELECT id FROM genres WHERE name=%s""", (genre,))
                        genre_id = cursor.fetchone()[0]

                    finally:
                        cursor.execute("""INSERT INTO show_genre(show_id, genre_id) VALUES(%s, %s)""",
                            (show_id, genre_id))

            if cast is not None:

                for actor in cast:
                    actor = actor.split(', ')

                    if len(actor) > 2:
                        name = (actor[0] + ', ' + actor[1]).decode('utf8')
                        actor_id = int(actor[2])
                    else:
                        name        = actor[0].decode('utf8')
                        actor_id    = int(actor[1])

                    if len(name) > 0:
                        cursor.execute("""SELECT id FROM actors WHERE name=%s""", (name,))
                        results = cursor.fetchall()
                        flag = True
                        for row in results:
                            if row[0] == actor_id:
                                flag = False
                        if flag:
                            cursor.execute("""INSERT INTO actors(id, name) VALUES(%s, %s)""", (actor_id, name))
                        try:
                            cursor.execute("""INSERT INTO show_actor(show_id, actor_id) VALUES(%s, %s)""",
                                (show_id, actor_id))
                        except db.IntegrityError:
                            pass

            if seasons is not None:

                for season in seasons:
                    season = season.split(', ')

                    num     = season[0]
                    if season[1] == 'NULL':
                        year = None
                    else:
                        year = int(season[1].split('-')[0])

                    try:
                        cursor.execute("""INSERT INTO seasons(num, show_id, year) VALUES(%s, %s, %s)""",
                            (num, show_id, year))
                    except db.IntegrityError:
                        pass

            if episodes is not None:

                for i in range(len(episodes)):
                    e = prog3.findall(episodes[i].strip())
                    for episode in e:
                        episode = episode[1:-1].split(', ')
                        num = int(episode[0])
                        if num > 0:
                            if episode[1] == 'NULL':
                                date = None
                            else:
                                date = episode[1]
                            name = episode[2]

                            try:
                                cursor.execute("""INSERT INTO episodes(num, season_num, show_id, air_date, name) VALUES(%s, %s, %s, %s, %s)""",
                                    (num, (i+1), show_id, date, name))
                            except db.IntegrityError:
                                pass
    conn.commit()

    file = open('history.sql', 'r')
    sql_statements = " ".join(file.readlines())
    for sql in sql_statements.split(";"):
        if len(sql) != 0:
            cursor = conn.cursor()
            cursor.execute(sql)
            cursor.close()
    conn.commit() 
       
    file = open('favorites.sql', 'r')
    sql_statements = " ".join(file.readlines())
    for sql in sql_statements.split(";"):
        if len(sql) != 0:
            cursor = conn.cursor()
            cursor.execute(sql)
            cursor.close()
    conn.commit()

    file = open('views.sql', 'r')
    sql_statements = " ".join(file.readlines())
    for sql in sql_statements.split(";"):
        if len(sql) != 0:
            cursor = conn.cursor()
            cursor.execute(sql)
            cursor.close()
    conn.commit()

except:
    print traceback.format_exc()  
    conn.rollback()

finally:
    conn.close()