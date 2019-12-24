using System;
using System.Security.Cryptography;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace habigisu
{

    //ソルトを作成、保存、返却するクラス
    class SaltSelector
    {
        OleDbConnection cn = new OleDbConnection(); //グローバル変数　コネクションオブジェクト

        
        private string GenerateSalt()               //ハッシュ文字列を作成して返す関数
        {
            const int SALT_SIZE = 24;
            byte[] buff = new byte[SALT_SIZE];

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        //DBに格納されている各社員のソルトがあるかを確認し、なければ新たにソルトを作成,DBに保存して返却する関数そのソルトと入力されたパスワードを用いてハッシュ化した文字列を返す関数
        public string getSalt(string eid)
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\habigisu.accdb;";

            OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
            OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト
            cmd.Connection = cn;
            cn.Open();

            cmd.CommandText = "SELECT ハッシュ文字列 FROM 社員PASSテーブル WHERE 社員ID=@eid"; //ハッシュ文字列をDBからとってくるSQL文
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@eid", eid);       //IDのパラメータ
            DataTable dt = new DataTable();
            da.Fill(dt);          

            if(dt.Rows.Count > 0)                          //検索結果が正常に帰ってきた時
            {
                string salt = cmd.ExecuteScalar().ToString();     //DBから見つかったハッシュ文字列を変数saltに格納

                if (salt.Length != 32)                    //ハッシュ文字列がまだ空白の場合
                {
                    salt = GenerateSalt();                //ハッシュ文字列作成する

                    //DBにハッシュ文字列を格納する
                    cmd.CommandText = "UPDATE 社員PASSテーブル SET ハッシュ文字列='" + salt
                        + "' WHERE 社員ID=@eid";
                    try
                    {
                        cmd.ExecuteNonQuery();           //UPDATE文実行
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return "error";                  //DBを確認
                    }
                    cn.Close();
                }
                return salt;                             //正しい返却値 
            }
            else
                return "\0";                             //社員番号ないよ
        }
    }
}