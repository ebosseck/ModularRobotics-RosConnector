// generated by RosbridgeMessageGenerator
// generated on 02 Aug 2023, 02:53:51

using System;
using System.Collections.Generic;

using Riptide;
using Visus.Robotics.RosBridge;

using ros_messages.std_msgs;

namespace ros_messages.std_msgs
{
    public class Int8MultiArrayMessage : ROSMessage
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
                return new Int8MultiArrayMessage(msg);
            });
        }

        #endregion

        public MultiArrayLayoutMessage layout;
        public List<sbyte> data;

        public const string _ROS_MESSAGE_ID = "std_msgs/Int8MultiArray";

        public Int8MultiArrayMessage(MultiArrayLayoutMessage layout = null, List<sbyte> data = null) : base()
        {
            this.layout = layout;
            this.data = data;
        }

        public Int8MultiArrayMessage(Message message) : base()
        {
            this.deserializeFromMessage(message);
        }


        #region Serialization

        public override void serializeToMessage(Message message)
        {
            message.AddString(_ROS_MESSAGE_ID);
            this.layout.serializeToMessage(message);
            message.AddSBytes(this.data.ToArray());
        }

        public override void deserializeFromMessage(Message message)
        {
            this.layout = new MultiArrayLayoutMessage();
            this.layout.deserializeFromMessage(message);
            this.data = new List<sbyte>(message.GetSBytes());
        }

        #endregion
    }
}
