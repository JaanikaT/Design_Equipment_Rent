## Welcome to the Design_Equipment_Rent Readme.md!

Here is an overview of our project.

### Project team:

Anree Salumäe - Design, Figma  
Kert Mänd - Back-end, ASP.NET MVC  
Andre Leppik - Design, Figma  
Kaspar Truu - Design, Figma  
Jaanika Teearu - Documentation

Jan Kõrva - Advisor  
Aliin Saar - Advisor  

### Tech stack:
Figma - https://www.figma.com/file/fRSEGedSYv7sEGlOs1NV0f/Laenutus?type=design&node-id=0%3A1&mode=design&t=vMiuLjMMgtXZrWqp-1  
Slack  
ASP.NET  
MySQL Workbench  
VS Code  
Visual Studio 2022  


### 24.04 - Day 1
Meeting with the client, overview of the problem and requirements.
Task is to make a database with rental app for all equipment in design department (cameras, objectives, lights, memory cards etc.).
There should be a mobile app (easier for rental) and larger desktop overview.
For rental app should have a barcode scanning ability, because some items have barcodes.
One requirement was to have items/renters color coded for approaching deadline or past deadline and what equipment is available.  

First step was to get to know the team and learn about the skillsets. 
Then we analyzed the task, with the help from Aliin and Jan, and decided to use a Razor pages with ASP.NET.


#### First draft  
<img src="https://github.com/JaanikaT/Design_Equipment_Rent/assets/88343009/b41f9693-d0ac-4dd4-9fb6-f12943a88174" width="500px">

#### Details  
<img src="https://github.com/JaanikaT/Design_Equipment_Rent/assets/88343009/a70df1eb-46fa-4678-bbc0-da103451a9fa" width="500px">

We decided for two sides - rental side (with students list) and equipment side for equipment overview. And searchbar to search for particular student or equipment.  
Andre and Kaspar started the design in Figma. The landing page of the app was quite bare and simple for user.  
Anree, Kert and Jaanika wrote down database tabels.  

#### Andmetabelid  
<img src="https://github.com/JaanikaT/Design_Equipment_Rent/assets/88343009/3d207925-6014-4ef5-83a2-5c878a603fa7" width="500px">


Lastly did some design and workflow schemes.

#### Design, colors, page flow
<img src="https://github.com/JaanikaT/Design_Equipment_Rent/assets/88343009/fa2519ff-8ba3-4e13-a833-036795bcb437" width="500px">


We got some feedback for our thoughts. We had to reconsider our simple landing page, because user most probably would like to see the item list which rent is overdue. And then choose if to go in rental side or equipment side. 

#### Detailed design layout scheme.

<img src="https://github.com/JaanikaT/Design_Equipment_Rent/assets/88343009/14bf867d-6d5d-4b54-8685-f06425dbeffb" width="500px">

 
### 25.04 - Day 2
Documentation  
Search for good barcode scanner code. Quacgga, didn't work correctly. Using code by Andrus, after realizing it works currently only on Android phones.   
More analysis and going in depth with layout and interaction for different pages. Designing it in Figma.  
Divided pages and started coding HTML/Tailwind pages based on Figma design.  
Added new database table for renting history.  
Kert set up ASP.NET and helped everyone to install dotnet, teached how to run it and see pages, which had been designed with Tailwind in .cshtml file.  
Finished design, tomorrow will do back-end and database part. 

### 26.04 - Day 3, Final Day
Finalized the desktop view on all web pages.  
Added the QR scanner into the application. Did not work properly.  
Fixing minor issues involving the application.  
Made interactions and color coded rows/items.  
Legend added.

#### Things to concider / didn't have time to finish:
Scanner code not working.
Student view with history of rented devices and renting need.  
In repair status.  



## Pictures
<img src="https://github.com/JaanikaT/Design_Equipment_Rent/assets/88343009/b41f9693-d0ac-4dd4-9fb6-f12943a88174" width="500px">

<img src="https://github.com/JaanikaT/Design_Equipment_Rent/assets/88343009/14bf867d-6d5d-4b54-8685-f06425dbeffb" width="500px">


