# Noteboard-with-Sql
### Daha önce txt ile yapılan not defteri uygulamasının; MsSql'de, EntityFramework kullanılarak, FluentApi yaklaşımıyla, katmanlı mimariye uygun olarak yapılması.

Bu projede neler yapıldığına adım adım bakacak olursak:
1. Projedenin katmanlı mimari yapısı oluşturuldu. (UI-BLL-DAL & Model)
2. Server'da tabloları oluşturacak 'Entity' classları ve bu tabloların kolon özelliklerinin belirlendiği 'EntityConfiguration' class'ları oluşturuldu.
3. Entity Framework'lerden CodeFirst yöntemi ile kod tarafından MsSql'e bağlanılarak database oluşturuldu.
4. Uygulamaya bakacak olursak giriş ekranı ve kayıt ekranı mevcut. Kayı olan kullanıcıların giriş yapabilmesi için admin tarafından onaylanmaları gerekiyor.
 Bu sebeple aşağıda resimde göründüğü gibi admin bilgileri ile giriş yapıldığında admin kullanıcı onay arayüzüne ulaşıyor.
5. Kullanıcı onaylanıp giriş yaptıktan sonra notlarına istediği CRUD işlemlerini gerçekleştirebiliyor.

![Notepad](https://www.linkpicture.com/q/Capture_250.png)
