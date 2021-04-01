# Interface ve Abstract

Merhaba. Bu projede küçük bir senaryo ile **Interface ve Abstract** yapısını kodladım. 


# Senaryo

- Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
- Starbucks ve Nero firması için çalışıyoruz.
- İki firma da müşterileri veri tabanına kaydetmek istiyor.
- Starbucks müşterilerini kaydederken **mernis** doğrulaması istiyor. Nero bu doğrulamayı istemiyor.

	>Mernis Service : TC kimlik numarası sorgulaması için yazılmış hazır bir servistir. 
	>Servis, doğrulama kontrolü için bizden kullanıcının TC numarası, Ad, Soyad, Doğum Yılı değerlerini istemektedir.
	> [Mernis Service Adres](https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?wsdl/)

