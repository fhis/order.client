﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iih.ci.ord.opemergency.assi.OrderTemplate.view;
using iih.en.pv.dto.d;
using xap.cli.sdk.controls;
using xap.cli.sdk.form;
using xap.cli.sdk.render;
using xap.rui.bizcontrol.Historyofrecords.card;
using xap.rui.control.basecontrol;
using xap.rui.control.extentions;
using xap.rui.engine;
using iih.ci.ord.opemergency.assi.i;
using iih.ci.ord.opemergency.assi.OrdertemplateComplex.view;

namespace iih.ci.ord.opemergency.assi.OrdertemplateComplex
{
    public partial class OrderHelpButtenComplex : XapBaseControl
    {
        public OpTemplateFrameComplex parentFrame;
        /// <summary>
        /// banner数据
        /// </summary>
        private Ent4BannerDTO BannerDTO;
        //切换按钮
        private XButton xBtnSwitch;
        // 确定、取消按钮
        private XButton xBtnOK;
        private XButton xBtnPrint;
        private XButton xBtnPrintView;
        private XButton xBtnClose;
        //全选、全消按钮
        private XButton xBtnAllChecked;
        private XButton xBtnAllCancel;

        // 门诊、住院图例
        //private StateRender stateRenderOP;
        //private StateRender stateRenderIP;
        // 控件布局
        private XBaseControl leftBaseCtrl;
        private XBaseControl rightBaseCtrl;
        private XLayoutPanel xLayoutPanel;

        /// <summary>
        /// 医嘱模板内容显示
        /// </summary>
        //private OpOrderTemplateListView templateListView;

        public OrderHelpButtenComplex()
        {
            InitializeComponent();
            this.Load += new EventHandler(OrderHelpButten_Load);
            intButten();
        }

        void OrderHelpButten_Load(object sender, EventArgs e)
        {
            //templateListView = this.Context.Config.GetInstance("OpOrderTemplateListView") as OpOrderTemplateListView;
            this.BannerDTO = this.Context["ent4BannerDTO"] as Ent4BannerDTO;
        }


        private void intButten()
        {
            // 确定、打印病历、病历打印预览，取消（关闭）按钮
            this.xBtnOK = new XButton();
            this.xBtnPrint = new XButton();
            this.xBtnPrintView = new XButton();
            this.xBtnClose = new XButton();
            this.xBtnSwitch = new XButton();
            //全选、全消
            this.xBtnAllChecked = new XButton();
            this.xBtnAllCancel = new XButton();
            // 住院、门诊图例
           // this.stateRenderIP = new StateRender { ForeColor = Color.FromArgb(0, 153, 229), ExplainName = "门诊" };
           // this.stateRenderOP = new StateRender { ForeColor = Color.FromArgb(36, 159, 131), ExplainName = "住院" };

            // 左右布局控件 展现按钮、图例
            this.leftBaseCtrl = new XBaseControl();
            this.rightBaseCtrl = new XBaseControl();
            this.xLayoutPanel = new XLayoutPanel();
            this.SuspendLayout();

            ///
            /// xLayoutPanel
            ///
            this.xLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            ///
            /// leftBaseCtrl 图例区域
            ///            
            this.xLayoutPanel.AddControl(this.leftBaseCtrl, ControlPosition.Left, 300);

            ///
            /// rightBaseCtrl 按钮区域
            ///
            //this.xLayoutPanel.AddControl(this.rightBaseCtrl, ControlPosition.Right, 308);
            this.xLayoutPanel.AddControl(this.rightBaseCtrl, ControlPosition.Right, 474);

            ///
            /// stateRenderOP
            ///
           // this.stateRenderOP.Location = new Point(73, 15);
            //this.leftBaseCtrl.AddRender(this.stateRenderOP);

            ///
            /// stateRenderIP
            ///
            //this.stateRenderIP.Location = new Point(160, 15);
           // this.leftBaseCtrl.AddRender(this.stateRenderIP);

            Size btnSize = new Size(86, 30);

            this.xBtnSwitch.Text = "切换";
            this.xBtnSwitch.Size = new Size(86, 30);
            this.xBtnSwitch.Location = new Point(26, 8);
            this.xBtnSwitch.MouseClick += new MouseEventHandler(xBtnSwtich_MouseClick);
            this.rightBaseCtrl.AddRender(this.xBtnSwitch);

            this.xBtnAllChecked.Text = "全选";
            this.xBtnAllChecked.Size = new Size(86, 30);
            this.xBtnAllChecked.Location = new Point(114, 8);
            this.xBtnAllChecked.MouseClick += new MouseEventHandler(xBtnAllChecked_MouseClick);
            this.rightBaseCtrl.AddRender(this.xBtnAllChecked);

            this.xBtnAllCancel.Text = "全消";
            this.xBtnAllCancel.Size = new Size(86, 30);
            this.xBtnAllCancel.Location = new Point(202, 8);
            this.xBtnAllCancel.MouseClick += new MouseEventHandler(xBtnAllCancel_MouseClick);
            this.rightBaseCtrl.AddRender(this.xBtnAllCancel);

            ///
            /// xBtnInovke
            ///
            this.xBtnOK.Text = "确定";
            this.xBtnOK.Size = new Size(86, 30);
            this.xBtnOK.Location = new Point(290, 8);
            this.xBtnOK.MouseClick += new MouseEventHandler(xBtnOK_MouseClick);
            this.rightBaseCtrl.AddRender(this.xBtnOK);

            ///
            /// xBtnPrint
            ///
            this.xBtnPrint.Text = "打印病历";
            this.xBtnPrint.Size = new Size(126, 30);
            this.xBtnPrint.Location = new Point(106, 8);
           // this.xBtnPrint.MouseClick += new System.Windows.Forms.MouseEventHandler(XBtnPrint_MouseClick);
          //  this.rightBaseCtrl.AddRender(this.xBtnPrint);

            ///
            /// xBtnPrint
            ///
            this.xBtnPrintView.Text = "病历预览打印";
            this.xBtnPrintView.Size = new Size(126, 30);
            this.xBtnPrintView.Location = new Point(242, 8);
           // this.xBtnPrintView.MouseClick += new System.Windows.Forms.MouseEventHandler(XBtnPrintView_MouseClick);
            //this.rightBaseCtrl.AddRender(this.xBtnPrintView);

            ///
            /// xBtnClose
            ///
            this.xBtnClose.Text = "取消";
            this.xBtnClose.Size = new Size(86, 30);
            this.xBtnClose.Location = new Point(378, 8);
            this.xBtnClose.MouseClick += new MouseEventHandler(xBtnClose_MouseClick);
             this.rightBaseCtrl.AddRender(this.xBtnClose);

            ///
            /// this
            ///
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.Controls.Add(this.xLayoutPanel);
        

            this.ResumeLayout(false);

        }
        //关闭
        void xBtnClose_MouseClick(object sender, MouseEventArgs e)
        {
            //this.templateListView.close();
            if(this.parentFrame!=null){
             this.parentFrame.close();   
            }
        }
         //保存数据
        void xBtnOK_MouseClick(object sender, MouseEventArgs e)
        {
            //this.templateListView.Save();
            if (this.parentFrame != null)
            {
                this.parentFrame.saveData();
            }
        }
        //切换到简易版
        void xBtnSwtich_MouseClick(object sender, MouseEventArgs e)
        {
            //this.templateListView.close();
            if (this.parentFrame != null)
            {
                this.parentFrame.switchToPithy();
            }
        }
        //全选
        void xBtnAllChecked_MouseClick(object sender, MouseEventArgs e)
        {
            //this.templateListView.close();
            if (this.parentFrame != null)
            {
                this.parentFrame.allChecked();
            }
        }
        //全选
        void xBtnAllCancel_MouseClick(object sender, MouseEventArgs e)
        {
            //this.templateListView.close();
            if (this.parentFrame != null)
            {
                this.parentFrame.allCancel();
            }
        }



        public XForm AssiViewFrame { get; set; }

        public Ent4BannerDTO Ent4BannerDTO { get; set; }
        /// <summary>
        /// 当前环境信息
        /// </summary>
        public BaseContext BaseContext { get; set; }
        /// <summary>
        /// 就诊类型 门诊 00、急诊 01 、体检 02 、住院 10、家庭病床 20
        /// </summary>
        public string Code_entp { get; set; }
    }
}
