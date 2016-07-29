using System;
using System.Linq;
using System.Linq.Expressions;

namespace FastFramework.Repositorys.Core.Contracts
{
    public interface IEfRepository<TEntity> : IEfRepository, IRepository
        where TEntity : class
    {

        /// <summary>
        /// 查询对象
        /// </summary>
        IQueryable<TEntity> Query { get; }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="enitty"></param>
        /// <param name="saveNow"></param>
        /// <returns></returns>
        TEntity Add(TEntity entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int Remove(Expression<Func<TEntity, bool>> where);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="where"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        int Update(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TEntity>> data);

        /// <summary>
        /// 执行事务
        /// </summary>
        /// <param name="act"></param>
        /// <returns></returns>
        bool BegionTran(Action act);


    }

    public interface IEfRepository { }


    public interface IRepository
    {

    }

}
