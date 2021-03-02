# efectura
Efectura assessment project

Postgresql was used in the project as database.
Migration files are inside.
You can run "update-database" command on the Package Manager Console to create the database if you have postgresql server installed on your machine.
ConnectionString for the database is in the appsettings.json file.
Remember to check database username and password before using migration files.

Project has swagger for easy use from browser.
There are 4 endpoints as requested.

api/Users (Post)
Body schema for posting new user is as follows: { "name": "Onur", "surname": "Dökmetaş", "birthday": "1984-07-03", "address": "istanbul" }
You may omit the "address" element.
It is optional.
Please obey the JSON date format when entering birthday.
It is as follows: "YYYY-MM-DD".

api/Users/TCKN (Put)
Will update the user with the TCKN specified in the url.
Body schema for updating (put) is same as posting new but you may omit any element.
Only elements you specify will be updated.

api/Users (Get)
Will list all users with all their data.

api/Users/TCKN (Delete)
Will delete the user with the TCKN specified in the url.
