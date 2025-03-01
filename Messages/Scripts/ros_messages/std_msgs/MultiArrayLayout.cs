// generated by RosbridgeMessageGenerator
// generated on 02 Aug 2023, 02:53:51

using System;
using System.Collections.Generic;

using Riptide;
using Visus.Robotics.RosBridge;

using ros_messages.std_msgs;

namespace ros_messages.std_msgs
{
    public class MultiArrayLayoutMessage : ROSMessage
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
                return new MultiArrayLayoutMessage(msg);
            });
        }

        #endregion

        public List<MultiArrayDimensionMessage> dim;
        public uint data_offset;

        public const string _ROS_MESSAGE_ID = "std_msgs/MultiArrayLayout";

        public MultiArrayLayoutMessage(List<MultiArrayDimensionMessage> dim = null, uint data_offset = 0) : base()
        {
            this.dim = dim;
            this.data_offset = data_offset;
        }

        public MultiArrayLayoutMessage(Message message) : base()
        {
            this.deserializeFromMessage(message);
        }


        #region Serialization

        public override void serializeToMessage(Message message)
        {
            message.AddString(_ROS_MESSAGE_ID);
            AddArrayLength(message, this.dim.Count);
            for (int i = 0; i < this.dim.Count; i++) {
                this.dim[i].serializeToMessage(message);
            }
            message.AddUInt(this.data_offset);
        }

        public override void deserializeFromMessage(Message message)
        {
            int length = ReadArrayLength(message);
            this.dim = new List<MultiArrayDimensionMessage>();
            for (int i = 0; i < length; i++) {
                MultiArrayDimensionMessage value = new MultiArrayDimensionMessage();
                value.deserializeFromMessage(message);
                this.dim.Add(value);
            }
            this.data_offset = message.GetUInt();
        }

        #endregion
    }
}
