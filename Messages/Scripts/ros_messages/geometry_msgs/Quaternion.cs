// generated by RosbridgeMessageGenerator
// generated on 02 Aug 2023, 02:53:51

using System;
using System.Collections.Generic;

using Riptide;
using Visus.Robotics.RosBridge;



namespace ros_messages.geometry_msgs
{
    public class QuaternionMessage : ROSMessage
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
                return new QuaternionMessage(msg);
            });
        }

        #endregion

        public double x;
        public double y;
        public double z;
        public double w;

        public const string _ROS_MESSAGE_ID = "geometry_msgs/Quaternion";

        public QuaternionMessage(double x = 0, double y = 0, double z = 0, double w = 0) : base()
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public QuaternionMessage(Message message) : base()
        {
            this.deserializeFromMessage(message);
        }


        #region Serialization

        public override void serializeToMessage(Message message)
        {
            message.AddString(_ROS_MESSAGE_ID);
            message.AddDouble(this.x);
            message.AddDouble(this.y);
            message.AddDouble(this.z);
            message.AddDouble(this.w);
        }

        public override void deserializeFromMessage(Message message)
        {
            this.x = message.GetDouble();
            this.y = message.GetDouble();
            this.z = message.GetDouble();
            this.w = message.GetDouble();
        }

        #endregion
    }
}
