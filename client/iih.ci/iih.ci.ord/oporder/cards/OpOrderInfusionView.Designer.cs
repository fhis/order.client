﻿namespace iih.ci.ord.oporder.cards
{
    partial class OpOrderInfusionView
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
            this.xapFormControl1 = new xap.rui.control.forms.view.XapFormControl();
            this.SuspendLayout();
            // 
            // xapFormControl1
            // 
            this.xapFormControl1.AutoSize = true;
            //this.xapFormControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            //this.xapFormControl1.CanShowing = null;
            this.xapFormControl1.Context = null;
            this.xapFormControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xapFormControl1.File = null;
            this.xapFormControl1.Location = new System.Drawing.Point(0, 0);
            this.xapFormControl1.Name = "xapFormControl1";
            this.xapFormControl1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.xapFormControl1.Size = new System.Drawing.Size(150, 150);
            this.xapFormControl1.TabIndex = 0;
            this.xapFormControl1.ViewFile = null;
            // 
            // OrderInfusionView
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xapFormControl1);
            this.Name = "OrderInfusionView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private xap.rui.control.forms.view.XapFormControl xapFormControl1;
    }
}
