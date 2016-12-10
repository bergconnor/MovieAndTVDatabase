from __future__ import division
import requests
import json
import sys
import time
import traceback
import re

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
info.append(["Title", "Release Date", "Duration", "Homepage", "Poster", "Genre(s)", "Cast", "Description"])
f = file('movies.txt', 'w')

try:
	lower = 1
	upper = 11
	total = (upper - lower) * PER_PAGE
	count = 0
	for i in range(lower, upper):
		page = str(i)
		if calls >= MAX_CALLS:
			time.sleep(10)
			calls = 0
		r = s.get(url + 'discover/movie?api_key=' + key + '&language=en-US&sort_by=popularity.desc&' + \
			'include_adult=false&include_video=false&page=' + page)
		calls += 1
		data = json.loads(r.text)
		results = data['results']
		for j in range(len(results)):
			row = []
			movie     	= results[j]
			movie_id	= movie['id']
			title     	= movie['title']
			date      	= movie['release_date']
			overview	= re.sub('[\n\r]', '', movie['overview'])
			if movie['poster_path'] is None:
				image = 'NULL'
			else:
				image = 'https://image.tmdb.org/t/p/original' + movie['poster_path']

			if calls >= MAX_CALLS:
				time.sleep(10)
				calls = 0
			r = s.get(url + 'movie/' + str(movie_id) + '?api_key=' + key + '&language=en-US&append_to_response=credits')
			calls += 1
			data = json.loads(r.text)
			genres_list   = data['genres']
			runtime       = data['runtime']
			homepage      = data['homepage']
			cast_list     = data['credits']['cast']

			if date is None or len(date) < 1:
				date = 'NULL'

			if runtime is None:
				runtime = 'NULL'

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

			if len(cast_list) == 0:
				cast = '[]'
			else:
				cast = '['
				for k in range(len(cast_list)):
					cast += '{' + cast_list[k]['name'] + ', ' + str(cast_list[k]['id']) + '}, '
					if cast_list[k]['id'] is None:
						print '********** ID IS NONE **********'
				cast = cast[:-2] + ']'

			row.append(title)
			row.append(date)
			row.append(str(runtime))
			row.append(homepage)
			row.append(image)
			row.append(genres)
			row.append(cast)
			row.append(overview)

			info.append(row)

			count += 1
			progress = (count/total)*100
			print '{1:.{0}f}%\r'.format(2, round(progress, 2)),

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