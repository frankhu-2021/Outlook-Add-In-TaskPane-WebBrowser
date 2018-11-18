namespace OutlookAddIn1
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.I_Swarmed = this.Factory.CreateRibbonGroup();
            this.toggleButton1 = this.Factory.CreateRibbonToggleButton();
            this.tab1.SuspendLayout();
            this.I_Swarmed.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.I_Swarmed);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // I_Swarmed
            // 
            this.I_Swarmed.Items.Add(this.toggleButton1);
            this.I_Swarmed.Label = "I Swarmed";
            this.I_Swarmed.Name = "I_Swarmed";
            // 
            // toggleButton1
            // 
            this.toggleButton1.Label = "Swarm Survey";
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.toggleButton1_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Mai" +
    "l.Read, Microsoft.Outlook.MeetingRequest.Read, Microsoft.Outlook.MeetingRequest." +
    "Send";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.I_Swarmed.ResumeLayout(false);
            this.I_Swarmed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup I_Swarmed;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton1;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
