🏡 Tiny House Rezervasyon ve Yönetim Sistemi

Bu proje, Tiny House konseptindeki evlerin kiralanması, yönetilmesi ve kullanıcılar arası etkileşimi kapsayan tam kapsamlı bir rezervasyon platformudur.
Veritabanı tasarımından uçtan uca backend mantığına kadar gerçek dünya problemlerine çözüm sunmak amacıyla geliştirilmiştir. 


🚀 Proje Hakkında

Sistem; kiracılar, ev sahipleri ve sistem yöneticileri olmak üzere üç farklı kullanıcı rolü üzerine inşa edilmiştir. 
Temel amaç, güvenli bir rezervasyon altyapısı sağlamak, ev uygunluk durumlarını anlık takip etmek ve kullanıcı değerlendirmeleriyle şeffaf bir platform oluşturmaktır. 


✨ Temel Özellikler

👤 Kiracı Modülü

İlan Keşfi: Aktif tiny house ilanlarını filtreleyerek listeleme. 

Rezervasyon & Ödeme: Uygun tarihleri seçerek online ödeme simülasyonu ile rezervasyon tamamlama.

Yorum & Puanlama: Konaklama sonrası evlere puan verme ve yorum yapma. 

Yönetim: Geçmiş ve aktif rezervasyonları görüntüleme veya iptal etme. 



🏠 Ev Sahibi Modülü

İlan Yönetimi: Yeni ev ekleme, fiyat güncelleme ve ilan durumunu (aktif/pasif) yönetme. 

Talep Yönetimi: Gelen rezervasyon taleplerini kabul etme veya reddetme. 

Analiz: Dashboard üzerinden gelir raporları ve kiracı yorumlarını takip etme. 



🔑 Admin Paneli

Tam Denetim: Kullanıcı hesaplarını yönetme, ilanları denetleme ve uygunsuz içerikleri silme. 

Finansal Takip: Sistem genelindeki mali hareketleri ve ödeme geçmişini raporlama. 

İstatistikler: Kullanıcı trendlerini ve sistemin genel doluluk oranlarını görsel grafiklerle analiz etme. 



🛠 Teknik Mimari

Veritabanı Tasarımı (MSSQL)

Projenin kalbi, ilişkisel veritabanı prensiplerine ve normalizasyon kurallarına uygun olarak tasarlanmıştır. 

Stored Procedures: Karmaşık sorguların performanslı çalışması için en az 2 adet aktif SP kullanılmıştır. 

Functions: Hesaplama ve veri işleme süreçleri için kullanıcı tanımlı fonksiyonlar entegre edilmiştir. 

Triggers: Veri tutarlılığını sağlamak ve otomatik işlemler için tetikleyiciler eklenmiştir. 

Constraints: Primary Key, Foreign Key, Unique, Check ve Not Null kısıtlamaları ile veri bütünlüğü en üst seviyede tutulmuştur. 


Teknolojiler

Backend: C# 

Frontend: Windows Forms

Veritabanı: MsSQL
