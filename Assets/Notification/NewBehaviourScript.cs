using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var c = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.High,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(c);

        var notification = new AndroidNotification();
        notification.Title = "Hi";
        notification.Text = "Wanna Play";
        notification.SmallIcon = "icon_0";
        notification.LargeIcon = "icon_1";
        notification.FireTime = System.DateTime.Now.AddSeconds(15);

        AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
