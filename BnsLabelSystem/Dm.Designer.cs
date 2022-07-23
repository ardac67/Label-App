namespace BnsLabelSystem
{
    partial class Dm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dm));
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.label5 = new DevExpress.XtraReports.UI.XRLabel();
            this.pictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.label11 = new DevExpress.XtraReports.UI.XRLabel();
            this.label10 = new DevExpress.XtraReports.UI.XRLabel();
            this.label9 = new DevExpress.XtraReports.UI.XRLabel();
            this.label8 = new DevExpress.XtraReports.UI.XRLabel();
            this.label7 = new DevExpress.XtraReports.UI.XRLabel();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.barCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label6,
            this.label5,
            this.pictureBox1,
            this.label11,
            this.label10,
            this.label9,
            this.label8,
            this.label7,
            this.label4,
            this.label3,
            this.label2,
            this.label1,
            this.barCode1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 347.9325F;
            this.Detail.MultiColumn.ColumnCount = 2;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProductCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("ColorCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("ItemDim1Code", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("KutuNo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dpi = 254F;
            this.label6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KutuNo]")});
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.label6.LocationFloat = new DevExpress.Utils.PointFloat(137.6552F, 204.1358F);
            this.label6.Name = "label6";
            this.label6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label6.SizeF = new System.Drawing.SizeF(77.02328F, 26.60747F);
            this.label6.StylePriority.UseBackColor = false;
            this.label6.StylePriority.UseFont = false;
            this.label6.StylePriority.UseTextAlignment = false;
            this.label6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.label6.WordWrap = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dpi = 254F;
            this.label5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dimension]")});
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.label5.LocationFloat = new DevExpress.Utils.PointFloat(205.9477F, 74.60754F);
            this.label5.Name = "label5";
            this.label5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label5.SizeF = new System.Drawing.SizeF(75.3224F, 42.54496F);
            this.label5.StylePriority.UseBackColor = false;
            this.label5.StylePriority.UseFont = false;
            this.label5.StylePriority.UseTextAlignment = false;
            this.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dpi = 254F;
            this.pictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleLeft;
            this.pictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("pictureBox1.ImageSource"));
            this.pictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(208.5097F, 177.8154F);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.SizeF = new System.Drawing.SizeF(72.76038F, 48.04845F);
            this.pictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.pictureBox1.StylePriority.UseBackColor = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dpi = 254F;
            this.label11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UniqueSerialNumber]")});
            this.label11.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Bold);
            this.label11.LocationFloat = new DevExpress.Utils.PointFloat(41.90628F, 153.76F);
            this.label11.Name = "label11";
            this.label11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label11.SizeF = new System.Drawing.SizeF(222.2499F, 20.05547F);
            this.label11.StylePriority.UseBackColor = false;
            this.label11.StylePriority.UseFont = false;
            this.label11.WordWrap = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dpi = 254F;
            this.label10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MansAdress]")});
            this.label10.Font = new System.Drawing.Font("Times New Roman", 4F, System.Drawing.FontStyle.Bold);
            this.label10.LocationFloat = new DevExpress.Utils.PointFloat(41.90626F, 292.8496F);
            this.label10.Name = "label10";
            this.label10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label10.SizeF = new System.Drawing.SizeF(471.9791F, 26.82413F);
            this.label10.StylePriority.UseBackColor = false;
            this.label10.StylePriority.UseFont = false;
            this.label10.WordWrap = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dpi = 254F;
            this.label9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Manufacturer]")});
            this.label9.Font = new System.Drawing.Font("Times New Roman", 5.5F, System.Drawing.FontStyle.Bold);
            this.label9.LocationFloat = new DevExpress.Utils.PointFloat(41.90626F, 265.4712F);
            this.label9.Name = "label9";
            this.label9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label9.SizeF = new System.Drawing.SizeF(471.9791F, 27.37837F);
            this.label9.StylePriority.UseBackColor = false;
            this.label9.StylePriority.UseFont = false;
            this.label9.WordWrap = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dpi = 254F;
            this.label8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Origin]")});
            this.label8.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
            this.label8.LocationFloat = new DevExpress.Utils.PointFloat(41.90628F, 201.8397F);
            this.label8.Name = "label8";
            this.label8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label8.SizeF = new System.Drawing.SizeF(164.0414F, 24.02419F);
            this.label8.StylePriority.UseBackColor = false;
            this.label8.StylePriority.UseFont = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dpi = 254F;
            this.label7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductionDate]")});
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
            this.label7.LocationFloat = new DevExpress.Utils.PointFloat(41.90625F, 177.8155F);
            this.label7.Name = "label7";
            this.label7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label7.SizeF = new System.Drawing.SizeF(222.2499F, 24.02419F);
            this.label7.StylePriority.UseBackColor = false;
            this.label7.StylePriority.UseFont = false;
            this.label7.TextFormatString = "{0:d.M.yyyy}";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dpi = 254F;
            this.label4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MainFabricComp]")});
            this.label4.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Bold);
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(41.90628F, 236.7433F);
            this.label4.Name = "label4";
            this.label4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label4.SizeF = new System.Drawing.SizeF(478.8229F, 28.72789F);
            this.label4.StylePriority.UseBackColor = false;
            this.label4.StylePriority.UseFont = false;
            this.label4.WordWrap = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dpi = 254F;
            this.label3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")});
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(41.90625F, 117.1525F);
            this.label3.Name = "label3";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label3.SizeF = new System.Drawing.SizeF(222.2499F, 34.6075F);
            this.label3.StylePriority.UseBackColor = false;
            this.label3.StylePriority.UseFont = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dpi = 254F;
            this.label2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EAN]")});
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
            this.label2.LocationFloat = new DevExpress.Utils.PointFloat(41.90625F, 82.54496F);
            this.label2.Name = "label2";
            this.label2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label2.SizeF = new System.Drawing.SizeF(222.2499F, 34.60756F);
            this.label2.StylePriority.UseBackColor = false;
            this.label2.StylePriority.UseFont = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dpi = 254F;
            this.label1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Article]")});
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(41.90625F, 40F);
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.label1.SizeF = new System.Drawing.SizeF(222.2499F, 42.54502F);
            this.label1.StylePriority.UseBackColor = false;
            this.label1.StylePriority.UseFont = false;
            // 
            // barCode1
            // 
            this.barCode1.AutoModule = true;
            this.barCode1.BackColor = System.Drawing.Color.Transparent;
            this.barCode1.Dpi = 254F;
            this.barCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataMatrixCode]")});
            this.barCode1.LocationFloat = new DevExpress.Utils.PointFloat(264.1561F, 40F);
            this.barCode1.Module = 5.08F;
            this.barCode1.Name = "barCode1";
            this.barCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(25, 25, 0, 0, 254F);
            this.barCode1.ShowText = false;
            this.barCode1.SizeF = new System.Drawing.SizeF(256.5731F, 225.4712F);
            this.barCode1.StylePriority.UseBackColor = false;
            this.barCode1.Symbology = dataMatrixGS1Generator1;
            // 
            // XtraReport1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin});
            this.DataMember = "ReportTable";
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageHeight = 350;
            this.PageWidth = 1050;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.ScriptReferencesString = "C:\\Program Files (x86)\\Nebim\\V3\\NebimV3.UIWindowsForm.dll";
            this.ShowPrintMarginsWarning = false;
            this.ShowPrintStatusDialog = false;
            this.SnapGridSize = 31.75F;
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel label6;
        private DevExpress.XtraReports.UI.XRLabel label5;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox1;
        private DevExpress.XtraReports.UI.XRLabel label11;
        private DevExpress.XtraReports.UI.XRLabel label10;
        private DevExpress.XtraReports.UI.XRLabel label9;
        private DevExpress.XtraReports.UI.XRLabel label8;
        private DevExpress.XtraReports.UI.XRLabel label7;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.XRLabel label3;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRBarCode barCode1;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    }
}
