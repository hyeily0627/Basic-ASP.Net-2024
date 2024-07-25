using System.Text;
using System.Security.Cryptography;


namespace MyPortfolio.helper
{
    public class common
    {
        public static string GetMd5Hash(MD5 md5Hash, string plainStr)
        {
            byte[] date = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(plainStr)); // 평문을 해시로 변경
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < date.Length; i++)
            {
                builder.Append(date[i].ToString("x2")); ;
            }
            return builder.ToString();  
        }
    }   
}
