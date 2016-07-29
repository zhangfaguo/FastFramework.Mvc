using System;
using System.Collections.Concurrent;

namespace FastFramework.Core
{
    public class AppConfig
    {

        public ConcurrentDictionary<string, object> items;

        static AppConfig _ins;

        static AppConfig()
        {
            _ins = new AppConfig();
        }

        private AppConfig()
        {
            items = new ConcurrentDictionary<string, object>();
        }

        public static AppConfig Instance
        {
            get
            {
                return _ins;
            }
        }


        #region IOC容器
        public IAppContianer Container
        {
            get;
            set;
        }

        public static IAppContianer Containers
        {
            get
            {
                return _ins.Container;
            }
            set
            {
                _ins.Container = value;
            }
        }
        #endregion

        #region 对象转换器
        public IMapper Mapper { get; set; }

        public static IMapper Mappers
        {
            get
            {
                return _ins.Mapper;
            }
            set
            {
                _ins.Mapper = value;
            }
        }
        #endregion

        #region 系统配置索引器

        public object this[string key]
        {
            get
            {
                return _ins.GetItem<object>(key);
            }

            set
            {
                _ins.SetItem(key, value);
            }
        }

        public T GetItem<T>(string key)
        {
            try
            {

                return (T)this.items[key];

            }
            catch (Exception ex)
            {
                throw new ArgumentException("配置【" + key + "】不存在", ex);
            }
        }

        public void SetItem(string key, Object value)
        {
            items.AddOrUpdate(key, value, (s, n) =>
            {
                return n;
            });
        }

        #endregion

        #region Json转换器
        public IJsonProvider JsonConvert { get; set; }

        public static IJsonProvider JsonConverts
        {
            get
            {
                return _ins.JsonConvert;
            }
            set
            {
                _ins.JsonConvert = value;
            }
        }
        #endregion

        #region 日志组件

        public ILogProvider LogProvider { get; set; }

        public static ILogProvider LogWrtier
        {
            get
            {
                if (_ins.LogProvider == null)
                    throw new ArgumentNullException("LogProvider");
                return _ins.LogProvider;
            }
        }

        #endregion

    }
}
