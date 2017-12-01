﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iih.ci.ord.ciordems.d;
using xap.cli.sdk.controls.DataView;
using xap.cli.sdk.render.Items;
using iih.ci.ord.dto.d;

namespace iih.ci.ord.opemergency.controls
{
    /// <summary>
    /// 用血
    /// </summary>
    class QuanBuTableCell : BaseValueUnitTableCell
    {
        protected override void initCellControlFormat(XBaseUserRender ctrl)
        {
            XComboBoxUnit xComboBoxUnit = ctrl as XComboBoxUnit;
            xComboBoxUnit.ComboboxWidthPercent = 0.38;
            xComboBoxUnit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            xComboBoxUnit.UnitIsEnable = false; // 禁用单位编辑
        }

        protected override void editorWillAppear(object rowDataSource, XBaseUserRender ctrl)
        {
            CiordubDTO btitemdo = rowDataSource as CiordubDTO;
            if (null != btitemdo)
            {
                XComboBoxUnit xComboBoxUnit = ctrl as XComboBoxUnit;
                xComboBoxUnit.ValueText = btitemdo.Quan_medu == null ? "" : btitemdo.Quan_medu.ToString();
                xComboBoxUnit.ValueUnit = btitemdo.Name_unit;
            }
        }

        protected override void editorWillDisappear(object rowDataSource, XBaseUserRender ctrl)
        {
            XComboBoxUnit xComboBoxUnit = ctrl as XComboBoxUnit;
            CiordubDTO btitemdo = rowDataSource as CiordubDTO;
            if (null != btitemdo)
            {
                btitemdo.Quan_medu = ((xComboBoxUnit.ValueText == null || xComboBoxUnit.ValueText.Length == 0) ? 0 : Double.Parse(xComboBoxUnit.ValueText));
                btitemdo.Name_unit = xComboBoxUnit.ValueUnit;
            }
        }

        protected override void cellWillAppear(object rowDataSource, XCellRender cell)
        {

            CiordubDTO btitemdo = rowDataSource as CiordubDTO;
            if (null != btitemdo && btitemdo.Id_srv != null && btitemdo.Id_srv.Length != 0)
            {
                cell.SetValue(btitemdo.Quan_medu.ToString() + btitemdo.Name_unit);
            }
        }
    }
}
