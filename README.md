# Alpha Case Study

 .Net Core 6 Web API Projesidir.


## Migrations
 - cd Core
- dotnet ef --startup-project ../AlphaCaseStudy/  migrations add InitialCreate
- dotnet ef --startup-project ../AlphaCaseStudy/ database update


## Postman URL

 - Postmande attığım requestlerin screenshotları yukarıda vardır. Örnek olarak Postman URL'leri ise şöyledir.
 
 -- Delete:: https://localhost:44331/api/Car?id=3
 
 -- Post :: https://localhost:44331/api/Car/changeHeadlightsByID?id=1
 
 -- Get :: https://localhost:44331/api/Car/1 // Car ID'sine göre atılan istek
 
 -- Get:: https://localhost:44331/api/Car/colorName?colorName=Red // Car Rengine göre atılan istek



Proje ile ilgili soru sormak veya herhangi bir konuda iletişime geçmek için 
No: 05545734462
Mail: onerberat0@gmail.com
















   
