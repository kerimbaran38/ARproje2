# **AR Uçak Güvenlik Kartı Projesi**

Bu proje, artırılmış gerçeklik (AR) teknolojisini kullanarak uçak güvenlik talimatlarını görselleştiren bir uygulamadır. Kullanıcılar, animasyonlar aracılığıyla emniyet kemerini bağlama ve can yeleğini kullanma talimatlarını izleyebilir. Animasyonlar, önceden belirlenmiş bir sırayla oynatılır ve döngüsel olarak tekrarlanır.

---

## **Projenin Özellikleri**
- **Emniyet Kemeri**:
  - Emniyet kemeri bağlama animasyonu 5 kez oynatılır.
- **Can Yeleği**:
  - Sarı pimin çekilmesi ve can yeleğinin şişirilmesi animasyonları 3 kez oynatılır.
- **Döngüsel Akış**:
  - Tüm animasyonlar tamamlandıktan sonra süreç baştan başlar.
- **AR Ortamı**:
  - Uygulama, artırılmış gerçeklik destekli bir cihaz üzerinde çalışır.

---

## **Kurulum ve Çalıştırma**

### **1. Gereksinimler**
- **Unity**: Proje, Unity 2020 veya daha yeni bir sürümle geliştirilmiştir. AR Foundation ve ilgili eklentiler kurulu olmalıdır.
- **Mobil Cihaz**: AR destekli bir Android veya iOS cihaz gereklidir.

---

### **2. Gerekli Paketlerin Kurulumu**
1. Unity'de `Window > Package Manager` menüsüne gidin.
2. Aşağıdaki paketlerin kurulu olduğundan emin olun:
   - **AR Foundation**
   - **ARCore XR Plugin** (Android için)
   - **ARKit XR Plugin** (iOS için)

---

### **3. Projenin Build Edilmesi**
1. Unity'de `File > Build Settings` menüsüne gidin.
2. Platformu **Android** veya **iOS** olarak ayarlayın ve "Switch Platform" düğmesine tıklayın.
3. "Scenes in Build" kısmında sahnenizin eklendiğinden emin olun.
   - Eğer sahne listede yoksa, `Add Open Scenes` düğmesine tıklayın.
4. **Player Settings** altında şunları kontrol edin:
   - **Minimum API Level**: Android için 7.0 (API Level 24) veya iOS için 11.0 ve üzeri.
   - **XR Plug-in Management**: Android için **ARCore**, iOS için **ARKit** işaretli olmalıdır.
5. "Build" düğmesine tıklayın ve APK veya IPA dosyasını oluşturun.
6. Dosyayı cihazınıza yükleyin.

---

## **Kullanım**
1. Uygulamayı cihazınıza yükleyin ve çalıştırın.
2. Animasyon akışı otomatik olarak başlar:
   - **Emniyet Kemeri**: Emniyet kemeri bağlama animasyonu 5 kez oynatılır.
   - **Can Yeleği**: Sarı pimin çekilmesi ve can yeleğinin şişirilmesi animasyonları 3 kez oynatılır.
   - Süreç tamamlandıktan sonra döngü baştan başlar.

---

## **Çalışma Prensibi**
- **Emniyet Kemeri**:
  - Uygulama başladığında emniyet kemeri animasyonu aktif hale gelir ve 5 kez tekrarlanır.
- **Can Yeleği**:
  - Emniyet kemeri animasyonları tamamlandığında can yeleği animasyonları başlar. Önce sarı pim çekilir, ardından can yeleği şişirilir. Bu süreç 3 kez tekrarlanır.
- **Döngüsel Akış**:
  - Can yeleği animasyonları tamamlandıktan sonra süreç emniyet kemerinden başlayarak tekrar eder.

---

## **Bilinen Sorunlar**
- AR düzlemi algılama performansı, cihazın kamerasının özelliklerine bağlıdır.
- Animasyonlar arasında gecikmeler doğru ayarlanmazsa zamanlama hataları oluşabilir.

---

## **Gelecek Geliştirmeler**
- Kullanıcı etkileşimli dokunmatik kontroller eklenebilir.
- Animasyonların yanında metin veya sesli talimatlar eklenebilir.
- Daha detaylı 3D modeller ve görsel efektler ile geliştirilebilir.
