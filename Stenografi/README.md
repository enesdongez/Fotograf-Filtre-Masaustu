# Stenografi Nedir

Stenografi, mesajı gömme yoluyla bilgiyi saklama sanatı ve bilimidir Bu yaklaşım, bir nesnenin içerisine bir verinin gizlenmesi olarak da tanımlanabilir. Bu yaklaşımla ses, sayısal resim, video görüntüleri üzerine veri saklanabilir. Görüntü dosyaları içerisine saklanacak veriler metin dosyası olabileceği gibi, herhangi bir görüntü içerisine gizlenmiş başka bir görüntü dosyası da olabilir.
Stenografide amaç, bir mesajın varlığını saklamak ve bir “covert channel (örtülü kanal)” yaratmaktır. Bu yüzden Stenografi, amacı mesajın içeriğini saklamak olan kriptolojinin bir parçası olarak görülebilir. Bununla birlikte bu iki tekniği beraber kullanmakta mümkündür. Bunun için gizli mesaj önce encrypt edilir (şifrelenir), sonra Stenografik yöntemlerle dijital bir verinin içerisine saklanabilir.



# Stenografi Uygulaması

Seçilen resimler üzerine istediğimiz mesajı belirlediğimiz şifre ile eklemek için geliştirilmiş bir uygulamadır. Uygulama içerisinde Steganography sınıfından üretilen EncryptStringAES nesne ile yüklenen resimin Bitmap sınıfı ile elde ettiğimiz resim kodları içerisine embedText fonksiyonu ile bizim tarafımızdan belirlenen mesajı tekrardan okunması için kullanacağımız şifre ile resmin içerisine ekledik. Şifresi eklenen resimi belirtilen dizine kayıt edilme işlemi gerçekleştirilir.
İçerisine şifreli mesaj kayıt edilmiş resimlerin, şifrelerinin çözülmesi için ikinci bölümde bulunan Resim Seç butonuna basıp şifreli mesaj kayıt edilmiş resim seçilebilir. Seçilen resim uygun şifre girişi ile kontrol edilirse DecryptStringAES fonksiyonu ile şifre çözümü gerçekleştirilerek, kayıt edilmiş mesaj verilen bölümde gösterilir.