using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraScheduler;


namespace S173638
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            schedulerControl1.Start = System.DateTime.Now;
            schedulerControl2.Start = System.DateTime.Now;
            schedulerStorage1.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Test", "test"));
            InitResources(schedulerStorage1);
            InitAppointments(schedulerStorage1);
            schedulerControl1.GroupType = SchedulerGroupType.Resource;
            schedulerControl2.GroupType = SchedulerGroupType.Resource;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (AppointmentCustomFieldMapping mapping in schedulerStorage1.Appointments.CustomFieldMappings)
                schedulerStorage2.Appointments.CustomFieldMappings.Add(mapping);
        }
        private void InitResources(SchedulerStorage storage)
        {
            for (int i = 0; i < 5; i++)
            {
                storage.Resources.Add(new Resource(i, "Resource" + i));
            }
        }
        private void InitAppointments(SchedulerStorage storage)
        {
            for (int i = 0; i < storage.Resources.Count; i++)
            {
                
                Resource resource = storage.Resources[i];
                string subj = resource.Caption + "'s ";
                Appointment appointment1 = new Appointment(AppointmentType.Normal, DateTime.Today.AddHours(i + 10), DateTime.Today.AddHours(i + 11), subj + "birthday") { LabelId = 8, StatusId = 3, ResourceId = i };
                storage.Appointments.Add(appointment1);
                appointment1.CustomFields["Test"] = "Appointment text1_"+i;

                Appointment appointment2 = new Appointment(AppointmentType.Normal, DateTime.Today.AddHours(i + 13), DateTime.Today.AddHours(i + 14), subj + "meeting") { LabelId = 2, StatusId = 2, ResourceId = i };
                storage.Appointments.Add(appointment2);
                appointment2.CustomFields["Test"] = "Appointment text2_"+i;

                Appointment appointment3 = new Appointment(AppointmentType.Normal, DateTime.Today.AddHours(i + 15), DateTime.Today.AddHours(i + 16), subj + "phone call") { LabelId = 10, StatusId = 0, ResourceId = i };
                storage.Appointments.Add(appointment3);
                appointment3.CustomFields["Test"] = "Appointment text3_"+i;

            }
        }
        bool isDragging = false;
        private void schedulerControl1_AppointmentDrag(object sender, AppointmentDragEventArgs e)
        {
            isDragging = true;
        }

        private void schedulerStorage1_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e)
        {
            isDragging = false;
        }
        private void schedulerStorage1_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            if (isDragging)
            {
                e.Cancel = true;
                isDragging = false;
            }
        }

        private void schedulerControl1_SelectionChanged(object sender, EventArgs e)
        {
            if (schedulerControl1.SelectedAppointments.Count > 0)
            {
                if (schedulerControl1.SelectedAppointments[0].CustomFields["Test"] != null)
                    Text = "Custom field value: " + schedulerControl1.SelectedAppointments[0].CustomFields["Test"].ToString();
                else
                    Text = " custom field is empty";
            }
        }

        private void schedulerControl2_SelectionChanged(object sender, EventArgs e)
        {
            if (schedulerControl2.SelectedAppointments.Count > 0)
            {
                if (schedulerControl2.SelectedAppointments[0].CustomFields["Test"] != null)
                    Text = "Custom field value: " + schedulerControl2.SelectedAppointments[0].CustomFields["Test"].ToString();
                else
                    Text = " custom field is empty";
            }
        }
    }
}