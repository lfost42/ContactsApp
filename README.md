# Guestbook

A study in image services, CRUD applications, and object-relational mapping with Entity Framework and PostgreSQL.

https://lfost42-guestbook.herokuapp.com/

![My App](./Guestbook/wwwroot/img/app.png)

##Planned updates:

- Add unit testing

- Sort entries by date created

- Make date automatically stamped with the date of creation

- Switch to popup-windows for Create/View/Edit/Delete screens

- Show image in View/Edit/Delete windows

- Allow image to be modified after creation

##Variations:

The app started off as a contacts database with name, birthdate, phone number, email, linkedin, website. Once deployed, it didn't make sense as a personal database without identity security so I transformed it into a guestbook as everyone had the ability to come in and add/modify/delete a record. 

##Database Modifications:

While converting the app to a guestbook, I didn't expect users to want to leave their birthdate so I changed it to date. I also didn't expect users to want to post their phone number in the open so that column was deleted. At some point I decided to add the Message column which I would have renamed the phone number column if I had known ahead of time I was going to need it. 

##Issues:
Now that I want the user to do more than upload an image, I think I made a mistake in not placing the image in a separate model. I will revisit that when I study image service further. 