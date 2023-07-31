Singleton tasarım deseni, bir sınıfın yalnızca bir örneğinin oluşturulmasını ve
bu örneğin uygulama boyunca tek bir noktadan erişilebilir olmasını sağlayan bir tasarım desenidir.
Bu desen, nesnenin tek bir kopyasının kullanılması gerektiği durumlarda kullanışlıdır ve birden fazla örnek oluşturulmasının önüne geçer.

Singleton deseni genellikle şu özellikleri içerir:

Özel bir kurucu metot: Singleton sınıfının kurucu metodu genellikle private veya protected olarak tanımlanır, böylece sınıfın dışından yeni bir örnek oluşturulması engellenir.

Statik bir örnek değişkeni: Singleton sınıfının yalnızca bir örneğini tutacak statik bir örnek değişkeni tanımlanır.

Statik bir örnek alma metodu: Singleton sınıfından tek bir örnek almak için genellikle statik bir metot tanımlanır.
Bu metot, örnek değişkenini kontrol eder ve örneği oluşturur ya da varolan örneği döndürür.

Singleton deseni, bir nesnenin tek bir kopyasının tutulması gereken durumlar için, örneğin yapılandırma ayarları, veritabanı bağlantıları gibi durumlar için sıklıkla kullanılır.