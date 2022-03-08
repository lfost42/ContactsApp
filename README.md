# Guestbook

Coding Challenge: A guestbook with image services and CRUD applications using code-first Entity Framework with PostgreSQL.

Application: If I can make the guestbook layout and options customizeable, this is something users can deploy to a free hosting service for events as a keepsake (virtual guestbook). 

https://lfost42-guestbook.herokuapp.com/

![My App](./GuestbookUI/wwwroot/img/app.png)

## Experiments and Plans

MVP: A working guestbook that allows a user to upload an image, add social media information, and leave a message. 

Completed Updates:

1. Build a class library and move methods into classes. 

Planned Updates

2. Implement DAO (Data Access Object) pattern to decouple the data access layer from the user interface. 
3. Add Unit Testing
4. Popup-windows or modals for CRUD screens
5. Allow image service to modify images after creation
6. Implement identity service to DELETE permissions. 

## Origins

This was my first ASP.NET MVC Core application. I used it to develop a workflow in creating web pages and learned to work with Entity Framework in a code-first situation. I'm trying to find reasons to keep it by thinking of upgrades because it was my first .NET web application!