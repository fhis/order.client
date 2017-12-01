package iih.ci.mr.nu.newbabypicc.d;

import xap.sys.appfw.orm.desc.DescManager;
import xap.mw.coreitf.c.GlobalConst;
import xap.mw.coreitf.i.IDODesc;
import xap.mw.coreitf.d.*;
import xap.mw.core.data.*;
import iih.ci.mr.nu.newbabypicc.d.desc.NewBabyPiccDODesc;
import java.math.BigDecimal;

/**
 * 新生儿科PICC护理记录单 DO数据 
 * 
 */
public class NewBabyPiccDO extends BaseDO {
	private static final long serialVersionUID = 1L;

	public static final String ID_PICC= "Id_picc";
	public static final String ID_PAT= "Id_pat";
	public static final String CODE_ENTP= "Code_entp";
	public static final String ID_ENT= "Id_ent";
	public static final String NAME_BED= "Name_bed";
	public static final String CODE_AMR_IP= "Code_amr_ip";
	public static final String OPERATOR= "Operator";
	public static final String DT_PUNCTURE= "Dt_puncture";
	public static final String CATHETERTYPE= "Cathetertype";
	public static final String ID_PUNCTURE_SITE= "Id_puncture_site";
	public static final String SD_PUNCTURE_SITE= "Sd_puncture_site";
	public static final String CATHETERLENGTH= "Catheterlength";
	public static final String CHESTRADIOGRAPH= "Chestradiograph";
	public static final String DT_EXTUBATION= "Dt_extubation";
	public static final String ID_RESULT_CULTURE= "Id_result_culture";
	public static final String SD_RESULT_CULTURE= "Sd_result_culture";
	public static final String CREATEDTIME= "Createdtime";
	public static final String MODIFIEDTIME= "Modifiedtime";
	public static final String MODIFIEDBY= "Modifiedby";
	public static final String CREATEDBY= "Createdby";
	public static final String ID_GRP= "Id_grp";
	public static final String ID_ORG= "Id_org";
	public static final String NAME_PAT= "Name_pat";
	public static final String NAME_OPERATOR= "Name_operator";
	public static final String NAME_PUNCTURE_SITE= "Name_puncture_site";
	public static final String NAME_RESULT_CULTURE= "Name_result_culture";
	public static final String DS = "Ds";
	public static final String SV = "Sv";
	
	public String getId_picc() {
		return ((String) getAttrVal("Id_picc"));
	}	
	public void setId_picc(String Id_picc) {
		setAttrVal("Id_picc", Id_picc);
	}
	public String getId_pat() {
		return ((String) getAttrVal("Id_pat"));
	}	
	public void setId_pat(String Id_pat) {
		setAttrVal("Id_pat", Id_pat);
	}
	public String getCode_entp() {
		return ((String) getAttrVal("Code_entp"));
	}	
	public void setCode_entp(String Code_entp) {
		setAttrVal("Code_entp", Code_entp);
	}
	public String getId_ent() {
		return ((String) getAttrVal("Id_ent"));
	}	
	public void setId_ent(String Id_ent) {
		setAttrVal("Id_ent", Id_ent);
	}
	public String getName_bed() {
		return ((String) getAttrVal("Name_bed"));
	}	
	public void setName_bed(String Name_bed) {
		setAttrVal("Name_bed", Name_bed);
	}
	public String getCode_amr_ip() {
		return ((String) getAttrVal("Code_amr_ip"));
	}	
	public void setCode_amr_ip(String Code_amr_ip) {
		setAttrVal("Code_amr_ip", Code_amr_ip);
	}
	public String getOperator() {
		return ((String) getAttrVal("Operator"));
	}	
	public void setOperator(String Operator) {
		setAttrVal("Operator", Operator);
	}
	public FDate getDt_puncture() {
		return ((FDate) getAttrVal("Dt_puncture"));
	}	
	public void setDt_puncture(FDate Dt_puncture) {
		setAttrVal("Dt_puncture", Dt_puncture);
	}
	public String getCathetertype() {
		return ((String) getAttrVal("Cathetertype"));
	}	
	public void setCathetertype(String Cathetertype) {
		setAttrVal("Cathetertype", Cathetertype);
	}
	public String getId_puncture_site() {
		return ((String) getAttrVal("Id_puncture_site"));
	}	
	public void setId_puncture_site(String Id_puncture_site) {
		setAttrVal("Id_puncture_site", Id_puncture_site);
	}
	public String getSd_puncture_site() {
		return ((String) getAttrVal("Sd_puncture_site"));
	}	
	public void setSd_puncture_site(String Sd_puncture_site) {
		setAttrVal("Sd_puncture_site", Sd_puncture_site);
	}
	public Integer getCatheterlength() {
		return ((Integer) getAttrVal("Catheterlength"));
	}	
	public void setCatheterlength(Integer Catheterlength) {
		setAttrVal("Catheterlength", Catheterlength);
	}
	public String getChestradiograph() {
		return ((String) getAttrVal("Chestradiograph"));
	}	
	public void setChestradiograph(String Chestradiograph) {
		setAttrVal("Chestradiograph", Chestradiograph);
	}
	public FDate getDt_extubation() {
		return ((FDate) getAttrVal("Dt_extubation"));
	}	
	public void setDt_extubation(FDate Dt_extubation) {
		setAttrVal("Dt_extubation", Dt_extubation);
	}
	public String getId_result_culture() {
		return ((String) getAttrVal("Id_result_culture"));
	}	
	public void setId_result_culture(String Id_result_culture) {
		setAttrVal("Id_result_culture", Id_result_culture);
	}
	public String getSd_result_culture() {
		return ((String) getAttrVal("Sd_result_culture"));
	}	
	public void setSd_result_culture(String Sd_result_culture) {
		setAttrVal("Sd_result_culture", Sd_result_culture);
	}
	public FDateTime getCreatedtime() {
		return ((FDateTime) getAttrVal("Createdtime"));
	}	
	public void setCreatedtime(FDateTime Createdtime) {
		setAttrVal("Createdtime", Createdtime);
	}
	public FDateTime getModifiedtime() {
		return ((FDateTime) getAttrVal("Modifiedtime"));
	}	
	public void setModifiedtime(FDateTime Modifiedtime) {
		setAttrVal("Modifiedtime", Modifiedtime);
	}
	public String getModifiedby() {
		return ((String) getAttrVal("Modifiedby"));
	}	
	public void setModifiedby(String Modifiedby) {
		setAttrVal("Modifiedby", Modifiedby);
	}
	public String getCreatedby() {
		return ((String) getAttrVal("Createdby"));
	}	
	public void setCreatedby(String Createdby) {
		setAttrVal("Createdby", Createdby);
	}
	public String getId_grp() {
		return ((String) getAttrVal("Id_grp"));
	}	
	public void setId_grp(String Id_grp) {
		setAttrVal("Id_grp", Id_grp);
	}
	public String getId_org() {
		return ((String) getAttrVal("Id_org"));
	}	
	public void setId_org(String Id_org) {
		setAttrVal("Id_org", Id_org);
	}
	public String getName_pat() {
		return ((String) getAttrVal("Name_pat"));
	}	
	public void setName_pat(String Name_pat) {
		setAttrVal("Name_pat", Name_pat);
	}
	public String getName_operator() {
		return ((String) getAttrVal("Name_operator"));
	}	
	public void setName_operator(String Name_operator) {
		setAttrVal("Name_operator", Name_operator);
	}
	public String getName_puncture_site() {
		return ((String) getAttrVal("Name_puncture_site"));
	}	
	public void setName_puncture_site(String Name_puncture_site) {
		setAttrVal("Name_puncture_site", Name_puncture_site);
	}
	public String getName_result_culture() {
		return ((String) getAttrVal("Name_result_culture"));
	}	
	public void setName_result_culture(String Name_result_culture) {
		setAttrVal("Name_result_culture", Name_result_culture);
	}

	public Integer getDs() {
		return ((Integer) getAttrVal(GlobalConst.DELETE_SIGN));
	}
	
	public void setDs(Integer ds) {
		setAttrVal(GlobalConst.DELETE_SIGN, ds);
	}
	
	public FDateTime getSv() {
		return ((FDateTime) getAttrVal(GlobalConst.SYSTEM_VERSION));
	}
	
	public void setSv(FDateTime sv) {
		setAttrVal(GlobalConst.SYSTEM_VERSION, sv);
	}

//	@Override
//	public java.lang.String getParentPKFieldName() {
//		return null;
//	}
  
	@Override
	public String getPKFieldName() {
		return "Id_picc";
	}
	
	@Override
	public String getTableName() {	  
		return "ci_mr_nu_picc";
	}
	
	@Override
	public IDODesc getDODesc() {
		return DescManager.getInstance().getDODesc(NewBabyPiccDODesc.class);
	}
	
}