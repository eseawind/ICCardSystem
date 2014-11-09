using System.Text.RegularExpressions;

namespace ICCardSystem.Common
{
    public class ValidateTools
    {
        /// <summary>
        /// 是否纯数字
        /// </summary>
        public bool IsNum(string StrInput)
        {
            Regex reg = new Regex(@"^\d+$");
            return reg.IsMatch(StrInput);
        }

        /// <summary>
        /// 检测是否是英文字母
        /// </summary>
        /// <param name="StrInput"></param>
        /// <returns></returns>
        public bool IsEnglish(string StrInput)
        {
            Regex reg = new Regex(@"^[a-zA-Z]+$");
            return reg.IsMatch(StrInput);
        }

        /// <summary>
        /// 检测是否含有中文字符
        /// </summary>
        public bool HasZh(string StrInput)
        {
            Regex reg = new Regex(@"[\u4e00-\u9fa5]");
            return reg.IsMatch(StrInput);
        }

        /// <summary>
        /// 检测是否英文或字母或下划线
        /// </summary>
        public bool IsEnNum(string StrInput)
        {
            Regex reg = new Regex(@"^([A-Za-z0-9]|[\u4e00-\u9fa5]|_)+$");
            return reg.IsMatch(StrInput);
        }

        /// <summary>
        /// 检测是否是邮箱格式
        /// </summary>
        public bool IsEmail(string strInput)
        {
            Regex regEmail = new Regex(@"^[\w-]+@[\w-]+\.(com|net|org|edu|mil|tv|biz|info|cc|cn)$");
            return regEmail.IsMatch(strInput);
        }

        /// <summary>是否是数字（负数、小数）</summary>
        /// <param name="strInput">输入字符串</param>
        public bool IsNumeric(string strInput)
        {
            if (string.IsNullOrEmpty(strInput))
                return false;
            var reg = new Regex(@"^-?\d+(\.\d)?\d*$");
            return reg.IsMatch(strInput);
        }

        /// <summary>
        /// 是不是时间类型数据
        /// </summary>
        /// <param name="strDate"></param>
        public bool IsDateTime(string strDate)
        {
            var reg = new Regex(
                    @"(((^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(10|12|0?[13578])([-\/\._])(3[01]|[12][0-9]|0?[1-9]))|(^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(11|0?[469])([-\/\._])(30|[12][0-9]|0?[1-9]))|(^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(0?2)([-\/\._])(2[0-8]|1[0-9]|0?[1-9]))|(^([2468][048]00)([-\/\._])(0?2)([-\/\._])(29))|(^([3579][26]00)([-\/\._])(0?2)([-\/\._])(29))|(^([1][89][0][48])([-\/\._])(0?2)([-\/\._])(29))|(^([2-9][0-9][0][48])([-\/\._])(0?2)([-\/\._])(29))|(^([1][89][2468][048])([-\/\._])(0?2)([-\/\._])(29))|(^([2-9][0-9][2468][048])([-\/\._])(0?2)([-\/\._])(29))|(^([1][89][13579][26])([-\/\._])(0?2)([-\/\._])(29))|(^([2-9][0-9][13579][26])([-\/\._])(0?2)([-\/\._])(29)))((\s+(0?[1-9]|1[012])(:[0-5]\d){0,2}(\s[AP]M))?$|(\s+([01]\d|2[0-3])(:[0-5]\d){0,2})?$))");
            return reg.IsMatch(strDate);
        }

        /// <summary>
        /// 检查手机号码是否正确
        /// </summary>
        /// <param name="str"></param>
        public bool IsPhoneNumber(string str)
        {
            // 严谨版 ^0?(13[0-9]|15[012356789]|18[0236789]|14[57])[0-9]{8}$
            var reg = new Regex(@"^1[3|4|5|8][0-9]\d{8}$");
            return reg.IsMatch(str);
        }
    }
}