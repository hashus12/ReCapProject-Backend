# ReCapProject - Araç Kiralama Sistemi 
![yazilim gelistiriciyetistirmekampi](https://user-images.githubusercontent.com/16624085/117002814-b7275680-acec-11eb-9d5b-2cc18f86d025.png)

#### Frontend Tarafı:[Rent A Car Frontend](https://github.com/hashus12/ReCapProject-Angular "Rent A Car Frontend")

## :pushpin:Proje Hakkında
N-Katmanlı Solid mimari yapısı ile hazırlanan, EntityFramework kullanılarak CRUD işlemlerinin yapıldığı, kayıt olma giriş yapabilme Jwt teknikleri ile token alarak güvenliği sağlanan, Caching, Validation, Transaction,Performance işlemlerini Autofac paketi ile oluşturulan Aspectleri kullanarak gerçekleştiren,
araç Kiralama iş yerlerine yönelik örnek bir projedir.Proje içerisinde data kaynakları kolayca değiştirilebilir, yeni nesneler eklenebilir, bütün iş istekleri değiştirilebilir.Yapılacak olanlar eski kodları bozmadan sürekli ekleme ile yapılabilir.Proje sürdürülebilirlik prensibini yerine getirmektedir.

### Backend Teknolojileri ve Teknikleri
Sql Server, Asp.Net Core for Restful api,EntityFramework Core,Autofac,FluentValidation
<br>Layered Architecture Design Pattern,IOC, AOP, Aspects, JWT

## :pushpin:Getting Started
![About](https://user-images.githubusercontent.com/16624085/117002846-c27a8200-acec-11eb-98bb-0316777e8a05.png)
<br>
## :books:Layers  
![entities](https://i.ibb.co/LJn8Y9X/Ads-z-tasar-m.jpg)
### Entities Katmanı
**Entities Katmanı**'nda **Dtos** ve **Concrete** olmak üzere iki adet klasör bulunmaktadır.Concrete klasörü veri tabanından gelen somut nesnelerin özelliklerini tutmak için oluşturulmuştur.Dtos klasörü ise veri tabanında birbiri ile ilişkili olan nesnelerin ilişkili özelliklerini birlikte kullanabilmek için oluşturulmuştur.
<br><br>:file_folder:`Dtos`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarDetailDto.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/DTOs/CarDetailDto.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarImageDto.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/DTOs/CarImageDto.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentalDetailDto.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/DTOs/RentalDetailDto.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentalPaymentDto.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/DTOs/RentalPaymentDto.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserForLoginDto.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/DTOs/UserForLoginDto.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserForRegisterDto.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/DTOs/UserForRegisterDto.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserForUpdateDto.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/DTOs/UserForUpdateDto.cs) 
<br> <br> :file_folder:`Concrete`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarImage.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/Concrete/CarImage.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Customer.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/Concrete/Customer.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Rental.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/Concrete/Rental.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Findeks.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/Concrete/Findeks.cs) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Brand.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/Concrete/Brand.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Car.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/Concrete/Car.cs)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Color.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Entities/Concrete/Color.cs)  

![corekatmani](https://i.ibb.co/0npPtyq/Ads-z-tasar-m-1.jpg)
###  Core Katmanı
**Core Katmanı** evrensel bir katmandır. Geliştirilecek her projede kullanılabilir, isimlendirme kuralları ve oluşturulma düzeni sebebi ile oldukça kullanışlıdır. **Core Katmanı**'nda **DataAccess**, **Entities**, **Utilities**, **Aspects**, **CrossCuttingConcerns**, **DependencyResolvers** ve **Extensions** klasörleri bulunmaktadır.
**Aspects** kasörü Caching, Validation, Transaction,Performance işlemlerinin Autofac attribute altyapısını hazırlar.**CrossCuttingConcerns** klasöründe Validation ve Cache yönetimi proje içerisinde, dikey katmanda dinamik çalışabilmesi için (generics)genelleştirildi.**DependencyResolvers** klasöründe servis konfigrasyonları yapıldı.**DataAccess** klasöründe bütün CRUD operasyonları ve DataBaseler generic olarak yapılandırıldı.**Extensions** içerisinde Jwt için yönetimi kolaylaştıran genişlemeler yapıldı.**Utilities** içerisinde iş metodu kurallarının yönetimi kolaylaştırıldı, belge ekleme işlemleri kodlandı,Aspectlerin araya girebilmesi için alt yapı hazırlandı ve ezilmeyi bekliyor, Results yapısı kurularak hata yönetimi yapılandırıldı, Jwt ve hashing teknikleriyle güvenlik yapılandırıldı.
> **⚠ DİKKAT: .**  
> Core Katmanı, diğer katmanları referans almaz.
<br> <br> :file_folder:`Core`  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Autofac](https://github.com/hashus12/ReCapProject-Backend/tree/master/Core/Aspects/Autofac) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CrossCuttingConcerns](https://github.com/hashus12/ReCapProject-Backend/tree/master/Core/CrossCuttingConcerns) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [DataAccess](https://github.com/hashus12/ReCapProject-Backend/tree/master/Core/DataAccess) 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [DependencyResolvers](https://github.com/hashus12/ReCapProject-Backend/tree/master/Core/DependencyResolvers)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Entities](https://github.com/hashus12/ReCapProject-Backend/tree/master/Core/Entities)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Extensions](https://github.com/hashus12/ReCapProject-Backend/tree/master/Core/Extensions)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Utilities](https://github.com/hashus12/ReCapProject-Backend/tree/master/Core/Utilities)  

![dataaccesskatmani](https://i.ibb.co/BgJVzpy/Data-Access.jpg)
###  Data Access Katmanı
**Data Access Katmanı**'nda **Abstract** interfaceleri barındıran ve **Concrete** classları barındıran klasörler bulunmaktadır.Crud operasyonlarını core katmanından miras alarak gerçekleştirmektedir.Gelebilecek iş kodları için altyapı burada hazırlanır.Objelerin data transferleri için kullanacağı data baseler ve varlıkların bağlantıları **Data Access Katmanı**'nda yapılandırıldı.
<br> <br> :file_folder:`DataAccess` 
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [Abstract](https://github.com/hashus12/ReCapProject-Backend/tree/master/DataAccess/Abstract)  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [EntityFramework](https://github.com/hashus12/ReCapProject-Backend/tree/master/DataAccess/Concrete/EntityFramework)  

![business](https://i.ibb.co/nmb6m8y/Data-Access.png)
###  Business Katmanı
**Business Katmanı**'nda altyapısı hazır olan bütün serviserin yönetimleri yazıldı.Sürekli değişebilen iş kodlarımızı altyapıyı değiştirmeden ekleyebildiğimiz katmandır.Sürekliliğin korunduğu ReCap projemde birçok değişikliğin sadece burada yapılıyor olması yönetimi, sürekli gelişimi çok kolaylaştırmaktadır.
<br> <br> :file_folder:`Concrete`
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [AuthManager.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Business/Concrete/AuthManager.cs)
<br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [BrandManager.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Business/Concrete/BrandManager.cs)
<br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarImageManager.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Business/Concrete/CarImageManager.cs)
<br> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CarManager.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Business/Concrete/CarManager.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [ColorManager.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Business/Concrete/ColorManager.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [CustomerManager.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Business/Concrete/CustomerManager.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [PaymentManager.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Business/Concrete/PaymentManager.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [RentalManager.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Business/Concrete/RentalManager.cs)
<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:page_facing_up: [UserManager.cs](https://github.com/hashus12/ReCapProject-Backend/blob/master/Business/Concrete/UserManager.cs)

* * *

![databaseandtables](https://user-images.githubusercontent.com/16624085/117002547-58fa7380-acec-11eb-9d13-9b8ac5f4532b.png)
###  Veritabanı Oluşturma 
Araba Kiralama Projemiz localdb ile çalışmaktadır. **LocalDb**'de veritabanı oluşturmak için **Visual Studio 2019** için *View > SQL Server Object Explorer* menü yolunu takip edebilirsiniz.Pencere açıldıktan sonra *SQL Server > (localdb)MSSQLLocalDB* altındaki **Databases** klasörüne sağ tıklayıp Add **New Database** seçeneğini ile veritabanınızı oluşturabilirsiniz. Veritabanı oluşturulduktan sonra **New Query** seçerek aşağıda bulunan Sql File ile veritabanınızda olması gereken tabloları oluşturabilirsiniz.  
- [SqlQuery.sql](https://github.com/hashus12/ReCapProject-Backend/blob/master/SQLQuery.sql) *(Tablonuzu linkde gördüğünüz şekilde oluşturun)*
<br>

![Prerequisites](https://user-images.githubusercontent.com/16624085/117002602-6fa0ca80-acec-11eb-8d9e-7a52a6035403.png)
### Nuget
```
Autofac Version="6.1.0"
Autofac.Extensions.DependencyInjection Version="7.1.0"
Autofac.Extras.DynamicProxy Version="6.0.0"
FluentValidation Version="9.5.1"
Microsoft.AspNetCore.Http Version="2.2.2"
Microsoft.AspNetCore.Http.Features Version="5.0.3"
Microsoft.AspNetCore.Http.Abstractions Version="2.2.0"
Microsoft.EntityFrameworkCore.SqlServer Version="3.1.1"
Microsoft.IdentityModel.Tokens Version="6.8.0"
System.IdentityModel.Tokens.Jwt Version="6.8.0"
```


## Araba Kiralama Projesi ile ilgili Notlar
- [SqlQuery.sql](https://github.com/hashus12/ReCapProject-Backend/blob/master/SQLQuery.sql) *(Tablonuzu linkde gördüğünüz   şekilde oluşturun)*
- *7.Haftadaki DataAccess katmanında bulunan Abstract kısım Generic Repository Design Pattern ile güncellendi.*
- *7.Haftadaki DataAccess katmanında bulunan InMemoryCarDal güncellendi. (LINQ kodları eklenmiştir.)*
- *8.Hafta ödevine ilişkin EntityFramework kodları yazıldı.*
- *9.Hafta ödevine ilişkin Core Katmanı kodları yazıldı.*
- *ConsoleUI' da yapılacan Add, Update, Delete işlemlerini ilgili fonksiyonlardan güncelleyebilirsiniz.*
- *10.Hafta ödevine ilişkin Business Katmanın'da Constant Eklendi ve Messages Kodları Yazıldı.* 
- *10.Hafta ödevine ilişkin Core Katmanın'da Utilities Eklendi ve Result ve DataResult Kodları Yazıldı..* 
- *11.Hafta WebAPI Eklendi ve Kodları Yazıldı.*
- *12.Hafta Autofac ve FluentValidation Kodları Yazıldı.*
- *12.Hafta Artık projede AOP ve IoC yapıları kullanılıyor.*
- *13.Hafta Veritabanına CarImages Tablosu Eklendi.*
- *13.Hafta Projeye Dosya Yükleme (File Helper) Sistemi Yazıldı.*
- *14.Hafta Veritabanı Güncellendi.*
- *14.Hafta JWT Entegrasyonu Yapıldı.*
- *15.Hafta Cache, Transaction ve Performance Entegrasyonu Yapıldı.*
<br>

## :pencil2:Authors
* **Hasan Hüseyin Özgen** - [hasanozgen](https://github.com/hashus12)
