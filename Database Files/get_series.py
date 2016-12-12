from __future__ import division
import requests
import json
import sys
import time
import re
import traceback

# Set up known information
PER_PAGE  = 20
MAX_CALLS = 10

url      = 'https://api.themoviedb.org/3/'
key      = '093f9d28bec52e1701eb8a2fd602e053'
username = 'bergconnor'
password = 'qy98r6de'
calls    = 0

# Create a session
s = requests.Session()

# Create a request token
if calls >= MAX_CALLS:
	time.sleep(10)
	calls = 0
r = s.get(url + 'authentication/token/new?api_key=' + key)
calls += 1
data = json.loads(r.text)
token = data['request_token']


# Validate the request token
if calls >= MAX_CALLS:
	time.sleep(10)
	calls = 0
r = s.get(url + 'authentication/token/validate_with_login?api_key=' + key + \
	'&username=' + username + '&password=' + password + '&request_token=' + token)	
calls += 1


# Create session
if calls >= MAX_CALLS:
	time.sleep(10)
	calls = 0
r = s.get(url + 'authentication/session/new?api_key=' + key + '&request_token=' + token)
calls += 1
data = json.loads(r.text)
session = data['session_id']


# Get necessary info about each available movie'
info = []
info.append(["Title", "Network", "Season(s)", "Homepage", "Poster", "Genre(s)", "Cast", "Description", "Season(s)", "Episode(s)"])
f = file('series.txt', 'w')

try:
	lower = 1
	upper = 2
	total = (upper - lower) * PER_PAGE
	count = 0
	for i in range(lower, upper):
		page = str(i)
		if calls >= MAX_CALLS:
			time.sleep(10)
			calls = 0

		r = s.get(url + 'discover/tv?api_key=' + key + '&language=en-US&sort_by=popularity.desc&page=' + \
			page + '&timezone=America/Chicago&include_null_first_air_dates=false')
		calls += 1
		data = json.loads(r.text)
		results = data['results']
		for j in range(len(results)):
			try:
				row = []
				show     	= results[j]
				show_id 	= show['id']
				title 		= show['name']
				overview	= re.sub('[\n\r]', '', show['overview'])
				if show['poster_path'] is None:
					image = 'NULL'
				else:
					image = 'https://image.tmdb.org/t/p/original' + show['poster_path']

				if calls >= MAX_CALLS:
					time.sleep(10)
					calls = 0
				r = s.get(url + 'tv/' + str(show_id) + '?api_key=' + key + '&language=en-US&append_to_response=credits')
				calls += 1
				data = json.loads(r.text)
				genres_list   = data['genres']
				network       = data['networks'][0]['name']
				homepage      = data['homepage']
				seasons		  = data['number_of_seasons']
				seasons_list  = data['seasons']
				cast_list     = data['credits']['cast']

				if network is None or len(network) < 1:
					network = 'NULL'

				if seasons is None:
					seasons = 'NULL'

				if homepage is None or len(homepage) < 1:
					homepage = 'NULL'

				if overview is None or len(overview) < 1:
					overview = 'NULL'

				if len(genres_list) == 0:
					genres = '{}'
				else:
					genres = '{'
					for k in range(len(genres_list)):
						genres += genres_list[k]['name'] + ', '
					genres = genres[:-2] + '}'

				if len(seasons_list) == 0:
					seasons_data = '[]'
				else:
					seasons_data = '['
					for k in range(len(seasons_list)):
						if seasons_list[k]['season_number'] > 0:
							number 		= str(seasons_list[k]['season_number'])
							date 		= seasons_list[k]['air_date']
							if date is None:
								date = 'NULL'
							episodes 	= str(seasons_list[k]['episode_count'])
							seasons_data += '{' + number + ', ' + date + ', ' + episodes + '}, '
					seasons_data = seasons_data[:-2] + ']'

				if len(cast_list) == 0:
					cast_list = '[]'
				else:
					cast = '['
					for k in range(len(cast_list)):
						cast += '{' + cast_list[k]['name'] + ', ' + str(cast_list[k]['id']) + '}, '
					cast = cast[:-2] + ']'

				episode_data = '['
				for season in range(1, seasons):
					if calls >= MAX_CALLS:
						time.sleep(10)
						calls = 0
					r = s.get(url + 'tv/' + str(show_id) + '/season/' + str(season) + '?api_key=' + key + '&language=en-US')
					calls += 1
					data = json.loads(r.text)
					episodes_list = data['episodes']
					episode_data += '{'
					for episode in episodes_list:
						number = episode['episode_number']
						date   = episode['air_date']
						if date is None:
							date = 'NULL'
						name   = episode['name']
						episode_data += '(' + str(number) + ', ' + date + ', ' + name + '), '

					episode_data = episode_data[:-2] + '}, '

				if len(episode_data) == 1:
					episode_data = '[]'
				else:
					episode_data = episode_data[:-2] + ']'

				row.append(title)
				row.append(network)
				row.append(str(seasons))
				row.append(homepage)
				row.append(image)
				row.append(genres)
				row.append(cast)
				row.append(overview)
				row.append(seasons_data)
				row.append(episode_data)

				info.append(row)

				count += 1
				progress = (count/total)*100
				print '{1:.{0}f}%\r'.format(2, round(progress, 2)),
			except:
				del info[-1]
				print traceback.format_exc()
				continue

except KeyboardInterrupt:
	print("Keyboard interrupt received, stopping...")
except:
	print traceback.format_exc()
finally:
	# Format info and print to text file
	transpose = map(list, zip(*info))
	col_widths = []
	for col in transpose:
		width = max(len(word) for word in col) + 2
		col_widths.append(width)

	for data in info:
		row = ''
		for i in range(len(data)):
			row += "".join(data[i].ljust(col_widths[i]))
		f.write(row.encode('utf8') + '\n')

	f.close()