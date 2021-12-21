# SoftwareArchitecture
 Yazılım Mimarisi Proje
 
# Facade Mimari Deseni Vize
Desenler,kullanım alanlarına göre farklılık gösterseler bile ortak bir takım özelliklere sahiptir.Bunlar:
1.Tekrar eden problemlere karşı geliştirilmiştirler,
2.Tekrar kullanılabilirlik,
3.Problem çözümü için yeniden uğraşılmaz
Tasarım desenleri uzun yıllar içerisinde tecrübe edinelerek ortaya çıkmıştır.

Desenlerin Oluşturulma Kuralları
	Kuralların konulması sebebi ortak bir platform oluşturmaktır.
1.Problemi çözmek,
2.Yazılım geliştirme süreçlerini basitleştirmek ve kompleks sistemlerin önüne geçmektir,
3.Okunabilirlik arttırmak,

! Tasarım Deseni iki esasa bağlıdır.Tekrar kullanılabilirlik ve esneklik
Yazılan kodlar bu esasa göre yazılmışsa iyi bir yazılım geliştirilmiştir.

Tasarım Desenleri üçe ayrılır bunlar şöyledir:
1.Creational Patterns (Yaratımsal)
2.Structural Patterns (Yapısal)
3.Behavioral Patterns (Davranışsal)

Projemde yaptığım uygulamalarda: 
Structural Patterns(Yapısal) Tasarım Desenlerinden olan:
Adapter Tasarım Deseni ve Facade Tasarım Deseni ile ilgili Consol uygulaması yapılmıştır.



Facade(Cephe-Önyüz-Arayüz) Tasarım Deseni
Sistemin karmaşıklıklarını gizler ve istemciye sisteme erişebilecek bir ara yüz(interface) sağlar.İstemci tarafından istenen basitleştirilmiş yöntemler ve var olan sistem sınıflarını yöntemlerine çağrılan veren tek bir sınıf içerir.
Facade tasarım deseni kullanılarak clientın yani bu operasyonları gerçekleştirecek nesnenin kod karmaşasına bulaşmamasını sağlar ve farklı clientların olduğu uygulamalarda bu kodların tekrarlanmasını engellemiş olur. Sonuç olarak da anlaşılması daha kolay bir kodlama yapılmış olur.
1.Alt sistemlerin direkt kullanılması yerine, alt sistemlere facade kullanılarak erişilir,
2.Client sınıfları sistemin isteklerini facade sınıfları üzerinden erişebilir,
3.İşlemler alt sınıflarda gerçekleşir,
4.İşin yapılmasını isteyen sınıflar client sınıflarıdır(facade sınıfları bir aracı olarak görünür)


# Adapter Mimari Deseni Vize

ADAPTER TASARIM DESENİ
Adapter Tasarım Deseni mevcut bir sınıfı veya arayüz sınıfını, eldeki farklı bir arayüz sınıfına uygun hale getirerek tekrar kullanmak amacıyla uygulanır
Adapter Tasarım Deseni kodun bağımlılığını azaltmak amacıyla uygulunan kalıplardan biridir.
Modüler bir yapısı olan projelerde daha çok kullanılmaktadır.Proje üzerinde çalışan kişiler farklı modüller geliştirerek ortak bir noktada yazılıma ekleyebilirler.
Eski bir yapıyı kullanırken, yeni bir yapı tasarlamanın zorluğu vardır.	
1.Fiziksel boyutlar ve yanlış hizalama olabilir,
2.Zamanlama veya sekronizasyon olabilir.
Yeni bir yapıyı eklemek için 
Çoğu zaman işe yarayacağını düşündüğümüz mevcut bir sınıfı kendi sistemimizde tekrar kullanmak isteriz. Fakat mevcut sınıf, tam beklediğimiz gibi olmayabilir. Bu durumda araya bir tane adaptör yazarak, mevcut sınıfı kendi sistemimize uygun hale getirebiliriz. Böylece adapte edilen nesnede kod değişikliği olmadan benzer bir arayüzü destekler hale getiririz. Ayrıca adaptasyon işlemi sırasında, adapte edilen nesnenin desteklemediği özellikler de adaptör tarafından gerçekleştirilebilir.

 
 
 
 
# Facade Mimari Deseni Final
Ödevin Amacı:
Yazılım dünyasında çözüm: 
Bir yazılımcının,bir yazılım ve bilgisayar mühendisliği öğrencisi için nereden başlayacağını öğrenebilmesi için bir yazılım rehberi hazırlanmıştır.
1.Web Geliştirme
2.Mobil Geliştirme
3.Oyun Geliştirme
ile alakalı hangi platformda kendisini geliştirebileceğini ve hangisine yönelmek için bilgiler öğrenebilmesi için gerekli bir yazılımcı rehberi.
Geliştirilicek platformlarda kullanılan programlar.
Kullanılabilecek yazılım dilleri ve bilgisi verilmiştir.
Kullanabileceği algoritmalar ile alakalı bilgiler verilmiştir.
Rehberin kapsamı:Yıllarını vermiş yazılımcılar sayesinde yeni bilgiler ile rehberin güncellenmesi sağlanmak istenmiştir.
Yeni yazılımcılar kazandırmak bilgi deposu olmuştur.

Desenin Neden Kullanılması:
Facade tasarım deseni:Yazılım Rehberi sürekli güncelleneceği için facade tasarım deseni farklı platformlara gelen yeni ek bilgileri ekleyebilecek en güzel tasarım desenidir.
Alt sistemler(Web Geliştirme, Mobil Geliştirme, Oyun Geliştirme) rahatlıkla bilgi eklenmesini sağlayabilecek bir desendir.

 

