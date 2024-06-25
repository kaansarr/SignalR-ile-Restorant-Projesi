## 📌 Bu proje, restoranların işleyişini modernleştirmek ve kullanıcı deneyimini optimize etmek için geliştirilmiş bir uygulamadır.

## 📌 Kullanıcılar, masalarındaki QR kodları kullanarak yemek siparişi verebilir ve rezervasyon oluşturabilirler. Oluşturulan rezervasyonlar anlık olarak admin paneline düşer ve yöneticilere anlık bildirimlerle ulaşır. Admin paneline giriş yaparken güvenlik amacıyla mail ile doğrulama sağlanmıştır.

## 📌  SignalR kütüphanesi, anlık bildirimler ve sepet gibi işlemler için kapsamlı bir şekilde kullanılmıştır. Restoran sistemine ait bir uygulama olan bu proje, sipariş yönetimini sağlar. Arka planda API kullanılmış olup, API yapısı kullanıcı arayüzü tarafında tüketilmiştir. Rezervasyon işlemleri için kullanıcılara e-posta gönderilmiştir. Anlık bildirimler ve sepet gibi işlemler için SignalR kullanılmıştır.

## 📌   SignalR, sadece bildirimlerde değil, aynı zamanda siparişlerin anlık olarak şefe iletilmesinde, istatistiklerin anlık olarak değişmesinde ve masaların anlık dolu-boş durumlarının gösterilmesinde kullanılmıştır

#### Proje üzerinde kullanılan teknolojiler
 - Katmanlı mimari olarak "N-Tier Architecture" kullanılmıştır.
 - Tasarım deseni olarak "Repository Design Patern" kullanılmıştır
 - Clead Code uymak için "ViewComponents" yapısı kullanılmıştır.
 - Anlık veri akışı için "SignalR" kullanılmıştır.
 - Bir restoranın QR menüsü üzerinden verilen anlık siparişlerin, mutfak bölümünde anlık erişilebilmesi imkanının olduğu bir proje.
 - MSQL veri tabanlı proje de bir çok ilişkili tablolar Code First yaklaşımıyla kullanıldı. 
 - Entity Framework(CodeFirst)
 - Güvenlik için Identity, rezervasyon onaylarından sonra mail gönderme
 - Html-Css-Bootstra 
 - Javascript - Ajax
 - Asp.Net Core 6.0
 - Asp.Net Core Api
 

## Admin Tarafı 
![Adminİstatistik](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/0fcfd692-d1e5-4cbc-b403-fc1df78be6e1)
![İstatistikSayfası](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/3ac4ffbd-db41-4afb-b294-836e89194bb1)
![KullanıcıGiriş](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/05b799b0-3785-43d3-941c-2c6ca9cee46d)
![Qr](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/910589fd-e6c1-4375-b453-c170ae05a974)
![Ürünler](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/bcd2b65a-55b3-4af7-a56b-1cd7483bc86a)
<br/>
<br/>
<br/>

## Kullanıcı Tarafı

![Default](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/1bf34cdb-a1e2-497a-9919-1a04165071fb)
![Defaultİletişim](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/d52957ec-199d-49cf-8012-1e4abbfa2231)
![DefaultMenü](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/8e50348a-7b84-4857-bfae-9f914cf28a7c)
![DefaultMesaj](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/1993bdf8-db83-42d4-85b2-0951a1d256b8)
![Rezervasyon](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/fe567519-cb4c-4ced-8ba3-bd9fe04e49ea)
![Sepet](https://github.com/kaansarr/SignalR-ile-Restorant-Projesi/assets/135230544/084fcd62-149c-4629-b9f0-44daff959abb)
