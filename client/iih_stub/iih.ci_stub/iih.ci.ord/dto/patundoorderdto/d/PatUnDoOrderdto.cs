using System;
using xap.mw.core.data;
using xap.mw.coreitf.d;

namespace iih.ci.ord.dto.patundoorderdto.d
{
    /// <summary>
    /// PatUnDoOrderdto 的摘要说明。
    /// </summary>
    public class PatUnDoOrderdto : BaseDTO {

        public PatUnDoOrderdto() {
 
        }

        /// <summary>
        /// 医嘱主键
        /// </summary>
		public string Id_or {
            get { return getAttrVal<string>("Id_or",null); }
            set { setAttrVal<string>("Id_or", value); }
        }

        /// <summary>
        /// 医嘱备注
        /// </summary>
		public string Des_or {
            get { return getAttrVal<string>("Des_or",null); }
            set { setAttrVal<string>("Des_or", value); }
        }

        /// <summary>
        /// 医学单位数值
        /// </summary>
		public double? Quan_medu {
            get { return getAttrVal<FDouble>("Quan_medu",null); }
            set { setAttrVal<FDouble>("Quan_medu", value); }
        }

        /// <summary>
        /// 医学单位
        /// </summary>
		public string Id_medu {
            get { return getAttrVal<string>("Id_medu",null); }
            set { setAttrVal<string>("Id_medu", value); }
        }

        /// <summary>
        /// 医学单位名称
        /// </summary>
		public string Name_medu {
            get { return getAttrVal<string>("Name_medu",null); }
            set { setAttrVal<string>("Name_medu", value); }
        }

        /// <summary>
        /// 用法
        /// </summary>
		public string Id_route {
            get { return getAttrVal<string>("Id_route",null); }
            set { setAttrVal<string>("Id_route", value); }
        }

        /// <summary>
        /// 用法名称
        /// </summary>
		public string Name_route {
            get { return getAttrVal<string>("Name_route",null); }
            set { setAttrVal<string>("Name_route", value); }
        }

        /// <summary>
        /// 医嘱频次
        /// </summary>
		public string Id_freq {
            get { return getAttrVal<string>("Id_freq",null); }
            set { setAttrVal<string>("Id_freq", value); }
        }

        /// <summary>
        /// 医嘱频次名称
        /// </summary>
		public string Name_freq {
            get { return getAttrVal<string>("Name_freq",null); }
            set { setAttrVal<string>("Name_freq", value); }
        }

        /// <summary>
        /// 医嘱名称
        /// </summary>
		public string Or_name {
            get { return getAttrVal<string>("Or_name",null); }
            set { setAttrVal<string>("Or_name", value); }
        }

        /// <summary>
        /// 剂量
        /// </summary>
		public double? Dose {
            get { return getAttrVal<FDouble>("Dose",null); }
            set { setAttrVal<FDouble>("Dose", value); }
        }

        /// <summary>
        /// 规格
        /// </summary>
		public string Spec {
            get { return getAttrVal<string>("Spec",null); }
            set { setAttrVal<string>("Spec", value); }
        }

        /// <summary>
        /// 开始时间
        /// </summary>
		public DateTime? Dt_effe {
            get { return getAttrVal<FDateTime>("Dt_effe",null); }
            set { setAttrVal<FDateTime>("Dt_effe", value); }
        }

        /// <summary>
        /// 结束时间
        /// </summary>
		public DateTime? Dt_end {
            get { return getAttrVal<FDateTime>("Dt_end",null); }
            set { setAttrVal<FDateTime>("Dt_end", value); }
        }

        /// <summary>
        /// 状态
        /// </summary>
		public string Id_su_or {
            get { return getAttrVal<string>("Id_su_or",null); }
            set { setAttrVal<string>("Id_su_or", value); }
        }

        /// <summary>
        /// 名称
        /// </summary>
		public string Name_su_or {
            get { return getAttrVal<string>("Name_su_or",null); }
            set { setAttrVal<string>("Name_su_or", value); }
        }

        /// <summary>
        /// 单位
        /// </summary>
		public string Id_unit {
            get { return getAttrVal<string>("Id_unit",null); }
            set { setAttrVal<string>("Id_unit", value); }
        }

        /// <summary>
        /// 单位名称
        /// </summary>
		public string Unit_name {
            get { return getAttrVal<string>("Unit_name",null); }
            set { setAttrVal<string>("Unit_name", value); }
        }
        /// <summary>
        /// 返回属性列表
        /// </summary>
        /// <returns></returns>
        public override string[] getAttrNames()
        {
            return new string[]{ "Id_or", "Des_or", "Quan_medu", "Id_medu", "Name_medu", "Id_route", "Name_route", "Id_freq", "Name_freq", "Or_name", "Dose", "Spec", "Dt_effe", "Dt_end", "Id_su_or", "Name_su_or", "Id_unit", "Unit_name"};
        }
        
        /// <summary>
        /// 返回全路径DO类名
        /// </summary>
        /// <returns></returns>
        public override string getFullClassName()
        {
            return "iih.ci.ord.dto.patundoorderdto.d.PatUnDoOrderdto";
        }
    }
}
