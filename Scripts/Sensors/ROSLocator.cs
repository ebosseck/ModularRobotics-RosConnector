using ros_messages.geometry_msgs;
using RosConnector.Abstract;
using UnityEngine;

namespace RosConnector.Sensors
{
    /// <summary>
    /// Class of sending positional data to ROS from Unity
    /// </summary>
    public class ROSLocator : ROSBehaviour
    {
        [Header("ROS Settings")]
        [Tooltip("Topic this sensor should publish to")]
        public string topic = "";

        /// <summary>
        /// Called after initialisation. Sets up the publisher for this script
        /// </summary>
        void Start()
        {
            connection.RegisterPublisher<TransformMsg>(topic);
        }

        /// <summary>
        /// Called on frame update.
        /// Publishes the current position of this object
        /// </summary>
        void Update()
        {
            publish();
        }

        /// <summary>
        /// Publishes this transform's position
        /// </summary>
        public void publish()
        {
            TransformMsg msg = new TransformMsg();
            msg.translation = new Vector3Msg(transform.position.z, -transform.position.x, transform.position.y);
            msg.rotation = new QuaternionMsg(0, 1, 0, 0);
        
            connection.Publish(topic, msg);
        }
    }
}
