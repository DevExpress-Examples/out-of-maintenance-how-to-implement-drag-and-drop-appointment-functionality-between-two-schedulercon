Namespace S173638
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler4 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.schedulerControl2 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage2 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            DirectCast(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerSplitContainerControl.SuspendLayout()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerSplitContainerControl
            ' 
            Me.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.schedulerSplitContainerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl"
            Me.schedulerSplitContainerControl.Panel1.Controls.Add(Me.schedulerControl1)
            Me.schedulerSplitContainerControl.Panel1.Text = "Panel1"
            Me.schedulerSplitContainerControl.Panel2.Controls.Add(Me.schedulerControl2)
            Me.schedulerSplitContainerControl.Panel2.Text = "Panel2"
            Me.schedulerSplitContainerControl.Size = New System.Drawing.Size(1088, 700)
            Me.schedulerSplitContainerControl.SplitterPosition = 542
            Me.schedulerSplitContainerControl.TabIndex = 2
            Me.schedulerSplitContainerControl.Text = "splitContainerControl1"
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(541, 700)
            Me.schedulerControl1.Start = New Date(2014, 11, 28, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.ShowWorkTimeOnly = True
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' schedulerStorage1
            ' 
            ' 
            ' schedulerControl2
            ' 
            Me.schedulerControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl2.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl2.Name = "schedulerControl2"
            Me.schedulerControl2.Size = New System.Drawing.Size(542, 700)
            Me.schedulerControl2.Start = New Date(2014, 11, 28, 0, 0, 0, 0)
            Me.schedulerControl2.Storage = Me.schedulerStorage2
            Me.schedulerControl2.TabIndex = 1
            Me.schedulerControl2.Text = "schedulerControl1"
            Me.schedulerControl2.Views.DayView.ShowWorkTimeOnly = True
            Me.schedulerControl2.Views.DayView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl2.Views.WorkWeekView.TimeRulers.Add(timeRuler4)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1088, 700)
            Me.Controls.Add(Me.schedulerSplitContainerControl)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerSplitContainerControl.ResumeLayout(False)
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerControl2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private schedulerSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
        Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private WithEvents schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private WithEvents schedulerControl2 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage2 As DevExpress.XtraScheduler.SchedulerStorage

    End Class
End Namespace
