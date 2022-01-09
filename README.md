# Guestbook

A study in image services, CRUD applications, and object-relational mapping with Entity Framework and PostgreSQL.

https://lfost42-guestbook.herokuapp.com/

![My App](./Guestbook/wwwroot/img/app.png)

## Planned updates:

- Add unit testing

- Popup-windows for Create/View/Edit/Delete screens (SweetAlert?)

- Allow image to be modified after creation

## Variations:

The app started off as a contacts database with name, birthdate, phone number, email, linkedin, and website. Once deployed, it didn't make sense as a database app without identity security so I transformed it into a guestbook. 

## Database Modifications:

While converting the app to a guestbook, I didn't expect users to want to leave their birthdate so I changed it to date. I also didn't expect users to want to post their phone number in the open so that column was deleted. At some point I decided to add the Message column which I would have renamed the phone number column if I had known ahead of time I was going to need it. 

## Issues:
I think Image properties should have been place in another class. I will revisit that when I study image services further. 