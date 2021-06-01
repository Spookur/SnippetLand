This application was to create a a site, "Shack Up!" which allows people to list their shacks on their properties for people to express interest in to rent. Like an AirBNB for people who like to rough it in shacks.

Planning: We started our table creation script and use the provided wireframes to intuit a relational design.

Building: We put together the homepage by developing a responsive design UI, using the Factory Pattern to get the appropriate data, using @model to get the data from our controller into the webpage. Then we built a Web API so we could use AJAX to add a Contact and test it using PostMan. We implemented Dynamic Search, Server Side Validations, and Update Account page. For the database, we created stored procedure to delete and reload sample data. We then created a listings repository which used ADO.NET.

Project Management: Within the team we dicussed how Test Driven Development can be used to write our update test before we implement the code in our repository. We discussed the advantage behind using IEnumerable in our interfaces, learned that sometimes you have to update your unit tests as you continue to add functionality. We explored how now to not write SQL in our C#, and then go through how to properly create these queries.

Update: I have deployed the app online.  See the link below.
http://shack-app.apphb.com/