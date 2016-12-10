/* Delete the views if they already exist */
DROP VIEW  IF EXISTS vhistory;
DROP VIEW  IF EXISTS vfavorites;

/* Create the schema for our views */
CREATE VIEW vfavorites
AS SELECT u.id AS user_id,
          group_concat(DISTINCT g.name ORDER BY g.name) AS genres
FROM users u
    LEFT JOIN favorites f
      ON f.user_id = u.id
    LEFT JOIN shows s
      ON s.id = f.show_id
    LEFT JOIN show_genre sg
      ON sg.show_id = s.id
    LEFT JOIN genres g
      ON g.id = sg.genre_id
GROUP BY u.id;

CREATE VIEW vhistory
AS SELECT u.id AS user_id,
          group_concat(DISTINCT g.name ORDER BY g.name) AS genres
FROM users u
    LEFT JOIN history h
      ON h.user_id = u.id
    LEFT JOIN shows s
      ON s.id = h.show_id
    LEFT JOIN show_genre sg
      ON sg.show_id = s.id
    LEFT JOIN genres g
      ON g.id = sg.genre_id
GROUP BY u.id;