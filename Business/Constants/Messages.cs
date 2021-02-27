using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ÜRÜN EKLENDİ";
        public static string ProductNameInvalid = "ÜRÜN İSMİ GEÇERSİZ";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "ÜRÜNLER LİSTELENDİ";
        public static string ProductDELETED = "Silindi";
        internal static string ProductCountOfCategoryError ="Bu kategoride en fazla 10 ürün olabilir";
        public static string CheckIfCategoryLimitExceded = "Kategory Limiti Aşıldığı ıcın yeni ürün eklenemiyor";
        internal static string ProductNameAlreadyExists;
    }
}
