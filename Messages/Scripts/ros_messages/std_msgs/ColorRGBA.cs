// generated by RosbridgeMessageGenerator
// generated on 02 Aug 2023, 02:53:51

using System;
using System.Collections.Generic;

using Riptide;
using Visus.Robotics.RosBridge;



namespace ros_messages.std_msgs
{
    public class ColorRGBAMessage : ROSMessage
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
                return new ColorRGBAMessage(msg);
            });
        }

        #endregion

        public float r;
        public float g;
        public float b;
        public float a;

        public const string _ROS_MESSAGE_ID = "std_msgs/ColorRGBA";

        public ColorRGBAMessage(float r = 0f, float g = 0f, float b = 0f, float a = 0f) : base()
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        public ColorRGBAMessage(Message message) : base()
        {
            this.deserializeFromMessage(message);
        }


        #region Serialization

        public override void serializeToMessage(Message message)
        {
            message.AddString(_ROS_MESSAGE_ID);
            message.AddFloat(this.r);
            message.AddFloat(this.g);
            message.AddFloat(this.b);
            message.AddFloat(this.a);
        }

        public override void deserializeFromMessage(Message message)
        {
            this.r = message.GetFloat();
            this.g = message.GetFloat();
            this.b = message.GetFloat();
            this.a = message.GetFloat();
        }

        #endregion
    }
}
