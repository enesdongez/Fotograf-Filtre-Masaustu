# Görüntü İşleme

Kaydedilmiş olan belirli görüntülerin işlenip mevcut resim ve grafiklerin değiştirilerek yabancılaştırılması veya iyileştirilmesi için kullanılmaktadır. Bizim uygulamamız, Visual Studio üzerinde c# dili ile geliştirilmiştir. Kayıtlı görüntüler üzerinde değişimler gerçekleştirebilmemizi sağlamaktadır. 
Programın ara yüzünde, kullanıcı resim seçmek üzere resim seç butonuna tıkladıktan sonra ara yüze .jpg, .png, .jpeg, .gif formatlarında resim ekleyebilir. Eklenen görüntü üzerinde program değişiklik yapabilmek için görüntüyü bitmap formatına dönüştürür. Bitmap dosya formatı, görüntü içerisinde her bir piksel için geçerli olan sıkıştırılmamış veri bilgisi içerir, elde ettiğimiz bu piksel değerleri ile resmimiz üzerinde yapabildiğimiz değişimler ve iyileştirmeler şunlardır: <br/>
	Ters çevirmek için dikey piksel değerlerinin, alt ve üst değerlerinin her birine erişip yer değiştirerek resmimizi tam ters yönde görüntüleyebiliriz.

	Gri formatta görüntülemek için elimizdeki resmin piksel format halinin her bir pikselinin renk değerleri olan RGB değerlerinin her biri için (R*0.299 + G*0.587 + B*0.114) işlemini gerçekleştirdikten sonra resmin gri renkteki halini elde ederiz.

	Negatif formatta göstermek için resmimizin her bir pikselinin renk değerlerini 255’ten çıkarırız ve resmin orijinal halindeki renklerin tam tersini elde ederiz.

	Parlaklığını arttırmak için resmimizin her bir pikselinin renk değerlerine yine bizim belirlediğimiz miktarda ekleme yaparız ve resmimizin orijinal halindeki renklerden daha aydınlık bir resim elde ederiz, parlaklığını azaltmak için de parlaklığını arttırmak için kullandığımız yöntemin tam tersini uygulayıp her bir renkten eşit miktarda çıkarma yaparız.

	Aynalamak için resmimizin yatay konumundaki piksel değerlerinin, sağ ve sol değerlerinin her birine erişip yer değiştirerek resmimizin yatayda aynalama işlemini gerçekleştirdik.



	Yakınlaştırmak için ara yüzde bulunan trackbarın değerini kullanıcı değiştirerek resmimizi yakınlaştırıp uzaklaştırabilir.

	Histogram eşitleme, bir resimdeki renk değerlerinin belli bir yerde kümelenmiş olmasından kaynaklanan renk dağılımı bozukluğunu gidermek için kullanılan bir yöntemdir, uygulamamızda eklenen resim üzerindeki ortalama renk değeri bulunup diğer renklerin değerleri de birbirlerine yaklaştırılıp resim üzerindeki renk dağılımını eşitlemektedir.

	Otsu algoritması, bir eşik değeri belirlenir ve bu eşik değerin üzerindeki renkler beyaza, altındaki renkler siyaha dönüştürülür. Otsu algoritması, gri seviye görüntüler üzerinde tam sonuç veren bir algoritmadır, görüntünün arka plan ve ön plan olmak üzere iki renk sınıfından oluştuğu varsayımı yapılır. Daha sonra tüm eşik değerleri için bu iki renk sınıfının sınıf içi varyans değeri hesaplanır. Bu değerin en küçük olmasını sağlayan eşik değeri, optimum eşik değeridir. Resmin gri formatı hariç diğer formatlarda da çalışır ancak optimum değerin bulunması ve resmin düzgün bir şekilde siyah ve beyaz olabilmesi için bu algoritmayı kullanmadan önce resmin gri formatta olması gerekir.

Yapılan bu işlemlerden sonra çıktı olarak ekrana gelen görüntü kullanıcının isteğine bağlı .jpg formatından bilgisayara kaydedilebilir.
