// generated by RosbridgeMessageGenerator
// generated on 22 May 2025, 00:29:59

using System;
using System.Collections.Generic;

using Riptide;
using Visus.Robotics.RosBridge;



namespace ros_messages.sensor_msgs
{
    public class ChannelFloat32Msg : ROSMessage
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
                return new ChannelFloat32Msg(msg);
            });
        }

        #endregion

        public string name;
        public List<float> values;

        public const string _ROS_MESSAGE_ID = "sensor_msgs/ChannelFloat32";

        public ChannelFloat32Msg(string name = "", List<float> values = null) : base()
        {
            this.name = name;
            this.values = values;
        }

        public ChannelFloat32Msg(Message message) : base()
        {
            this.deserializeFromMessage(message);
        }


        #region Serialization

        public override void serializeToMessage(Message message, bool includeHeader = true)
        {
            if (includeHeader) {
                message.AddString(_ROS_MESSAGE_ID);
            }
            message.AddString(this.name);
            message.AddFloats(this.values.ToArray());
        }

        public override void deserializeFromMessage(Message message)
        {
            this.name = message.GetString();
            this.values = new List<float>(message.GetFloats());
        }

        #endregion
    }
}
