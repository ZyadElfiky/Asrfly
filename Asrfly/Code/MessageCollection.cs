using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asrfly.Properties;
namespace Asrfly.Code
{
    public static class MessageCollection
    {

        // Message
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowErrorServerMessage()
        {
            MessageBox.Show(Resources.ServerErrorText, Resources.ServerErrorCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowFiledRequireMessage()
        {
            MessageBox.Show(Resources.FiledReqText, Resources.FiledReqCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowRequiredDeleteRowMessage()
        {
            MessageBox.Show(Resources.DeleteFiledText, Resources.DeleteFiledCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Dialog
        public static bool ShowDeleteDialog()
        {
            var result = MessageBox.Show(Resources.DeleteDialogText, Resources.DeleteDialogCaption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        // Notification
        public static void ShowDeleteNotification()
        {
            Gui.GuiNotification.NotificationForm notification = new Gui.GuiNotification.NotificationForm();
            notification.labelNotificationTitle.Text = "تمت عملية الحذف بنجاح";
            notification.Show();
        }
        public static void AddDataNotification()
        {
            Gui.GuiNotification.NotificationForm notification = new Gui.GuiNotification.NotificationForm();
            notification.labelNotificationTitle.Text = "تمت عملية الاضافه بنجاح";
            notification.Show();
        }

        public static void EditDataNotification()
        {
            Gui.GuiNotification.NotificationForm notification = new Gui.GuiNotification.NotificationForm();
            notification.labelNotificationTitle.Text = "تمت عملية التعديل بنجاح";
            notification.Show();
        }
    }
}
