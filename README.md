# Guestbook

Coding Challenge: A guestbook with image services and CRUD applications using code-first Entity Framework with PostgreSQL.

Application: Users can customize and deploy this to a free hosting service as a keepsake for special events (virtual guestbook). 

https://lfost42-guestbook.herokuapp.com/

![My App](./GuestbookUI/wwwroot/img/app.png)

## Experiments and Plans

MVP: A working guestbook that allows a user to upload an image, add social media information, and leave a message. 

Completed Updates:

- Build a class library and move methods into classes. 

Planned Updates

- Implement DAO (Data Access Object) pattern to decouple the data access layer from the user interface. 
- Add Unit Testing
- Implement modals for CRUD screens
- Allow image service to modify images after creation
- Implement identity service for DELETE permissions. 

## Origins

This was my first ASP.NET Core MVC application. I use this to experiment with newer techniques before implementing them in bigger projects. 