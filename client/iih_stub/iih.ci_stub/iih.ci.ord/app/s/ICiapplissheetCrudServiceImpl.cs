﻿using System;
using System.Collections.Generic;
//using iih.ci.ord.app.s.itf;
using xap.mw.core.utils;
using xap.mw.coreitf.d;
using xap.mw.serviceframework;
using xap.rui.appfw;
using xap.mw.core.data;
using xap.sys.appfw.tmpl.qryscheme; 
using iih.ci.ord.app.d;
using xap.sys.basebiz.appfwdata;
using xap.sys.appfw.tmpl.qryscheme.qrydto;

namespace iih.ci.ord.app.i
{
    public class ICiapplissheetCrudServiceImpl : ICiapplissheetCrudService
    {
        private string url   = XapSvrConfig.BaseUrl + "iihci.ord/iih.ci.ord.app.i.ICiapplissheetCudService";//ConfigUtil.getServiceUrl();
        private string url_r = XapSvrConfig.BaseUrl + "iihci.ord/iih.ci.ord.app.i.ICiapplissheetRService";//ConfigUtil.getServiceUrl();
        
        private ServiceInvocation si;
		private CacheHelper<CiapplissheetAggDO> ch;
        /// <summary>
        /// 构造函数
        /// </summary>
        public ICiapplissheetCrudServiceImpl()
        {
        	ch = new CacheHelper<CiapplissheetAggDO>();
            si = new ServiceInvocationImpl();
            si.url = url;
        }

        /// <summary>
        /// 检验申请单AggDO数据真删除
        /// </summary>
        /// <param name="aggdos"></param>
        public void delete(CiapplissheetAggDO[] aggdos)
        {
            List<object> param = new List<object>();
            param.Add(aggdos);
            si.url = url;
            si.invokeList<CiapplissheetAggDO>("delete", param.ToArray());  
        }

        /// <summary>
        /// 检验申请单AggDO数据插入保存
        /// </summary>
        /// <param name="aggdos"></param>
        /// <returns></returns>
        public CiapplissheetAggDO[] insert(CiapplissheetAggDO[] aggdos)
        {
            List<object> param = new List<object>();
            param.Add(aggdos);
            si.url = url;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("insert", param.ToArray());
            #region "数据缓存逻辑新增"
            handleRtn(rtn);
            #endregion
            return rtn;
        }

        /// <summary>
        /// 检验申请单AggDO数据保存
        /// </summary>
        /// <param name="aggdos"></param>
        /// <returns></returns>
        public CiapplissheetAggDO[] save(CiapplissheetAggDO[] aggdos)
        {
            List<object> param = new List<object>();
            param.Add(aggdos);
            si.url = url;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("save", param.ToArray());
            #region "数据缓存逻辑新增"
            handleRtn(rtn);
            #endregion
            return rtn;
        }

        /// <summary>
        /// 检验申请单AggDO数据更新
        /// </summary>
        /// <param name="aggdos"></param>
        /// <returns></returns>
        public CiapplissheetAggDO[] update(CiapplissheetAggDO[] aggdos)
        {
            List<object> param = new List<object>();
            param.Add(aggdos);
            si.url = url;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("update", param.ToArray());
            #region "数据缓存逻辑新增"
            handleRtn(rtn);
            #endregion
            return rtn;
        }

        /// <summary>
        /// 检验申请单AggDO数据逻辑删除
        /// </summary>
        /// <param name="aggdos"></param>
        public void logicDelete(CiapplissheetAggDO[] aggdos)
        {
            List<object> param = new List<object>();
            param.Add(aggdos);
            si.url = url;
            si.invokeList<CiapplissheetAggDO>("logicDelete", param.ToArray());  //??
        }

        /// <summary>
        /// 根据id值查找检验申请单AggDO数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CiapplissheetAggDO findById(String id)
        {
        	#region "缓存处理"
        	if (ch.IsCached("findById"))
            {
                return ch.findById(id);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(id);
            si.url = url_r;
            CiapplissheetAggDO rtn = si.invoke<CiapplissheetAggDO>("findById", param.ToArray());
            return rtn;
        }

        /// <summary>
        /// 根据id值集合查找检验申请单AggDO数据集合
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="isLazy"></param>
        /// <returns></returns>
        public CiapplissheetAggDO[] findByIds(String[] ids, FBoolean isLazy)
        {
        	#region "缓存处理"
         	if (ch.IsCached("findByIds"))
            {
                return ch.findByIds(ids, isLazy);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(ids);
            param.Add(isLazy);
            si.url = url_r;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("findByIds", param.ToArray());
            #region "数据缓存逻辑新增"
            handleRtn(rtn);
            #endregion
            return rtn;
        }

        /// <summary>
        /// 根据id值集合查找检验申请单AggDO数据集合--大数据量
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="isLazy"></param>
        /// <returns></returns>
        public CiapplissheetAggDO[] findByBIds(String[] ids, FBoolean isLazy)
        {
        	#region "缓存处理"
        	if (ch.IsCached("findByBIds"))
            {
                return ch.findByBIds(ids, isLazy);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(ids);
            param.Add(isLazy);
            si.url = url_r;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("findByBIds", param.ToArray());
            #region "数据缓存逻辑新增"
            handleRtn(rtn);
            #endregion
            return rtn;
        }

        /// <summary>
        /// 根据condition条件查找检验申请单AggDO数据集合
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="isLazy"></param>
        /// <returns></returns>
        public CiapplissheetAggDO[] find(String condition, string orderStr, FBoolean isLazy)
        {
        	#region "缓存处理"
        	if (ch.IsCached("find"))
            {
                return ch.find(condition, orderStr, isLazy);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(condition);
            param.Add(orderStr);
            param.Add(isLazy);
            si.url = url_r;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("find", param.ToArray());
            #region "数据缓存逻辑新增"
            handleRtn(rtn);
            #endregion
            return rtn;
        }

        /// <summary>
        /// 根据condition条件及管控查找检验申请单AggDO数据集合
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="isLazy"></param>
        /// <returns></returns>
        public CiapplissheetAggDO[] findByBDMode(String condition, string orderStr, FBoolean isLazy)
        {
        	#region "缓存处理"
        	if (ch.IsCached("find"))
            {
                return ch.find(condition, orderStr, isLazy);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(condition);
            param.Add(orderStr);
            param.Add(isLazy);
            si.url = url_r;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("findByBDMode", param.ToArray());
            #region "数据缓存逻辑新增"
            handleRtn(rtn);
            #endregion
            return rtn;
        }

        /// <summary>
        /// 根据查询方案查找检验申请单AggDO数据集合
        /// </summary>
        /// <param name="qscheme"></param>
        /// <returns></returns>
        public CiapplissheetAggDO[] findByQScheme(IQryScheme qscheme)
        {
        	#region "缓存处理"
        	if (ch.IsCached("findByQScheme"))
            {
                return ch.findByQScheme(qscheme);
            }
            #endregion
            List<object> param = new List<object>();
            param.Add(qscheme);
            si.url = url_r;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("findByQScheme", param.ToArray());
            #region "数据缓存逻辑新增"
            handleRtn(rtn);
            #endregion
            return rtn;
        }

        /// <summary>
        /// 根据分页信息及查询与分组条件获得分页数据
        /// </summary>
        /// <param name="pg"></param>
        /// <param name="wherePart"></param>
        /// <param name="orderByPart"></param>
        /// <param name="isLazy"></param>
        /// <returns>PagingRtnData</returns>
        public PagingRtnData<CiapplissheetAggDO> findByPageInfo(PaginationInfo pg, String wherePart,String orderByPart,FBoolean isLazy)
        {
            List<object> param = new List<object>();
		    param.Add(pg);
		    param.Add(wherePart);
		    param.Add(orderByPart);
		    param.Add(isLazy);
            si.url = url_r;
            PagingRtnData<CiapplissheetAggDO> rtn = si.invokePaging<CiapplissheetAggDO>("findByPageInfo", param.ToArray());
            return rtn;
        }  
        
        /// <summary>
        /// 根据分页信息、查询与分组条件及管控获得分页数据
        /// </summary>
        /// <param name="pg"></param>
        /// <param name="wherePart"></param>
        /// <param name="orderByPart"></param>
        /// <param name="isLazy"></param>
        /// <returns>PagingRtnData</returns>
        public PagingRtnData<CiapplissheetAggDO> findByPageInfoAndBDMode(PaginationInfo pg, String wherePart,String orderByPart,FBoolean isLazy)
        {
            List<object> param = new List<object>();
		    param.Add(pg);
		    param.Add(wherePart);
		    param.Add(orderByPart);
		    param.Add(isLazy);
            si.url = url_r;
            PagingRtnData<CiapplissheetAggDO> rtn = si.invokePaging<CiapplissheetAggDO>("findByPageInfoAndBDMode", param.ToArray());
            return rtn;
        }  
        
        /// <summary>
        /// 根据查询模板条件、分页信息查询分页数据集合
        /// </summary>
        /// <param name="qryRootNodeDTO"></param>
        /// <param name="orderStr"></param>
        /// <param name="pg"></param>
        /// <param name="isLazy"></param>
        public PagingRtnData<CiapplissheetAggDO> findByQCondAndPageInfo(QryRootNodeDTO qryRootNodeDTO,String orderStr,PaginationInfo pg,FBoolean isLazy)
        {
            List<object> param = new List<object>();
		    param.Add(qryRootNodeDTO);
		    param.Add(orderStr);
		    param.Add(pg);
		    param.Add(isLazy);
            si.url = url_r;
            PagingRtnData<CiapplissheetAggDO> rtn = si.invokePaging<CiapplissheetAggDO>("findByQCondAndPageInfo", param.ToArray());
            return rtn;
        }
        
        /// <summary>
        /// 根据主DO对检验申请单AggDO数据真删除
        /// </summary>
        /// <param name="mainDos"></param>
        public void deleteByParentDO(CiAppLisSheetDO[] mainDos){
            List<object> param = new List<object>();
            param.Add(mainDos);
            si.url = url;
            si.invokeList<CiAppLisSheetDO>("deleteByParentDO", param.ToArray());  
        }
        
        /// <summary>
        /// 根据主DO对检验申请单AggDO数据逻辑删除
        /// </summary>
        /// <param name="mainDos"></param>
        public void logicDeleteByParentDO(CiAppLisSheetDO[] mainDos){
            List<object> param = new List<object>();
            param.Add(mainDos);
            si.url = url;
            si.invokeList<CiAppLisSheetDO>("logicDeleteByParentDO", param.ToArray());  
        }

		#region "数据缓存逻辑新增"
        /// <summary>
        /// 查询返回数据的处理
        /// </summary>
        /// <param name="aggdos"></param>
        private void handleRtn(BaseAggDO[] aggdos)
        {
            if (aggdos == null || aggdos.Length == 0 || aggdos.Length == 1) return;
            foreach (BaseAggDO agg in aggdos)
            {
                agg.service = this;
            }
        }
        #endregion
        
        /// <summary>
        /// 根据查询方案查询聚合数据集合
        /// </summary>
        /// <param name="qryRootNodeDTO"></param>
        /// <param name="orderStr"></param>
        /// <param name="isLazy"></param>
        public CiapplissheetAggDO[] findByQCond(QryRootNodeDTO qryRootNodeDTO,String orderStr,FBoolean isLazy)
        {
            List<object> param = new List<object>();
            param.Add(qryRootNodeDTO);
            param.Add(orderStr);
            param.Add(isLazy);
            si.url = url_r;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("findByQCond", param.ToArray());
            return rtn;
        }
        
        /// <summary>
        /// 根据DO某一字符类型属性值查询DO数据
        /// <summary>
        /// <param name="attr"></param>
        /// <param name="value"></param>
        /// <returns>CiapplissheetAggDO[]</return>
        public CiapplissheetAggDO[] findByAttrValString(string attr, string value)
        {
            List<object> param = new List<object>();
            param.Add(attr);
            param.Add(value);
            si.url=url_r;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("findByAttrValString", param.ToArray());
            return rtn;
        }
        /// <summary>
        /// 根据DO某一字符类型属性值数组查询DO数据
        /// <summary>
        /// <param name="attr"></param>
        /// <param name="values"></param>
        /// <returns>CiapplissheetAggDO[]</return>
        public CiapplissheetAggDO[] findByAttrValStrings(string attr, string[] values)
        {
            List<object> param = new List<object>();
            param.Add(attr);
            param.Add(values);
            si.url=url_r;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("findByAttrValStrings", param.ToArray());
            return rtn;
        }
        /// <summary>
        /// 根据DO某一属性值List查询DO数据
        /// <summary>
        /// <param name="attr"></param>
        /// <param name="values"></param>
        /// <returns>CiapplissheetAggDO[]</return>
        public CiapplissheetAggDO[] findByAttrValList(string attr, FArrayList values)
        {
            List<object> param = new List<object>();
            param.Add(attr);
            param.Add(values);
            si.url=url_r;
            CiapplissheetAggDO[] rtn = si.invokeList<CiapplissheetAggDO>("findByAttrValList", param.ToArray());
            return rtn;
        }
    }
}