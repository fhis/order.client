﻿namespace iih.ci.ord.opemergency.assi.OrderTemplate.view
{
    partial class OpOrderTemplateTreeView
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
            components = new System.ComponentModel.Container();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.oTree1 = new xap.rui.control.tree.otree.OTree();
            xap.rui.control.tree.options.FocusOptions focusOptions1 = new xap.rui.control.tree.options.FocusOptions();
            // 
            // oTree1
            // 
            this.oTree1.BackColor = System.Drawing.Color.White;
            this.oTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            focusOptions1.NodeFocusOnRefresh = xap.rui.control.tree.options.FocusOnRefreshMode.KeepFocus;
            this.oTree1.FocusOption = focusOptions1;
            this.oTree1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.oTree1.IsContainerRender = true;
            this.oTree1.Location = new System.Drawing.Point(0, 30);
            this.oTree1.Name = "oTree1";
            this.oTree1.SingleBorderStyle = false;
            this.oTree1.Size = new System.Drawing.Size(290, 600);
            this.oTree1.TabIndex = 1;
         
        }

        #endregion
    }
}
