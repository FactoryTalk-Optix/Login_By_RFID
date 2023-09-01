#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.Core;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
using System.Linq;
#endregion

public class LoginByRfid : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void LoginById(string inputId) {
        var usersFolder = Project.Current.Get<Folder>("Security/Users");
        foreach (RFID_User singleUser in usersFolder.Children.OfType<RFID_User>()) {
            if (singleUser.GetVariable("RFID_Id").Value == inputId) {
                Log.Debug("Logging in with: " + singleUser.BrowseName + " - " + singleUser.GetVariable("RFID_Id").Value);
                var loginResult = Session.Login(singleUser.BrowseName, "");
                if (loginResult.ResultCode == ChangeUserResultCode.WrongPassword) {
                    Session.Logout();
                    var myDialogType = (DialogType)Project.Current.Get("UI/ChangeUserForm/LoginDialog");
                    UICommands.OpenDialog(Owner, myDialogType, singleUser.NodeId);
                }
                return;
            } else {
                Log.Debug("Found not matching user: " + singleUser.BrowseName + " - " + singleUser.GetVariable("RFID_Id").Value);
            }
        }
        Log.Warning("Cannot login user with ID " + inputId);
    }
}
