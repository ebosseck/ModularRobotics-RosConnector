// generated by RosbridgeMessageGenerator
// generated on 02 Aug 2023, 02:53:51

using System;
using System.Collections.Generic;

using Riptide;
using Visus.Robotics.RosBridge;



namespace ros_messages.trajectory_msgs
{
    public class JointTrajectoryPointMessage : ROSMessage
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
                return new JointTrajectoryPointMessage(msg);
            });
        }

        #endregion

        public List<double> positions;
        public List<double> velocities;
        public List<double> accelerations;
        public List<double> effort;
        public int[] time_from_start;

        public const string _ROS_MESSAGE_ID = "trajectory_msgs/JointTrajectoryPoint";

        public JointTrajectoryPointMessage(List<double> positions = null, List<double> velocities = null, List<double> accelerations = null, List<double> effort = null, int[] time_from_start = null) : base()
        {
            this.positions = positions;
            this.velocities = velocities;
            this.accelerations = accelerations;
            this.effort = effort;
            this.time_from_start = time_from_start;
        }

        public JointTrajectoryPointMessage(Message message) : base()
        {
            this.deserializeFromMessage(message);
        }


        #region Serialization

        public override void serializeToMessage(Message message)
        {
            message.AddString(_ROS_MESSAGE_ID);
            message.AddDoubles(this.positions.ToArray());
            message.AddDoubles(this.velocities.ToArray());
            message.AddDoubles(this.accelerations.ToArray());
            message.AddDoubles(this.effort.ToArray());
            message.AddInt(this.time_from_start[0]);
            message.AddInt(this.time_from_start[1]);
        }

        public override void deserializeFromMessage(Message message)
        {
            this.positions = new List<double>(message.GetDoubles());
            this.velocities = new List<double>(message.GetDoubles());
            this.accelerations = new List<double>(message.GetDoubles());
            this.effort = new List<double>(message.GetDoubles());
            this.time_from_start = new int[]{message.GetInt(), message.GetInt()};
        }

        #endregion
    }
}
