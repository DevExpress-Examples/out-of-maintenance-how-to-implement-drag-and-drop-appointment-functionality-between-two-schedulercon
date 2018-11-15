<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/S173638/Form1.cs) (VB: [Form1.vb](./VB/S173638/Form1.vb))
* [Program.cs](./CS/S173638/Program.cs) (VB: [Program.vb](./VB/S173638/Program.vb))
<!-- default file list end -->
# How to implement drag-and-drop appointment functionality between two SchedulerControls 


<p>By default, the drag-and-drop appointment functionality between two SchedulerControls is supported.<br /><br />However, SchedulerControl always removes an appointment after moving it to another SchedulerControl. <br />Nevertheless, it is possible to implement this behavior manually by handling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_AppointmentDragtopic">AppointmentDrag</a>, <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerSchedulerStorageBase_AppointmentsChangedtopic">AppointmentsChanged</a> and<a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerSchedulerStorageBase_AppointmentDeletingtopic">AppointmentDeleting</a> events, and preventing appointment deletion in the AppointmentDeleting event handler.<br /><br />Take special note that both SchedulerControls should have the same mappings to custom fields to prevent losing data from these fields after moving an appointment.<br />Thus, it's necessary to set custom field mappings for the storages manually using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraSchedulerAppointmentCustomFieldMappingCollection_Addtopic2601">SchedulerStorage.Appointments.CustomFieldMappings.Add</a> method.</p>

<br/>


