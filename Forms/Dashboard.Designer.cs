namespace HEMA_Program.Forms
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabpanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelRev = new System.Windows.Forms.Panel();
            this.tabpanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTripCons = new System.Windows.Forms.Panel();
            this.valueTripCons = new System.Windows.Forms.Label();
            this.lblTripCons = new System.Windows.Forms.Label();
            this.panelDistance = new System.Windows.Forms.Panel();
            this.valueDistance = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.panelFuel = new System.Windows.Forms.Panel();
            this.valueFuel = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.tabpanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTotalCons = new System.Windows.Forms.Panel();
            this.valueTotalCons = new System.Windows.Forms.Label();
            this.lblTotalCons = new System.Windows.Forms.Label();
            this.panelInstantCons = new System.Windows.Forms.Panel();
            this.valueInstantCons = new System.Windows.Forms.Label();
            this.lblInstantCons = new System.Windows.Forms.Label();
            this.panelFuelHour = new System.Windows.Forms.Panel();
            this.valueFuelHour = new System.Windows.Forms.Label();
            this.lblFueHour = new System.Windows.Forms.Label();
            this.gaugeRev = new System.Windows.Forms.AGauge();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.lblLoad = new System.Windows.Forms.Label();
            this.panelTemp = new System.Windows.Forms.Panel();
            this.lblTemp = new System.Windows.Forms.Label();
            this.pbarTemp = new HEMA_Program.VerticalProgressBar();
            this.pbarLoad = new HEMA_Program.VerticalProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gaugeSpeed = new System.Windows.Forms.AGauge();
            this.valRev = new System.Windows.Forms.Label();
            this.lblRev = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.valSpeed = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.tabpanel3.SuspendLayout();
            this.panelRev.SuspendLayout();
            this.tabpanel2.SuspendLayout();
            this.panelTripCons.SuspendLayout();
            this.panelDistance.SuspendLayout();
            this.panelFuel.SuspendLayout();
            this.tabpanel1.SuspendLayout();
            this.panelTotalCons.SuspendLayout();
            this.panelInstantCons.SuspendLayout();
            this.panelFuelHour.SuspendLayout();
            this.panelLoad.SuspendLayout();
            this.panelTemp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.tabpanel3);
            this.panelMain.Controls.Add(this.tabpanel2);
            this.panelMain.Controls.Add(this.tabpanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(604, 456);
            this.panelMain.TabIndex = 0;
            // 
            // tabpanel3
            // 
            this.tabpanel3.ColumnCount = 4;
            this.tabpanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tabpanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabpanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tabpanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tabpanel3.Controls.Add(this.panelTemp, 0, 0);
            this.tabpanel3.Controls.Add(this.panelLoad, 0, 0);
            this.tabpanel3.Controls.Add(this.panelRev, 0, 0);
            this.tabpanel3.Controls.Add(this.panel1, 3, 0);
            this.tabpanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpanel3.Location = new System.Drawing.Point(0, 200);
            this.tabpanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tabpanel3.Name = "tabpanel3";
            this.tabpanel3.RowCount = 1;
            this.tabpanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanel3.Size = new System.Drawing.Size(600, 252);
            this.tabpanel3.TabIndex = 2;
            // 
            // panelRev
            // 
            this.panelRev.Controls.Add(this.lblRev);
            this.panelRev.Controls.Add(this.valRev);
            this.panelRev.Controls.Add(this.gaugeRev);
            this.panelRev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRev.Location = new System.Drawing.Point(0, 0);
            this.panelRev.Margin = new System.Windows.Forms.Padding(0);
            this.panelRev.Name = "panelRev";
            this.panelRev.Size = new System.Drawing.Size(240, 252);
            this.panelRev.TabIndex = 10;
            // 
            // tabpanel2
            // 
            this.tabpanel2.ColumnCount = 3;
            this.tabpanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabpanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabpanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabpanel2.Controls.Add(this.panelTripCons, 0, 0);
            this.tabpanel2.Controls.Add(this.panelDistance, 1, 0);
            this.tabpanel2.Controls.Add(this.panelFuel, 2, 0);
            this.tabpanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabpanel2.Location = new System.Drawing.Point(0, 100);
            this.tabpanel2.Name = "tabpanel2";
            this.tabpanel2.Padding = new System.Windows.Forms.Padding(5);
            this.tabpanel2.RowCount = 1;
            this.tabpanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanel2.Size = new System.Drawing.Size(600, 100);
            this.tabpanel2.TabIndex = 1;
            // 
            // panelTripCons
            // 
            this.panelTripCons.Controls.Add(this.valueTripCons);
            this.panelTripCons.Controls.Add(this.lblTripCons);
            this.panelTripCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTripCons.Location = new System.Drawing.Point(8, 8);
            this.panelTripCons.Name = "panelTripCons";
            this.panelTripCons.Size = new System.Drawing.Size(190, 84);
            this.panelTripCons.TabIndex = 0;
            // 
            // valueTripCons
            // 
            this.valueTripCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueTripCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.valueTripCons.Location = new System.Drawing.Point(0, 23);
            this.valueTripCons.Name = "valueTripCons";
            this.valueTripCons.Size = new System.Drawing.Size(190, 61);
            this.valueTripCons.TabIndex = 1;
            this.valueTripCons.Text = "label4";
            this.valueTripCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTripCons
            // 
            this.lblTripCons.BackColor = System.Drawing.Color.Gray;
            this.lblTripCons.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTripCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTripCons.ForeColor = System.Drawing.Color.White;
            this.lblTripCons.Location = new System.Drawing.Point(0, 0);
            this.lblTripCons.Name = "lblTripCons";
            this.lblTripCons.Size = new System.Drawing.Size(190, 23);
            this.lblTripCons.TabIndex = 0;
            this.lblTripCons.Text = "Trip l/100 Km";
            this.lblTripCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDistance
            // 
            this.panelDistance.Controls.Add(this.valueDistance);
            this.panelDistance.Controls.Add(this.lblDistance);
            this.panelDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDistance.Location = new System.Drawing.Point(204, 8);
            this.panelDistance.Name = "panelDistance";
            this.panelDistance.Size = new System.Drawing.Size(190, 84);
            this.panelDistance.TabIndex = 1;
            // 
            // valueDistance
            // 
            this.valueDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.valueDistance.Location = new System.Drawing.Point(0, 23);
            this.valueDistance.Name = "valueDistance";
            this.valueDistance.Size = new System.Drawing.Size(190, 61);
            this.valueDistance.TabIndex = 1;
            this.valueDistance.Text = "label5";
            this.valueDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistance
            // 
            this.lblDistance.BackColor = System.Drawing.Color.Gray;
            this.lblDistance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDistance.ForeColor = System.Drawing.Color.White;
            this.lblDistance.Location = new System.Drawing.Point(0, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(190, 23);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Distance";
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFuel
            // 
            this.panelFuel.Controls.Add(this.valueFuel);
            this.panelFuel.Controls.Add(this.lblFuel);
            this.panelFuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFuel.Location = new System.Drawing.Point(400, 8);
            this.panelFuel.Name = "panelFuel";
            this.panelFuel.Size = new System.Drawing.Size(192, 84);
            this.panelFuel.TabIndex = 2;
            // 
            // valueFuel
            // 
            this.valueFuel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.valueFuel.Location = new System.Drawing.Point(0, 23);
            this.valueFuel.Name = "valueFuel";
            this.valueFuel.Size = new System.Drawing.Size(192, 61);
            this.valueFuel.TabIndex = 1;
            this.valueFuel.Text = "label6";
            this.valueFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuel
            // 
            this.lblFuel.BackColor = System.Drawing.Color.Gray;
            this.lblFuel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFuel.ForeColor = System.Drawing.Color.White;
            this.lblFuel.Location = new System.Drawing.Point(0, 0);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(192, 23);
            this.lblFuel.TabIndex = 0;
            this.lblFuel.Text = "Fuel (lt)";
            this.lblFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabpanel1
            // 
            this.tabpanel1.ColumnCount = 3;
            this.tabpanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabpanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabpanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabpanel1.Controls.Add(this.panelTotalCons, 0, 0);
            this.tabpanel1.Controls.Add(this.panelInstantCons, 1, 0);
            this.tabpanel1.Controls.Add(this.panelFuelHour, 2, 0);
            this.tabpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabpanel1.Location = new System.Drawing.Point(0, 0);
            this.tabpanel1.Name = "tabpanel1";
            this.tabpanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tabpanel1.RowCount = 1;
            this.tabpanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanel1.Size = new System.Drawing.Size(600, 100);
            this.tabpanel1.TabIndex = 0;
            // 
            // panelTotalCons
            // 
            this.panelTotalCons.Controls.Add(this.valueTotalCons);
            this.panelTotalCons.Controls.Add(this.lblTotalCons);
            this.panelTotalCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalCons.Location = new System.Drawing.Point(8, 8);
            this.panelTotalCons.Name = "panelTotalCons";
            this.panelTotalCons.Size = new System.Drawing.Size(190, 84);
            this.panelTotalCons.TabIndex = 0;
            // 
            // valueTotalCons
            // 
            this.valueTotalCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueTotalCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.valueTotalCons.Location = new System.Drawing.Point(0, 23);
            this.valueTotalCons.Name = "valueTotalCons";
            this.valueTotalCons.Size = new System.Drawing.Size(190, 61);
            this.valueTotalCons.TabIndex = 1;
            this.valueTotalCons.Text = "label1";
            this.valueTotalCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCons
            // 
            this.lblTotalCons.BackColor = System.Drawing.Color.Gray;
            this.lblTotalCons.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCons.ForeColor = System.Drawing.Color.White;
            this.lblTotalCons.Location = new System.Drawing.Point(0, 0);
            this.lblTotalCons.Name = "lblTotalCons";
            this.lblTotalCons.Size = new System.Drawing.Size(190, 23);
            this.lblTotalCons.TabIndex = 0;
            this.lblTotalCons.Text = "Total l/100 Km";
            this.lblTotalCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInstantCons
            // 
            this.panelInstantCons.Controls.Add(this.valueInstantCons);
            this.panelInstantCons.Controls.Add(this.lblInstantCons);
            this.panelInstantCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInstantCons.Location = new System.Drawing.Point(204, 8);
            this.panelInstantCons.Name = "panelInstantCons";
            this.panelInstantCons.Size = new System.Drawing.Size(190, 84);
            this.panelInstantCons.TabIndex = 1;
            // 
            // valueInstantCons
            // 
            this.valueInstantCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueInstantCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.valueInstantCons.Location = new System.Drawing.Point(0, 23);
            this.valueInstantCons.Name = "valueInstantCons";
            this.valueInstantCons.Size = new System.Drawing.Size(190, 61);
            this.valueInstantCons.TabIndex = 1;
            this.valueInstantCons.Text = "label2";
            this.valueInstantCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstantCons
            // 
            this.lblInstantCons.BackColor = System.Drawing.Color.Gray;
            this.lblInstantCons.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstantCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInstantCons.ForeColor = System.Drawing.Color.White;
            this.lblInstantCons.Location = new System.Drawing.Point(0, 0);
            this.lblInstantCons.Name = "lblInstantCons";
            this.lblInstantCons.Size = new System.Drawing.Size(190, 23);
            this.lblInstantCons.TabIndex = 0;
            this.lblInstantCons.Text = "Instant l/100 Km";
            this.lblInstantCons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFuelHour
            // 
            this.panelFuelHour.Controls.Add(this.valueFuelHour);
            this.panelFuelHour.Controls.Add(this.lblFueHour);
            this.panelFuelHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFuelHour.Location = new System.Drawing.Point(400, 8);
            this.panelFuelHour.Name = "panelFuelHour";
            this.panelFuelHour.Size = new System.Drawing.Size(192, 84);
            this.panelFuelHour.TabIndex = 2;
            // 
            // valueFuelHour
            // 
            this.valueFuelHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueFuelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.valueFuelHour.Location = new System.Drawing.Point(0, 23);
            this.valueFuelHour.Name = "valueFuelHour";
            this.valueFuelHour.Size = new System.Drawing.Size(192, 61);
            this.valueFuelHour.TabIndex = 1;
            this.valueFuelHour.Text = "label3";
            this.valueFuelHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFueHour
            // 
            this.lblFueHour.BackColor = System.Drawing.Color.Gray;
            this.lblFueHour.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFueHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFueHour.ForeColor = System.Drawing.Color.White;
            this.lblFueHour.Location = new System.Drawing.Point(0, 0);
            this.lblFueHour.Name = "lblFueHour";
            this.lblFueHour.Size = new System.Drawing.Size(192, 23);
            this.lblFueHour.TabIndex = 0;
            this.lblFueHour.Text = "Fuel (lt/hr)";
            this.lblFueHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gaugeRev
            // 
            this.gaugeRev.BaseArcColor = System.Drawing.Color.Gray;
            this.gaugeRev.BaseArcRadius = 80;
            this.gaugeRev.BaseArcStart = 135;
            this.gaugeRev.BaseArcSweep = 270;
            this.gaugeRev.BaseArcWidth = 2;
            this.gaugeRev.Center = new System.Drawing.Point(100, 100);
            this.gaugeRev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeRev.Location = new System.Drawing.Point(0, 0);
            this.gaugeRev.Margin = new System.Windows.Forms.Padding(0);
            this.gaugeRev.MaxValue = 9F;
            this.gaugeRev.MinValue = 0F;
            this.gaugeRev.Name = "gaugeRev";
            this.gaugeRev.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.gaugeRev.NeedleColor2 = System.Drawing.Color.Red;
            this.gaugeRev.NeedleRadius = 70;
            this.gaugeRev.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.gaugeRev.NeedleWidth = 2;
            this.gaugeRev.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaugeRev.ScaleLinesInterInnerRadius = 73;
            this.gaugeRev.ScaleLinesInterOuterRadius = 80;
            this.gaugeRev.ScaleLinesInterWidth = 1;
            this.gaugeRev.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaugeRev.ScaleLinesMajorInnerRadius = 70;
            this.gaugeRev.ScaleLinesMajorOuterRadius = 80;
            this.gaugeRev.ScaleLinesMajorStepValue = 1F;
            this.gaugeRev.ScaleLinesMajorWidth = 2;
            this.gaugeRev.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaugeRev.ScaleLinesMinorInnerRadius = 75;
            this.gaugeRev.ScaleLinesMinorOuterRadius = 80;
            this.gaugeRev.ScaleLinesMinorTicks = 9;
            this.gaugeRev.ScaleLinesMinorWidth = 1;
            this.gaugeRev.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaugeRev.ScaleNumbersFormat = null;
            this.gaugeRev.ScaleNumbersRadius = 95;
            this.gaugeRev.ScaleNumbersRotation = 0;
            this.gaugeRev.ScaleNumbersStartScaleLine = 0;
            this.gaugeRev.ScaleNumbersStepScaleLines = 1;
            this.gaugeRev.Size = new System.Drawing.Size(240, 252);
            this.gaugeRev.TabIndex = 1;
            this.gaugeRev.Value = 1.254F;
            // 
            // panelLoad
            // 
            this.panelLoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLoad.Controls.Add(this.lblLoad);
            this.panelLoad.Controls.Add(this.pbarLoad);
            this.panelLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoad.Location = new System.Drawing.Point(243, 3);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(54, 246);
            this.panelLoad.TabIndex = 12;
            // 
            // lblLoad
            // 
            this.lblLoad.BackColor = System.Drawing.Color.Gray;
            this.lblLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoad.ForeColor = System.Drawing.Color.White;
            this.lblLoad.Location = new System.Drawing.Point(0, 0);
            this.lblLoad.Margin = new System.Windows.Forms.Padding(0);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(50, 42);
            this.lblLoad.TabIndex = 1;
            this.lblLoad.Text = "Load";
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTemp
            // 
            this.panelTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTemp.Controls.Add(this.lblTemp);
            this.panelTemp.Controls.Add(this.pbarTemp);
            this.panelTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTemp.Location = new System.Drawing.Point(303, 3);
            this.panelTemp.Name = "panelTemp";
            this.panelTemp.Size = new System.Drawing.Size(54, 246);
            this.panelTemp.TabIndex = 13;
            // 
            // lblTemp
            // 
            this.lblTemp.BackColor = System.Drawing.Color.Gray;
            this.lblTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(0, 0);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(50, 42);
            this.lblTemp.TabIndex = 1;
            this.lblTemp.Text = "Temp";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbarTemp
            // 
            this.pbarTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbarTemp.Location = new System.Drawing.Point(0, 0);
            this.pbarTemp.Margin = new System.Windows.Forms.Padding(0);
            this.pbarTemp.Maximum = 200;
            this.pbarTemp.Name = "pbarTemp";
            this.pbarTemp.Size = new System.Drawing.Size(50, 242);
            this.pbarTemp.TabIndex = 0;
            this.pbarTemp.Value = 80;
            // 
            // pbarLoad
            // 
            this.pbarLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbarLoad.Location = new System.Drawing.Point(0, 0);
            this.pbarLoad.Margin = new System.Windows.Forms.Padding(0);
            this.pbarLoad.Name = "pbarLoad";
            this.pbarLoad.Size = new System.Drawing.Size(50, 242);
            this.pbarLoad.TabIndex = 0;
            this.pbarLoad.Value = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Controls.Add(this.valSpeed);
            this.panel1.Controls.Add(this.gaugeSpeed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(360, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 252);
            this.panel1.TabIndex = 14;
            // 
            // gaugeSpeed
            // 
            this.gaugeSpeed.BaseArcColor = System.Drawing.Color.Gray;
            this.gaugeSpeed.BaseArcRadius = 80;
            this.gaugeSpeed.BaseArcStart = 135;
            this.gaugeSpeed.BaseArcSweep = 270;
            this.gaugeSpeed.BaseArcWidth = 2;
            this.gaugeSpeed.Center = new System.Drawing.Point(100, 100);
            this.gaugeSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeSpeed.Location = new System.Drawing.Point(0, 0);
            this.gaugeSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.gaugeSpeed.MaxValue = 300F;
            this.gaugeSpeed.MinValue = 0F;
            this.gaugeSpeed.Name = "gaugeSpeed";
            this.gaugeSpeed.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Red;
            this.gaugeSpeed.NeedleColor2 = System.Drawing.Color.Red;
            this.gaugeSpeed.NeedleRadius = 70;
            this.gaugeSpeed.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.gaugeSpeed.NeedleWidth = 2;
            this.gaugeSpeed.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaugeSpeed.ScaleLinesInterInnerRadius = 73;
            this.gaugeSpeed.ScaleLinesInterOuterRadius = 80;
            this.gaugeSpeed.ScaleLinesInterWidth = 1;
            this.gaugeSpeed.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaugeSpeed.ScaleLinesMajorInnerRadius = 70;
            this.gaugeSpeed.ScaleLinesMajorOuterRadius = 80;
            this.gaugeSpeed.ScaleLinesMajorStepValue = 30F;
            this.gaugeSpeed.ScaleLinesMajorWidth = 2;
            this.gaugeSpeed.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.gaugeSpeed.ScaleLinesMinorInnerRadius = 75;
            this.gaugeSpeed.ScaleLinesMinorOuterRadius = 80;
            this.gaugeSpeed.ScaleLinesMinorTicks = 9;
            this.gaugeSpeed.ScaleLinesMinorWidth = 1;
            this.gaugeSpeed.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaugeSpeed.ScaleNumbersFormat = null;
            this.gaugeSpeed.ScaleNumbersRadius = 95;
            this.gaugeSpeed.ScaleNumbersRotation = 0;
            this.gaugeSpeed.ScaleNumbersStartScaleLine = 0;
            this.gaugeSpeed.ScaleNumbersStepScaleLines = 1;
            this.gaugeSpeed.Size = new System.Drawing.Size(240, 252);
            this.gaugeSpeed.TabIndex = 17;
            this.gaugeSpeed.Value = 80F;
            // 
            // valRev
            // 
            this.valRev.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.valRev.Location = new System.Drawing.Point(0, 216);
            this.valRev.Name = "valRev";
            this.valRev.Size = new System.Drawing.Size(240, 36);
            this.valRev.TabIndex = 2;
            this.valRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRev
            // 
            this.lblRev.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRev.Location = new System.Drawing.Point(0, 180);
            this.lblRev.Name = "lblRev";
            this.lblRev.Size = new System.Drawing.Size(240, 36);
            this.lblRev.TabIndex = 3;
            this.lblRev.Text = "RPM x 1000";
            this.lblRev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSpeed.Location = new System.Drawing.Point(0, 180);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(240, 36);
            this.lblSpeed.TabIndex = 19;
            this.lblSpeed.Text = "KMH";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valSpeed
            // 
            this.valSpeed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.valSpeed.Location = new System.Drawing.Point(0, 216);
            this.valSpeed.Name = "valSpeed";
            this.valSpeed.Size = new System.Drawing.Size(240, 36);
            this.valSpeed.TabIndex = 18;
            this.valSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 456);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panelMain.ResumeLayout(false);
            this.tabpanel3.ResumeLayout(false);
            this.panelRev.ResumeLayout(false);
            this.tabpanel2.ResumeLayout(false);
            this.panelTripCons.ResumeLayout(false);
            this.panelDistance.ResumeLayout(false);
            this.panelFuel.ResumeLayout(false);
            this.tabpanel1.ResumeLayout(false);
            this.panelTotalCons.ResumeLayout(false);
            this.panelInstantCons.ResumeLayout(false);
            this.panelFuelHour.ResumeLayout(false);
            this.panelLoad.ResumeLayout(false);
            this.panelTemp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tabpanel2;
        private System.Windows.Forms.Panel panelTripCons;
        private System.Windows.Forms.Panel panelDistance;
        private System.Windows.Forms.Panel panelFuel;
        private System.Windows.Forms.TableLayoutPanel tabpanel1;
        private System.Windows.Forms.Panel panelTotalCons;
        private System.Windows.Forms.Panel panelInstantCons;
        private System.Windows.Forms.Panel panelFuelHour;
        private System.Windows.Forms.Label lblTripCons;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblTotalCons;
        private System.Windows.Forms.Label lblInstantCons;
        private System.Windows.Forms.Label lblFueHour;
        private System.Windows.Forms.Label valueTripCons;
        private System.Windows.Forms.Label valueDistance;
        private System.Windows.Forms.Label valueFuel;
        private System.Windows.Forms.Label valueTotalCons;
        private System.Windows.Forms.Label valueInstantCons;
        private System.Windows.Forms.Label valueFuelHour;
        private System.Windows.Forms.TableLayoutPanel tabpanel3;
        private System.Windows.Forms.Panel panelRev;
        private System.Windows.Forms.AGauge gaugeRev;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Label lblLoad;
        private VerticalProgressBar pbarLoad;
        private System.Windows.Forms.Panel panelTemp;
        private System.Windows.Forms.Label lblTemp;
        private VerticalProgressBar pbarTemp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.AGauge gaugeSpeed;
        private System.Windows.Forms.Label lblRev;
        private System.Windows.Forms.Label valRev;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label valSpeed;
    }
}