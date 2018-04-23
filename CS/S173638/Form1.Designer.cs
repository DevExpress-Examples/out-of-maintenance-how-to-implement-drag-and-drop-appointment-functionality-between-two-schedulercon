namespace S173638
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.schedulerControl2 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage2 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl)).BeginInit();
            this.schedulerSplitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage2)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerSplitContainerControl
            // 
            this.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.schedulerSplitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl";
            this.schedulerSplitContainerControl.Panel1.Controls.Add(this.schedulerControl1);
            this.schedulerSplitContainerControl.Panel1.Text = "Panel1";
            this.schedulerSplitContainerControl.Panel2.Controls.Add(this.schedulerControl2);
            this.schedulerSplitContainerControl.Panel2.Text = "Panel2";
            this.schedulerSplitContainerControl.Size = new System.Drawing.Size(1088, 700);
            this.schedulerSplitContainerControl.SplitterPosition = 542;
            this.schedulerSplitContainerControl.TabIndex = 2;
            this.schedulerSplitContainerControl.Text = "splitContainerControl1";
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(541, 700);
            this.schedulerControl1.Start = new System.DateTime(2014, 11, 28, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.ShowWorkTimeOnly = true;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.SelectionChanged += new System.EventHandler(this.schedulerControl1_SelectionChanged);
            this.schedulerControl1.AppointmentDrag += new DevExpress.XtraScheduler.AppointmentDragEventHandler(this.schedulerControl1_AppointmentDrag);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.AppointmentChanging += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerStorage1_AppointmentChanging);
            this.schedulerStorage1.AppointmentDeleting += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerStorage1_AppointmentDeleting);
            // 
            // schedulerControl2
            // 
            this.schedulerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl2.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl2.Name = "schedulerControl2";
            this.schedulerControl2.Size = new System.Drawing.Size(542, 700);
            this.schedulerControl2.Start = new System.DateTime(2014, 11, 28, 0, 0, 0, 0);
            this.schedulerControl2.Storage = this.schedulerStorage2;
            this.schedulerControl2.TabIndex = 1;
            this.schedulerControl2.Text = "schedulerControl1";
            this.schedulerControl2.Views.DayView.ShowWorkTimeOnly = true;
            this.schedulerControl2.Views.DayView.TimeRulers.Add(timeRuler3);
            this.schedulerControl2.Views.WorkWeekView.TimeRulers.Add(timeRuler4);
            this.schedulerControl2.SelectionChanged += new System.EventHandler(this.schedulerControl2_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 700);
            this.Controls.Add(this.schedulerSplitContainerControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerSplitContainerControl)).EndInit();
            this.schedulerSplitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl schedulerSplitContainerControl;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl2;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage2;

    }
}
