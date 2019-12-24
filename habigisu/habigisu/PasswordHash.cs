using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace habigisu
{
    //パスワードをハッシュ化するクラス ソルトとパスワードを用いてハッシュ化した文字列を返す関数
    class PasswordHash
    {
        public string GeneratePasswordHash(string pwd, string salt)
        {
            string saltpwd = String.Concat(pwd, salt);                                  //saltとpwdを連結
            UTF8Encoding encoder = new UTF8Encoding();
            byte[] buffer = encoder.GetBytes(saltpwd);                                  //UTF-8にエンコード
            SHA256CryptoServiceProvider csp = new SHA256CryptoServiceProvider();
            byte[] hash = csp.ComputeHash(buffer);                                      //ハッシュ化
            return Convert.ToBase64String(hash);                                        //Base64で返却
        }
    }
}
