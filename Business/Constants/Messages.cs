using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        // Public ile belirlediğimiz parametrelerin isimlendirmesini büyük harfler başlatıyoruz. (Pascal Case)
        public static string Added => "Added";
        public static string Deleted => "Deleted";
        public static string Updated => "Updated";
        public static string Listed => "Listed";
    }
}
