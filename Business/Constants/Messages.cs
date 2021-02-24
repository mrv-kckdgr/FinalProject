using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz";

        public static string ProductListed = "Ürünler listelendi";

        public static string MaintenanceTime = "Sistem Bakımda";

        public static string UnitPriceInvalid { get; internal set; }

        public static string CategoryLimitExceded = "Kategori limiti aşıldı!!! Yeni ürün eklenemiyor!!!";

        public static string ProductNameAlreadyExists = "Aynı isimde zaten başka bir ürün bulunmaktadır!!!";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.!!";
    }
}
