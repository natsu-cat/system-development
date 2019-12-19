using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Security.Cryptography;
using System.Data.OleDb;

namespace habigisu
{

    //パスワードをハッシュ化するクラス
    class PasswordHash
    {
        OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト

        //DBに格納されている各社員のソルトがあるかを確認し、なければ新たにソルトを作成,保存し、そのソルトと入力されたパスワードを用いてハッシュ化した文字列を返す関数
        public string PasswordToHash(string eid, string pwd)
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\habigisu.accdb;";

            OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
            OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト

            cmd.Connection = cn;

           cmd.CommandText = "SELECT * FROM 社員PASSテーブル WHERE ID=@eid AND PASS=@pwd"

            string salt = "\0";


            const int SALT_SIZE = 24;

            var buff = new byte[SALT_SIZE];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(buff);
            }
            salt = Convert.ToBase64String(buff);
            return Convert.ToBase64String(buff);
        }
    }
}
=======

namespace habigisu
{
    
    class PasswordHash
    {
    }
}
>>>>>>> make passwordhash class
