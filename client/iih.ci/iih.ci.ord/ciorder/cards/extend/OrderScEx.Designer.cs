﻿using System.Drawing;
namespace iih.ci.ord.ciorder.cards.extend
{
    partial class OrderScEx
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // xapFormControl1
            // 
            //this.xapFormControl1.ActiveRender = null;
            ////this.xapFormControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.xapFormControl1.Context = null;
            this.xapFormControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xapFormControl1.File = null;
            this.xapFormControl1.IsXapGrid = true;
            this.xapFormControl1.Location = new System.Drawing.Point(0, 0);
            this.xapFormControl1.Name = "xapFormControl1";
            this.xapFormControl1.Size = new System.Drawing.Size(590, 420);
            this.xapFormControl1.TabIndex = 1;
            this.xapFormControl1.ViewFile = null;
            // 
            // OrderScEx
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AddRender(this.xapFormControl1);
            this.Name = "OrderScEx";
            this.Size = new System.Drawing.Size(590, 420);
            this.Load += new System.EventHandler(this.OrderScEx_Load);
            this.ResumeLayout(false);
        }

        #endregion

        xap.rui.control.forms.view.XapFormControl xapFormControl1;
    }
}
