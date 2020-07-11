using System;

namespace ringo
{
    class randomcode //随机生成字符串
    {
        public static string code()//随机生成用户验证码
        {
            string code = "";           //验证码字符串
            Random ran = new Random();
            for (int i = 0; i < 4; i++) //随机生成4位数字验证码
            {
                int n = ran.Next(9);
                code += n;
            }
            return code;
        }
    }
}