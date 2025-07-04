// generated by RosbridgeMessageGenerator
// generated on 22 May 2025, 00:29:59

using System;
using System.Collections.Generic;

using Riptide;
using Visus.Robotics.RosBridge;

using ros_messages.geometry_msgs;
using ros_messages.std_msgs;

namespace ros_messages.geometry_msgs
{
    public class TwistStampedMsg : ROSMessage
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
                return new TwistStampedMsg(msg);
            });
        }

        #endregion

        public HeaderMsg header;
        public TwistMsg twist;

        public const string _ROS_MESSAGE_ID = "geometry_msgs/TwistStamped";

        public TwistStampedMsg(HeaderMsg header = null, TwistMsg twist = null) : base()
        {
            this.header = header;
            this.twist = twist;
        }

        public TwistStampedMsg(Message message) : base()
        {
            this.deserializeFromMessage(message);
        }


        #region Serialization

        public override void serializeToMessage(Message message, bool includeHeader = true)
        {
            if (includeHeader) {
                message.AddString(_ROS_MESSAGE_ID);
            }
            this.header.serializeToMessage(message, includeHeader: false);
            this.twist.serializeToMessage(message, includeHeader: false);
        }

        public override void deserializeFromMessage(Message message)
        {
            this.header = new HeaderMsg();
            this.header.deserializeFromMessage(message);
            this.twist = new TwistMsg();
            this.twist.deserializeFromMessage(message);
        }

        #endregion
    }
}
