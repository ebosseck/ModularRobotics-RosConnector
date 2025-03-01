// generated by RosbridgeMessageGenerator
// generated on 02 Aug 2023, 02:53:51

using System;
using System.Collections.Generic;

using Riptide;
using Visus.Robotics.RosBridge;



namespace ros_messages.std_msgs
{
    public class BoolMessage : ROSMessage
    {

        

        #region Registration
        
#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void _registerMessage () {
            ROSMessageFactory.registerMessage(_ROS_MESSAGE_ID, delegate(Message msg)
            {
                return new BoolMessage(msg);
            });
        }

        #endregion

        public bool data;

        public const string _ROS_MESSAGE_ID = "std_msgs/Bool";

        public BoolMessage(bool data = false) : base()
        {
            this.data = data;
        }

        public BoolMessage(Message message) : base()
        {
            this.deserializeFromMessage(message);
        }


        #region Serialization

        public override void serializeToMessage(Message message)
        {
            message.AddString(_ROS_MESSAGE_ID);
            message.AddBool(this.data);
        }

        public override void deserializeFromMessage(Message message)
        {
            this.data = message.GetBool();
        }

        #endregion
    }
}
