using System.Collections.Generic;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Tüm ürünler listelendi";
        public static string ProductsCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde ürün zaten mevcut";
        public static string CategoryLimitExceded = "Kategori limit aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkin yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanııc zaten mevcut";
        public static string AccessTokenCreated = "Token başarılı bir şekilde oluşturuldu";
    }
}