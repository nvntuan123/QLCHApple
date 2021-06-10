using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHApple_BUS
{
    class HamChung
    {
        public static string returnMaCaoNhat_BUS(List<string> _LST_String) // Hàm này tăng mã lên 1.
        {
            if (_LST_String.Count > 0)
            {
                string _STR_MaNVMax = _tachChu(_LST_String[0]);
                // B1: Tách số ra cho vào list.
                int _IN = _LST_String.Count;

                List<int> _LST_Number = new List<int>();

                for (int i = 0; i < _IN; ++i)
                {
                    _LST_Number.Add(_tachSo(_LST_String[i]));
                }

                // B2: Tìm Max.
                int _IMax = _timSoLonNhat(_LST_Number.ToArray());

                // B3: Tăng biến Max vừa tìm được lên 1.
                ++_IMax;

                // B4: Ráp phần chữ với số Max vào 1 chuỗi.
                _STR_MaNVMax += _IMax.ToString();

                return _STR_MaNVMax;
            }
            return "1";
        }

        // Hàm tách số từ chuỗi.
        static int _tachSo(string _str)
        {
            string _STR_So = "";
            int _In = _str.Count();
            for (int i = 0; i < _In; ++i)
            {
                if (_str[i] >= '0' && _str[i] <= '9')
                    _STR_So += _str[i];
            }
            return Convert.ToInt32(_STR_So);
        }

        // Hàm tách chữ từ chuỗi.
        static string _tachChu(string _str)
        {
            string _STR_Chu = "";
            int _In = _str.Count();
            for (int i = 0; i < _In; ++i)
            {
                if (_str[i] < '0' || _str[i] > '9')
                    _STR_Chu += _str[i];
            }
            return _STR_Chu;
        }

        static int _timSoLonNhat(int[] _Array)
        {
            int _In = _Array.Count();
            int _IMax = _Array[0];
            for (int i = 0; i < _In; ++i)
            {
                if (_Array[i] > _IMax)
                {
                    _IMax = _Array[i];
                }
            }
            return _IMax;
        }
    }
}
