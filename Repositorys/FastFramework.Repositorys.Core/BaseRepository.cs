using FastFramework.Repositorys.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EntityFramework.Extensions;
using Microsoft.Practices.Unity;

namespace FastFramework.Repositorys.Core
{
    public abstract class BaseRepository<TEntity> : BaseRepository, IEfRepository<TEntity>
        where TEntity : class
    {


        public DbSet<TEntity> Objects
        {
            get
            {
                return Provider.Set<TEntity>();
            }
        }

        public IQueryable<TEntity> Query
        {
            get
            {
                return Objects.AsQueryable();
            }
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="enitty"></param>
        /// <param name="saveNow"></param>
        /// <returns></returns>
        public TEntity Add(TEntity entity)
        {
            this.Objects.Add(entity);

            this.Save();

            return entity;
        }

        public int Remove(Expression<Func<TEntity, bool>> where)
        {
            return this.Objects.Where(where).Delete();
        }

        public int Update(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TEntity>> data)
        {
            var i = Objects.Where(where).Update(data);

            return i;
        }

        public bool BegionTran(Action act)
        {
            var tag = false;
            using (var tran = this.Provider.Database.BeginTransaction())
            {
                try
                {
                    act();
                    tran.Commit();
                    tag = true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            return tag;
        }

        public int Save()
        {
            return Provider.SaveChanges();
        }
    }

    public abstract class BaseRepository
    {
        [Dependency]
        public DbContext Provider { get; set; }

    }
}
