
# Tatil Rezervasyonu Web Sitesi Projesi

Bu proje, tatil rezervasyonu alanında faaliyet gösteren bir web sitesini temsil etmektedir. Sitede, çeşitli tatil seçeneklerinin listelendiği, kullanıcıların bu tatil seçeneklerinde rezervasyon yapabildiği, kullanıcıların kişisel hesabına ait bilgilere erişebildiği ve admin kullanıcısının da site içerisinde CRUD işlemleri gerçekleştirebildiği üç farklı tasarıma sahip bir projedir.

# Özellikler
•	Farklı tatil seçeneklerinin görüntülendiği bir ana sayfa.
•	Kullanıcıların seçtikleri tatil seçeneklerinde rezervasyon yapabilmesi.
•	Kullanıcı hesaplarının oluşturulması ve yönetilmesi.
•	Kullanıcıların rezervasyon geçmişlerini görüntüleyebilmesi.
•	Kullanıcıların yalnızca giriş yapmış kullanıcılar tarafından rezervasyon yapılabilmesi kontrolü.
•	Admin kullanıcısının site yönetimi üzerinde CRUD (Oluştur, Oku, Güncelle, Sil) işlemlerini gerçekleştirebilmesi.
•	Admin tarafından rol atamalarının yapılması.

## Kullanılan Teknolojiler
Bu proje Ajax, Api, Api Consume, Google Chart, Raporlama, Unit of Work, CQRS Design Pattern, Repository Design Pattern, Fluent Validaton, Auto Mapper, DI, DTO, Identity, Login, Register, Rolleme, Dashboard, Linq, SignalR, Area, View Component, Include Metotlar, Hata Sayfaları, Mail Gönderme, Şifre Yenileme, Mail Aktivasyonu, Rapid Api, MediatR, Pivot Table, Trigger, Çoklu Dil Desteği ve birçok konu başlığını içeriyor.

## Proje Geliştirme Aşamaları
1.	Katmanlar Oluşturuldu: Proje katmanları ayrıldı ve bu katmanlar arasındaki işlevsel ayrım sağlandı. (EntityLayer, DataAccesLayer, BusinessLayer, UI)
2.	Veritabanı İşlemleri ve Migration: Code First yöntemi kullanılarak veritabanı işlemleri gerçekleştirildi. Veri erişimi için DataAccesLayer içinde Context sınıfı tanımlandı ve migration işlemi yapıldı.
3.	Generic Interface ve Veri Erişimi: DataAccesLayer ve BusinessLayer arasında Generic Interface'ler kullanılarak veri erişimi sağlandı.
4.	Repository Design Pattern: Veritabanı işlemleri Repository Design Pattern yaklaşımı kullanılarak yapıldı.
5.	Doğrulama İşlemleri: Fluent Validation kütüphanesi kullanılarak gelen veriler Business katmanında Validator klasörü içinde kontrol edildi.
6.	Performans Artırımı: Partial Async ve View Component yapıları kullanılarak performans artırımı sağlandı.
7.	CRUD İşlemleri: MSSQL veritabanı kullanılarak CRUD işlemleri yapıldı.
8.	Kullanıcı Girişi ve Kimlik Yönetimi: Identity kullanılarak kullanıcı girişi yapıldı ve kullanıcı profil bilgileri getirildi.
9.	Profil ve Resim Güncelleme: Kullanıcılar Identity ile profil ve resim bilgilerini güncelleyebildi.
10.	Bağımlılıkların Yönetimi: Container dependencies ve startup yapıları refactoring edildi.
11.	Raporlama İşlemleri: Hem dinamik hem de statik excel ve pdf raporları sayfaları oluşturuldu.
12.	Mail Gönderme İşlemi: Mail gönderme işlemleri gerçekleştirildi.
13.	Ajax ile İşlemler: Ajax kullanılarak tur rotaları işlemleri gerçekleştirildi.
14.	Veri Transferi ve AutoMapper: Data Transfer Object (DTO) katmanı oluşturuldu ve AutoMapper kullanılarak veri transferi işlemleri optimize edildi.
15.	API Entegrasyonu: Dış API entegrasyonu için bir API projesi oluşturuldu.
16.	Dış API Kullanımı: Rapid API üzerinden otel listesi çekildi.
17.	CQRS Design Pattern: Veri işlemleri CQRS Design Pattern kullanılarak ayrıştırıldı.
18.	Düzenli İşlemler MediatR ile: MediatR kütüphanesi kullanılarak işlemler daha düzenli bir şekilde yapıldı.
19.	Veritabanı İşlemleri Yönetimi: Unit Of Work implementasyonu yapıldı ve veritabanı işlemleri daha yönetilebilir hale getirildi.
20.	API Veri Oluşturma: API üzerinden ziyaretçi veri seti oluşturuldu.
21.	Pivot Tablosu Oluşturma: Ziyaretçiler için pivot tablosu oluşturuldu.
22.	Anlık Veri Görüntüleme: SignalR kullanılarak grafikte anlık veri görüntüleme yapıldı.
23.	Rol Yönetimi: Admin rol atamaları ve CRUD işlemleri ile gerçekleştirildi.
24.	Çoklu Dil Desteği ve Şifre Yenileme: Proje, çoklu dil desteği ve şifre yenileme işlemleri ile tamamlandı.
![6](https://github.com/senanurkotankiran/TraversalCoreProje/assets/77417875/3aa64742-e483-4bb8-a8f0-628eeea5755c)
![Uploading 5.png…]()
![a2](https://github.com/senanurkotankiran/TraversalCoreProje/assets/77417875/dbb0ae50-0762-40b1-9d7c-008c8c0ea8ab)
![Uploading a1.png…]()
![login](https://github.com/senanurkotankiran/TraversalCoreProje/assets/77417875/4527b8cd-3e51-47c9-882e-67f89b85d508)
![Uploading rol.png…]()
![admin4](https://github.com/senanurkotankiran/TraversalCoreProje/assets/77417875/f6da76af-aec2-45d8-bb07-35a858937f88)
![admin2](https://github.com/senanurkotankiran/TraversalCoreProje/assets/77417875/2b9c365a-7b66-42fb-bd18-ba2b31cb65b6)
![admin1](https://github.com/senanurkotankiran/TraversalCoreProje/assets/77417875/1d29deef-7abc-40d5-ae1b-e25cbd4fd20f)
![Uploading member3.png…]()
![member2](https://github.com/senanurkotankiran/TraversalCoreProje/assets/77417875/4430305f-88b3-4ddc-b553-81eba54a9514)
![Uploading member1.png…]()
![Uploading 9.png…]()
![Uploading 8.png…]()
![Uploading 7.png…]()

