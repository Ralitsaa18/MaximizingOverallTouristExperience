namespace MaximizingOverallTouristExperience
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtSpotName = new System.Windows.Forms.TextBox();
            this.btnAddSpot = new System.Windows.Forms.Button();
            this.btnShortestRoute = new System.Windows.Forms.Button();
            this.btnAlternativeRoute = new System.Windows.Forms.Button();
            this.lblStartingPoint = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.txtStartingPoint = new System.Windows.Forms.TextBox();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 42);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(776, 426);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 7D;
            // 
            // txtSpotName
            // 
            this.txtSpotName.Location = new System.Drawing.Point(12, 12);
            this.txtSpotName.Name = "txtSpotName";
            this.txtSpotName.Size = new System.Drawing.Size(200, 20);
            this.txtSpotName.TabIndex = 1;
            // 
            // btnAddSpot
            // 
            this.btnAddSpot.Location = new System.Drawing.Point(218, 10);
            this.btnAddSpot.Name = "btnAddSpot";
            this.btnAddSpot.Size = new System.Drawing.Size(75, 23);
            this.btnAddSpot.TabIndex = 2;
            this.btnAddSpot.Text = "Добави";
            this.btnAddSpot.UseVisualStyleBackColor = true;
            this.btnAddSpot.Click += new System.EventHandler(this.btnAddSpot_Click);
            // 
            // btnShortestRoute
            // 
            this.btnShortestRoute.Location = new System.Drawing.Point(12, 474);
            this.btnShortestRoute.Name = "btnShortestRoute";
            this.btnShortestRoute.Size = new System.Drawing.Size(96, 23);
            this.btnShortestRoute.TabIndex = 3;
            this.btnShortestRoute.Text = "Най-кратък маршрут";
            this.btnShortestRoute.UseVisualStyleBackColor = true;
            this.btnShortestRoute.Click += new System.EventHandler(this.btnShortestRoute_Click);
            // 
            // btnAlternativeRoute
            // 
            this.btnAlternativeRoute.Location = new System.Drawing.Point(114, 474);
            this.btnAlternativeRoute.Name = "btnAlternativeRoute";
            this.btnAlternativeRoute.Size = new System.Drawing.Size(113, 23);
            this.btnAlternativeRoute.TabIndex = 4;
            this.btnAlternativeRoute.Text = "Алтернативен маршрут";
            this.btnAlternativeRoute.UseVisualStyleBackColor = true;
            this.btnAlternativeRoute.Click += new System.EventHandler(this.btnAlternativeRoute_Click);
            // 
            // lblStartingPoint
            // 
            this.lblStartingPoint.AutoSize = true;
            this.lblStartingPoint.Location = new System.Drawing.Point(315, 15);
            this.lblStartingPoint.Name = "lblStartingPoint";
            this.lblStartingPoint.Size = new System.Drawing.Size(92, 13);
            this.lblStartingPoint.TabIndex = 5;
            this.lblStartingPoint.Text = "Начална точка:";
            // 
            // txtStartingPoint
            // 
            this.txtStartingPoint.Location = new System.Drawing.Point(413, 12);
            this.txtStartingPoint.Name = "txtStartingPoint";
            this.txtStartingPoint.ReadOnly = true;
            this.txtStartingPoint.Size = new System.Drawing.Size(200, 20);
            this.txtStartingPoint.TabIndex = 6;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Location = new System.Drawing.Point(315, 474);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(56, 13);
            this.lblRoute.TabIndex = 7;
            this.lblRoute.Text = "Маршрут:";
            // 
            // txtRoute
            // 
            this.txtRoute.Location = new System.Drawing.Point(377, 471);
            this.txtRoute.Multiline = true;
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.ReadOnly = true;
            this.txtRoute.Size = new System.Drawing.Size(411, 23);
            this.txtRoute.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.txtRoute);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.txtStartingPoint);
            this.Controls.Add(this.lblStartingPoint);
            this.Controls.Add(this.btnAlternativeRoute);
            this.Controls.Add(this.btnShortestRoute);
            this.Controls.Add(this.btnAddSpot);
            this.Controls.Add(this.txtSpotName);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Form1";
            this.Text = "Tourist Experience Optimizer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox txtSpotName;
        private System.Windows.Forms.Button btnAddSpot;
        private System.Windows.Forms.Button btnShortestRoute;
        private System.Windows.Forms.Button btnAlternativeRoute;
        private System.Windows.Forms.Label lblStartingPoint;
        private System.Windows.Forms.TextBox txtStartingPoint;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.TextBox txtRoute;

        #endregion
    }
}
