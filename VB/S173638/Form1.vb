Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraScheduler


Namespace S173638
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            schedulerControl1.Start = Date.Now
            schedulerControl2.Start = Date.Now
            schedulerStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("Test", "test"))
            InitResources(schedulerStorage1)
            InitAppointments(schedulerStorage1)
            schedulerControl1.GroupType = SchedulerGroupType.Resource
            schedulerControl2.GroupType = SchedulerGroupType.Resource
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            For Each mapping As AppointmentCustomFieldMapping In schedulerStorage1.Appointments.CustomFieldMappings
                schedulerStorage2.Appointments.CustomFieldMappings.Add(mapping)
            Next mapping
        End Sub
        Private Sub InitResources(ByVal storage As SchedulerStorage)
            For i As Integer = 0 To 4
                storage.Resources.Add(New Resource(i, "Resource" & i))
            Next i
        End Sub
        Private Sub InitAppointments(ByVal storage As SchedulerStorage)
            For i As Integer = 0 To storage.Resources.Count - 1

                Dim resource As Resource = storage.Resources(i)
                Dim subj As String = resource.Caption & "'s "
                Dim appointment1 As New Appointment(AppointmentType.Normal, Date.Today.AddHours(i + 10), Date.Today.AddHours(i + 11), subj & "birthday") With {.LabelId = 8, .StatusId = 3, .ResourceId = i}
                storage.Appointments.Add(appointment1)
                appointment1.CustomFields("Test") = "Appointment text1_" & i

                Dim appointment2 As New Appointment(AppointmentType.Normal, Date.Today.AddHours(i + 13), Date.Today.AddHours(i + 14), subj & "meeting") With {.LabelId = 2, .StatusId = 2, .ResourceId = i}
                storage.Appointments.Add(appointment2)
                appointment2.CustomFields("Test") = "Appointment text2_" & i

                Dim appointment3 As New Appointment(AppointmentType.Normal, Date.Today.AddHours(i + 15), Date.Today.AddHours(i + 16), subj & "phone call") With {.LabelId = 10, .StatusId = 0, .ResourceId = i}
                storage.Appointments.Add(appointment3)
                appointment3.CustomFields("Test") = "Appointment text3_" & i

            Next i
        End Sub
        Private isDragging As Boolean = False
        Private Sub schedulerControl1_AppointmentDrag(ByVal sender As Object, ByVal e As AppointmentDragEventArgs) Handles schedulerControl1.AppointmentDrag
            isDragging = True
        End Sub

        Private Sub schedulerStorage1_AppointmentChanging(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs) Handles schedulerStorage1.AppointmentChanging
            isDragging = False
        End Sub
        Private Sub schedulerStorage1_AppointmentDeleting(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs) Handles schedulerStorage1.AppointmentDeleting
            If isDragging Then
                e.Cancel = True
                isDragging = False
            End If
        End Sub

        Private Sub schedulerControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl1.SelectionChanged
            If schedulerControl1.SelectedAppointments.Count > 0 Then
                If schedulerControl1.SelectedAppointments(0).CustomFields("Test") IsNot Nothing Then
                    Text = "Custom field value: " & schedulerControl1.SelectedAppointments(0).CustomFields("Test").ToString()
                Else
                    Text = " custom field is empty"
                End If
            End If
        End Sub

        Private Sub schedulerControl2_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl2.SelectionChanged
            If schedulerControl2.SelectedAppointments.Count > 0 Then
                If schedulerControl2.SelectedAppointments(0).CustomFields("Test") IsNot Nothing Then
                    Text = "Custom field value: " & schedulerControl2.SelectedAppointments(0).CustomFields("Test").ToString()
                Else
                    Text = " custom field is empty"
                End If
            End If
        End Sub
    End Class
End Namespace