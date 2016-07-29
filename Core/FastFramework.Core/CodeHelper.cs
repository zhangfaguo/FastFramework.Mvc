using System;

namespace FastFramework.Core
{
    public class CodeHelper
    {
        /// <summary>
        /// 安全执行代码
        /// </summary>
        public static T SafeRun<T>(Func<T> act)
        {
            T tag = default(T);
            try
            {
                tag = act();
            }
            catch (Exception ex)
            {
                AppConfig.LogWrtier.Log("CodeHelper", ex);
                tag = default(T);
            }

            return tag;
        }

        public static T SafeRun<TParm, T>(Func<TParm, T> act, TParm parm)
        {
            T tag = default(T);
            try
            {
                tag = act(parm);
            }
            catch (Exception ex)
            {
                AppConfig.LogWrtier.Log("CodeHelper", ex);
                tag = default(T);
            }

            return tag;
        }

        public static T SafeRun<TParm, TParm2, T>(Func<TParm, TParm2, T> act, TParm parm, TParm2 parm2)
        {
            T tag = default(T);
            try
            {
                tag = act(parm, parm2);
            }
            catch (Exception ex)
            {
                AppConfig.LogWrtier.Log("CodeHelper", ex);
                tag = default(T);
            }

            return tag;
        }
    }
}
