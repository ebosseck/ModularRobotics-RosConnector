// generated by RosbridgeMessageGenerator
// generated on 27 May 2025, 04:17:01

using System;
using System.Collections.Generic;

using Riptide;
using Visus.Robotics.RosBridge;



namespace ros_messages.shape_msgs
{
    public class PlaneMsg : ROSMessage
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
                return new PlaneMsg(msg);
            });
        }

        #endregion

        public double[] coef;

        public const string _ROS_MESSAGE_ID = "shape_msgs/Plane";

        public PlaneMsg(double[] coef = null) : base()
        {
            this.coef = coef;
        }

        public PlaneMsg(Message message) : base()
        {
            this.deserializeFromMessage(message);
        }


        #region Serialization

        public override void serializeToMessage(Message message, bool includeHeader = true)
        {
            if (includeHeader) {
                message.AddString(_ROS_MESSAGE_ID);
            }
            message.AddDoubles(this.coef, false);
        }

        public override void deserializeFromMessage(Message message)
        {
            message.GetDoubles(4, this.coef);
        }

        #endregion
    }
}
