import json
import random
import time

JSON_FILE   = 'names.json'
ACCTS_FILE  = 'accounts.sql'
USERS_FILE  = 'users.sql'
HIST_FILE   = 'history.sql'
FAV_FILE    = 'favorites.sql'
FORMAT      = '%Y-%m-%d'

NUM_SHOWS       = 2196
MAX_USER_ID     = 10000
MAX_USERS       = 5
MAX_WATCHED     = 10
MAX_FAVORITED   = 5

VALUES_IDX  = 5
ID_IDX      = 0
START_IDX   = 3
END_IDX     = 4

user_ids = []
names = []

with open(JSON_FILE) as f:
    data = json.load(f)
    for value in data:
        names.append(value['name'])

f.close()

users       = file(USERS_FILE, 'w')
history     = file(HIST_FILE, 'w')
favorites   = file(FAV_FILE, 'w')
users.write('START TRANSACTION;\n')
history.write('START TRANSACTION;\n')
favorites.write('START TRANSACTION;\n')
with open(ACCTS_FILE) as accounts:
    for line in accounts.readlines():
        try:
            data    = line.split(' ')
            values  = data[VALUES_IDX]
            values  = values[1:-2].split(',')

            acct_id = values[ID_IDX]
            start   = '20' + values[START_IDX][1:-1]
            end     = '20' + values[END_IDX][1:-1]  
            start   = time.mktime(time.strptime(start, FORMAT))
            end     = time.mktime(time.strptime(end, FORMAT))

            num_user = random.randint(1, MAX_USERS)
            name_taken = []
            for i in range(num_user):
                name = ''
                while True:
                    name = random.choice(names)
                    if name not in name_taken:
                        name_taken.append(name)
                        break

                user_id = 0
                while True:
                    user_id = random.randint(1,MAX_USER_ID)
                    if user_id not in user_ids:
                        user_ids.append(user_id)
                        break

                s1 = 'INSERT INTO users (id, name,account_id) VALUES ' + \
                    '(' + str(user_id) + ',"' + name + '",' + acct_id + ');\n'
                users.write(s1)

                watched = random.randint(1,MAX_WATCHED)
                show_taken = []
                for j in range(watched):
                    watch_date  = start + random.random() * (end - start)
                    watch_date  = time.strftime(FORMAT, time.localtime(watch_date))
                    while True:
                        show_id = random.randint(1, NUM_SHOWS)
                        if show_id not in show_taken:
                            show_taken.append(show_id)
                            break


                    s2 = 'INSERT INTO history (user_id,show_id,date) VALUES ' + \
                        '(' + str(user_id) + ',' + str(show_id) + ',"' + watch_date + '");\n'
                    history.write(s2)

                favorited = random.randint(1,MAX_FAVORITED)
                show_taken = []
                for k in range(favorited):
                    add_date    = start + random.random() * (end - start)
                    add_date    = time.strftime(FORMAT, time.localtime(add_date))
                    while True:
                        show_id = random.randint(1, NUM_SHOWS)
                        if show_id not in show_taken:
                            show_taken.append(show_id)
                            break

                    s3 = 'INSERT INTO favorites (user_id,show_id,date) VALUES ' + \
                        '(' + str(user_id) + ',' + str(show_id) + ',"' + watch_date + '");\n'
                    favorites.write(s3)
        except IndexError:
            continue

users.write('COMMIT;')
history.write('COMMIT;')
favorites.write('COMMIT;')
accounts.close()
favorites.close()
history.close()
users.close()