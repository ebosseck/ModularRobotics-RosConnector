// generated by RosbridgeMessageGenerator
// generated on 02 Aug 2023, 02:53:51

using System;
using System.Collections.Generic;

using Riptide;
using Visus.Robotics.RosBridge;

using ros_messages.std_msgs;

namespace ros_messages.std_msgs
{
    public class Float32MultiArrayMessage : ROSMessage
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
                return new Float32MultiArrayMessage(msg);
            });
        }

        #endregion

        public MultiArrayLayoutMessage layout;
        public List<float> data;

        public const string _ROS_MESSAGE_ID = "std_msgs/Float32MultiArray";

        public Float32MultiArrayMessage(MultiArrayLayoutMessage layout = null, List<float> data = null) : base()
        {
            this.layout = layout;
            this.data = data;
        }

        public Float32MultiArrayMessage(Message message) : base()
        {
            this.deserializeFromMessage(message);
        }


        #region Serialization

        public override void serializeToMessage(Message message)
        {
            message.AddString(_ROS_MESSAGE_ID);
            this.layout.serializeToMessage(message);
            message.AddFloats(this.data.ToArray());
        }

        public override void deserializeFromMessage(Message message)
        {
            this.layout = new MultiArrayLayoutMessage();
            this.layout.deserializeFromMessage(message);
            this.data = new List<float>(message.GetFloats());
        }

        #endregion
    }
}
